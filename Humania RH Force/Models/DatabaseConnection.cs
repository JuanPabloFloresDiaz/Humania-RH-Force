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
        private MySqlConnection connection;

        public DatabaseConnection()
        {
            string server = "localhost";
            string database = "HumaniaRHForce";
            string user = "root";
            string password = "";
            string connectionString = "Server=" + server+"; Database="+ database +
            "; Uid=" + user + "; Pwd=" +password+ ";";
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
