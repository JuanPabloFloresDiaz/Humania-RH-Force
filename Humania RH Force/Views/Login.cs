using Humania_RH_Force.Resources.Components.CustomMessageBox;
using Humania_RH_Force.Resources.Components.TextBoxs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Humania_RH_Force.Views
{
    public partial class Login : Form, ILoginView
    {
        // Eventos
        public event EventHandler ProbarConexion;
        public event EventHandler IniciarSesion;
        // Clase principal
        public Login()
        {
            InitializeComponent();
            btnAyuda.Click += (s, e) => ProbarConexion?.Invoke(this, EventArgs.Empty);  // Enlaza el botón con el evento
            btnAcceder.Click += (s, e) => IniciarSesion?.Invoke(this, EventArgs.Empty);  // Enlaza btnAcceder con IniciarSesion
        }
        // Se definen los controles que se ocuparan
        public TextBoxRounded CorreoControl => txtCorreo;
        public TextBoxRounded ClaveControl => txtClave;

        // Funciones
        // Mostrar el error especifico en el campo especifico
        public void MostrarError(Control control, string mensaje)
        {
            errorLogin.SetError(control, mensaje); // Mostrar el error en el control específico
        }

        // Limpiar errores de ErrorProvider
        public void LimpiarError()
        {
            errorLogin.Clear();
        }
        // Mostrar mensaje con su titulo y el icono especifico
        public void MostrarMensaje(string mensaje, string titulo, MessageBoxIcon icono)
        {
            DialogResult result = RJMessageBox.Show(mensaje, titulo,
            MessageBoxButtons.OK,
            icono);
        }
        // Aplicarle a variables los datos de los campos
        public string Correo => CorreoControl.Texts;
        public string Clave => ClaveControl.Texts;
    }
}
