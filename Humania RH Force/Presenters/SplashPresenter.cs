using Humania_RH_Force.Models;
using Humania_RH_Force.Views;
using System;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace Humania_RH_Force.Presenters
{
    public class SplashPresenter
    {
        private readonly ISplashView _view;
        private readonly AdministradorModel _model;

        public SplashPresenter(ISplashView view, AdministradorModel model)
        {
            _view = view;
            _model = model;
        }

        public async Task InitializeAsync()
        {
            for (int i = 0; i <= 100; i += 20)
            {
                _view.UpdateProgress(i);
                await Task.Delay(200); // Simulación de carga
            }

            if (!CheckInternetConnection())
            {
                _view.RedirectToNoInternet = true;
                return;
            }

            try
            {
                if (_model.ReadUsers())
                {
                    _view.RedirectToLogin = true;
                }
                else
                {
                    _view.RedirectToFirstUse = true;
                }
            }
            catch (Exception)
            {
                _view.RedirectToServerError = true;
            }
        }

        private bool CheckInternetConnection()
        {
            try
            {
                return new Ping().Send("www.google.com").Status == IPStatus.Success;
            }
            catch
            {
                return false;
            }
        }
    }
}
