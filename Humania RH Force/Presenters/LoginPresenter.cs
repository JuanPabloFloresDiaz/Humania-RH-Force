// Conectamos el presentador con el modelo y la vista
using Humania_RH_Force.Models;
using Humania_RH_Force.Views;
// Usamos la clase de conexión con MySQL
using MySql.Data.MySqlClient;
using System;
using System.ComponentModel.DataAnnotations;

namespace Humania_RH_Force.Presenters
{
    public class LoginPresenter
    {
        // Variables que referencien las distintas clases que necesitamos.
        private readonly ILoginView view;
        private readonly DatabaseConnection dbConnection;
        private readonly AdministradorModel administradorModel;

        // Propiedades con validación
        // Validaciones para el correo
        private string _correo;
        public string Correo
        {
            get => _correo;
            set
            {
                // Limpiamos los errores
                view.LimpiarError();
                // Verificación de campo vacio o espacios en blanco
                if (string.IsNullOrWhiteSpace(value))
                {
                    view.MostrarError(view.CorreoControl, "El campo de correo está vacío.");
                    _correo = string.Empty; // Para asegurarnos de que no se usa un valor incorrecto
                }
                // Validamos formato de correo
                else if (!Validator.ValidateEmail(value))
                {
                    view.MostrarError(view.CorreoControl, "Formato de correo no válido.");
                    _correo = string.Empty;
                }
                // Confirmamos el valor de la variable
                else
                {
                    _correo = value;
                }
            }
        }

        // Validaciones para la clave
        private string _clave;
        public string Clave
        {
            get => _clave;
            set
            {
                // Verificación de campo vacio o espacios en blanco
                if (string.IsNullOrWhiteSpace(value))
                {
                    view.MostrarError(view.ClaveControl, "El campo de clave está vacío.");
                    _clave = string.Empty;
                }
                // Validamos la contraseña
                else if (!Validator.ValidatePassword(value))
                {
                    view.MostrarError(view.ClaveControl, Validator.GetPasswordError());
                    _clave = string.Empty;
                }
                // Confirmamos el valor de la variable
                else
                {
                    _clave = value;
                }
            }
        }
        // Referenciamos el presentador con la interfaz de la vista
        public LoginPresenter(ILoginView view)
        {
            // Declaramos la interfaz de la vista
            this.view = view;
            // Declaramos los modelos
            dbConnection = new DatabaseConnection();
            administradorModel = new AdministradorModel();
            // Le aplicamos los eventos del presentador a la vista
            this.view.ProbarConexion += OnProbarConexion;
            this.view.IniciarSesion += OnIniciarSesion;
        }

        // Función para probar la conexión
        private void OnProbarConexion(object sender, EventArgs e)
        {
            MySqlConnection connection = null;
            try
            {
                connection = dbConnection.GetConnection();
                view.MostrarMensaje("Conexión exitosa a la base de datos.", "Resultado de conexión", MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                view.MostrarMensaje($"Error de conexión: {ex.Message}", "Resultado de conexión", MessageBoxIcon.Error);
            }
            finally
            {
                connection?.Close();
            }
        }
        // Función para iniciar sesión
        private void OnIniciarSesion(object sender, EventArgs e)
        {
            // Establecer valores desde la vista, desencadenando las validaciones
            Correo = view.Correo;
            Clave = view.Clave;

            // Si las validaciones fallan, las propiedades se establecerán en vacío y se mostrará el error,
            // por lo que verificamos si las propiedades contienen valores antes de continuar
            if (!string.IsNullOrEmpty(Correo) && !string.IsNullOrEmpty(Clave))
            {
                bool isAuthenticated = administradorModel.Login(Correo, Clave);
                if (isAuthenticated)
                {
                    view.MostrarMensaje("Inicio de sesión exitoso.", "Resultado de autenticación", MessageBoxIcon.Information);
                }
                else
                {
                    view.MostrarMensaje("Correo o contraseña incorrectos.", "Resultado de autenticación", MessageBoxIcon.Warning);
                }
            }
        }
    }
}
