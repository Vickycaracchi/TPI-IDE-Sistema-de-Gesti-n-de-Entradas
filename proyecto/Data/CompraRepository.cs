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

        public Compra Get(CompraKeyDTO key)
        {
            using var context = CreateContext();
            return context.Compras
                .FirstOrDefault(c => c.IdCliente == key.IdCliente && c.FechaHora == key.FechaHora && c.IdFiesta == key.IdFiesta);
        }
        
        public IEnumerable<Compra> GetAll(int idVendedor)
        {
            using var context = CreateContext();
            var query = context.Compras.Where(c => c.IdVendedor == idVendedor);
            return query.ToList();
        }

        public IEnumerable<Compra> GetAllByJefe(int idJefe)
        {
            using var context = CreateContext();
            // Obtener todos los vendedores asignados a este jefe
            var vendedoresIds = context.Usuarios
                .Where(u => u.IdJefe == idJefe && u.Tipo.ToLower() == "vendedor")
                .Select(u => u.Id)
                .ToList();

            // Obtener todas las compras de esos vendedores
            var query = context.Compras.Where(c => vendedoresIds.Contains(c.IdVendedor));
            return query.ToList();
        }

        public IEnumerable<Compra> GetAllCli(int idCliente)
        {
            using var context = CreateContext();
            var query = context.Compras.Join(
                context.Fiestas,
                compra => compra.IdFiesta,
                fiesta => fiesta.IdFiesta,
                (compra, fiesta) => new { compra, fiesta }
            ).Where(cf => cf.fiesta.FechaFiesta.Date >= DateTime.Today && cf.compra.IdCliente == idCliente)
             .Select(cf => cf.compra);
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
    }
}
