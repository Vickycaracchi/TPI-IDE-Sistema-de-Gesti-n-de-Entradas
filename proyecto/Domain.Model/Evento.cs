using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{

    public class Evento
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public string Desc { get; private set; }

        public DateTime Fecha { get; private set; }
        public string Lugar { get; private set; }

        public Evento() { }

        public Evento(int id, string nombre, string desc, DateTime fecha, string lugar)
        {
            SetId(id);
            SetNombre(nombre);
            SetDesc(desc);
            SetFecha(fecha);
            SetLugar(lugar);
        }

        public void SetId(int id)
        {
            if (id < 0)
                throw new ArgumentException("El Id debe ser mayor que 0.", nameof(id));
            Id = id;
        }
        public void SetNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre no puede ser nulo o vacío.", nameof(nombre));
            Nombre = nombre;
        }
        public void SetDesc(string desc)
        {
            if (string.IsNullOrWhiteSpace(desc))
                throw new ArgumentException("El nombre no puede ser nulo o vacío.", nameof(desc));
            Desc = desc;
        }
        public void SetFecha(DateTime fecha)
        {
            if (fecha == default)
                throw new ArgumentException("La fecha no puede ser nula.", nameof(fecha));
            Fecha = fecha;
        }
        public void SetLugar(string lugar)
        {
            if (string.IsNullOrWhiteSpace(lugar))
                throw new ArgumentException("El lugar no puede ser nulo o vacío.", nameof(lugar));
            Lugar = lugar;
        }
    }
}