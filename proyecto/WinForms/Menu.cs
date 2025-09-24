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
    public partial class Menu : Form
    {
        public Menu(VendedorDTO vendedor)
        {
            InitializeComponent();
            ingresarVendedor.Visible = false;
            registarVendedor.Visible = true;
            nombreVendedor.Visible = false;
            nombreVendedor.Text = vendedor.Nombre;
            nombreVendedor.Visible = true;
            tipoVendedor.Visible = true;
            tipoVendedor.Text = vendedor.Tipo;
            //MessageBox.Show($"Bienvenido {vendedor.Nombre} ({vendedor.Tipo})", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public Menu()
        {
            InitializeComponent(); 
        }
        
        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresarCliente ingresarCliForm = new IngresarCliente();

            ingresarCliForm.ShowDialog();
        }
        private void registrarseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarCliente registrarClienteForm = new RegistrarCliente();

            registrarClienteForm.ShowDialog();
        }

        private void registarVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarVendedor registrarVendedorForm = new RegistrarVendedor();

            registrarVendedorForm.ShowDialog();
        }

        private void ingresarVendedor_Click(object sender, EventArgs e)
        {
            IngresarVendedor ingresarVendedorForm = new IngresarVendedor();

            ingresarVendedorForm.ShowDialog();
            
        }
        }
}
