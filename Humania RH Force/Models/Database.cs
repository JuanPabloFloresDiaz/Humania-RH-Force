using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Humania_RH_Force.Models
{
    public class Database
    {
        private static MySqlCommand command = null;
        private static string error = null;
        private static DatabaseConnection dbConnection = new DatabaseConnection();

        /// <summary>
        /// Método para ejecutar una sentencia SQL (INSERT, UPDATE o DELETE).
        /// </summary>
        /// <param name="query">Consulta SQL.</param>
        /// <param name="parameters">Parámetros de la consulta.</param>
        /// <returns>Verdadero si la ejecución es exitosa, falso si ocurre un error.</returns>
        public static bool ExecuteRow(string query, Dictionary<string, object> parameters)
        {
            MySqlConnection connection = null;
            try
            {
                connection = dbConnection.GetConnection();
                using (command = new MySqlCommand(query, connection))
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.AddWithValue(param.Key, param.Value);
                    }
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (MySqlException ex)
            {
                SetException(ex.Number, ex.Message);
                return false;
            }
            finally
            {
                connection?.Close();
            }
        }

        /// <summary>
        /// Método para obtener el último ID insertado en la base de datos.
        /// </summary>
        /// <param name="query">Consulta SQL.</param>
        /// <param name="parameters">Parámetros de la consulta.</param>
        /// <returns>ID del último registro insertado o 0 si falla.</returns>
        public static int GetLastRow(string query, Dictionary<string, object> parameters)
        {
            MySqlConnection connection = null;
            try
            {
                if (ExecuteRow(query, parameters))
                {
                    return (int)command.LastInsertedId;
                }
                return 0;
            }
            finally
            {
                connection?.Close();
            }
        }

        /// <summary>
        /// Método para obtener un único registro de una consulta SQL SELECT.
        /// </summary>
        /// <param name="query">Consulta SQL.</param>
        /// <param name="parameters">Parámetros de la consulta.</param>
        /// <returns>Un registro como diccionario o null si falla.</returns>
        public static Dictionary<string, object> GetRow(string query, Dictionary<string, object> parameters = null)
        {
            MySqlConnection connection = null;
            try
            {
                connection = dbConnection.GetConnection();
                using (command = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var result = new Dictionary<string, object>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                result[reader.GetName(i)] = reader.GetValue(i);
                            }
                            return result;
                        }
                    }
                }
                return null;
            }
            catch (MySqlException ex)
            {
                SetException(ex.Number, ex.Message);
                return null;
            }
            finally
            {
                connection?.Close();
            }
        }

        /// <summary>
        /// Método para obtener todos los registros de una consulta SQL SELECT.
        /// </summary>
        /// <param name="query">Consulta SQL.</param>
        /// <param name="parameters">Parámetros de la consulta.</param>
        /// <returns>Lista de registros como diccionario o null si falla.</returns>
        public static List<Dictionary<string, object>> GetRows(string query, Dictionary<string, object> parameters = null)
        {
            MySqlConnection connection = null;
            var rows = new List<Dictionary<string, object>>();
            try
            {
                connection = dbConnection.GetConnection();
                using (command = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var row = new Dictionary<string, object>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[reader.GetName(i)] = reader.GetValue(i);
                            }
                            rows.Add(row);
                        }
                    }
                }
                return rows;
            }
            catch (MySqlException ex)
            {
                SetException(ex.Number, ex.Message);
                return null;
            }
            finally
            {
                connection?.Close();
            }
        }

        /// <summary>
        /// Método para establecer un error personalizado.
        /// </summary>
        private static void SetException(int code, string message)
        {
            error = $"{message}{Environment.NewLine}";
            switch (code)
            {
                case 2002:
                    error = "Servidor desconocido";
                    break;
                case 1049:
                    error = "Base de datos desconocida";
                    break;
                case 1045:
                    error = "Acceso denegado";
                    break;
                case 1146:
                    error = "Tabla no encontrada";
                    break;
                case 1054:
                    error = "Columna no encontrada";
                    break;
                case 23000:
                    error = "Violación de restricción de integridad";
                    break;
                default:
                    error = "Ocurrió un problema en la base de datos";
                    break;
            }
        }

        /// <summary>
        /// Obtiene el mensaje de error actual.
        /// </summary>
        public static string GetException()
        {
            return error;
        }
    }
}
