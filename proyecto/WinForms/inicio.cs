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
    public enum FormMode
    {
        Add,
        Update
    }
    public partial class inicio : Form
    {
        public FormMode mode;
        public FormMode Mode
        {
            get
            {
                return mode;
            }
            set
            {
                SetFormMode(value);
            }
        }
        private void SetFormMode(FormMode value)
        {
            mode = value;
        }
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
        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (var ingresarUsuarioForm = new Login())
            {
                if (ingresarUsuarioForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show(
                        $"Bienvenido, {ingresarUsuarioForm.TipoUsuario}!",
                        "Inicio de Sesión Exitoso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    if (ingresarUsuarioForm.TipoUsuario == "Administrador")
                    {

                        var menuAdminForm = new MenuAdmin();
                        menuAdminForm.ShowDialog();
                    }
                    else if (ingresarUsuarioForm.TipoUsuario == "Vendedor")
                    {
                        var listaClientesForm = new MenuVendedor();
                        listaClientesForm.usuarioIngresado = ingresarUsuarioForm.usuarioIngresado;
                        listaClientesForm.ShowDialog();
                    }
                    //falta else if para cliente
                }
            }
        }
        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new RegistrarUsuario());
        }
    }
}