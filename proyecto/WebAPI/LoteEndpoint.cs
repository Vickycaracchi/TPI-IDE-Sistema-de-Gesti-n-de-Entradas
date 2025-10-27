using Application.Services;
using DTOs;

namespace WebAPI
{
    public static class LoteEndpoint
    {
        public static void MapLoteEndpoints(this WebApplication app)
        {
            app.MapGet("/lotes/{id}", (int id) =>
            {
                LoteService loteService = new LoteService();

                LoteDTO dto = loteService.Get(id);

                if (dto == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(dto);
            })
            .WithName("GetLote")
            .Produces<LoteDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapGet("/lotes", () =>
            {
                LoteService loteService = new LoteService();

                var dtos = loteService.GetAll();

                return Results.Ok(dtos);
            })
            .WithName("GetAllLotes")
            .Produces<List<LoteDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();


            app.MapPost("/lotes", (LoteDTO dto) =>
            {
                try
                {
                    LoteService loteService = new LoteService();

                    LoteDTO loteDTO = loteService.Add(dto);

                    return Results.Created($"/lotes/{loteDTO.Id}", loteDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("AddLote")
            .Produces<LoteDTO>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapPut("/lotes", (LoteDTO dto) =>
            {
                try
                {
                    LoteService loteService = new LoteService();

                    var found = loteService.Update(dto);

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
            .WithName("UpdateLote")
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapDelete("/lotes/{id}", (int id) =>
            {
                LoteService loteService = new LoteService();

                var deleted = loteService.Delete(id);

                if (!deleted)
                {
                    return Results.NotFound();
                }

                return Results.NoContent();
            })
            .WithName("DeleteLote")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            
        }
    }
}
