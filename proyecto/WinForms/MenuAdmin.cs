using Infraestructura.Reportes;
using QuestPDF.Fluent;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WinForms
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void AbrirFormularioEnPanel(Form formHijo)
        {
            // Limpia el panel antes de cargar otro form
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            this.panelContenedor.Controls.Add(formHijo);
            this.panelContenedor.Tag = formHijo;

            formHijo.Show();
        }

        private void listarVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new VendedoresLista());
        }

        private void listarEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new EventosLista());
        }

        private void gestiónProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new ProductosLista());
        }

        private void gestiónLugaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new LugaresLista());
        }

        private void gestiónLotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new LotesLista());
        }


        private void gestiónFiestasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FiestasLista());
        }

        private void asignarVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new AsignarVendedores());
        }

        private async void generarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generarReporteToolStripMenuItem.Enabled = false;

            string rutaCompleta = null;

            try
            {
                rutaCompleta = await Task.Run(() =>
                {
                    var datos = new ReporteDataCli();
                    var documento = new ReporteClientes(datos);

                    string rutaEjecucion = AppDomain.CurrentDomain.BaseDirectory;
                    string rutaSolucion = Path.GetFullPath(Path.Combine(rutaEjecucion, @"..\..\..\.."));

                    string carpetaReportes = Path.Combine(rutaSolucion, "Reportes");
                    Directory.CreateDirectory(carpetaReportes);

                    var nombreArchivo = $"Reporte_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
                    var ruta = Path.Combine(carpetaReportes, nombreArchivo);// 3. Generar el PDF

                    documento.GeneratePdf(ruta);

                    return ruta;
                });

                // 4. Mostrar Mensaje de Éxito y Abrir el Archivo
                DialogResult resultado = MessageBox.Show(
                    $"El reporte se generó exitosamente en:\n{rutaCompleta}\n\n¿Desea abrir el archivo ahora?",
                    "Reporte Generado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (resultado == DialogResult.Yes)
                {
                    // Intenta abrir el PDF con el programa predeterminado del sistema
                    // Usamos Process.Start para lanzar la aplicación.
                    Process.Start(new ProcessStartInfo(rutaCompleta) { UseShellExecute = true });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al generar el reporte: {ex.Message}",
                                "Error de Generación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            finally
            {
                generarReporteToolStripMenuItem.Enabled = true;
            }
        }

        private void verDatosReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new ReporteDatosVista());
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}