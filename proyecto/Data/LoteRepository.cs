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

        public Lote Add(Lote lote, int idFiesta)
        {
            using var context = CreateContext();
            context.Lotes.Add(lote);
            context.SaveChanges();
            return lote;
        }
        public void AddRelacion(int idLote, int idFiesta)
        {
            using var context = CreateContext();
            var relacion = new FiestaLote(idFiesta, idLote);
            context.FiestasLotes.Add(relacion);
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
        public Lote? Get(int id)
        {
            using var context = CreateContext();
            return context.Lotes
                .FirstOrDefault(c => c.Id == id);
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

                context.SaveChanges();
                return true;
            }
            return false;
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
        public Lote? GetLoteActual(int idFiesta)
        {
            using var context = CreateContext();
            var query = context.FiestasLotes
                .Where(fl => fl.IdFiesta == idFiesta)
                .Select(fl => fl.IdLote);
            return context.Lotes
                .Where(l => query.Contains(l.Id) && l.FechaDesde <= DateTime.Now && l.FechaHasta >= DateTime.Now)
                .FirstOrDefault();
        }
    }
}
