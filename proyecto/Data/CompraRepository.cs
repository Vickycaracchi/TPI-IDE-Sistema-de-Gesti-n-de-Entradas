using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace Data
{
    public class CompraRepository
    {
        private BGEContext CreateContext()
        {
            return new BGEContext();
        }

        public void Add(Compra compra)
        {
            using var context = CreateContext();
            context.Compras.Add(compra);
            context.SaveChanges();
        }
        
        public IEnumerable<Compra> GetAll(int idVendedor)
        {
            using var context = CreateContext();
            var query = context.Compras.Where(c => c.IdVendedor == idVendedor);
            return query.ToList();
        }

        public IEnumerable<Compra> GetAllCli(int idCliente)
        {
            using var context = CreateContext();
            var query = context.Compras.Where(c => c.IdCliente == idCliente);
            return query.ToList();
        }

        public bool Update(Compra compra)
        {
            using var context = CreateContext();
            var existingCompra = context.Compras.Find(compra.FechaHora, compra.IdVendedor, compra.IdCliente, compra.IdFiesta);
            if (existingCompra != null)
            {
                existingCompra.SetFecha(compra.FechaHora);
                existingCompra.SetCantidadCompra(compra.CantidadCompra);
                existingCompra.SetEntrada(compra.Entrada);
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
