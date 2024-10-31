using Humania_RH_Force.Resources.Components.CustomMessageBox;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Humania_RH_Force.Models
{
    public class AdministradorModel
    {
        /// <summary>
        /// Verifica si el administrador puede iniciar sesión.
        /// </summary>
        /// <param name="correo">Correo del administrador.</param>
        /// <param name="clave">Clave del administrador.</param>
        /// <returns>Verdadero si la autenticación es exitosa, falso en caso contrario.</returns>
        public bool Login(string correo, string clave)
        {
            string query = "SELECT clave_administrador FROM administradores WHERE correo_administrador = @correo AND estado_administrador = 1";
            var parameters = new Dictionary<string, object>
            {
                { "@correo", correo }
            };
            var result = Database.GetRow(query, parameters);

            if (result != null && result.TryGetValue("clave_administrador", out object storedClave))
            {
                return storedClave.ToString() == clave;
            }
            else
            {
                RJMessageBox.Show(Database.GetException(), "Excepción",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Verifica si existen administradores registrados.
        /// </summary>
        /// <returns>Verdadero si existen usuarios, falso en caso contrario.</returns>
        public bool ReadUsers() {
            string query = "SELECT COUNT(*) FROM administradores;";
            var result = Database.GetRow(query);
            if (result != null && result.Count > 0) {
                return true;
            }
            else
            {
                RJMessageBox.Show(Database.GetException(), "Excepción",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Insertar el primer usuario.
        /// </summary>
        /// <param name="nombre">Nombre del administrador.</param>
        /// <param name="apellido">Apellido del administrador.</param>
        /// <param name="clave">Clave del administrador.</param>
        /// <param name="correo">Correo del administrador.</param>
        /// <param name="telefono">Teléfono del administrador.</param>
        /// <param name="dui">DUI del administrador.</param>
        /// <param name="foto"> Nombre del archivo de la foto del administrador.</param>
        /// <returns>Verdadero si la insercción es exitosa, falso en caso contrario.</returns>
        public bool FirstUser(string nombre, string apellido, string clave, string correo, string telefono, string dui, string foto) {
            string query = "INSERT INTO administradores(nombre_administrador, apellido_administrador, clave_administrador, correo_administrador, telefono_administrador, dui_administrador, foto_administrador)" +
                "VALUES(@nombre, @apellido, @clave, @correo, @telefono, @dui, @foto)";
            var parameters = new Dictionary<string, object>
            {
                { "@nombre", nombre },
                { "@apellido", apellido },
                { "@clave", clave },
                { "@correo", correo },
                { "@telefono", telefono },
                { "@dui", dui },
                { "@foto", foto }
            };
            var result = Database.ExecuteRow(query, parameters);

            if (result == true)
            {
                return result;
            }
            else
            {
                RJMessageBox.Show(Database.GetException(), "Excepción",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
