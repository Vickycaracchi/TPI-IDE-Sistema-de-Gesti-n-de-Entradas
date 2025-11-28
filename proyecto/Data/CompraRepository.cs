using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using DTOs;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

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
        private IEnumerable<CompraDTO> GetComprasProductosCliente(int idCliente)
        {
            using var context = CreateContext();
            var query = from c in context.ComprasProductos
                        join u in context.Usuarios on idCliente equals u.Id
                        where c.IdCliente == idCliente
                        group c by new { c.IdFiesta, c.IdCliente, c.IdProducto} into g
                        select new ComprasClienteDTO
                        {
                            FechaHora = c.FechaHora,
                            IdCliente = c.IdCliente,
                            IdFiesta = c.IdFiesta,
                            IdVendedor = c.IdVendedor,
                            CantidadCompra = c.CantidadCompra,
                            Entrada = c.Producto
                        };
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
        public IEnumerable<CompraParaReporteFiestasDTO> GetComprasParaReporteFiestasASPNET()
        {
            var configuration = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                                .Build();

            string connectionString = configuration.GetConnectionString("DefaultConnection");

            List<CompraParaReporteFiestasDTO> comprasParaReporte = new List<CompraParaReporteFiestasDTO>();

            const string sqlQuery = @"
                select c.IdVendedor, count(e.IdEntrada) as cant_entradas, sum(l.Precio) as monto_total, u.IdJefe, f.FechaFiesta
                from (select top 3 * from fiestas f order by f.FechaFiesta desc) f
                inner join compras c on c.IdFiesta = f.IdFiesta
                inner join Entradas e on e.FechaHora = c.FechaHora and e.IdCliente = c.IdCliente and e.IdFiesta = c.IdFiesta
                inner join FiestasLotes fl on fl.IdFiesta = f.IdFiesta
                inner join Lotes l on l.Id = fl.IdLote and c.FechaHora between l.FechaDesde and l.FechaHasta
                inner join Eventos ev on ev.Id = f.IdEvento
                left join Usuarios u on u.Id = c.IdVendedor
                group by c.IdVendedor, ev.Nombre, f.FechaFiesta, u.IdJefe
                order by f.FechaFiesta, cant_entradas desc, monto_total desc
                ";
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand(sqlQuery, connection))
                {
                    try
                    {
                        connection.Open();

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var compraReporte = new CompraParaReporteFiestasDTO
                                {
                                    Vendedor = reader.GetInt32(reader.GetOrdinal("IdVendedor")),
                                    Entradas = reader.GetInt32(reader.GetOrdinal("cant_entradas")),
                                    Monto = reader.GetInt32(reader.GetOrdinal("monto_total")),
                                    Jefe = reader.IsDBNull(reader.GetOrdinal("IdJefe")) ? 0 : reader.GetInt32(reader.GetOrdinal("IdJefe")),
                                    FechaFiesta = reader.GetDateTime(reader.GetOrdinal("FechaFiesta"))
                                };
                                comprasParaReporte.Add(compraReporte);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al obtener las compras para reporte: {ex.Message}");
                        throw;
                    }
                }
            }
            return comprasParaReporte;
        }
        public IEnumerable<CompraParaReporteClientesDTO> GetComprasParaReporteClientesASPNET()
        {
            var configuration = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                                .Build();

            string connectionString = configuration.GetConnectionString("DefaultConnection");

            List<CompraParaReporteClientesDTO> comprasParaReporte = new List<CompraParaReporteClientesDTO>();

            const string sqlQuery = @"
                select top 10 c.IdCliente, f.IdFiesta, count(e.IdEntrada) as cant_entradas
                from (select top 5 * from fiestas f order by f.FechaFiesta desc) f
                inner join Compras c on c.IdFiesta = f.IdFiesta
                inner join Entradas e on e.FechaHora = c.FechaHora and e.IdCliente = c.IdCliente and e.IdFiesta = c.IdFiesta
                group by c.IdCliente, f.IdFiesta
                order by f.IdFiesta, cant_entradas desc
                ";
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand(sqlQuery, connection))
                {
                    try
                    {
                        connection.Open();

                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var compraReporte = new CompraParaReporteClientesDTO
                                {
                                    Cliente = reader.GetInt32(reader.GetOrdinal("IdCliente")),
                                    Entradas = reader.GetInt32(reader.GetOrdinal("cant_entradas")),
                                    Fiesta = reader.GetInt32(reader.GetOrdinal("IdFiesta")),
                                };
                                comprasParaReporte.Add(compraReporte);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al obtener las compras para reporte: {ex.Message}");
                        throw;
                    }
                }
            }
            return comprasParaReporte;
        }
    }
}
