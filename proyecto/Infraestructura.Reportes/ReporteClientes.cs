using API.Clients;
using Application.Services;
using DTOs;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using System;
using System.Linq; // Necesario para FirstOrDefault()

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
                // Es mejor usar Task.Run().Wait() o ConfigureAwait(false).GetAwaiter().GetResult()
                // para evitar deadlocks, pero manteniendo la estructura original con GetAwaiter().GetResult():
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
                // var ultimasCincoFechas = this.fiestas.Select(f => f.FechaFiesta).ToHashSet(); // Esta línea no se utiliza, se puede eliminar o comentar.
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener los datos: {ex.Message}");
                this.comprasParaReporte = new List<CompraParaReporteClientesDTO>();
                this.usuarios = new List<UsuarioDTO>();
                this.eventos = new List<EventoDTO>();
                this.lugares = new List<LugarDTO>();
                this.fiestas = new List<FiestaDTO>();
            }
        }

        // --- Implementación de IDocument ---
        public DocumentMetadata GetMetadata() => DocumentMetadata.Default; // Se puede agregar metadatos

        public void Compose(IDocumentContainer container)
        {
            container
                .Page(page =>
                {
                    // Mejora en el diseño de la página
                    page.Size(PageSizes.A4);
                    page.Margin(30); // Márgenes un poco más pequeños para aprovechar el espacio
                    page.PageColor(Colors.White);

                    // Componentes del documento
                    page.Header().Element(ComposeHeader);
                    page.Content().Element(ComposeContent);
                    page.Footer().Element(ComposeFooter); // Añadimos un pie de página
                });
        }

        // --- Encabezado del Reporte (Header) ---
        void ComposeHeader(IContainer container)
        {
            container.BorderBottom(2).BorderColor(Colors.Blue.Medium).PaddingBottom(10).Row(row =>
            {
                // Título más grande y centrado visualmente
                row.ConstantColumn(450).Text("🏆 Reporte de Clientes VIP (Top 10)")
                    .SemiBold().FontSize(28)
                    .FontColor(Colors.Blue.Darken2);

                // Columna para información extra o logo
                row.RelativeColumn().Text(DateTime.Now.ToString("dd/MM/yyyy"))
                    .SemiBold().FontSize(12)
                    .FontColor(Colors.Grey.Darken2)
                    .AlignRight();
            });
        }

        // --- Contenido Principal del Reporte (Content) ---
        private void ComposeContent(IContainer container)
        {
            container
                .PaddingVertical(20)
                .DefaultTextStyle(TextStyle.Default.FontSize(10))
                .Column(column =>
                {
                    column.Spacing(25);

                    column.Item().Text("Detalle de Compras de Clientes Destacados")
                        .FontSize(18).SemiBold()
                        .FontColor(Colors.Grey.Darken3).Underline();

                    column.Item().Table(table =>
                    {
                        // Column layout tuned for readability
                        table.ColumnsDefinition(columns =>
                        {
                            columns.ConstantColumn(36); // No.
                            columns.RelativeColumn(2);  // Nombre/Apellido
                            columns.RelativeColumn(3);  // Email
                            columns.ConstantColumn(80); // Entradas
                            columns.RelativeColumn(3);  // Evento
                        });

                        // Header styling
                        table.Header(header =>
                        {
                            header.Cell().Element(HeaderCellStyle).Text("#").SemiBold();
                            header.Cell().Element(HeaderCellStyle).Text("Cliente").SemiBold();
                            header.Cell().Element(HeaderCellStyle).Text("Email").SemiBold();
                            header.Cell().Element(HeaderCellStyle).Text("Entradas").SemiBold().AlignRight();
                            header.Cell().Element(HeaderCellStyle).Text("Evento/Fiesta").SemiBold();

                            IContainer HeaderCellStyle(IContainer cell) =>
                                cell
                                    .Background(Colors.Blue.Lighten4)
                                    .PaddingVertical(6)
                                    .PaddingHorizontal(6)
                                    .BorderBottom(2)
                                    .BorderColor(Colors.Blue.Medium)
                                    .AlignLeft();
                        });

                        // Data rows with zebra striping and subtle gridlines
                        int i = 1;
                        foreach (var compra in comprasParaReporte)
                        {
                            var cliente = this.usuarios.FirstOrDefault(u => u.Id == compra.Cliente);
                            var fiesta = this.fiestas.FirstOrDefault(f => f.IdFiesta == compra.Fiesta);
                            var evento = this.eventos.FirstOrDefault(e => e.Id == fiesta?.IdEvento);

                            var rowBg = (i % 2 == 0) ? Colors.Grey.Lighten5 : Colors.White;

                            table.Cell().Element(c => DataCellStyle(c, rowBg)).Text(i.ToString());
                            table.Cell().Element(c => DataCellStyle(c, rowBg)).Text($"{cliente?.Nombre} {cliente?.Apellido}".Trim());
                            table.Cell().Element(c => DataCellStyle(c, rowBg)).Text(cliente?.Email ?? "N/A");
                            table.Cell().Element(c => DataCellStyle(c, rowBg)).AlignRight().Text(compra.Entradas.ToString("N0"));
                            table.Cell().Element(c => DataCellStyle(c, rowBg)).Text(evento?.Nombre ?? "N/A");

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

                    // 3. Información adicional de eventos (sin cambios)
                    column.Item().PaddingTop(20).Column(subColumn =>
                    {
                        subColumn.Spacing(10);
                        subColumn.Item().Text("Información de las últimas 5 Fiestas analizadas:")
                            .FontSize(14).SemiBold()
                            .FontColor(Colors.Grey.Darken3);

                        foreach (var fiesta in fiestas)
                        {
                            var evento = this.eventos.FirstOrDefault(e => e.Id == fiesta.IdEvento);
                            var lugar = this.lugares.FirstOrDefault(l => l.Id == fiesta.IdLugar);

                            subColumn.Item().Text(text =>
                            {
                                text.Span("• ").FontSize(11).FontColor(Colors.Blue.Medium).SemiBold();
                                text.Span($"Evento: ").FontSize(11).SemiBold();
                                text.Span($"{evento?.Nombre ?? "N/A"}").FontSize(11).FontColor(Colors.Blue.Darken1);
                                text.Span($" | Lugar: ").FontSize(11).SemiBold();
                                text.Span($"{lugar?.Nombre ?? "N/A"} - {lugar?.Direccion ?? "N/A"}").FontSize(11);
                                text.Span($" | Fecha: ").FontSize(11).SemiBold();
                                text.Span($"{fiesta.FechaFiesta.ToShortDateString()}").FontSize(11);
                            });
                        }
                    });
                });
        }

        // --- Pie de página (Footer) ---
        private void ComposeFooter(IContainer container)
        {
            container.BorderTop(1).BorderColor(Colors.Grey.Lighten1).PaddingTop(5).Row(row =>
            {
                row.ConstantColumn(300).Text($"Reporte generado el {DateTime.Now:dd/MM/yyyy} a las {DateTime.Now:HH:mm:ss}").FontSize(8).FontColor(Colors.Grey.Darken1);
                // Fix: Use .Text() to display the page number, since IContainer does not have a PageNumber() method.
                row.RelativeItem().AlignRight().Text(text =>
                {
                    text.Span("Página ").FontSize(8).FontColor(Colors.Grey.Darken1);
                    text.CurrentPageNumber().FontSize(8).FontColor(Colors.Grey.Darken1);
                });
            });
        }
    }

    // Mantienes tu clase de modelo de datos
    public class ReporteDataCli { }
}