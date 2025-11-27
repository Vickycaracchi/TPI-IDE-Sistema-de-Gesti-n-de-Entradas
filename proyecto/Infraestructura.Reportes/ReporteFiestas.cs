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
    public class ReporteFiestas : IDocument
    {
        List<CompraParaReporteDTO> comprasParaReporte;
        List<UsuarioDTO> usuarios;
        List<EventoDTO> eventos;
        List<LugarDTO> lugares;
        List<FiestaDTO> fiestas;
        public ReporteDataFiestas Model { get; }

        public ReporteFiestas(ReporteDataFiestas model)
        {
            Model = model;
            
            try
            {
                this.comprasParaReporte = CompraApiClient.GetComprasParaReporteFiestasAsync()
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
                    .Take(3)
                    .ToList();
                var ultimasTresFechas = this.fiestas.Select(f => f.FechaFiesta).ToHashSet();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener las compras: {ex.Message}");
                this.comprasParaReporte = new List<CompraParaReporteDTO>();
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
                row.ConstantColumn(400).Text("Reporte sobre las ultimas 3 fiestas").SemiBold().FontSize(24).FontColor(Colors.Blue.Medium);

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
                        columns.ConstantColumn(70);
                        columns.ConstantColumn(130);
                        columns.RelativeColumn();
                    });

                    table.Header(header =>
                    {
                        header.Cell().Background(Colors.Grey.Lighten3).Text("Id").SemiBold();
                        header.Cell().Background(Colors.Grey.Lighten3).Text("Vendedor").SemiBold();
                        header.Cell().Background(Colors.Grey.Lighten3).Text("Cantidad").SemiBold();
                        header.Cell().Background(Colors.Grey.Lighten3).Text("Monto").SemiBold();
                        header.Cell().Background(Colors.Grey.Lighten3).Text("Evento").SemiBold();
                        header.Cell().Background(Colors.Grey.Lighten3).Text("Jefe").SemiBold();
                    });

                    foreach (var compra in comprasParaReporte)
                    {
                        var fiesta = this.fiestas.FirstOrDefault(f => f.FechaFiesta == compra.FechaFiesta);
                        var evento = this.eventos.FirstOrDefault(e => e.Id == fiesta?.IdEvento);
                        var vendedor = this.usuarios.FirstOrDefault(u => u.Id == compra.Vendedor);
                        var jefe = this.usuarios.FirstOrDefault(u => u.Id == vendedor?.IdJefe);
                        if (jefe == null)
                        {
                            jefe = new UsuarioDTO { Nombre = "Es jefe" };
                        }

                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten1)
                             .Text(vendedor.Id.ToString());

                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten1)
                             .Text(vendedor.Nombre.ToString());

                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten1)
                             .Text(compra.Entradas.ToString());

                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten1)
                             .Text(compra.Monto.ToString("0.00"));

                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten1)
                             .Text(evento.Nombre.ToString());

                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten1)
                             .Text(jefe.Nombre.ToString());
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
    public class ReporteDataFiestas { }
}