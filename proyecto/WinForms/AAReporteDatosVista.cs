using API.Clients;
using DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class ReporteDatosVista : Form
    {
        public ReporteDatosVista()
        {
            InitializeComponent();
        }
        private void ReporteVista_Load(object sender, EventArgs e)
        {
            GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            try
            {

                var compras = await CompraApiClient.GetComprasParaReporteAsync();


                MessageBox.Show($"Error al cargar las ventas: {compras}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                reporteDataGriedView.AutoGenerateColumns = true;
                reporteDataGriedView.DataSource = compras;

                if (reporteDataGriedView.Rows.Count > 0)
                {
                    reporteDataGriedView.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las ventas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
