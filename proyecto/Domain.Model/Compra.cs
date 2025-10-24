using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Domain.Model
{
    public class Compra
    {
        public DateTime FechaHora { get; private set; }
        public int CantidadCompra { get; private set; }
        public int IdVendedor { get; private set; }
        public int IdCliente { get; private set; }

        public Compra(DateTime fechaHora, int cantidadCompra, int idVendedor, int idCliente)
        {
            SetFecha(fechaHora);
            SetCantidadCompra(cantidadCompra);
            SetIdVendedor(idVendedor);
            SetIdCliente(idCliente);
        }
        public void SetFecha(DateTime fecha)
        {
            if (fecha == default)
                throw new ArgumentException("La fecha no puede ser nula.", nameof(fecha));
            FechaHora = fecha;
        }
        public void SetCantidadCompra(int cantidadCompra)
        {
            if (cantidadCompra == 0)
                throw new ArgumentException("La cantidad de compra no puede ser nula.", nameof(cantidadCompra));
            CantidadCompra = cantidadCompra;
        }
        public void SetIdVendedor(int idVendedor)
        {
            if (idVendedor == 0)
                throw new ArgumentException("La cantidad de compra no puede ser nula.", nameof(idVendedor));
            IdVendedor = idVendedor;
        }
        public void SetIdCliente(int idCliente)
        {
            if (idCliente == 0)
                throw new ArgumentException("La cantidad de compra no puede ser nula.", nameof(idCliente));
            IdCliente = idCliente;
        }
    }
}
