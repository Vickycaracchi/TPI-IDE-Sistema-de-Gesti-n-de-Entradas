using API.Clients;
using DTOs;
using System;
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
                        // Guarda datos del usuario logueado
                        TipoUsuario = usuario.Tipo;
                        usuarioIngresado = usuario;

                        MessageBox.Show(
                            $"¡Bienvenido, {TipoUsuario}!",
                            "Inicio de Sesión Exitoso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        // Redirección según tipo de usuario
                        if (TipoUsuario == "Administrador")
                        {
                            var menuAdminForm = new MenuAdmin();
                            menuAdminForm.ShowDialog();
                        }
                        else if (TipoUsuario == "Vendedor")
                        {
                            var menuVendedorForm = new MenuVendedor();
                            menuVendedorForm.usuarioIngresado = usuarioIngresado;
                            menuVendedorForm.ShowDialog();
                        }
                        else if (TipoUsuario == "Jefe")
                        {
                            var menuJefeForm = new MenuJefe();
                            menuJefeForm.usuarioIngresado = usuarioIngresado;
                            menuJefeForm.ShowDialog();
                        }
                        else if (TipoUsuario == "Cliente")
                        {
                            var menuClienteForm = new menuCliente();
                            menuClienteForm.usuarioIngresado = usuarioIngresado;
                            menuClienteForm.ShowDialog();
                        }

                        // Cierra el Login
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Credenciales inválidas. Intente nuevamente.",
                            "Error de Inicio de Sesión",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );

                        this.Hide();

                        Login ingresarUsuarioForm = new Login();
                        ingresarUsuarioForm.ShowDialog();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Ocurrió un error al intentar iniciar sesión: {ex.Message}",
                        "Error de Conexión",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
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
                ingresarVendedorErrorProvider.SetError(contrasenaTextBox, "La contraseña es Requerida");
            }

            return isValid;
        }
    }
}