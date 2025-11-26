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
            var compras = compraRepository.GetAllCli(idCliente);
            var entradasRepository = new EntradaRepository();
            var fiestaRepository = new FiestaRepository();
            /*
            var compraDTOs = compras.Select(compra =>
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
            }).ToList();*/

            List<CompraKeyDTO> listaIds = new List<CompraKeyDTO>();
            List<CompraDTO> comprasLista = new List<CompraDTO>();
            foreach (var compraN in compras)
            {
                CompraKeyDTO compraNK = new CompraKeyDTO
                {
                    IdCliente = compraN.IdCliente,
                    FechaHora = compraN.FechaHora,
                    IdFiesta = compraN.IdFiesta
                };
                if (!listaIds.Contains(compraNK))
                {
                    listaIds.Add(compraNK);
                    var entradas = entradasRepository.GetByCompra(compraN.IdCliente, compraN.FechaHora, compraN.IdFiesta);
                    var cantidad = entradas.Count();
                    CompraDTO compraToAdd = new CompraDTO
                    {
                        FechaHora = compraN.FechaHora,
                        IdVendedor = compraN.IdVendedor,
                        IdCliente = compraN.IdCliente,
                        IdFiesta = compraN.IdFiesta,
                        CantidadCompra = cantidad
                    };
                    comprasLista.Add(compraToAdd);
                }
                else
                {
                    var compraVK = listaIds.First(c => c.Equals(compraNK));
                    var compraV = compraRepository.Get(compraVK);
                    var loteCompraV = fiestaRepository.GetLoteFromCompra(compraV);
                    var loteCompraN = fiestaRepository.GetLoteFromCompra(compraN);
                    if (loteCompraN == loteCompraV)
                    {
                        var entradasCompraN = entradasRepository.GetByCompra(compraNK.IdCliente, compraNK.FechaHora, compraNK.IdFiesta);
                        var cantidadCompraN = entradasCompraN.Count();

                        foreach (var compraSub in comprasLista)
                        {
                            if (fiestaRepository.GetLoteFromCompra(compraRepository.Get(new CompraKeyDTO {IdFiesta = compraSub.IdFiesta, IdCliente = compraSub.IdCliente, FechaHora = compraSub.FechaHora})) == loteCompraN)
                            {
                                compraSub.CantidadCompra += cantidadCompraN;
                            }
                        }
                    }
                }
            }
            return comprasLista.ToList();
        }

        public IEnumerable<CompraDTO> GetAllByJefe(int idJefe)
        {
            var compraRepository = new CompraRepository();
            var compras = compraRepository.GetAllByJefe(idJefe);
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

        public bool Update(CompraDTO dto)
        {
            var compraRepository = new CompraRepository();

            Compra compra = new Compra(dto.FechaHora, dto.IdVendedor, dto.IdCliente, dto.IdFiesta);
            return compraRepository.Update(compra);
        }
    }
}
