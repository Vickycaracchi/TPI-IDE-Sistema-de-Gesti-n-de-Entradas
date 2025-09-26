namespace WinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IngresarVendedor ingresarVendedorForm = new IngresarVendedor();
            
            RegistrarVendedor registrarVendedor = new RegistrarVendedor();  
            registrarVendedor.ShowDialog();

            if (ingresarVendedorForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show($"Bienvenido, {ingresarVendedorForm.TipoVendedor}!", "Inicio de Sesión Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (ingresarVendedorForm.TipoVendedor == "Administrador")
                {
                    MenuAdmin menuAdminForm = new MenuAdmin();
                    Application.Run(menuAdminForm);
                }
                else if (ingresarVendedorForm.TipoVendedor == "Vendedor")
                {
                    ClientesLista listaClientesForm = new ClientesLista();
                    Application.Run(listaClientesForm);
                }
            }
        }
    }
}