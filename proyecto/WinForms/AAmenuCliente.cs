using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTOs;

namespace WinForms
{

    public partial class menuCliente : Form
    {
        public menuCliente()
        {
            InitializeComponent();
        }
        public UsuarioDTO usuarioIngresado { get; set; }
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

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new ListarProductos());
        }
        private void verEventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new ListarEventos());
        }
        private void verFiestas_Click(object sender, EventArgs e)
        {

            AbrirFormularioEnPanel(new ListarFiestas());
        }
        private void MenuCliente_Load(object sender, EventArgs e)
        {

        }

        private void menuCliente_Load_1(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void verMisComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarCompras listarComprasForm = new ListarCompras();
            listarComprasForm.usuarioIngresado = usuarioIngresado;
            AbrirFormularioEnPanel(listarComprasForm);
        }

        private void comrparProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComprarProducto comprarProductoForm = new ComprarProducto();
            comprarProductoForm.usuarioIngresado = usuarioIngresado;
            AbrirFormularioEnPanel(comprarProductoForm);
        }
    }
}
