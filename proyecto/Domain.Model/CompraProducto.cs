using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class CompraProducto
    {
        public int IdCliente { get; set; }
        public int IdFiesta { get; set; }
        public int IdProducto { get; set; }
        public DateTime FechaHora { get; set; }
        public int Cantidad { get; set; }
        public CompraProducto(int idCliente, int idFiesta, int idProducto, DateTime fechaHora, int cantidad)
        {
            SetIdCliente(idCliente);
            SetIdFiesta(idFiesta);
            SetIdProducto(idProducto);
            SetFechaHora(fechaHora);
            SetCantidad(cantidad);
        }
        public void SetIdCliente(int idCliente)
        {
            if (idCliente <= 0)
                throw new ArgumentException("El Id del cliente debe ser mayor que 0.", nameof(idCliente));
            IdCliente = idCliente;
        }
        public void SetIdFiesta(int idFiesta)
        {
            if (idFiesta <= 0)
                throw new ArgumentException("El Id de la fiesta debe ser mayor que 0.", nameof(idFiesta));
            IdFiesta = idFiesta;
        }
        public void SetIdProducto(int idProducto)
        {
            if (idProducto <= 0)
                throw new ArgumentException("El Id del producto debe ser mayor que 0.", nameof(idProducto));
            IdProducto = idProducto;
        }
        public void SetFechaHora(DateTime fechaHora)
        {
            if (fechaHora == default)
                throw new ArgumentException("La fecha y hora no puede ser nula.", nameof(fechaHora));
            FechaHora = fechaHora;
        }
        public void SetCantidad(int cantidad)
        {
            if (cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor que 0.", nameof(cantidad));
            Cantidad = cantidad;
        }
    }
}
