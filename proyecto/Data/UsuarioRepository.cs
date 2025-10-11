using Domain.Model;
using Microsoft.AspNetCore.Http.Timeouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UsuarioRepository
    {
        private BGEContext CreateContext()
        {
            return new BGEContext();
        }

        public void Add(Usuario usuario)
        {
            using var context = CreateContext();
            context.Usuarios.Add(usuario);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var usuario = context.Usuarios.Find(id);
            if (usuario != null)
            {
                context.Usuarios.Remove(usuario);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Usuario? Get(int id)
        {
            using var context = CreateContext();
            return context.Usuarios
                .FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Usuario> GetAll()
        {
            using var context = CreateContext();
            return context.Usuarios
                .ToList();
        }

        public bool Update(Usuario usuario)
        {
            using var context = CreateContext();
            var existingUsuario = context.Usuarios.Find(usuario.Id);
            if (existingUsuario != null)
            {
                existingUsuario.SetDni(usuario.Dni);
                existingUsuario.SetNombre(usuario.Nombre);
                existingUsuario.SetApellido(usuario.Apellido);
                existingUsuario.SetEmail(usuario.Email);
                existingUsuario.SetContrasena(usuario.Contrasena);
                existingUsuario.SetCvu(usuario.Cvu);
                existingUsuario.SetTipo(usuario.Tipo);
                existingUsuario.SetNumeroTelefono(usuario.NumeroTelefono);
                existingUsuario.SetFechaNac(usuario.FechaNac);
                existingUsuario.SetInstagram(usuario.Instagram);

                context.SaveChanges();
                return true;
            }
            return false;
        }
        public Usuario? GetByEmail(string email)
        {
            using var context = CreateContext();
            return context.Usuarios
                .FirstOrDefault(c => c.Email.ToLower() == email.ToLower());
        }

        public bool EmailExists(string email, int? excludeId = null)
        {
            using var context = CreateContext();
            var query = context.Usuarios.Where(c => c.Email.ToLower() == email.ToLower());
            if (excludeId.HasValue)
            {
                query = query.Where(c => c.Id != excludeId.Value);
            }
            return query.Any();
        }

        public Usuario? GetByDni(string dni)
        {
            using var context = CreateContext();
            return context.Usuarios
                .FirstOrDefault(c => c.Dni.ToLower() == dni.ToLower());
        }

        public IEnumerable<Usuario> GetByTipo(string tipoBuscado) 
        {
            using var context = CreateContext();
            var query = context.Usuarios.Where(c => c.Tipo.ToLower() == tipoBuscado.ToLower());
            return query.ToList();
        }
    }
}
