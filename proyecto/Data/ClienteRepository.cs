using Domain.Model;
using DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlClient;

namespace Data
{
    public class ClienteRepository
    {
        private BGEContext CreateContext()
        {
            return new BGEContext();
        }

        public void Add(Cliente cliente)
        {
            using var context = CreateContext();
            context.Clientes.Add(cliente);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var cliente = context.Clientes.Find(id);
            if (cliente != null)
            {
                context.Clientes.Remove(cliente);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Cliente? Get(int id)
        {
            using var context = CreateContext();
            return context.Clientes
                .FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Cliente> GetAll()
        {
            using var context = CreateContext();
            return context.Clientes
                .ToList();
        }

        public bool Update(Cliente cliente)
        {
            using var context = CreateContext();
            var existingCliente = context.Clientes.Find(cliente.Id);
            if (existingCliente != null)
            {
                existingCliente.SetNombre(cliente.Nombre);
                existingCliente.SetApellido(cliente.Apellido);
                existingCliente.SetEmail(cliente.Email);
                existingCliente.SetNumeroTelefono(cliente.NumeroTelefono);
                existingCliente.SetFechaNac(cliente.FechaNac);
                existingCliente.SetInstagram(cliente.Instagram);
                existingCliente.SetContrasena(cliente.Contrasena);

                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Cliente? GetByEmail(string email)
        {
            using var context = CreateContext();
            return context.Clientes
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
