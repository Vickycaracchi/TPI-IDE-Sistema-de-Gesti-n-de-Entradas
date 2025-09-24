using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class VendedorRepository
    {
        private BGEContext CreateContext()
        {
            return new BGEContext();
        }

        public void Add(Vendedor vendedor)
        {
            using var context = CreateContext();
            context.Vendedores.Add(vendedor);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var vendedor = context.Vendedores.Find(id);
            if (vendedor != null)
            {
                context.Vendedores.Remove(vendedor);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Vendedor? Get(int id)
        {
            using var context = CreateContext();
            return context.Vendedores
                .FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Vendedor> GetAll()
        {
            using var context = CreateContext();
            return context.Vendedores
                .ToList();
        }

        public bool Update(Vendedor vendedor)
        {
            using var context = CreateContext();
            var existingVendedor = context.Vendedores.Find(vendedor.Id);
            if (existingVendedor != null)
            {
                existingVendedor.SetDni(vendedor.Dni);
                existingVendedor.SetNombre(vendedor.Nombre);
                existingVendedor.SetApellido(vendedor.Apellido);
                existingVendedor.SetEmail(vendedor.Email);
                existingVendedor.SetContrasena(vendedor.Contrasena);
                existingVendedor.SetCvu(vendedor.Cvu);
                existingVendedor.SetTipo(vendedor.Tipo);

                context.SaveChanges();
                return true;
            }
            return false;
        }
        public Vendedor? GetByEmail(string email)
        {
            using var context = CreateContext();
            return context.Vendedores
                .FirstOrDefault(c => c.Email.ToLower() == email.ToLower());
        }

        public bool EmailExists(string email, int? excludeId = null)
        {
            using var context = CreateContext();
            var query = context.Clientes.Where(c => c.Email.ToLower() == email.ToLower());
            if (excludeId.HasValue)
            {
                query = query.Where(c => c.Id != excludeId.Value);
            }
            return query.Any();
        }
    }
}
