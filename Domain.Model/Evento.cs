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

            public Evento() { }

            public Evento(int id, string nombre, string desc)
            {
                SetId(id);
                SetNombre (nombre);
                SetDesc (desc);
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
    }
}
