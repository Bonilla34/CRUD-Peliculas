using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_Movies.Models;
using CRUD_Movies.Data;
using CRUD_Movies.Views;
using MySql.Data.MySqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD_Movies.Controller
{
    internal class MoviesController
    {
        public static List<Movies> GetMovies()
        {
            List<Movies> movies = new List<Movies>();
            using (var connection = Conection.GetConnection())
            {
                string query = "SELECT * FROM movies";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Movies movie = new Movies(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetTimeSpan(3), reader.GetInt32(4));
                    movies.Add(movie);
                }
            }
            return movies;
        }

        public void addMovies(string name, string gender, TimeSpan duration, int director)
        {
            try
            {
                string query = "INSERT INTO movies(name, gender, duration, FKDirector) VALUES (@name, @gender, @duration, @FKDirector)";
                MySqlCommand command = new MySqlCommand(query, Conection.GetConnection());
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@duration", duration);
                command.Parameters.AddWithValue("@FKDirector", director);
                command.ExecuteNonQuery();
                MessageBox.Show("Pelicula registrada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar pelicula: " + ex.Message);
            }
        }

        public void updateMovies(string name, string gender, TimeSpan duration, int director, int id)
        {
            try
            {
                string query = "UPDATE movies SET name = @name, gender = @gender, duration = @duration, FKDirector = @FKDirector WHERE PKMovies = @id";
                MySqlCommand command = new MySqlCommand(query, Conection.GetConnection());
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@duration", duration);
                command.Parameters.AddWithValue("@FKDirector", director);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                MessageBox.Show("Pelicula actualizada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar pelicula: " + ex.Message);
            }
        }

        public void deleteMovies(int id)
        {
            try
            {
                string query = "DELETE FROM movies WHERE PKMovies = @id";
                MySqlCommand command = new MySqlCommand(query, Conection.GetConnection());
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
                MessageBox.Show("Pelicula eliminada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar pelicula: " + ex.Message);
            }
        }
    }
}