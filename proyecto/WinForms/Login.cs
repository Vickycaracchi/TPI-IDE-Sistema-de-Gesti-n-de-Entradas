using API.Clients;
using DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public string TipoUsuario { get; private set; }
        public UsuarioDTO usuarioIngresado { get; private set; }

        private async void enviarLoginVendedor_Click(object sender, EventArgs e)
        {
            if (this.ValidateVendedor())
            {
                try
                {
                    LoginDTO login = new LoginDTO()
                    {
                        Dni = this.DniTextBox.Text,
                        Contrasena = this.contrasenaTextBox.Text
                    };

                    UsuarioDTO? usuario = await UsuarioApiClient.LoginAsync(login);
                    if (usuario != null)
                    {
                        TipoUsuario = usuario.Tipo;
                        usuarioIngresado = usuario;

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Credenciales inválidas. Intente nuevamente.", "Error de Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        this.Hide();

                        Login ingresarUsuarioForm = new Login();

                        ingresarUsuarioForm.ShowDialog();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al intentar iniciar sesión: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateVendedor()
        {
            bool isValid = true;

            ingresarVendedorErrorProvider.SetError(DniTextBox, string.Empty);
            ingresarVendedorErrorProvider.SetError(contrasenaTextBox, string.Empty);

            if (this.DniTextBox.Text == string.Empty)
            {
                isValid = false;
                ingresarVendedorErrorProvider.SetError(DniTextBox, "El DNI es Requerido");
            }

            if (this.contrasenaTextBox.Text == string.Empty)
            {
                isValid = false;
                ingresarVendedorErrorProvider.SetError(contrasenaTextBox, "La contrasena es Requerida");
            }

            return isValid;
        }
    }
}