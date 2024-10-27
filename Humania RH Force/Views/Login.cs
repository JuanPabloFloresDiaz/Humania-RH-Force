using Humania_RH_Force.Resources.Components.CustomMessageBox;
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
        public event EventHandler ProbarConexion;
        public Login()
        {
            InitializeComponent();
            btnAyuda.Click += (s, e) => ProbarConexion?.Invoke(this, EventArgs.Empty);  // Enlaza el botón con el evento
        }

        public void MostrarMensaje(string mensaje)
        {
            DialogResult result = RJMessageBox.Show(mensaje, "Resultado de Conexión");
        }
    }
}
