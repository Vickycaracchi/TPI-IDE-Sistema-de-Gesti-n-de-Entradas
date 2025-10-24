using Application.Services;
using DTOs;

namespace WebAPI
{
    public static class LugarEndpoint
    {
        public static void MapLugarEndpoints(this WebApplication app)
        {
            app.MapGet("/lugares/{id}", (int id) =>
            {
                LugarService lugarService = new LugarService();

                LugarDTO dto = lugarService.Get(id);

                if (dto == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(dto);
            })
            .WithName("GetLugar")
            .Produces<LugarDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapGet("/lugares", () =>
            {
                LugarService lugarService = new LugarService();

                var dtos = lugarService.GetAll();

                return Results.Ok(dtos);
            })
            .WithName("GetAllLugares")
            .Produces<List<LugarDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();

            app.MapPost("/lugares", (LugarDTO dto) =>
            {
                try
                {
                    LugarService lugarService = new LugarService();

                    LugarDTO lugarDTO = lugarService.Add(dto);

                    return Results.Created($"/lugares/{lugarDTO.Id}", lugarDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("AddLugar")
            .Produces<LugarDTO>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapPut("/lugares", (LugarDTO dto) =>
            {
                try
                {
                    LugarService lugarService = new LugarService();

                    var found = lugarService.Update(dto);

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
            .WithName("UpdateLugar")
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapDelete("/lugares/{id}", (int id) =>
            {
                LugarService lugarService = new LugarService();

                var deleted = lugarService.Delete(id);

                if (!deleted)
                {
                    return Results.NotFound();
                }

                return Results.NoContent();
            })
            .WithName("DeleteLugar")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();
        }
    }
}
