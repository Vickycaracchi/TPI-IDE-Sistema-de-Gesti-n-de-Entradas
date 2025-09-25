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
    public partial class RegistrarVendedor : Form
    {
        public RegistrarVendedor()
        {
            InitializeComponent();

            Mode = FormMode.Add;
            AgregarItems();
        }

        private FormMode mode;
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

        private void AgregarItems()
        {
            var tiposVendedores = new List<string> {
                "Administrador",
                "Jefe",
                "Vendedor"
            };
            tipoComboBox.DataSource = tiposVendedores;
        }
        private void SetFormMode(FormMode value)
        {
            mode = value;
        }
        private async void enviarRegistroVendedor_Click(object sender, EventArgs e)
        {
            if (this.ValidateVendedor())
            {
                try
                {
                    VendedorDTO vendedor = new VendedorDTO();
                    vendedor.Email = emailTextBox.Text;
                    vendedor.Dni = dniTextBox.Text;
                    vendedor.Nombre = nombreTextBox.Text;
                    vendedor.Apellido = apellidoTextBox.Text;
                    vendedor.Contrasena = contrasenaTextBox.Text;
                    vendedor.Cvu = cvuTextBox.Text;
                    vendedor.Tipo = tipoComboBox.SelectedItem.ToString(); ;
                    if (this.Mode == FormMode.Update)
                    {
                        await VendedorApiClient.UpdateAsync(vendedor);
                    }
                    else
                    {
                        await VendedorApiClient.AddAsync(vendedor);
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private bool ValidateVendedor()
        {
            bool isValid = true;

            registrarVendedorErrorProvider.SetError(nombreTextBox, string.Empty);
            registrarVendedorErrorProvider.SetError(apellidoTextBox, string.Empty);
            registrarVendedorErrorProvider.SetError(emailTextBox, string.Empty);
            registrarVendedorErrorProvider.SetError(tipoComboBox, string.Empty);


            if (this.nombreTextBox.Text == string.Empty)
            {
                isValid = false;
                registrarVendedorErrorProvider.SetError(nombreTextBox, "El Nombre es Requerido");
            }

            if (this.apellidoTextBox.Text == string.Empty)
            {
                isValid = false;
                registrarVendedorErrorProvider.SetError(apellidoTextBox, "El Apellido es Requerido");
            }
            if (this.emailTextBox.Text == string.Empty)
            {
                isValid = false;
                registrarVendedorErrorProvider.SetError(emailTextBox, "El Email es Requerido");
            }
            else if (!EsEmailValido(this.emailTextBox.Text))
            {
                isValid = false;
                registrarVendedorErrorProvider.SetError(emailTextBox, "El formato del Email no es válido");
            }
            if(string.IsNullOrWhiteSpace(this.tipoComboBox.SelectedItem.ToString()))
            {
                isValid = false;
                registrarVendedorErrorProvider.SetError(tipoComboBox, "El Tipo es Requerido");
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