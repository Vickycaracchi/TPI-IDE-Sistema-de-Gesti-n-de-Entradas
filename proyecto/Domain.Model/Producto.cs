using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Producto
    {
        public int Id { get; private set; }
        public string Descripcion { get; private set; }
        public int Precio { get; private set; }

        public Producto() { }

        public Producto(int id, string descripcion, int precio)
        {
            SetId(id);
            SetDescripcion(descripcion);
            SetPrecio(precio);
        }

        public void SetId(int id)
        {
            if (id < 0)
                throw new ArgumentException("El Id debe ser mayor que 0.", nameof(id));
            Id = id;
        }

        public void SetDescripcion(string descripcion)
        {
            if (string.IsNullOrWhiteSpace(descripcion))
                throw new ArgumentException("La descripción no puede ser nula o vacía.", nameof(descripcion));

            Descripcion = descripcion;
        }
        public void SetPrecio(int precio)
        {
            if (precio < 0)
                throw new ArgumentException("El precio no puede ser negativo.", nameof(precio));

            Precio = precio;
        }
    }
}
