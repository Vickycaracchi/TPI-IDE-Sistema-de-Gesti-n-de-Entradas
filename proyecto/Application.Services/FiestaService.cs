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
    public class FiestaService
    {
        public FiestaDTO Add(FiestaDTO dto)
        {
            var fiestaRepository = new FiestaRepository();

       

            Fiesta fiesta = new Fiesta(dto.IdFiesta, dto.FechaFiesta, dto.IdLugar, dto.IdEvento);

            fiestaRepository.Add(fiesta);

            return dto;
        }

        public IEnumerable<FiestaDTO> GetAll()
        {
            var fiestaRepository = new FiestaRepository();
            var fiestas = fiestaRepository.GetAll();


            return fiestas.Select(fiesta => new FiestaDTO
            {
                IdFiesta = fiesta.IdFiesta,
                FechaFiesta = fiesta.FechaFiesta,
                IdLugar = fiesta.IdLugar,
                IdEvento = fiesta.IdEvento,
                

            }).ToList();
        }
        public FiestaDTO Get(int idFiesta)
        {
            var fiestaRepository = new FiestaRepository();
            Fiesta? fiesta = fiestaRepository.Get(idFiesta);

            if (fiesta == null)
                return null;

            return new FiestaDTO

            {
                IdFiesta = fiesta.IdFiesta,
                FechaFiesta = fiesta.FechaFiesta,
                IdLugar = fiesta.IdLugar,
                IdEvento = fiesta.IdEvento,

            };
        }


        public bool Update(FiestaDTO dto)
        {
            var fiestaRepository = new FiestaRepository();

            Fiesta fiesta = new Fiesta(dto.IdFiesta, dto.FechaFiesta, dto.IdLugar, dto.IdEvento);
            return fiestaRepository.Update(fiesta);
        }

        public bool Delete(int idFiesta)
        {
            var fiestaRepository = new FiestaRepository();
            return fiestaRepository.Delete(idFiesta);
        }

    }
}
