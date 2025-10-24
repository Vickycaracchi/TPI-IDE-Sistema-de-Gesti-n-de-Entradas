using Domain.Model;
using Data;
using DTOs;

namespace Application.Services
{
    public class LugarService
    {
        public LugarDTO Add(LugarDTO dto)
        {
            var lugarRepository = new LugarRepository();

            // Validar que el nombre no esté duplicado
            if (lugarRepository.NombreExists(dto.Nombre))
            {
                throw new ArgumentException($"Ya existe un lugar con el nombre '{dto.Nombre}'.");
            }

            Lugar lugar = new Lugar(dto.Id, dto.Nombre, dto.Direccion, dto.Ciudad);

            lugarRepository.Add(lugar);

            dto.Id = lugar.Id;

            return dto;
        }

        public bool Delete(int id)
        {
            var lugarRepository = new LugarRepository();
            return lugarRepository.Delete(id);
        }

        public LugarDTO Get(int id)
        {
            var lugarRepository = new LugarRepository();
            Lugar? lugar = lugarRepository.Get(id);

            if (lugar == null)
                return null;

            return new LugarDTO
            {
                Id = lugar.Id,
                Nombre = lugar.Nombre,
                Direccion = lugar.Direccion,
                Ciudad = lugar.Ciudad
            };
        }

        public IEnumerable<LugarDTO> GetAll()
        {
            var lugarRepository = new LugarRepository();
            var lugares = lugarRepository.GetAll();

            return lugares.Select(lugar => new LugarDTO
            {
                Id = lugar.Id,
                Nombre = lugar.Nombre,
                Direccion = lugar.Direccion,
                Ciudad = lugar.Ciudad
            }).ToList();
        }

        public bool Update(LugarDTO dto)
        {
            var lugarRepository = new LugarRepository();

            // Validar que el nombre no esté duplicado (excluyendo el lugar actual)
            if (lugarRepository.NombreExists(dto.Nombre, dto.Id))
            {
                throw new ArgumentException($"Ya existe otro lugar con el nombre '{dto.Nombre}'.");
            }

            Lugar lugar = new Lugar(dto.Id, dto.Nombre, dto.Direccion, dto.Ciudad);
            return lugarRepository.Update(lugar);
        }
    }
}
