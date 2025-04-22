using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CRUD_Movies.Data
{
    internal class Conection
    {
        public static MySqlConnection GetConnection()
        {
            string connectionString = "Server=localhost;Database=prueba_tecnica;user=root; password=12345678;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connection opened successfully.");
            return connection;
        }
    }
}
