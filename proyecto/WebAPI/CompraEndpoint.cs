using Application.Services;
using DTOs;

namespace WebAPI
{
    public static class CompraEndpoint
    {
        public static void MapCompraEndpoints(this WebApplication app)
        {          

            app.MapGet("/compras/{idVendedor}", (int idVendedor) =>
            {
                CompraService compraService = new CompraService();

                var dtos = compraService.GetAll(idVendedor);

                return Results.Ok(dtos);
            })
            .WithName("GetAllCompras")
            .Produces<List<EventoDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();

            app.MapPost("/compras", (CompraDTO dto) =>
            {
                try
                {
                    CompraService compraService = new CompraService();

                    CompraDTO compraDTO = compraService.Add(dto);

                    return Results.Created($"/compra/{compraDTO.IdVendedor}", compraDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("AddCompra")
            .Produces<EventoDTO>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapPut("/compras", (CompraDTO dto) =>
            {
                try
                {
                    CompraService compraService = new CompraService();

                    var found = compraService.Update(dto);

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
            .WithName("UpdateCompra")
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();
        }
    }
}
