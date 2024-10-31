using System;
using System.Windows.Forms;
using Humania_RH_Force.Presenters;
using Humania_RH_Force.Views;

namespace Humania_RH_Force
{
    public class AppContext : ApplicationContext
    {
        public AppContext()
        {
            ShowSplash();
        }
        public void NavigateToDashboard()
        {

        }

        private void ShowSplash()
        {
            var splash = new Splash();
            splash.FormClosed += OnSplashClosed;
            splash.Show();
        }

        private void OnSplashClosed(object sender, FormClosedEventArgs e)
        {
            var splash = sender as Splash;

            if (splash.RedirectToLogin)
                ShowForm(new Login());
            else if (splash.RedirectToFirstUse)
                ShowForm(new SignUp()); // Aquí usarás tu pantalla de Primer Uso
            else if (splash.RedirectToNoInternet)
                ShowForm(new NoInternet());
            else
                ShowForm(new ServerError());
        }

        private void ShowForm(Form form)
        {
            // Configurar el presentador adecuado si el formulario es de tipo Login
            if (form is Login loginForm)
            {
                // Aquí pasamos la instancia de loginForm en lugar de crear una nueva
                var loginPresenter = new LoginPresenter(loginForm);
            }

            form.FormClosed += (sender, args) => ExitThread();
            form.Show();
        }
    }
}
