using API.Clients;
using Domain.Model;
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
    public partial class VerMisVendedores : Form
    {
        public VerMisVendedores()
        {
            InitializeComponent();
            this.Resize += MisVendedores_Resize;
        }
        private void MisVendedores_Load(object sender, EventArgs e)
        {
            this.MisVendedores_Resize(sender, e);
            GetAllAndLoad();
        }
        public UsuarioDTO usuarioIngresado { get; set; }
        private async void GetAllAndLoad()
        {
            try
            {
                var vendedores = await UsuarioApiClient.GetAllAsync();
                var misVendedores = vendedores.Where(v => v.IdJefe == usuarioIngresado.Id).ToList();

                foreach (var v in misVendedores)
                {
                    v.Contrasena = "***";
                }
                misVendedoresDataGridView.AutoGenerateColumns = true;
                misVendedoresDataGridView.DataSource = misVendedores;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los vendedores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MisVendedores_Resize(object sender, EventArgs e)
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }
    }
}
