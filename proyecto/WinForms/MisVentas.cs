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
    public partial class MisVentas : Form
    {
        public UsuarioDTO usuarioIngresado { get; set; }
        public MisVentas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void MisVentas_Load(object sender, EventArgs e)
        {
            GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            this.misVentasDataGridView.DataSource = null;
            this.misVentasDataGridView.DataSource = await CompraApiClient.GetAllAsync(usuarioIngresado.Id);

            if (this.misVentasDataGridView.Rows.Count > 0)
            {
                this.misVentasDataGridView.Rows[0].Selected = true;
            }
        }
        
    }
}
