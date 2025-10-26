using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class FiestaDTO
    {
        public int IdFiesta { get; set; }
        public DateTime FechaFiesta { get; set; }
        public int IdLugar { get; set; }
        public int IdEvento { get; set; }
    }
}
