using Domain.Model;
using Data;
using DTOs;

namespace Application.Services
{
    public class EventoService
    {
        public EventoDTO Add(EventoDTO dto)
        {
            var eventoRepository = new EventoRepository();

            var fecha = DateTime.Now;
            Evento evento = new Evento(dto.Id, dto.Nombre, dto.Desc, dto.Fecha, dto.Lugar);

            eventoRepository.Add(evento);

            dto.Id = evento.Id;
            dto.Fecha = evento.Fecha;

            return dto;
        }

        public bool Delete(int id)
        {
            var eventoRepository = new EventoRepository();
            return eventoRepository.Delete(id);
        }

        public EventoDTO Get(int id)
        {
            var eventoRepository = new EventoRepository();
            Evento? evento = eventoRepository.Get(id);

            if (evento == null)
                return null;

            return new EventoDTO
            {
                Id = evento.Id,
                Nombre = evento.Nombre
            };
        }

        public IEnumerable<EventoDTO> GetAll()
        {
            var eventoRepository = new EventoRepository();
            var eventos = eventoRepository.GetAll();

            return eventos.Select(evento => new EventoDTO
            {
                Id = evento.Id,
                Nombre = evento.Nombre
            }).ToList();
        }

        public bool Update(EventoDTO dto)
        {
            var eventoRepository = new EventoRepository();

            Evento evento = new Evento(dto.Id, dto.Nombre, dto.Desc, dto.Fecha, dto.Lugar);
            return eventoRepository.Update(evento);
        }
    }
}
