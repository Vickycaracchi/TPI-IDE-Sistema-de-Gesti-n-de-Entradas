using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class CompraProductoDTO
    {
        public int IdCliente { get; set; }
        public int IdFiesta { get; set; }
        public int IdProducto { get; set; }
        public DateTime FechaHora { get; set; }
    }
}
