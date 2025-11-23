using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;

namespace Data
{
    public class EntradaRepository
    {
        private BGEContext CreateContext()
        {
            return new BGEContext();
        }

        public void Add(Entrada entrada)
        {
            using var context = CreateContext();
            context.Entradas.Add(entrada);
            context.SaveChanges();
        }

        public IEnumerable<Entrada> GetByCompra(int idCliente, DateTime fechaHora, int idFiesta)
        {
            using var context = CreateContext();
            return context.Entradas
                .Where(e => e.IdCliente == idCliente && 
                           e.FechaHora == fechaHora && 
                           e.IdFiesta == idFiesta)
                .ToList();
        }
    }
}

