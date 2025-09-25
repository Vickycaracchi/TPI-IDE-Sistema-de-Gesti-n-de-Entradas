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
        public Menu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
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

            if (ingresarVendedorForm.ShowDialog() == DialogResult.OK) this.Close();

        }
    }
}
