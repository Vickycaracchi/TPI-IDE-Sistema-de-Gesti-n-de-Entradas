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
    public partial class IngresarVendedor : Form
    {
        public IngresarVendedor()
        {
            InitializeComponent();
        }

        public string TipoVendedor { get; private set; }

        private async void enviarLoginVendedor_Click(object sender, EventArgs e)
        {
            if (this.ValidateVendedor())
            {
                try
                {
                    VendedorLoginDTO vendedorIng = new VendedorLoginDTO()
                    {
                        Email = this.emailTextBox.Text,
                        Nombre = this.nombreTextBox.Text,
                        Contrasena = this.contrasenaTextBox.Text
                    };

                    VendedorDTO? vendedor = await VendedorApiClient.LoginAsync(vendedorIng);
                    if (vendedor != null)
                    {
                        TipoVendedor = vendedor.Tipo;

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Credenciales inválidas. Intente nuevamente.", "Error de Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                        this.Hide();
                        
                        IngresarVendedor ingresarVendedorForm = new IngresarVendedor();

                        ingresarVendedorForm.ShowDialog();
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

            ingresarVendedorErrorProvider.SetError(emailTextBox, string.Empty);
            ingresarVendedorErrorProvider.SetError(nombreTextBox, string.Empty);
            ingresarVendedorErrorProvider.SetError(contrasenaTextBox, string.Empty);

            if (this.emailTextBox.Text == string.Empty)
            {
                isValid = false;
                ingresarVendedorErrorProvider.SetError(emailTextBox, "El Email es Requerido");
            }
            else if (!EsEmailValido(this.emailTextBox.Text))
            {
                isValid = false;
                ingresarVendedorErrorProvider.SetError(emailTextBox, "El formato del Email no es válido");
            }

            if (this.nombreTextBox.Text == string.Empty)
            {
                isValid = false;
                ingresarVendedorErrorProvider.SetError(nombreTextBox, "El Nombre es Requerido");
            }

            if (this.contrasenaTextBox.Text == string.Empty)
            {
                isValid = false;
                ingresarVendedorErrorProvider.SetError(contrasenaTextBox, "La contrasena es Requerida");
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
