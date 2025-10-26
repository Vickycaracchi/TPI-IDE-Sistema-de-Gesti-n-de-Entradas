using Application.Services;
using DTOs;

namespace WebAPI
{
    public static class FiestaEndpoint
    {
        public static void MapFiestaEndpoints(this WebApplication app)
        {          

            app.MapGet("/fiestas", () =>
            {
                FiestaService fiestaService = new FiestaService();

                var dtos = fiestaService.GetAll();

                return Results.Ok(dtos);
            })
            .WithName("GetAllFiestas")
            .Produces<List<FiestaDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();

            app.MapGet("/fiestas/{idFiesta}", (int idFiesta) =>
            {
                FiestaService fiestaService = new FiestaService();

                FiestaDTO dto = fiestaService.Get(idFiesta);

                if (dto == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(dto);
            })
            .WithName("GetFiesta")
            .Produces<FiestaDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapPost("/fiestas", (FiestaDTO dto) =>
            {
                try
                {
                    FiestaService fiestaService = new FiestaService();

                    FiestaDTO fiestaDTO = fiestaService.Add(dto);

                    return Results.Created($"/fiesta/{fiestaDTO.IdFiesta}", fiestaDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("AddFiesta")
            .Produces<FiestaDTO>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapPut("/fiestas", (FiestaDTO dto) =>
            {
                try
                {
                    FiestaService fiestaService = new FiestaService();

                    var found = fiestaService.Update(dto);

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
            .WithName("UpdateFiesta")
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapDelete("/fiestas/{idFiesta}", (int idFiesta) =>
            {
                FiestaService fiestaService = new FiestaService();

                var deleted = fiestaService.Delete(idFiesta);

                if (!deleted)
                {
                    return Results.NotFound();
                }

                return Results.NoContent();
            })
            .WithName("DeleteFiesta")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();
        }
    }
}
