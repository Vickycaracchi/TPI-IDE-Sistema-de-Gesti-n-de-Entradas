using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using QuestPDF.Helpers;
using QuestPDF.Previewer;
using System;

namespace Infraestructura.Reportes
{
    public class Reporte : IDocument
    {
        public ReporteData Model { get; } // Puedes pasar datos aquí si es necesario

        public Reporte(ReporteData model)
        {
            Model = model;
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
        void ComposeContent(IContainer container)
        {
            container.PaddingVertical(40).Column(column =>
            {
                // Agrega un espaciado entre los elementos
                column.Spacing(20);

                // Sección de texto simple
                column.Item().Text(text =>
                {
                    text.Span("Fecha: ").SemiBold();
                    text.Span(DateTime.Now.ToShortDateString());
                });

                // Sección de tabla (ejemplo)
                column.Item().PaddingVertical(10).Table(table =>
                {
                    // Configuración de la tabla
                    table.ColumnsDefinition(columns =>
                    {
                        columns.ConstantColumn(50);
                        columns.ConstantColumn(150);
                        columns.RelativeColumn();
                    });

                    // Encabezados de la tabla
                    table.Header(header =>
                    {
                        header.Cell().Background(Colors.Grey.Lighten3).Text("ID").SemiBold();
                        header.Cell().Background(Colors.Grey.Lighten3).Text("Producto").SemiBold();
                        header.Cell().Background(Colors.Grey.Lighten3).Text("Descripción").SemiBold();
                    });

                    // Filas de datos (ejemplo de datos ficticios)
                    for (int i = 1; i <= 5; i++)
                    {
                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten1).Text(i.ToString());
                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten1).Text($"Producto {i}");
                        table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten1).Text(Placeholders.LoremIpsum());
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