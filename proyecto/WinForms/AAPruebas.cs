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
    public partial class Pruebas : Form
    {
        public Pruebas()
        {
            var categorias = new List<string> {
                "Música",
                "Deportes",
                "Conferencias",
                "Teatro"
            };
            InitializeComponent();
            cbCategoria.DataSource = categorias;
            cbCategoria.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string categoriaSeleccionada = cbCategoria.SelectedItem.ToString();

            MessageBox.Show($"Categoría seleccionada: {categoriaSeleccionada}");
        }
    }
}
