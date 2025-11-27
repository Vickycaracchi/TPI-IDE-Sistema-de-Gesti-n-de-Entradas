using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using DTOs;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class CompraRepository
    {
        private BGEContext CreateContext()
        {
            return new BGEContext();
        }

        public void Add(Compra compra, int cantidadCompra)
        {
            using var context = CreateContext();
            context.Compras.Add(compra);
            context.SaveChanges();

            // Crear las entradas correspondientes con IDs secuenciales
            // Obtener el último ID de entrada para generar el siguiente secuencialmente
            int ultimoId = 0;
            if (context.Entradas.Any())
            {
                ultimoId = context.Entradas.Max(e => (int?)e.IdEntrada) ?? 0;
            }

            for (int i = 0; i < cantidadCompra; i++)
            {
                int nuevoId = ultimoId + i + 1;
                Entrada entrada = new Entrada(nuevoId, compra.IdCliente, compra.IdFiesta, compra.FechaHora);
                context.Entradas.Add(entrada);
            }
            context.SaveChanges();
        }
        public IEnumerable<CompraDTO> GetAllVendedor(int idVendedor)
        {
            using var context = CreateContext();

            var idsVendedores = context.Usuarios
                .Where(u => u.IdJefe == idVendedor)
                .Select(u => u.Id)
                .ToList();

            var query = from c in context.Compras
                        join e in context.Entradas
                            on new { c.FechaHora, c.IdCliente, c.IdFiesta } equals new { e.FechaHora, e.IdCliente, e.IdFiesta }
                        join f in context.Fiestas on c.IdFiesta equals f.IdFiesta
                        join fl in context.FiestasLotes on f.IdFiesta equals fl.IdFiesta
                        join l in context.Lotes on fl.IdLote equals l.Id
                        where l.FechaDesde <= c.FechaHora && l.FechaHasta >= c.FechaHora && c.IdVendedor == idVendedor
                        group e by new { c.IdCliente, c.IdFiesta, c.IdVendedor, l.Nombre } into g
                        orderby g.Max(c => c.FechaHora) descending
                        select new CompraDTO
                        {
                            FechaHora = g.Max(c => c.FechaHora),
                            IdCliente = g.Key.IdCliente,
                            IdFiesta = g.Key.IdFiesta,
                            IdVendedor = g.Key.IdVendedor,
                            CantidadCompra = g.Count(),
                            Entrada = string.Join(", ", g.Select(entrada => entrada.IdEntrada)),
                            Lote = g.Key.Nombre
                        };

            return query.ToList();
        }

        public IEnumerable<CompraDTO> GetAllJefe(int idJefe)
        {
            using var context = CreateContext();

            var idsVendedores = context.Usuarios
                .Where(u => u.IdJefe == idJefe)
                .Select(u => u.Id)
                .ToList();
            
            var query = from c in context.Compras
                        join e in context.Entradas
                            on new { c.FechaHora, c.IdCliente, c.IdFiesta } equals new { e.FechaHora, e.IdCliente, e.IdFiesta }
                        join f in context.Fiestas on c.IdFiesta equals f.IdFiesta
                        join fl in context.FiestasLotes on f.IdFiesta equals fl.IdFiesta
                        join l in context.Lotes on fl.IdLote equals l.Id
                        where l.FechaDesde <= c.FechaHora && l.FechaHasta >= c.FechaHora && idsVendedores.Contains(c.IdVendedor)
                        group e by new { c.IdCliente, c.IdFiesta, c.IdVendedor, l.Nombre } into g
                        orderby g.Max(c => c.FechaHora) descending
                        select new CompraDTO
                        {
                            FechaHora = g.Max(c => c.FechaHora),
                            IdCliente = g.Key.IdCliente,
                            IdFiesta = g.Key.IdFiesta,
                            IdVendedor = g.Key.IdVendedor,
                            CantidadCompra = g.Count(),
                            Entrada = string.Join(", ", g.Select(entrada => entrada.IdEntrada)),
                            Lote = g.Key.Nombre
                        };

            return query.ToList();
        }

        public IEnumerable<CompraDTO> GetAllCli(int idCliente)
        {
            using var context = CreateContext();
            
            var query = from c in context.Compras
                        join e in context.Entradas
                            on new { c.FechaHora, c.IdCliente, c.IdFiesta } equals new { e.FechaHora, e.IdCliente, e.IdFiesta }
                        join f in context.Fiestas on c.IdFiesta equals f.IdFiesta
                        join fl in context.FiestasLotes on f.IdFiesta equals fl.IdFiesta
                        join l in context.Lotes on fl.IdLote equals l.Id
                        where l.FechaDesde <= c.FechaHora && l.FechaHasta >= c.FechaHora && c.IdCliente == idCliente
                        group e by new { c.IdCliente, c.IdFiesta, c.IdVendedor } into g
                        orderby g.Max(c => c.FechaHora) descending
                        select new CompraDTO
                        {
                            FechaHora = g.Max(c => c.FechaHora),
                            IdCliente = g.Key.IdCliente,
                            IdFiesta = g.Key.IdFiesta,
                            IdVendedor = g.Key.IdVendedor,
                            CantidadCompra = g.Count(),
                            Entrada = string.Join(", ", g.Select(entrada => entrada.IdEntrada))
                        };

            return query.ToList();
        }

        public bool Update(Compra compra)
        {
            using var context = CreateContext();
            var existingCompra = context.Compras.Find(compra.IdCliente, compra.FechaHora, compra.IdFiesta);
            if (existingCompra != null)
            {
                existingCompra.SetFecha(compra.FechaHora);
                existingCompra.SetIdVendedor(compra.IdVendedor);
                existingCompra.SetIdCliente(compra.IdCliente);
                existingCompra.SetIdFiesta(compra.IdFiesta);

                context.SaveChanges();
                return true;
            }
            return false;
        }
        public IEnumerable<CompraParaReporteDTO> GetComprasParaReporteAsync()
        {
            using var context = CreateContext();
            var ultimasFiestas = context.Fiestas
                .OrderByDescending(f => f.FechaFiesta)
                .Take(3)
                .ToList();

            var query = (from f in ultimasFiestas
                         join c in context.Compras on f.IdFiesta equals c.IdFiesta
                         join e in context.Entradas on new { c.FechaHora, c.IdCliente, c.IdFiesta }
                                                     equals new { e.FechaHora, e.IdCliente, e.IdFiesta }
                         join fl in context.FiestasLotes on f.IdFiesta equals fl.IdFiesta
                         join l in context.Lotes on fl.IdLote equals l.Id
                         where c.FechaHora >= l.FechaDesde && c.FechaHora <= l.FechaHasta
                         join ev in context.Eventos on f.IdEvento equals ev.Id
                         group new { c, e, l, ev, f } by new { c.IdVendedor, ev.Nombre, f.FechaFiesta } into g
                         select new CompraParaReporteDTO
                         {
                             Vendedor = g.Key.IdVendedor,
                             Entradas = g.Count(),
                             Jefe = g.Key.IdVendedor,
                             Monto = g.Sum(x => x.l.Precio),
                             FechaFiesta = g.Key.FechaFiesta
                         })
                  .OrderBy(r => r.FechaFiesta)
                  .ThenByDescending(r => r.Entradas)
                  .ThenByDescending(r => r.Monto);

            return query.ToList();
        }
    }
}
