using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Humania_RH_Force.Models
{
    public class DatabaseConnection
    {
        private readonly string connectionString;

        public DatabaseConnection()
        {
            string server = "localhost";
            string database = "HumaniaRHForce";
            string user = "root";
            string password = "";
            connectionString = "Server=" + server + "; Database=" + database +
                               "; Uid=" + user + "; Pwd=" + password + ";";
        }

        /// <summary>
        /// Devuelve una nueva conexión ya abierta.
        /// </summary>
        /// <returns>Una instancia de MySqlConnection abierta.</returns>
        public MySqlConnection GetConnection()
        {
            var connection = new MySqlConnection(connectionString);
            connection.Open();  // Abre la conexión antes de devolverla
            return connection;
        }
    }
}
