using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class ProductoDTO
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
    }
    public class ProdcutoConCantidadDTO
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }
    }
    public class ProductoConCompraDTO
    {
        public List<ProdcutoConCantidadDTO> Producto { get; set; }
        public CompraKeyDTO Compra { get; set; }
    }
}
