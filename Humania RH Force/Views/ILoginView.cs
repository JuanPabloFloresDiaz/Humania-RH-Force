using Humania_RH_Force.Resources.Components.TextBoxs;

namespace Humania_RH_Force.Views
{
    public interface ILoginView
    {
        // Eventos para el login
        event EventHandler ProbarConexion;  // Evento para probar la conexión
        event EventHandler IniciarSesion;   // Evento para iniciar sesión
        //Funciones para mandar a llamar
        void MostrarMensaje(string mensaje, string titulo, MessageBoxIcon icono);  // Método para mostrar mensajes
        void MostrarError(Control control, string mensaje);
        void LimpiarError();
        // Variables
        string Correo { get; }
        string Clave { get; }

        // Propiedades para acceso a los controles específicos
        TextBoxRounded CorreoControl { get; }
        TextBoxRounded ClaveControl { get; }


        // Nueva función para redirección
        void RedirigirDashboard();
    }
}
