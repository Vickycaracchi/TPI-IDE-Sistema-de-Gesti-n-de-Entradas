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
            Login Login = new Login();
            Login.ShowDialog();
            

        }
    }
}