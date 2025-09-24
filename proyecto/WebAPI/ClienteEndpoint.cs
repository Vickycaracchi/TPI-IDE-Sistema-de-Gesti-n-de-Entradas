using Application.Services;
using DTOs;

namespace WebAPI
{
    public static class ClienteEndpoint
    {
        public static void MapClienteEndpoints(this WebApplication app)
        {
            app.MapGet("/clientes/{id}", (int id) =>
            {
                ClienteService clienteService = new ClienteService();

                ClienteDTO dto = clienteService.Get(id);

                if (dto == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(dto);
            })
            .WithName("GetCliente")
            .Produces<ClienteDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapGet("/clientes", () =>
            {
                ClienteService clienteService = new ClienteService();

                var dtos = clienteService.GetAll();

                return Results.Ok(dtos);
            })
            .WithName("GetAllClientes")
            .Produces<List<ClienteDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();

            app.MapPost("/clientes", (ClienteDTO dto) =>
            {
                try
                {
                    ClienteService clienteService = new ClienteService();

                    ClienteDTO clienteDTO = clienteService.Add(dto);

                    return Results.Created($"/clientes/{clienteDTO.Id}", clienteDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("AddCliente")
            .Produces<ClienteDTO>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapPut("/clientes", (ClienteDTO dto) =>
            {
                try
                {
                    ClienteService clienteService = new ClienteService();

                    var found = clienteService.Update(dto);

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
            .WithName("UpdateCliente")
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapDelete("/clientes/{id}", (int id) =>
            {
                ClienteService clienteService = new ClienteService();

                var deleted = clienteService.Delete(id);

                if (!deleted)
                {
                    return Results.NotFound();
                }

                return Results.NoContent();
            })
            .WithName("DeleteCliente")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapPost("/auth/login", (CliLoginDTO loginDto) =>
            {
                try
                {
                    ClienteService clienteService = new ClienteService();

                    ClienteDTO? cliente = clienteService.GetForLogin(loginDto);

                    if (cliente == null)
                    {
                        return Results.Unauthorized();
                    }

                    return Results.Ok(cliente);
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
            .WithName("Login")
            .Produces<ClienteDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status401Unauthorized)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();
        }
    }
}
