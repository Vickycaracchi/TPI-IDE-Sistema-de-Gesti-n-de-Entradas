using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace Data
{
    public class FiestaRepository
    {
        private BGEContext CreateContext()
        {
            return new BGEContext();
        }

        public void Add(Fiesta fiesta)
        {
            using var context = CreateContext();
            context.Fiestas.Add(fiesta);
            context.SaveChanges();
        }

        public IEnumerable<Fiesta> GetAll()
        {
            using var context = CreateContext();
            return context.Fiestas.ToList();
        }
        public Fiesta? Get(int idFiesta)
        {
            using var context = CreateContext();
            return context.Fiestas
                .FirstOrDefault(c => c.IdFiesta == idFiesta);
        }

  

        public bool Update(Fiesta fiesta)
        {
            using var context = CreateContext();
            var existingFiesta = context.Fiestas.Find(fiesta.IdFiesta);
            if (existingFiesta != null)
            {
                existingFiesta.SetIdFiesta(fiesta.IdFiesta);
                existingFiesta.SetFecha(fiesta.FechaFiesta);
                existingFiesta.SetIdLugar(fiesta.IdLugar);
                existingFiesta.SetIdEvento(fiesta.IdEvento);
                


                context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int idFiesta)
        {
            using var context = CreateContext();
            var fiesta = context.Fiestas.Find(idFiesta);
            if (fiesta != null)
            {
                context.Fiestas.Remove(fiesta);
                context.FiestasLotes.RemoveRange(context.FiestasLotes.Where(fl => fl.IdFiesta == idFiesta));
                context.SaveChanges();
                return true;
            }
            return false;
        }

    }
}
