using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class EntradaDTO
    {
        public int IdEntrada { get; private set; }
        public int IdCliente { get; private set; }
        public int IdFiesta { get; private set; }
        public DateTime FechaHora { get; private set; }
    }
}