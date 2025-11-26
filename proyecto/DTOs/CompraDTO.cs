using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class CompraDTO
    {
        public DateTime FechaHora { get; set; }
        public int CantidadCompra { get; set; }
        public string Entrada { get; set; }
        public int IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public int IdFiesta { get; set; }
        public string Lote { get; set; }
    }
    public class  CompraKeyDTO
    {
        public DateTime FechaHora { get; set; }
        public int IdCliente { get; set; }
        public int IdFiesta { get; set; }
    }
    public class CompraParaMostrarDTO
    {
        public string Cliente { get; set; }
        public string Vendedor { get; set; }
        public string Fiesta { get; set; }
        public string Lugar { get; set; }
        public int CantidadCompra { get; set; }
        public DateTime FechaHora { get; set; }
        public string Entrada { get; set; }
        public string Lote { get; set; }
    }
}
