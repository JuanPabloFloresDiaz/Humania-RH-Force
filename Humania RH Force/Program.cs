using Humania_RH_Force.Presenters;
using Humania_RH_Force.Views;
using System;
using System.Windows.Forms;

namespace Humania_RH_Force
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppContext());
        }
    }
}
