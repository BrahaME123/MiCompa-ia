using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
namespace MiCompañia.Datos
{
    public abstract class ConnectionToMySQL
    {
        private readonly String connectionString;
        public ConnectionToMySQL()
        {
            connectionString = "Server=localhost; Database=micompañia; User=root; port=3306; password=123qweasdA;";
        }

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
