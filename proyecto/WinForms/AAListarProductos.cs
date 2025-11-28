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
    public partial class ListarProductos : Form
    {
        public ListarProductos()
        {
            InitializeComponent();
            this.Resize += prodLista_Resize;
        }


        private async void GetAllAndLoad()
        {
            try
            {
                this.productosDataGridView.DataSource = null;
                this.productosDataGridView.DataSource = await ProductoApiClient.GetAllAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListarProductos_Load(object sender, EventArgs e)
        {
            this.prodLista_Resize(sender, e);
            this.GetAllAndLoad();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void prodLista_Resize(object sender, EventArgs e)
        {


            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;


        }
    }
}
