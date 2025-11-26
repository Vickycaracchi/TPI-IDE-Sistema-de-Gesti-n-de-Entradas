using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using API.Clients;

namespace WinForms
{
    public partial class ListarEventos : Form
    {
        public ListarEventos()
        {
            InitializeComponent();
        }


        private async void GetAllAndLoad()
        {
            try
            {
                this.EventosDataGridView.DataSource = null;
                this.EventosDataGridView.DataSource = await EventoApiClient.GetAllAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de eventos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarEventos_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }
    }
}
