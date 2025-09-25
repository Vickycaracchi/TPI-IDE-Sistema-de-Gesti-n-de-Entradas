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
            

            if (ingresarVendedorForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show($"Bienvenido, {ingresarVendedorForm.TipoVendedor}!", "Inicio de Sesión Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (ingresarVendedorForm.TipoVendedor == "Administrador")
                {
                    RegistrarVendedor registrarVendedorForm = new RegistrarVendedor();
                    //Application.Run(registrarVendedorForm);
                    Menu menuForm = new Menu();
                    Application.Run(menuForm);
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