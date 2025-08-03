using System;
using System.Collections.Generic;
using Domain.Model;

namespace Data
{
    public class EventosInMemory
    {
        public static List<Evento> Eventos;

        static EventosInMemory()
        {
            Eventos = new List<Evento>
            {
                new Evento(1, "Cupula", "fiesta de reggeaton", DateTime.Now, "Centro Cultural Guemes"),
                new Evento(2, "No vayas a atender cuando el demonio llama tour", "tour del disco NVAACEDL", DateTime.Now, "Bioceres Arena"),
                new Evento(3, "Oscuro extasis tour", "tour del disco OE", DateTime.Now, "Ex rural"),
                new Evento(4, "LOUIE presentacion primer ep", "presentacion del primer EP de LOUIE", DateTime.Now, "Majo club"),
                new Evento(5, "Bohemia", "fiesta de disfraces", DateTime.Now, "La Sala de Las Artes"),
            };
        }
    }
}
