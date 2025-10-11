using Application.Services;
using DTOs;

namespace WebAPI
{
    public static class UsuarioEndpoint
    {
        public static void MapUsuarioEndpoints(this WebApplication app)
        {
            app.MapGet("/usuarios/{id}", (int id) =>
            {
                UsuarioService usuarioService = new UsuarioService();

                UsuarioDTO dto = usuarioService.Get(id);

                if (dto == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(dto);
            })
            .WithName("GetUsuarios")
            .Produces<UsuarioDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapGet("/usuarios", () =>
            {
                UsuarioService usuarioService = new UsuarioService();

                var dtos = usuarioService.GetAll();

                return Results.Ok(dtos);
            })
            .WithName("GetAllUsuarios")
            .Produces<List<UsuarioDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();

            app.MapGet("/usuariosByTipo/{tipoBuscado}", (string tipoBuscado) =>
            {
                UsuarioService usuarioService = new UsuarioService();

                var dtos = usuarioService.GetByTipo(tipoBuscado);

                return Results.Ok(dtos);
            })
            .WithName("GetUsuariosTipo")
            .Produces<List<UsuarioDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();

            app.MapPost("/usuarios", (UsuarioDTO dto) =>
            {
                try
                {
                    UsuarioService usuarioService = new UsuarioService();

                    UsuarioDTO usuarioDTO = usuarioService.Add(dto);

                    return Results.Created($"/usuarios/{usuarioDTO.Id}", usuarioDTO);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("AddUsuarios")
            .Produces<UsuarioDTO>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapPut("/usuarios", (UsuarioDTO dto) =>
            {
                try
                {
                    UsuarioService usuarioService = new UsuarioService();

                    var found = usuarioService.Update(dto);

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
            .WithName("UpdateUsuarios")
            .Produces(StatusCodes.Status404NotFound)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapDelete("/usuarios/{id}", (int id) =>
            {
                UsuarioService usuarioService = new UsuarioService();

                var deleted = usuarioService.Delete(id);

                if (!deleted)
                {
                    return Results.NotFound();
                }

                return Results.NoContent();
            })
            .WithName("DeleteUsuarios")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();

            app.MapPost("loginUsuario", (LoginDTO loginDto) =>
            {
                try
                {
                    UsuarioService usuarioService = new UsuarioService();

                    UsuarioDTO? usuario = usuarioService.GetForLogin(loginDto);

                    if (usuario == null)
                    {
                        return Results.Unauthorized();
                    }

                    return Results.Ok(usuario);
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
            .WithName("LoginUsuarios")
            .Produces<UsuarioDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status401Unauthorized)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();
        }
    }
}
