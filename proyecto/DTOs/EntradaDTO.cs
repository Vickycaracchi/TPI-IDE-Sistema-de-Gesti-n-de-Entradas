using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class EntradaDTO
    {
        public int IdEntrada { get; set; }
        public int IdCliente { get; set; }
        public int IdFiesta { get; set; }
        public DateTime FechaHora { get; set; }
    }
}