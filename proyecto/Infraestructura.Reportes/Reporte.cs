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
        List<EventoDTO> eventos;
        List<LugarDTO> lugares;
        List<FiestaDTO> fiestas;
        public Dictionary<string, float> DatosGrafico { get; private set; }
        public ReporteData Model { get; }

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

                DatosGrafico = this.comprasParaReporte
                    .Where(c => ultimasTresFechas.Contains(c.FechaFiesta))
                    .GroupBy(c => c.FechaFiesta)
                    .Select(g => new
                    {
                        Fecha = g.Key,
                        TotalEntradas = g.Sum(c => c.Entradas) // O g.Sum(c => c.Monto) para el monto total
                    })
                    // Mapea la fecha a un nombre de evento y el total a un float
                    .ToDictionary(
                        x => this.eventos.FirstOrDefault(e => e.Id == this.fiestas.FirstOrDefault(f => f.FechaFiesta == x.Fecha)?.IdEvento)?.Nombre ?? x.Fecha.ToString("dd/MM"),
                        x => (float)x.TotalEntradas
                    );
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
                });
        }

        // --- Definición de las Secciones del Documento ---

        // Encabezado
        void ComposeHeader(IContainer container)
        {
            container.Row(row =>
            {
                // Columna izquierda para el título
                row.ConstantColumn(400).Text("Reporte sobre las ultimas 3 fiestas").SemiBold().FontSize(24).FontColor(Colors.Blue.Medium);

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


                // Sección de tabla (ejemplo)
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
    public class ReporteData { }
}