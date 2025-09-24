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
        }
        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresarCliente ingresarCliForm = new IngresarCliente();

            ingresarCliForm.MdiParent = this;

            ingresarCliForm.Show();
        }
        private void registrarseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarCliente registrarClienteForm = new RegistrarCliente();

            registrarClienteForm.MdiParent = this;

            registrarClienteForm.Show();
        }

        private void registarVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarVendedor registrarVendedorForm = new RegistrarVendedor();

            registrarVendedorForm.MdiParent = this;

            registrarVendedorForm.Show();
        }

    }
}
