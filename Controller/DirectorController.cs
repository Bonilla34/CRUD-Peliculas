using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_Movies.Models;
using CRUD_Movies.Data;
using MySql.Data.MySqlClient;

namespace CRUD_Movies.Controller
{
    internal class DirectorController
    {
        public static List<Directors> GetDirectors()
        {
            List<Directors> directors = new List<Directors>();
            using (var connection = Conection.GetConnection())
            {
                string query = "SELECT * FROM director";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Directors director = new Directors(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetBoolean(3));
                    directors.Add(director);
                }
            }
            return directors;
        }

        public void addDirector(string name, string age, bool active)
        {
            try
            {
                string query = "INSERT INTO director(name, age, active) VALUES (@name, @age, @active)";
                MySqlCommand command = new MySqlCommand(query, Conection.GetConnection());
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@active", active);
                command.ExecuteNonQuery();
                MessageBox.Show("Director registrado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar director: " + ex.Message);
            }
        }

        public void updateDirector(string name, string age, bool active, int id)
        {
            try
            {
                string query = "UPDATE director SET name = @name, age = @age, active = @active WHERE PKDirector = @id";
                MySqlCommand command = new MySqlCommand(query, Conection.GetConnection());
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@age", age);
                command.Parameters.AddWithValue("@active", active);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                MessageBox.Show("Director actualizado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar director: " + ex.Message);
            }
        }

        public void deleteDirector(int id)
        {
            try
            {
                string query = "DELETE FROM director WHERE PKDirector = @id";
                MySqlCommand command = new MySqlCommand(query, Conection.GetConnection());
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                MessageBox.Show("Director eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar director: " + ex.Message);
            }
        }
    }
}
