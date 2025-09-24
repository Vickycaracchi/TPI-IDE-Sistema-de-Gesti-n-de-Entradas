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
    public partial class IngresarCliente : Form
    {
        public IngresarCliente()
        {
            InitializeComponent();
        }

        private async void ingresarButton_Click(object sender, EventArgs e)
        {
            if(this.ValidateCliente())
            {
                try
                {
                    CliLoginDTO clienteIng = new CliLoginDTO()
                    {
                        Email = this.emailTextBox.Text,
                        Nombre = this.nombreTextBox.Text,
                        Contrasena = this.contrasenaTextBox.Text
                    };

                    ClienteDTO? cliente = await ClienteApiClient.LoginAsync(clienteIng);
                    if(cliente != null)
                    {
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Credenciales inválidas. Intente nuevamente.", "Error de Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al intentar iniciar sesión: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateCliente()
        {
            bool isValid = true;

            loginErrorProvider.SetError(emailTextBox, string.Empty);
            loginErrorProvider.SetError(nombreTextBox, string.Empty);
            loginErrorProvider.SetError(contrasenaTextBox, string.Empty);

            if (this.emailTextBox.Text == string.Empty)
            {
                isValid = false;
                loginErrorProvider.SetError(emailTextBox, "El Email es Requerido");
            }
            else if (!EsEmailValido(this.emailTextBox.Text))
            {
                isValid = false;
                loginErrorProvider.SetError(emailTextBox, "El formato del Email no es válido");
            }

            if (this.nombreTextBox.Text == string.Empty)
            {
                isValid = false;
                loginErrorProvider.SetError(nombreTextBox, "El Nombre es Requerido");
            }

            if (this.contrasenaTextBox.Text == string.Empty)
            {
                isValid = false;
                loginErrorProvider.SetError(contrasenaTextBox, "La contrasena es Requerida");
            }

            return isValid;
        }

        private static bool EsEmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
    }
}
