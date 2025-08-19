using Application.Services;
using DTOs;

namespace WebAPI
{
    public static class EventoEndpoint
    {
        public static void MapEventoEndpoints(this WebApplication app)
        {
            app.MapGet("/eventos/{id}", (int id) =>
            {
                EventoService eventoService = new EventoService();

                EventoDTO dto = eventoService.Get(id);

                if (dto == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(dto);
            })
            .WithName("GetEvento")
            .Produces<EventoDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapGet("/eventos", () =>
            {
                EventoService eventoService = new EventoService();

                var dtos = eventoService.GetAll();

                return Results.Ok(dtos);
            })
            .WithName("GetAllEventos")
            .Produces<List<EventoDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();

            app.MapPost("/eventos", (EventoDTO dto) =>
            {
                try
                {
                    EventoService eventoService = new EventoService();

                    EventoDTO eventoDTO = eventoService.Add(dto);

                    return Results.Created($"/eventos/{eventoDTO.Id}", eventoDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("AddEvento")
            .Produces<EventoDTO>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapPut("/eventos", (EventoDTO dto) =>
            {
                try
                {
                    EventoService eventoService = new EventoService();

                    var found = eventoService.Update(dto);

                    if (!found)
                    {
                        return Results.NotFound();
                    }

                    return Results.NoContent();
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("UpdateEvento")
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapDelete("/eventos/{id}", (int id) =>
            {
                EventoService eventoService = new EventoService();

                var deleted = eventoService.Delete(id);

                if (!deleted)
                {
                    return Results.NotFound();
                }

                return Results.NoContent();
            })
            .WithName("DeleteEvento")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();
        }
    }
}
