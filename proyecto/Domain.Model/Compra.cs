using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Compra
    {
        public DateTime FechaHora { get; private set; }
        public int CantidadCompra { get; private set; }
        public int IdVendedor { get; private set; }
        public int IdCliente { get; private set; }
    }
}
