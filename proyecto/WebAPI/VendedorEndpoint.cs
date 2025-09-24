using Application.Services;
using DTOs;

namespace WebAPI
{
    public static class VendedorEndpoint
    {
        public static void MapVendedorEndpoints(this WebApplication app)
        {
            app.MapGet("/vendedors/{id}", (int id) =>
            {
                VendedorService vendedorService = new VendedorService();

                VendedorDTO dto = vendedorService.Get(id);

                if (dto == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(dto);
            })
            .WithName("GetVendedor")
            .Produces<VendedorDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapGet("/vendedors", () =>
            {
                VendedorService vendedorService = new VendedorService();

                var dtos = vendedorService.GetAll();

                return Results.Ok(dtos);
            })
            .WithName("GetAllVendedors")
            .Produces<List<VendedorDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();

            app.MapPost("/vendedors", (VendedorDTO dto) =>
            {
                try
                {
                    VendedorService vendedorService = new VendedorService();

                    VendedorDTO vendedorDTO = vendedorService.Add(dto);

                    return Results.Created($"/vendedors/{vendedorDTO.Id}", vendedorDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("AddVendedor")
            .Produces<VendedorDTO>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapPut("/vendedors", (VendedorDTO dto) =>
            {
                try
                {
                    VendedorService vendedorService = new VendedorService();

                    var found = vendedorService.Update(dto);

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
            .WithName("UpdateVendedor")
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapDelete("/vendedors/{id}", (int id) =>
            {
                VendedorService vendedorService = new VendedorService();

                var deleted = vendedorService.Delete(id);

                if (!deleted)
                {
                    return Results.NotFound();
                }

                return Results.NoContent();
            })
            .WithName("DeleteVendedor")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapPost("loginVendedor", (CliLoginDTO loginDto) =>
            {
                try
                {
                    VendedorService vendedorService = new VendedorService();

                    VendedorDTO? vendedor = vendedorService.GetForLogin(loginDto);

                    if (vendedor == null)
                    {
                        return Results.Unauthorized();
                    }

                    return Results.Ok(vendedor);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
                catch (Exception)
                {
                    return Results.StatusCode(500);
                }
            })
            .WithName("LoginVendedor")
            .Produces<VendedorDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status401Unauthorized)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();
        }
    }
}
