using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Lote
    {
        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public int Precio { get; private set; }
        public DateTime FechaDesde { get; private set; }
        public DateTime FechaHasta { get; private set; }

        public Lote() { }

        public Lote(int id, string nombre, int precio, DateTime fechaDesde, DateTime fechaHasta)
        {
            SetId(id);
            SetNombre(nombre);
            SetPrecio(precio);
            SetFechaDesde(fechaDesde);
            SetFechaHasta(fechaHasta);
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

        public void SetPrecio(int precio)
        {
            if (precio < 0)
                throw new ArgumentException("El precio no puede ser negativo.", nameof(precio));
            Precio = precio;
        }

        public void SetFechaDesde(DateTime fechaDesde)
        {
            if (fechaDesde == default)
                throw new ArgumentException("La fecha desde no puede ser nula.", nameof(fechaDesde));
            FechaDesde = fechaDesde;
        }

        public void SetFechaHasta(DateTime fechaHasta)
        {
            if (fechaHasta == default)
                throw new ArgumentException("La fecha hasta no puede ser nula.", nameof(fechaHasta));
            if (fechaHasta <= FechaDesde)
                throw new ArgumentException("La fecha hasta debe ser posterior a la fecha desde.", nameof(fechaHasta));
            FechaHasta = fechaHasta;
        }
    }
}