using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
using DTOs;

namespace Data
{
    public class ProductoRepository
    {
        private BGEContext CreateContext()
        {
            return new BGEContext();
        }

        public void Add(Producto producto)
        {
            using var context = CreateContext();
            context.Productos.Add(producto);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var producto = context.Productos.Find(id);
            if (producto != null)
            {
                context.Productos.Remove(producto);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Producto? Get(int id)
        {
            using var context = CreateContext();
            return context.Productos
                .FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Producto> GetAll()
        {
            using var context = CreateContext();
            return context.Productos
                .ToList();
        }

        public bool Update(Producto producto)
        {
            using var context = CreateContext();
            var existingProducto = context.Productos.Find(producto.Id);
            if (existingProducto != null)
            {
                existingProducto.SetDescripcion(producto.Descripcion);
                existingProducto.SetPrecio(producto.Precio);

                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool AddCompra(int idProducto, CompraKeyDTO compraKey, int cantidad)
        {
            using var context = CreateContext();
            var producto = context.Productos.Find(idProducto);
            var compra = context.Compras.Find(compraKey);
            if (producto != null && compra != null)
            {
                var compraProducto = new CompraProducto(compra.IdCliente, compra.IdFiesta, idProducto, compra.FechaHora, cantidad);
                context.ComprasProductos.Add(compraProducto);
                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
