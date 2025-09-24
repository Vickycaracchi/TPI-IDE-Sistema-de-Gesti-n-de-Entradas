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
        private VendedorDTO vendedor;
        private FormMode mode;
        public VendedorDTO Vendedor
        {
            get { return vendedor; }
            set
            {
                vendedor = value;
                this.SetVendedor();
            }
        }
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
        public RegistrarVendedor()
        {
            InitializeComponent();

            Mode = FormMode.Add;
            vendedor = new VendedorDTO();
            AgrgarItems();
        }

        private void AgrgarItems()
        {
            tipoListBox.Items.Add("Administrador");
            tipoListBox.Items.Add("Jefe");
            tipoListBox.Items.Add("Vendedor");
            tipoListBox.SelectedIndex = 0;
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
                    this.Vendedor.Email = emailTextBox.Text;
                    this.Vendedor.Dni = dniTextBox.Text;
                    this.Vendedor.Nombre = nombreTextBox.Text;
                    this.Vendedor.Apellido = apellidoTextBox.Text;
                    this.Vendedor.Contrasena = contrasenaTextBox.Text;
                    this.Vendedor.Cvu = cvuTextBox.Text;
                    this.Vendedor.Tipo = tipoListBox.SelectedItem.ToString();

                    if (this.Mode == FormMode.Update)
                    {
                        await VendedorApiClient.UpdateAsync(this.Vendedor);
                    }
                    else
                    {
                        await VendedorApiClient.AddAsync(this.Vendedor);
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void SetVendedor()
        {
            this.dniTextBox.Text = this.Vendedor.Dni;
            this.nombreTextBox.Text = this.Vendedor.Nombre;
            this.apellidoTextBox.Text = this.Vendedor.Apellido;
            this.emailTextBox.Text = this.Vendedor.Email;
            this.contrasenaTextBox.Text = this.Vendedor.Contrasena;
            this.cvuTextBox.Text = this.Vendedor.Cvu;
            this.tipoListBox.SelectedItem = this.Vendedor.Tipo;
        }
        private bool ValidateVendedor()
        {
            bool isValid = true;

            registrarVendedorErrorProvider.SetError(nombreTextBox, string.Empty);
            registrarVendedorErrorProvider.SetError(apellidoTextBox, string.Empty);
            registrarVendedorErrorProvider.SetError(emailTextBox, string.Empty);


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
