using System;
using System.Windows.Forms;
using Humania_RH_Force.Views;
using Humania_RH_Force.Presenters;

namespace Humania_RH_Force
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var loginView = new Login();
            var loginPresenter = new LoginPresenter(loginView);  // Enlaza la vista con el presentador

            Application.Run(loginView);
        }
    }
}