namespace Humania_RH_Force.Views
{
    public interface ILoginView
    {
        event EventHandler ProbarConexion;  // Evento para probar la conexión
        void MostrarMensaje(string mensaje);  // Método para mostrar mensajes
    }
}
