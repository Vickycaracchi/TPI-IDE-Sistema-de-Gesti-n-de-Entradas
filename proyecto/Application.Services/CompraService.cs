using Data;
using Domain.Model;
using DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CompraService
    {
        public CompraDTO Add(CompraDTO dto)
        {
            var compraRepository = new CompraRepository();

            dto.FechaHora = DateTime.Now;

            Compra compra = new Compra(dto.FechaHora, dto.IdVendedor, dto.IdCliente, dto.IdFiesta);

            compraRepository.Add(compra, dto.CantidadCompra);

            return dto;
        }

        public IEnumerable<CompraDTO> GetAll(int idVendedor)
        {
            var compraRepository = new CompraRepository();
            var compras = compraRepository.GetAll(idVendedor);
            var entradasRepository = new EntradaRepository();

            return compras.Select(compra =>
            {
                // Obtener las entradas asociadas a esta compra
                var entradas = entradasRepository.GetByCompra(compra.IdCliente, compra.FechaHora, compra.IdFiesta);
                var idsEntradas = string.Join(", ", entradas.Select(e => e.IdEntrada));
                var cantidad = entradas.Count();

                return new CompraDTO
                {
                    FechaHora = compra.FechaHora,
                    IdVendedor = compra.IdVendedor,
                    IdCliente = compra.IdCliente,
                    IdFiesta = compra.IdFiesta,
                    CantidadCompra = cantidad,
                    Entrada = idsEntradas
                };
            }).ToList();
        }
        public IEnumerable<CompraDTO> GetAllCli(int idCliente)
        {
            var compraRepository = new CompraRepository();

            return compraRepository.GetAllCli(idCliente);

        }

        public IEnumerable<CompraDTO> GetAllByJefe(int idJefe)
        {
            var compraRepository = new CompraRepository();

            return compraRepository.GetAllByJefe(idJefe);
        }

        public bool Update(CompraDTO dto)
        {
            var compraRepository = new CompraRepository();

            Compra compra = new Compra(dto.FechaHora, dto.IdVendedor, dto.IdCliente, dto.IdFiesta);
            return compraRepository.Update(compra);
        }
    }
}
