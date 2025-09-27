using API.Clients;
using DTOs;
using System;
using System.Collections.Generic;
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

        public VendedorDTO Vendedor { get; set; }

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
            if (mode == FormMode.Update)
            {
                LoadVendedorData();
            }
        }

        private void LoadVendedorData()
        {
            if (this.Vendedor != null)
            {
                nombreTextBox.Text = Vendedor.Nombre;
                apellidoTextBox.Text = Vendedor.Apellido;
                emailTextBox.Text = Vendedor.Email;
                dniTextBox.Text = Vendedor.Dni;
                contrasenaTextBox.Text = Vendedor.Contrasena;
                cvuTextBox.Text = Vendedor.Cvu;

                if (!string.IsNullOrEmpty(Vendedor.Tipo) && tipoComboBox.Items.Contains(Vendedor.Tipo))
                {
                    tipoComboBox.SelectedItem = Vendedor.Tipo;
                }
            }
        }

        private async void enviarRegistroVendedor_Click(object sender, EventArgs e)
        {
            if (this.ValidateVendedor())
            {
                try
                {
                    // Si estamos en Update, mantenemos el mismo Id
                    if (Vendedor == null)
                        Vendedor = new VendedorDTO();

                    Vendedor.Email = emailTextBox.Text;
                    Vendedor.Dni = dniTextBox.Text;
                    Vendedor.Nombre = nombreTextBox.Text;
                    Vendedor.Apellido = apellidoTextBox.Text;
                    Vendedor.Contrasena = contrasenaTextBox.Text;
                    Vendedor.Cvu = cvuTextBox.Text;
                    Vendedor.Tipo = tipoComboBox.SelectedItem.ToString();

                    if (this.Mode == FormMode.Update)
                    {
                        await VendedorApiClient.UpdateAsync(Vendedor);
                    }
                    else
                    {
                        await VendedorApiClient.AddAsync(Vendedor);
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

            if (string.IsNullOrWhiteSpace(this.tipoComboBox.SelectedItem?.ToString()))
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