using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Domain.Model
{
    public class Fiesta
    {
        public int IdFiesta { get; private set; }
        public DateTime FechaFiesta { get; private set; }
        public int IdLugar { get; private set; }
        public int IdEvento { get; private set; }

        public Fiesta() { }
        public Fiesta(int idFiesta, DateTime Fechafiesta,  int idLugar, int idEvento)
        {
            SetIdFiesta(idFiesta);
            SetFecha(Fechafiesta);
            SetIdLugar(idLugar);
            SetIdEvento(idEvento);


        }
        public void SetIdFiesta(int id)
        {
            if (id < 0)
                throw new ArgumentException("El Id debe ser mayor que 0.", nameof(id));
            IdFiesta = id;
        }
        public void SetFecha(DateTime fecha)
        {
            if (fecha == default)
                throw new ArgumentException("La fecha no puede ser nula.", nameof(fecha));
            FechaFiesta = fecha;
        }
        public void SetIdLugar(int idLugar)
        {
            if (idLugar == 0)
                throw new ArgumentException("El lugar no puede ser nulo.", nameof(idLugar));
            IdLugar = idLugar;
        }
        public void SetIdEvento(int idEvento)
        {
            if (idEvento == 0)
                throw new ArgumentException("El evento no puede ser nulo.", nameof(idEvento));
            IdEvento = idEvento;
        }

    }
}
