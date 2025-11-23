using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Entrada
    {
        public int IdEntrada { get; private set; }
        public int IdCliente { get; private set; }
        public int IdFiesta { get; private set; }
        public DateTime FechaHora { get; private set; }
        public Entrada(int idEntrada, int idCliente, int idFiesta, DateTime fechaHora)
        {
            SetIdEntrada(idEntrada);
            SetIdCliente(idCliente);
            SetIdFiesta(idFiesta);
            SetFechaHora(fechaHora);
        }

        public Entrada(int idCliente, int idFiesta, DateTime fechaHora)
        {
            SetIdCliente(idCliente);
            SetIdFiesta(idFiesta);
            SetFechaHora(fechaHora);
        }

        public void SetIdEntrada(int idEntrada)
        {
            if (idEntrada <= 0)
                throw new ArgumentException("El Id de entrada debe ser mayor que 0.", nameof(idEntrada));
            IdEntrada = idEntrada;
        }
        public void SetIdCliente(int idCliente)
        {
            if (idCliente < 0)
                throw new ArgumentException("El Id debe ser mayor que 0.", nameof(idCliente));
            IdCliente = idCliente;
        }
        public void SetIdFiesta(int idFiesta)
        {
            if (idFiesta < 0)
                throw new ArgumentException("El Id debe ser mayor que 0.", nameof(idFiesta));
            IdFiesta = idFiesta;
        }
        public void SetFechaHora(DateTime fechaHora)
        {
            if (fechaHora == default)
                throw new ArgumentException("La fecha desde no puede ser nula.", nameof(fechaHora));
            FechaHora = fechaHora;
        }
    }
}