using System;
using System.Collections.Generic;

namespace Humania_RH_Force.Models
{
    internal class AdministradorModel
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

            // Llamada a Database.GetRow para obtener la clave de la base de datos
            var result = Database.GetRow(query, parameters);

            if (result != null && result.TryGetValue("clave_administrador", out object storedClave))
            {
                // Compara la clave proporcionada con la clave almacenada
                return storedClave.ToString() == clave;
            }
            else
            {
                Console.WriteLine(Database.GetException());  // Muestra el error específico, si hubo uno
                return false;
            }
        }
    }
}
