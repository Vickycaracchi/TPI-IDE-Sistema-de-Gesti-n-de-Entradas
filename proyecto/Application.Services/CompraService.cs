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

        public IEnumerable<CompraDTO> GetAllVendedor(int idVendedor)
        {
            var compraRepository = new CompraRepository();

            return compraRepository.GetAllVendedor(idVendedor);
        }
        public IEnumerable<CompraDTO> GetAllCli(int idCliente)
        {
            var compraRepository = new CompraRepository();

            return compraRepository.GetAllCli(idCliente);

        }

        public IEnumerable<CompraDTO> GetAllByJefe(int idJefe)
        {
            var compraRepository = new CompraRepository();

            return compraRepository.GetAllJefe(idJefe);
        }

        public IEnumerable<ComprasClienteDTO> GetComprasProductosCliente(int idCliente)
        {
            var compraRepository = new CompraRepository();

            return compraRepository.GetComprasProductosCliente(idCliente);
        }

        public IEnumerable<CompraParaReporteFiestasDTO> GetComprasParaReporteFiestas()
        {
            var compraRepository = new CompraRepository();

            return compraRepository.GetComprasParaReporteFiestasASPNET();
        }

        public IEnumerable<CompraParaReporteClientesDTO> GetComprasParaReporteClientes()
        {
            var compraRepository = new CompraRepository();

            return compraRepository.GetComprasParaReporteClientesASPNET();
        }

        public bool Update(CompraDTO dto)
        {
            var compraRepository = new CompraRepository();

            Compra compra = new Compra(dto.FechaHora, dto.IdVendedor, dto.IdCliente, dto.IdFiesta);
            return compraRepository.Update(compra);
        }
    }
}
