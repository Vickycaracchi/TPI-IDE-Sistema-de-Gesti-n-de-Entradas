using System;
using System.Windows.Forms;

namespace WinForms
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void AbrirFormularioEnPanel(Form formHijo)
        {
            // Limpia el panel antes de cargar otro form
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            this.panelContenedor.Controls.Add(formHijo);
            this.panelContenedor.Tag = formHijo;

            formHijo.Show();
        }

        private void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new ClientesLista());
        }

        private void listarVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new VendedoresLista());
        }

        private void listarEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new EventosLista());
        }

        private void gestiónProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new ProductosLista());
        }

        private void gestiónLugaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new LugaresLista());
        }

        private void gestiónLotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new LotesLista());
        }

  
        private void gestiónFiestasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new FiestasLista());
        }
    }
}