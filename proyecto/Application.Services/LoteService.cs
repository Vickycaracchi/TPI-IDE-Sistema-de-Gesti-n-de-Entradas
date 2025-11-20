using Domain.Model;
using Data;
using DTOs;

namespace Application.Services
{
    public class LoteService
    {
        public LoteDTO Add(LoteDTO dto)
        {
            var loteRepository = new LoteRepository();

            // Validar que el nombre no esté duplicado
            if (loteRepository.NombreExists(dto.Nombre))
            {
                throw new ArgumentException($"Ya existe un lote con el nombre '{dto.Nombre}'.");
            }

            Lote lote = new Lote(dto.Id, dto.Nombre, dto.Precio, dto.FechaDesde, dto.FechaHasta);

            loteRepository.Add(lote);

            dto.Id = lote.Id;

            return dto;
        }

        public bool Delete(int id)
        {
            var loteRepository = new LoteRepository();
            return loteRepository.Delete(id);
        }
        public LoteDTO Get(int id)
        {
            var loteRepository = new LoteRepository();
            Lote? lote = loteRepository.Get(id);

            if (lote == null)
                return null;

            return new LoteDTO
            {
                Id = lote.Id,
                Nombre = lote.Nombre,
                Precio = lote.Precio,
                FechaDesde = lote.FechaDesde,
                FechaHasta = lote.FechaHasta
            };
        }

        public IEnumerable<LoteDTO> GetAll()
        {
            var loteRepository = new LoteRepository();
            var lotes = loteRepository.GetAll();

            return lotes.Select(lote => new LoteDTO
            {
                Id = lote.Id,
                Nombre = lote.Nombre,
                Precio = lote.Precio,
                FechaDesde = lote.FechaDesde,
                FechaHasta = lote.FechaHasta
            }).ToList();
        }


        public bool Update(LoteDTO dto)
        {
            var loteRepository = new LoteRepository();

            // Validar que el nombre no esté duplicado (excluyendo el lote actual)
            if (loteRepository.NombreExists(dto.Nombre, dto.Id))
            {
                throw new ArgumentException($"Ya existe otro lote con el nombre '{dto.Nombre}'.");
            }

            Lote lote = new Lote(dto.Id, dto.Nombre, dto.Precio, dto.FechaDesde, dto.FechaHasta);
            return loteRepository.Update(lote);
        }
        public LoteDTO GetLoteActual(int idFiesta)
        {
            var loteRepository = new LoteRepository();
            Lote? lote = loteRepository.GetLoteActual(idFiesta);

            if(lote == null)
                return null;
            
            return new LoteDTO
            {
                Id = lote.Id,
                Nombre = lote.Nombre,
                Precio = lote.Precio,
                FechaDesde = lote.FechaDesde,
                FechaHasta = lote.FechaHasta
            };
        }
    }
}