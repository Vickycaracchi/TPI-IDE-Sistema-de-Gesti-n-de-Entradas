using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTOs
{
    public class EventoDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Desc { get; set; }
        public DateTime Fecha { get; private set; }
        public string Lugar { get; private set; }
    }
}
