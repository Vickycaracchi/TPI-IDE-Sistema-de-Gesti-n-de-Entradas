using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data.SqlClient;

namespace Data
{
    public class EventoRepository
    {
        private BGEContext CreateContext()
        {
            return new BGEContext();
        }

        public void Add(Evento evento)
        {
            using var context = CreateContext();
            context.Eventos.Add(evento);
            context.SaveChanges();
        }

        public bool Delete(int id)
        {
            using var context = CreateContext();
            var evento = context.Eventos.Find(id);
            if (evento != null)
            {
                context.Eventos.Remove(evento);
                context.SaveChanges();
                return true;
            }
            return false;
        }

        public Evento? Get(int id)
        {
            using var context = CreateContext();
            return context.Eventos
                .FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Evento> GetAll()
        {
            using var context = CreateContext();
            return context.Eventos
                .ToList();
        }

        public bool Update(Evento evento)
        {
            using var context = CreateContext();
            var existingEvento = context.Eventos.Find(evento.Id);
            if (existingEvento != null)
            {
                existingEvento.SetNombre(evento.Nombre);
                existingEvento.SetDesc(evento.Desc);
                existingEvento.SetFecha(evento.Fecha);
                existingEvento.SetLugar(evento.Lugar);


                context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}