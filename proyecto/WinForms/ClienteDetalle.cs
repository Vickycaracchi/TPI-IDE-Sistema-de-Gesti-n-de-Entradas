using DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinForms
{
    public enum FormMode
    {
        Add,
        Update
    }
    public partial class ClienteDetalle : Form
    {
        private ClienteDTO cliente;
        private FormMode mode;
        public ClienteDTO Cliente
        {
            get { return cliente; }
            set
            {
                cliente = value;
                this.SetCliente();
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
        public ClienteDetalle()
        {
            InitializeComponent();

            Mode = FormMode.Add;
        }

        private void SetFormMode(FormMode value)
        {
            mode = value;
        }
        private async void enviarFormularioCliente(object sender, EventArgs e)
        {
            if (this.ValidateCliente())
            {
                try
                {
                    this.Cliente.Email = emailTextBox.Text;
                    this.Cliente.Nombre = nombreTextBox.Text;
                    this.Cliente.Apellido = apellidoTextBox.Text;
                    this.Cliente.NumeroTelefono = numeroTelefonoTextBox.Text;
                    this.Cliente.FechaNac = DateTime.Parse(fechaNacTextBox.Text);
                    this.Cliente.Instagram = instagramTextBox.Text;

                    if (this.Mode == FormMode.Update)
                    {
                        await ClienteApiClient.UpdateAsync(this.Cliente);
                    }
                    else
                    {
                        await ClienteApiClient.AddAsync(this.Cliente);
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void SetCliente()
        {
            this.idTextBox.Text = this.Cliente.Id.ToString();
            this.emailTextBox.Text = this.Cliente.Email;
            this.nombreTextBox.Text = this.Cliente.Nombre;
            this.apellidoTextBox.Text = this.Cliente.Apellido;
            this.numeroTelefonoTextBox.Text = this.Cliente.NumeroTelefono;
            this.fechaNacTextBox.Text = this.Cliente.FechaNac.ToString();
            this.instagramTextBox.Text = this.Cliente.Instagram;
        }
        private bool ValidateCliente()
        {
            bool isValid = true;

            errorProvider.SetError(emailTextBox, string.Empty);
            errorProvider.SetError(nombreTextBox, string.Empty);
            errorProvider.SetError(apellidoTextBox, string.Empty);

            if (this.emailTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(emailTextBox, "El Email es Requerido");
            }
            else if (!EsEmailValido(this.emailTextBox.Text))
            {
                isValid = false;
                errorProvider.SetError(emailTextBox, "El formato del Email no es válido");
            }

            if (this.nombreTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(nombreTextBox, "El Nombre es Requerido");
            }

            if (this.apellidoTextBox.Text == string.Empty)
            {
                isValid = false;
                errorProvider.SetError(apellidoTextBox, "El Apellido es Requerido");
            }

            return isValid;
        }

        private static bool EsEmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClienteDetalle_Load(object sender, EventArgs e)
        {

        }
    }
}
