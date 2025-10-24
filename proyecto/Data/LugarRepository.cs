using Domain.Model;
using Microsoft.AspNetCore.Http.Timeouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class LugarRepository
    {
        private BGEContext CreateContext()
        {
            return new BGEContext();
        }

        public void Add(Lugar lugar)
        {
            using var context = CreateContext();
            context.Lugares.Add(lugar);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var lugar = context.Lugares.Find(id);
            if (lugar != null)
            {
                context.Lugares.Remove(lugar);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Lugar? Get(int id)
        {
            using var context = CreateContext();
            return context.Lugares
                .FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Lugar> GetAll()
        {
            using var context = CreateContext();
            return context.Lugares
                .ToList();
        }

        public bool Update(Lugar lugar)
        {
            using var context = CreateContext();
            var existingLugar = context.Lugares.Find(lugar.Id);
            if (existingLugar != null)
            {
                existingLugar.SetNombre(lugar.Nombre);
                existingLugar.SetDireccion(lugar.Direccion);
                existingLugar.SetCiudad(lugar.Ciudad);

                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Lugar? GetByNombre(string nombre)
        {
            using var context = CreateContext();
            return context.Lugares
                .FirstOrDefault(c => c.Nombre.ToLower() == nombre.ToLower());
        }

        public bool NombreExists(string nombre, int? excludeId = null)
        {
            using var context = CreateContext();
            var query = context.Lugares.Where(c => c.Nombre.ToLower() == nombre.ToLower());
            if (excludeId.HasValue)
            {
                query = query.Where(c => c.Id != excludeId.Value);
            }
            return query.Any();
        }
    }
}
