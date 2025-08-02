using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Model;
using Data;

namespace Application.Services
{
    public class EventoService
    {
        public void Add(Evento evento)
        {
            evento.SetId(GetNextId());

            EventosInMemory.Evento.Add(evento);
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

        public Evento Get(int id)
        {
            //Deberia devolver un objeto cloneado 
            return EventosInMemory.Eventos.Find(x => x.Id == id);
        }

        public IEnumerable<Evento> GetAll()
        {
            //Devuelvo una lista nueva cada vez que se llama a GetAll
            //pero idealmente deberia implementar un Deep Clone
            return EventosInMemory.Eventos.ToList();
        }

        public bool Update(Evento evento)
        {
            Evento? eventoToUpdate = EventosInMemory.Eventos.Find(x => x.Id == evento.Id);

            if (eventoToUpdate != null)
            {
                eventoToUpdate.SetNombre(evento.Nombre);
                eventoToUpdate.SetDesc(evento.Apellido);
                eventoToUpdate.SetFecha(evento.Email);
                eventoToUpdate.SetLugar(evento.FechaAlta);

                return true;
            }
            else
            {
                return false;
            }
        }

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
