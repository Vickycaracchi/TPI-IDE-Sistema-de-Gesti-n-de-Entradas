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

        private void btnClientes_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario ClientesLista
            ClientesLista clientesForm = new ClientesLista();
            // Muestra el formulario
            clientesForm.ShowDialog();
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario EventosLista
            EventosLista eventosForm = new EventosLista();
            // Muestra el formulario
            eventosForm.ShowDialog();
        }
    }
}
