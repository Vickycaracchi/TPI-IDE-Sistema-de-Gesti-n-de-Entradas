using QuestPDF.Infrastructure;

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
            QuestPDF.Settings.License = LicenseType.Community;
            Login Login = new Login();
            Login.ShowDialog();
            

        }
    }
}