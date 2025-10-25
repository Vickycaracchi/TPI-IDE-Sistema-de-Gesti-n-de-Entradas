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
    public partial class MenuVendedor : Form
    {
        public UsuarioDTO usuarioIngresado {  get; set; }
        public MenuVendedor()
        {
            InitializeComponent();
        }
        private void AbrirFormularioEnPanel(Form formHijo)
        {
            // Limpia el panel antes de cargar otro form
            if (this.panelContenedorVendedor.Controls.Count > 0)
                this.panelContenedorVendedor.Controls.RemoveAt(0);

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            this.panelContenedorVendedor.Controls.Add(formHijo);
            this.panelContenedorVendedor.Tag = formHijo;

            formHijo.Show();
        }
        private void verMisVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MisVentas misVentasForm = new MisVentas();
            misVentasForm.usuarioIngresado = usuarioIngresado;
            AbrirFormularioEnPanel(misVentasForm);
        }

        private void resgistrarNuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AbrirFormularioEnPanel(new RegistrarVenta());
        }


        private void gestionDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new ClientesLista());
        }
    }
}
