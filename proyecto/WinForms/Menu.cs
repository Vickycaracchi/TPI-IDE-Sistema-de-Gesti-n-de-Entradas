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
        private void clienteABMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesLista clientesForm = new ClientesLista();

            clientesForm.MdiParent = this;

            clientesForm.Show();
        }

        private void eventosABMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventosLista eventosForm = new EventosLista();

            eventosForm.MdiParent = this;

            eventosForm.Show();
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresarCliente ingresarCliForm = new IngresarCliente();

            ingresarCliForm.MdiParent = this;

            ingresarCliForm.Show();
        }
    }
}
