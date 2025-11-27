using API.Clients;
using Application.Services;
using DTOs;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using System;

namespace Infraestructura.Reportes
{
    public class ReporteClientes : IDocument
    {
        List<CompraParaReporteClientesDTO> comprasParaReporte;
        List<UsuarioDTO> usuarios;
        List<EventoDTO> eventos;
        List<LugarDTO> lugares;
        List<FiestaDTO> fiestas;
        public ReporteDataCli Model { get; }

        public ReporteClientes(ReporteDataCli model)
        {
            Model = model;

            try
            {
                this.comprasParaReporte = CompraApiClient.GetComprasParaReporteClientesAsync()
                    .GetAwaiter()
                    .GetResult()
                    .ToList();
                this.usuarios = UsuarioApiClient.GetAllAsync()
                    .GetAwaiter()
                    .GetResult()
                    .ToList();
                this.eventos = EventoApiClient.GetAllAsync()
                    .GetAwaiter()
                    .GetResult()
                    .ToList();
                this.lugares = LugarApiClient.GetAllAsync()
                    .GetAwaiter()
                    .GetResult()
                    .ToList();
                this.fiestas = FiestaApiClient.GetAllAsync()
                    .GetAwaiter()
                    .GetResult()
                    .OrderByDescending(f => f.FechaFiesta)
                    .Take(5)
                    .ToList();
                var ultimasCincoFechas = this.fiestas.Select(f => f.FechaFiesta).ToHashSet();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener las compras: {ex.Message}");
                this.comprasParaReporte = new List<CompraParaReporteClientesDTO>();
            }
        }
        public void Compose(IDocumentContainer container)
        {
            container
                .Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(50);
                    page.PageColor(Colors.White);

                    page.Header().Element(ComposeHeader);
                    page.Content().Element(ComposeContent);
                });
        }
        void ComposeHeader(IContainer container)
        {
            container.Row(row =>
            {
                row.ConstantColumn(400).Text("Reporte sobre los 10 mejores clientes").SemiBold().FontSize(24).FontColor(Colors.Blue.Medium);

            });
        }

        private void ComposeContent(IContainer container)
        {
            container.PaddingVertical(40).Column(column =>
            {
                column.Spacing(20);

                column.Item().PaddingVertical(15).Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.ConstantColumn(40);
                        columns.ConstantColumn(70);
                        columns.ConstantColumn(70);
                        columns.ConstantColumn(130);
                        columns.ConstantColumn(70);
                        columns.RelativeColumn();
                    });

                    table.Header(header =>
                    {
                        header.Cell().Background(Colors.Grey.Lighten3).Text("Id").SemiBold();
                        header.Cell().Background(Colors.Grey.Lighten3).Text("Nombre").SemiBold();
                        header.Cell().Background(Colors.Grey.Lighten3).Text("Apellido").SemiBold();
                        header.Cell().Background(Colors.Grey.Lighten3).Text("Email").SemiBold();
                        header.Cell().Background(Colors.Grey.Lighten3).Text("Entradas").SemiBold();
                        header.Cell().Background(Colors.Grey.Lighten3).Text("Evento").SemiBold();
                    });

                    int i = 0;
                    foreach (var compra in comprasParaReporte)
                    {
                        var cliente = this.usuarios.FirstOrDefault(u => u.Id == compra.Cliente);
                        var fiesta = this.fiestas.FirstOrDefault(f => f.IdFiesta == compra.Fiesta);
                        var evento = this.eventos.FirstOrDefault(e => e.Id == fiesta?.IdEvento);

                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten1)
                             .Text(cliente.Id.ToString());

                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten1)
                             .Text(cliente.Nombre.ToString());

                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten1)
                             .Text(cliente.Apellido.ToString());

                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten1)
                             .Text(cliente.Email.ToString());

                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten1)
                             .Text(compra.Entradas.ToString());

                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten1)
                             .Text(evento.Nombre.ToString());
                        i++;
                        if (i %4 == 0)
                        {
                            table.Cell().ColumnSpan(6).Height(20).Background(Colors.Grey.Lighten4).BorderBottom(0);
                        }
                    }
                });
                foreach (var fiesta in fiestas)
                {
                    var evento = this.eventos.FirstOrDefault(e => e.Id == fiesta.IdEvento);
                    var lugar = this.lugares.FirstOrDefault(l => l.Id == fiesta.IdLugar);
                    column.Item().Text($"Información general del evento: {evento.Nombre} \nLugar: {lugar.Nombre} - Direccion: {lugar.Direccion}\nFecha {fiesta.FechaFiesta}").FontSize(11).FontColor(Colors.Blue.Medium);
                }

                column.Item().Text($"Reporte generado el {DateTime.Now}").FontSize(9).FontColor(Colors.Grey.Darken1);
            });
        }
    }
    public class ReporteDataCli { }
}