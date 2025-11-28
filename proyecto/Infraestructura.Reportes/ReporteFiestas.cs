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
        List<CompraParaReporteFiestasDTO> comprasParaReporte;
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
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener las compras: {ex.Message}");
                this.comprasParaReporte = new List<CompraParaReporteFiestasDTO>();
                this.usuarios = new List<UsuarioDTO>();
                this.eventos = new List<EventoDTO>();
                this.lugares = new List<LugarDTO>();
                this.fiestas = new List<FiestaDTO>();
            }
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

        public void Compose(IDocumentContainer container)
        {
            container
                .Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(30);
                    page.PageColor(Colors.White);

                    page.Header().Element(ComposeHeader);
                    page.Content().Element(ComposeContent);
                    page.Footer().Element(ComposeFooter);
                });
        }

        void ComposeHeader(IContainer container)
        {
            container
                .BorderBottom(2).BorderColor(Colors.Blue.Medium)
                .PaddingBottom(10)
                .Row(row =>
                {
                    row.ConstantColumn(450).Text("Reporte de ventas de las últimas 3 fiestas")
                        .SemiBold().FontSize(28)
                        .FontColor(Colors.Blue.Darken2);

                    row.RelativeColumn().Text(DateTime.Now.ToString("dd/MM/yyyy"))
                        .SemiBold().FontSize(12)
                        .FontColor(Colors.Grey.Darken2)
                        .AlignRight();
                });
        }

        private void ComposeContent(IContainer container)
        {
            container
                .PaddingVertical(20)
                .DefaultTextStyle(TextStyle.Default.FontSize(10))
                .Column(column =>
                {
                    column.Spacing(25);

                    column.Item().Text("Detalle de ventas por vendedor")
                        .FontSize(18).SemiBold()
                        .FontColor(Colors.Grey.Darken3).Underline();

                    column.Item().Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(40);
                            columns.RelativeColumn(2);
                            columns.ConstantColumn(80);
                            columns.ConstantColumn(100);
                            columns.RelativeColumn(2);
                            columns.RelativeColumn(2);
                        });

                        table.Header(header =>
                        {
                            header.Cell().Element(HeaderCellStyle).Text("Id").SemiBold();
                            header.Cell().Element(HeaderCellStyle).Text("Vendedor").SemiBold();
                            header.Cell().Element(HeaderCellStyle).Text("Cantidad").SemiBold().AlignRight();
                            header.Cell().Element(HeaderCellStyle).Text("Monto").SemiBold().AlignRight();
                            header.Cell().Element(HeaderCellStyle).Text("Evento").SemiBold();
                            header.Cell().Element(HeaderCellStyle).Text("Jefe").SemiBold();

                            IContainer HeaderCellStyle(IContainer cell) =>
                                cell
                                    .Background(Colors.Blue.Lighten4)
                                    .PaddingVertical(6)
                                    .PaddingHorizontal(6)
                                    .BorderBottom(2)
                                    .BorderColor(Colors.Blue.Medium)
                                    .AlignLeft();
                        });

                        int i = 1;
                        foreach (var compra in comprasParaReporte)
                        {
                            var fiesta = this.fiestas.FirstOrDefault(f => f.FechaFiesta == compra.FechaFiesta);
                            var evento = this.eventos.FirstOrDefault(e => e.Id == fiesta?.IdEvento);
                            var vendedor = this.usuarios.FirstOrDefault(u => u.Id == compra.Vendedor);
                            var jefe = this.usuarios.FirstOrDefault(u => u.Id == vendedor?.IdJefe) ?? new UsuarioDTO { Nombre = "Es jefe" };

                            var rowBg = (i % 2 == 0) ? Colors.Grey.Lighten5 : Colors.White;

                            table.Cell().Element(c => DataCellStyle(c, rowBg)).Text(vendedor?.Id.ToString() ?? "N/A");
                            table.Cell().Element(c => DataCellStyle(c, rowBg)).Text($"{vendedor?.Nombre} {vendedor?.Apellido}".Trim());
                            table.Cell().Element(c => DataCellStyle(c, rowBg)).AlignRight().Text(compra.Entradas.ToString("N0"));
                            table.Cell().Element(c => DataCellStyle(c, rowBg)).AlignRight().Text(compra.Monto.ToString("N2"));
                            table.Cell().Element(c => DataCellStyle(c, rowBg)).Text(evento?.Nombre ?? "N/A");
                            table.Cell().Element(c => DataCellStyle(c, rowBg)).Text(jefe?.Nombre ?? "N/A");

                            i++;
                        }

                        IContainer DataCellStyle(IContainer cell, Color background) =>
                            cell
                                .Background(background)
                                .PaddingVertical(6)
                                .PaddingHorizontal(6)
                                .BorderBottom(0.5f)
                                .BorderColor(Colors.Grey.Lighten2)
                                .AlignLeft();
                    });

                    column.Item().PaddingTop(20).Column(subColumn =>
                    {
                        subColumn.Spacing(10);
                        subColumn.Item().Text("Información de las últimas 3 Fiestas analizadas:")
                            .FontSize(14).SemiBold()
                            .FontColor(Colors.Grey.Darken3);

                        foreach (var fiesta in fiestas)
                        {
                            var evento = this.eventos.FirstOrDefault(e => e.Id == fiesta.IdEvento);
                            var lugar = this.lugares.FirstOrDefault(l => l.Id == fiesta.IdLugar);

                            subColumn.Item().Text(text =>
                            {
                                text.Span("• ").FontSize(11).FontColor(Colors.Blue.Medium).SemiBold();
                                text.Span("Evento: ").FontSize(11).SemiBold();
                                text.Span($"{evento?.Nombre ?? "N/A"}").FontSize(11).FontColor(Colors.Blue.Darken1);
                                text.Span(" | Lugar: ").FontSize(11).SemiBold();
                                text.Span($"{lugar?.Nombre ?? "N/A"} - {lugar?.Direccion ?? "N/A"}").FontSize(11);
                                text.Span(" | Fecha: ").FontSize(11).SemiBold();
                                text.Span($"{fiesta.FechaFiesta.ToShortDateString()}").FontSize(11);
                            });
                        }
                    });
                });
        }

        private void ComposeFooter(IContainer container)
        {
            container
                .BorderTop(1).BorderColor(Colors.Grey.Lighten1)
                .PaddingTop(5)
                .Row(row =>
                {
                    row.ConstantColumn(300).Text($"Reporte generado el {DateTime.Now:dd/MM/yyyy} a las {DateTime.Now:HH:mm:ss}")
                        .FontSize(8).FontColor(Colors.Grey.Darken1);
                    row.RelativeItem().AlignRight().Text(text =>
                    {
                        text.Span("Página ").FontSize(8).FontColor(Colors.Grey.Darken1);
                        text.CurrentPageNumber().FontSize(8).FontColor(Colors.Grey.Darken1);
                    });
                });
        }
    }

    public class ReporteDataFiestas { }
}