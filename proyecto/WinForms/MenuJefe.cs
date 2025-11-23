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
    public partial class MenuJefe : Form
    {
        public UsuarioDTO usuarioIngresado { get; set; }
        public MenuJefe()
        {
            InitializeComponent();
        }
        private void AbrirFormularioEnPanel(Form formHijo)
        {
            // Limpia el panel antes de cargar otro form
            if (this.panelContenedorJefe.Controls.Count > 0)
                this.panelContenedorJefe.Controls.RemoveAt(0);

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            this.panelContenedorJefe.Controls.Add(formHijo);
            this.panelContenedorJefe.Tag = formHijo;

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
            RegistrarCompra registrarVentaForm = new RegistrarCompra();
            registrarVentaForm.usuarioIngresado = usuarioIngresado;
            AbrirFormularioEnPanel(registrarVentaForm);
        }


        private void gestionDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new ClientesLista());
        }

        private void ventasDeTusVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentasVendedores ventasVendedoresForm = new VentasVendedores();
            ventasVendedoresForm.usuarioIngresado = usuarioIngresado;
            AbrirFormularioEnPanel(ventasVendedoresForm);
        }

        private void MenuJefe_Load(object sender, EventArgs e)
        {

        }
    }
}

