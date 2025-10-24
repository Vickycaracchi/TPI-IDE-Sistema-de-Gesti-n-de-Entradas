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
            return context.Compras
                .Where(c => c.IdVendedor == idVendedor)
                .ToList();
        }

        public bool Update(Compra compra)
        {
            using var context = CreateContext();
            var existingCompra = context.Compras.Find(compra.FechaHora, compra.IdVendedor, compra.IdCliente);
            if (existingCompra != null)
            {
                existingCompra.SetFecha(compra.FechaHora);
                existingCompra.SetCantidadCompra(compra.CantidadCompra);
                existingCompra.SetIdVendedor(compra.IdVendedor);
                existingCompra.SetIdCliente(compra.IdCliente);


                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
