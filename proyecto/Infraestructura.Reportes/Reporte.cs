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
    public class Reporte : IDocument
    {
        List<CompraParaReporteDTO> comprasParaReporte;
        List<UsuarioDTO> usuarios;
        public ReporteData Model { get; } // Puedes pasar datos aquí si es necesario

        public Reporte(ReporteData model)
        {
            Model = model;
         
            try
            {
                // Este patrón bloquea la ejecución hasta que la operación asíncrona termine.
                // Es necesario porque QuestPDF es síncrono.
                this.comprasParaReporte = CompraApiClient.GetComprasParaReporteAsync()
                    .GetAwaiter()
                    .GetResult()
                    .ToList();
                this.usuarios = UsuarioApiClient.GetAllAsync()
                    .GetAwaiter()
                    .GetResult()
                    .ToList();
            }
            catch (Exception ex)
            {
                // Manejo de errores de obtención de datos
                Console.WriteLine($"Error al obtener las compras: {ex.Message}");
                this.comprasParaReporte = new List<CompraParaReporteDTO>(); // Asegura que la lista no sea null
            }
        }

        // Define la configuración global de la página (tamaño, márgenes, etc.)
        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
        public DocumentSettings GetSettings() => DocumentSettings.Default;


        /// Define cómo se ve cada página del documento
        public void Compose(IDocumentContainer container)
        {
            container
                .Page(page =>
                {
                    // Configuración de la página (tamaño A4, márgenes de 50 puntos)
                    page.Size(PageSizes.A4);
                    page.Margin(50);
                    page.PageColor(Colors.White);

                    // Define la estructura de cada página (encabezado, contenido, pie de página)
                    page.Header().Element(ComposeHeader);
                    page.Content().Element(ComposeContent);
                    page.Footer().Element(ComposeFooter);
                });
        }

        // --- Definición de las Secciones del Documento ---

        // Encabezado
        void ComposeHeader(IContainer container)
        {
            container.Row(row =>
            {
                // Columna izquierda para el título
                row.ConstantColumn(400).Text("Reporte de Proyecto .NET").SemiBold().FontSize(24).FontColor(Colors.Blue.Medium);

                // Columna derecha para una imagen o logo (opcional)
                row.RelativeColumn().Image(Placeholders.Image(100, 50));
            });
        }

        // Contenido Principal
        private void ComposeContent(IContainer container)
        {
            container.PaddingVertical(40).Column(column =>
            {
                // Agrega un espaciado entre los elementos
                column.Spacing(20);

                // Sección de texto simple
                column.Item().Text(text =>
                {
                    text.Span("Evento: ").SemiBold();
                    text.Span("EVENTO.NOMBRE + EVENTO.DESCRIPCION");
                    text.Span("Fiesta: ").SemiBold();
                    text.Span(DateTime.Now.ToShortDateString() + "LUGAR.NOMBRE + FIESTA.FECHAHORA");
                    text.Span("Lotes: ").SemiBold();
                    text.Span("LOTE{i}.NOMBRE + LOTE{i}.PRECIO");
                    text.Span("Tabla de resumen de ventas").SemiBold();
                });

                // Sección de tabla (ejemplo)
                column.Item().PaddingVertical(15).Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.ConstantColumn(70);
                        columns.ConstantColumn(70);
                        columns.ConstantColumn(70);
                        columns.RelativeColumn();
                    });

                    table.Header(header =>
                    {
                        header.Cell().Background(Colors.Grey.Lighten3).Text("Id").SemiBold();
                        header.Cell().Background(Colors.Grey.Lighten3).Text("Vendedor").SemiBold();
                        header.Cell().Background(Colors.Grey.Lighten3).Text("Cantidad").SemiBold();
                        header.Cell().Background(Colors.Grey.Lighten3).Text("Jefe").SemiBold();
                        header.Cell().Background(Colors.Grey.Lighten3).Text("Monto").SemiBold();
                    });

                    foreach (var compra in comprasParaReporte)
                    {
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
                             .Text(jefe.Nombre.ToString());

                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten1)
                             .Text(compra.Monto.ToString("0.00"));
                    }
                });

                // Más texto o elementos
                column.Item().Text(Placeholders.Paragraph());
            });
        }

        // Pie de página
        void ComposeFooter(IContainer container)
        {
            container.Row(row =>
            {
                // Columna izquierda para información de contacto
                row.ConstantColumn(300).Text("Contacto: tu.email@ejemplo.com").FontSize(9);

                // Columna derecha para la numeración de página
                row.RelativeColumn().AlignRight().Text(x =>
                {
                    x.CurrentPageNumber().FontSize(9);
                    x.Span(" / ").FontSize(9);
                    x.TotalPages().FontSize(9);
                });
            });
        }
    }

    // Clase de modelo de datos simple (si la necesitas)
    public class ReporteData { }
}