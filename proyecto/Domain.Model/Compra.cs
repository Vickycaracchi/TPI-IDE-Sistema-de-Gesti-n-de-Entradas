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
        public string Entrada { get; private set; }
        public int IdVendedor { get; private set; }
        public int IdCliente { get; private set; }
        public int IdFiesta { get; private set; }

        public decimal Precio_Entrada{ get; private set; }

        public Compra(DateTime fechaHora, int cantidadCompra, string entrada, int idVendedor, int idCliente, int idFiesta, decimal precio)
        {
            SetFecha(fechaHora);
            SetCantidadCompra(cantidadCompra);
            SetEntrada(entrada);
            SetIdVendedor(idVendedor);
            SetIdCliente(idCliente);
            SetIdFiesta(idFiesta);
            SetPrecioEntrada(precio);
        }
        public Compra() { }
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
        public void SetEntrada(string entrada)
        {
            if (entrada == null) { Entrada = null; } else {  Entrada = entrada; }
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
        public void SetIdFiesta(int idFiesta)
        {
            if(idFiesta == 0)
                throw new ArgumentException("La fiesta no puede ser nula.", nameof (idFiesta));
            IdFiesta = idFiesta;
        }

        public void SetPrecioEntrada(decimal precio)
        {
            if (precio < 0)
                throw new ArgumentException("el precio no puede ser negativo.", nameof(precio));
            Precio_Entrada = precio;
        }
    }
}
