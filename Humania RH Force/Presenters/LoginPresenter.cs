using Humania_RH_Force.Models;
using Humania_RH_Force.Views;
using System;

namespace Humania_RH_Force.Presenters
{
    public class LoginPresenter
    {
        private readonly ILoginView view;
        private readonly DatabaseConnection dbConnection;

        public LoginPresenter(ILoginView view)
        {
            this.view = view;
            dbConnection = new DatabaseConnection();

            this.view.ProbarConexion += OnProbarConexion;  // Enlaza el evento de la vista al manejador
        }

        private void OnProbarConexion(object sender, EventArgs e)
        {
            try
            {
                using (var connection = dbConnection.GetConnection())
                {
                    connection.Open();
                    view.MostrarMensaje("Conexión exitosa a la base de datos.");
                }
            }
            catch (Exception ex)
            {
                view.MostrarMensaje($"Error de conexión: {ex.Message}");
            }
        }
    }
}
