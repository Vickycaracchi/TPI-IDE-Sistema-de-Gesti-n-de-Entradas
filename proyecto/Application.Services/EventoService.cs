using Domain.Model;
using Data;
using DTOs;

namespace Application.Services
{
    public class EventoService
    {
        public EventoDTO Add(EventoDTO dto)
        {
            // Validar que el nombre no esté duplicado
            if (EventosInMemory.Eventos.Any(e => e.Nombre.Equals(dto.Nombre, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException($"Ya existe un evento con el Nombre '{dto.Nombre}'.");
            }

            var id = GetNextId();

            Evento evento = new Evento(id, dto.Nombre, dto.Desc, dto.Fecha, dto.Lugar);

            EventosInMemory.Eventos.Add(evento);

            dto.Id = evento.Id;

            return dto;
        }

        public bool Delete(int id)
        {
            Evento? eventoToDelete = EventosInMemory.Eventos.Find(x => x.Id == id);

            if (eventoToDelete != null)
            {
                EventosInMemory.Eventos.Remove(eventoToDelete);

                return true;
            }
            else
            {
                return false;
            }
        }

        public EventoDTO Get(int id)
        {
            Evento? evento = EventosInMemory.Eventos.Find(x => x.Id == id);

            if (evento == null)
                return null;

            return new EventoDTO
            {
                Id = evento.Id,
                Nombre = evento.Nombre,
                Desc = evento.Desc,
                Fecha = evento.Fecha,
                Lugar = evento.Lugar
            };
        }

        public IEnumerable<EventoDTO> GetAll()
        {
            return EventosInMemory.Eventos.Select(evento => new EventoDTO
            {
                Id = evento.Id,
                Nombre = evento.Nombre,
                Desc = evento.Desc,
                Fecha = evento.Fecha,
                Lugar = evento.Lugar
            }).ToList();
        }

        public bool Update(EventoDTO dto)
        {
            Evento? eventoToUpdate = EventosInMemory.Eventos.Find(x => x.Id == dto.Id);

            if (eventoToUpdate != null)
            {
                // Validar que el nombre no esté duplicado
                if (EventosInMemory.Eventos.Any(e => e.Id != dto.Id && e.Nombre.Equals(dto.Nombre, StringComparison.OrdinalIgnoreCase)))
                {
                    throw new ArgumentException($"Ya existe un evento con el Nombre '{dto.Nombre}'.");
                }

                eventoToUpdate.SetNombre(dto.Nombre);
                eventoToUpdate.SetDesc(dto.Desc);
                eventoToUpdate.SetFecha(dto.Fecha);
                eventoToUpdate.SetLugar(dto.Lugar);

                return true;
            }
            else
            {
                return false;
            }
        }

        //No es ThreadSafe pero sirve para el proposito del ejemplo        
        private static int GetNextId()
        {
            int nextId;

            if (EventosInMemory.Eventos.Count > 0)
            {
                nextId = EventosInMemory.Eventos.Max(x => x.Id) + 1;
            }
            else
            {
                nextId = 1;
            }

            return nextId;
        }
    }
}
