using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class FiestaLote
    {
        public int IdFiesta { get; private set; }
        public int IdLote { get; private set; }
        public FiestaLote(int idFiesta, int idLote)
        {
            SetIdFiesta(idFiesta);
            SetIdLote(idLote);
        }
        public void SetIdFiesta(int idFiesta)
        {
            if (idFiesta <= 0)
                throw new ArgumentException("El Id de la fiesta debe ser mayor que 0.", nameof(idFiesta));
            IdFiesta = idFiesta;
        }
        public void SetIdLote(int idLote)
        {
            if (idLote <= 0)
                throw new ArgumentException("El Id del lote debe ser mayor que 0.", nameof(idLote));
            IdLote = idLote;
        }
    }
}