using Application.Services;
using DTOs;

namespace WebAPI
{
    public static class ProductoEndpoint
    {
        public static void MapProductoEndpoints(this WebApplication app)
        {
            app.MapGet("/productos/{id}", (int id) =>
            {
                ProductoService productoService = new ProductoService();

                ProductoDTO dto = productoService.Get(id);

                if (dto == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(dto);
            })
            .WithName("GetProducto")
            .Produces<ProductoDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapGet("/productos", () =>
            {
                ProductoService productoService = new ProductoService();

                var dtos = productoService.GetAll();

                return Results.Ok(dtos);
            })
            .WithName("GetAllProductos")
            .Produces<List<ProductoDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();

            app.MapPost("/productos", (ProductoDTO dto) =>
            {
                try
                {
                    ProductoService productoService = new ProductoService();

                    ProductoDTO productoDTO = productoService.Add(dto);

                    return Results.Created($"/productos/{productoDTO.Id}", productoDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("AddProducto")
            .Produces<ProductoDTO>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapPut("/productos", (ProductoDTO dto) =>
            {
                try
                {
                    ProductoService productoService = new ProductoService();

                    var found = productoService.Update(dto);

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
            .WithName("UpdateProducto")
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapDelete("/productos/{id}", (int id) =>
            {
                ProductoService productoService = new ProductoService();

                var deleted = productoService.Delete(id);

                if (!deleted)
                {
                    return Results.NotFound();
                }

                return Results.NoContent();
            })
            .WithName("DeleteProducto")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();
        }
    }
}

