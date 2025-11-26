using Application.Services;
using DTOs;

namespace WebAPI
{
    public static class CompraEndpoint
    {
        public static void MapCompraEndpoints(this WebApplication app)
        {

            // GET compras por vendedor
            app.MapGet("/compras/vendedor/{idVendedor}", (int idVendedor) =>
            {
                CompraService compraService = new CompraService();
                var dtos = compraService.GetAllVendedor(idVendedor);
                return Results.Ok(dtos);
            })
            .WithName("GetAllComprasVendedor")
            .Produces<List<EventoDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();

            // GET compras por cliente
            app.MapGet("/compras/cliente/{idCliente}", (int idCliente) =>
            {
                CompraService compraService = new CompraService();
                var dtos = compraService.GetAllCli(idCliente);
                return Results.Ok(dtos);
            })
            .WithName("GetAllComprasCliente")
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

            // GET compras por jefe (ventas de sus vendedores)
            app.MapGet("/compras/jefe/{idJefe}", (int idJefe) =>
            {
                CompraService compraService = new CompraService();
                var dtos = compraService.GetAllByJefe(idJefe);
                return Results.Ok(dtos);
            })
            .WithName("GetAllComprasByJefe")
            .Produces<List<CompraDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();
        }
    }
}
