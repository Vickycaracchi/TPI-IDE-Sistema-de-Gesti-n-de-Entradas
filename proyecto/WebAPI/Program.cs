using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain.Model;
using DTOs;
using Application.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpLogging(o => { });

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHttpLogging();
}

app.UseHttpsRedirection();

//CLIENTES
app.MapGet("/clientes/{id}", (int id) =>
{
    ClienteService clienteService = new ClienteService();
    ClienteDTO dto = clienteService.Get(id);
    if (dto == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(dto);
});
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
});
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
});
.WithName("UpdateCliente")
.Produces(StatusCodes.Status404NotFound)
.Produces(StatusCodes.Status400BadRequest)
.WithOpenApi();

app.MapDelete("/clientes/{id}", (int id) =>
{
    ClienteService service = new ClienteService();
    var deleted = clienteService.Delete(id);

    if (!deleted)
    {
        return Results.NotFound();
    }

    return Results.NoContent();
});
.WithName("DeleteCliente")
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();




//  EVENTOS 

app.MapGet("/eventos/{id}", (int id) =>
{
    EventoService eventoService = new EventoService();
    EventoDTO dto = eventoService.GetById(id);
    if (dto == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(dto);
});
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
});
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
});

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
});
.WithName("DeleteEvento")
.Produces(StatusCodes.Status204NoContent)
.Produces(StatusCodes.Status404NotFound)
.WithOpenApi();


app.Run();
