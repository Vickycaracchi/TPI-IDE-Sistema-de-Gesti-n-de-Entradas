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
    public partial class inicio : Form
    {
        public inicio()
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

        private void ingresarComoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var ingresarClienteForm = new IngresarCliente())
            {
                if (ingresarClienteForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show(
                        $"Bienvenido!",
                        "Inicio de Sesión Exitoso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    var inicioCliente = new menuCliente();
                    inicioCliente.ShowDialog();


                }
            }
        }

        private void ingresarComoVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            using (var ingresarVendedorForm = new IngresarVendedor())
            {
                if (ingresarVendedorForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show(
                        $"Bienvenido, {ingresarVendedorForm.TipoVendedor}!",
                        "Inicio de Sesión Exitoso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    if (ingresarVendedorForm.TipoVendedor == "Administrador")
                    {
                        
                        var menuAdminForm = new MenuAdmin();
                        menuAdminForm.ShowDialog();
                    }
                    else if (ingresarVendedorForm.TipoVendedor == "Vendedor")
                    {
                        var listaClientesForm = new ClientesLista();
                        listaClientesForm.ShowDialog();
                    }
                }
            }
        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new RegistrarCliente());
        }

        private void registrarAdministradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new RegistrarVendedor());
        }


        private void inicio_Load(object sender, EventArgs e)
        {

        }
    }
}