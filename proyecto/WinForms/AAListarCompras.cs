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
    public partial class ListarCompras : Form
    {
        public UsuarioDTO usuarioIngresado { get; set; }
        public ListarCompras()
        {
            InitializeComponent();
            this.Resize += comLista_Resize;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListarCompras_Load(object sender, EventArgs e)
        {
            this.comLista_Resize(sender, e);
            GetAllAndLoad();
        }

        private async void GetAllAndLoad()
        {
            try
            {

                var compras = await CompraApiClient.GetAllCliAsync(usuarioIngresado.Id);


                var usuarios = await UsuarioApiClient.GetAllAsync();
                var fiestas = (await FiestaApiClient.GetAllAsync()).ToList();
                var lugares = await LugarApiClient.GetAllAsync();
                var eventos = await EventoApiClient.GetAllAsync();


                ListarComprasDataGridView.AutoGenerateColumns = true;
                ListarComprasDataGridView.DataSource = compras;

                if (ListarComprasDataGridView.Rows.Count > 0)
                {
                    ListarComprasDataGridView.Rows[0].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las compras: {ex.Message}\n\nStackTrace:\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void comLista_Resize(object sender, EventArgs e)
        {


            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;


        }
    }
}
