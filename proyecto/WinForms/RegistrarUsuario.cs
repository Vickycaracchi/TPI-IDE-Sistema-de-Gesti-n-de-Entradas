using API.Clients;
using DTOs;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class RegistrarUsuario : Form
    {
        internal UsuarioDTO usuario = new UsuarioDTO();
        public RegistrarUsuario()
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
            var tiposUsuarios = new List<string> {
                "Administrador",
                "Vendedor",
                "Usuario",
                "Cliente"
            };
            tipoComboBox.DataSource = tiposUsuarios;
        }

        private void SetFormMode(FormMode value)
        {
            mode = value;
            if (mode == FormMode.Update)
            {
                LoadUsuarioData();
            }
        }

        private void LoadUsuarioData()
        {
            if (usuario != null)
            {
                dniTextBox.Text = usuario.Dni;
                nombreTextBox.Text = usuario.Nombre;
                apellidoTextBox.Text = usuario.Apellido;
                emailTextBox.Text = usuario.Email;
                contrasenaTextBox.Text = usuario.Contrasena;
                cvuTextBox.Text = usuario.Cvu;
                numeroTelefonoTextBox.Text = usuario.NumeroTelefono;
                instagramTextBox.Text = usuario.Instagram;
                if (!string.IsNullOrEmpty(usuario.Tipo) && tipoComboBox.Items.Contains(usuario.Tipo))
                {
                    tipoComboBox.SelectedItem = usuario.Tipo;
                }
                //asegurar que la fecha no sea la default
                if (usuario.FechaNac != default(DateTime))
                {
                    this.fechaNacDatePicker.Value = usuario.FechaNac;
                }
            }
        }

        private async void enviarRegistroUsuario_Click(object sender, EventArgs e)
        {
            if (this.ValidateUsuario())
            {
                try
                {
                    // Si estamos en Update, mantenemos el mismo Id
                    if (usuario == null)
                        usuario = new UsuarioDTO();

                    usuario.Email = emailTextBox.Text;
                    usuario.Dni = dniTextBox.Text;
                    usuario.Nombre = nombreTextBox.Text;
                    usuario.Apellido = apellidoTextBox.Text;
                    usuario.Contrasena = contrasenaTextBox.Text;
                    usuario.Cvu = cvuTextBox.Text;
                    usuario.Tipo = tipoComboBox.SelectedItem.ToString();
                    usuario.NumeroTelefono = numeroTelefonoTextBox.Text;
                    usuario.Instagram = instagramTextBox.Text;
                    usuario.FechaNac = fechaNacDatePicker.Value;

                    if (this.Mode == FormMode.Update)
                    {
                        await UsuarioApiClient.UpdateAsync(usuario);
                    }
                    else
                    {
                        await UsuarioApiClient.AddAsync(usuario);
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateUsuario()
        {
            bool isValid = true;

            registrarUsuarioErrorProvider.SetError(nombreTextBox, string.Empty);
            registrarUsuarioErrorProvider.SetError(apellidoTextBox, string.Empty);
            registrarUsuarioErrorProvider.SetError(emailTextBox, string.Empty);
            registrarUsuarioErrorProvider.SetError(tipoComboBox, string.Empty);

            if (this.nombreTextBox.Text == string.Empty)
            {
                isValid = false;
                registrarUsuarioErrorProvider.SetError(nombreTextBox, "El Nombre es Requerido");
            }

            if (this.apellidoTextBox.Text == string.Empty)
            {
                isValid = false;
                registrarUsuarioErrorProvider.SetError(apellidoTextBox, "El Apellido es Requerido");
            }

            if (this.emailTextBox.Text == string.Empty)
            {
                isValid = false;
                registrarUsuarioErrorProvider.SetError(emailTextBox, "El Email es Requerido");
            }
            else if (!EsEmailValido(this.emailTextBox.Text))
            {
                isValid = false;
                registrarUsuarioErrorProvider.SetError(emailTextBox, "El formato del Email no es válido");
            }

            if (string.IsNullOrWhiteSpace(this.tipoComboBox.SelectedItem?.ToString()))
            {
                isValid = false;
                registrarUsuarioErrorProvider.SetError(tipoComboBox, "El Tipo es Requerido");
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