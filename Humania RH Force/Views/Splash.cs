using CircularProgressBar_NET5;
using Humania_RH_Force.Models;
using Humania_RH_Force.Presenters;
using System;
using System.Windows.Forms;

namespace Humania_RH_Force.Views
{
    public partial class Splash : Form, ISplashView
    {
        private readonly SplashPresenter _presenter;

        public bool RedirectToLogin { get; set; }
        public bool RedirectToFirstUse { get; set; }
        public bool RedirectToNoInternet { get; set; }
        public bool RedirectToServerError { get; set; }

        public Splash()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            _presenter = new SplashPresenter(this, new AdministradorModel());
            Load += Splash_Load;
        }

        private async void Splash_Load(object sender, EventArgs e)
        {
            await _presenter.InitializeAsync();
            Close(); // Cierra el formulario después de inicializar y establecer redirección
        }

        public void UpdateProgress(int progress)
        {
            cpbCarga.Value = progress;
        }

        public void ShowLogin() => RedirectToLogin = true;
        public void ShowFirstUse() => RedirectToFirstUse = true;
        public void ShowNoInternetError() => RedirectToNoInternet = true;
        public void ShowServerError() => RedirectToServerError = true;
    }
}
