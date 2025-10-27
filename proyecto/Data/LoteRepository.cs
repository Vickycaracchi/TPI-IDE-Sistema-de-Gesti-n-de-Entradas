using Domain.Model;
using DTOs;
using Microsoft.AspNetCore.Http.Timeouts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class LoteRepository
    {
        private BGEContext CreateContext()
        {
            return new BGEContext();
        }

        public void Add(Lote lote)
        {
            using var context = CreateContext();
            context.Lotes.Add(lote);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var lote = context.Lotes.Find(id);
            if (lote != null)
            {
                context.Lotes.Remove(lote);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public List<Lote> GetLotesPorFiesta(int idFiesta)
        {
            using var context = CreateContext();
            return context.Lotes
                .Where(l => l.IdFiesta == idFiesta)
                .ToList();
        }

        public Lote? Get(int id)
        {
            using var context = CreateContext();
            return context.Lotes
                .FirstOrDefault(c => c.Id == id);
        }

        public bool FiestaTieneLotes(int idFiesta)
        {
            using var context = CreateContext();
            return context.Lotes.Any(l => l.IdFiesta == idFiesta);
        }

        public IEnumerable<Lote> GetAll()
        {
            using var context = CreateContext();
            return context.Lotes
                .ToList();
        }

        public bool Update(Lote lote)
        {
            using var context = CreateContext();
            var existingLote = context.Lotes.Find(lote.Id);
            if (existingLote != null)
            {
                existingLote.SetNombre(lote.Nombre);
                existingLote.SetPrecio(lote.Precio);
                existingLote.SetFechaDesde(lote.FechaDesde);
                existingLote.SetFechaHasta(lote.FechaHasta);
                existingLote.SetCantidadLote(lote.CantidadLote);
                existingLote.SetIdFiesta(lote.IdFiesta);
                existingLote.SetLoteActual(lote.LoteActual);

                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Lote? GetByNombre(string nombre)
        {
            using var context = CreateContext();
            return context.Lotes
                .FirstOrDefault(c => c.Nombre.ToLower() == nombre.ToLower());
        }

        public bool NombreExists(string nombre, int? excludeId = null)
        {
            using var context = CreateContext();
            var query = context.Lotes.Where(c => c.Nombre.ToLower() == nombre.ToLower());
            if (excludeId.HasValue)
            {
                query = query.Where(c => c.Id != excludeId.Value);
            }
            return query.Any();
        }

        public LoteDTO ToDTO(Lote lote)
        {
            return new LoteDTO
            {
                Id = lote.Id,
                Nombre = lote.Nombre,
                Precio = lote.Precio,
                FechaDesde = lote.FechaDesde,
                FechaHasta = lote.FechaHasta,
                CantidadLote = lote.CantidadLote
            };
        }

        public LoteDTO? GetLoteActual(int idFiesta)
        {
            using var context = CreateContext();
            var query = context.Lotes.Where(c => c.IdFiesta == idFiesta && c.LoteActual == true);
            var lote = query.FirstOrDefault();
            
            return new LoteDTO
            {
                Id = lote.Id,
                Nombre = lote.Nombre,
                Precio = lote.Precio,
                FechaDesde = lote.FechaDesde,
                FechaHasta = lote.FechaHasta,
                CantidadLote = lote.CantidadLote
            };
        }
    }
}
