using Data;
using Domain.Model;
using DTOs;
using System;
using System.Collections.Generic;
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

            compraRepository.Add(compra);

            return dto;
        }

        public IEnumerable<CompraDTO> GetAll(int idVendedor)
        {
            var compraRepository = new CompraRepository();
            var compras = compraRepository.GetAll(idVendedor);

            return compras.Select(compra => new CompraDTO
            {
                FechaHora = compra.FechaHora,
                IdVendedor = compra.IdVendedor,
                IdCliente = compra.IdCliente,
                IdFiesta = compra.IdFiesta

            }).ToList();
        }
        public IEnumerable<CompraDTO> GetAllCli(int idCliente)
        {
            var compraRepository = new CompraRepository();
            var compras = compraRepository.GetAllCli(idCliente);

            return compras.Select(compra => new CompraDTO
            {
                FechaHora = compra.FechaHora,
                IdVendedor = compra.IdVendedor,
                IdCliente = compra.IdCliente,
                IdFiesta = compra.IdFiesta

            }).ToList();
        }
        public bool Update(CompraDTO dto)
        {
            var compraRepository = new CompraRepository();

            Compra compra = new Compra(dto.FechaHora, dto.IdVendedor, dto.IdCliente, dto.IdFiesta);
            return compraRepository.Update(compra);
        }
    }
}
