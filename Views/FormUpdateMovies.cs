using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_Movies.Controller;
using CRUD_Movies.Data;
using CRUD_Movies.Models;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CRUD_Movies.Views
{
    public partial class FormUpdateMovies : Form
    {
        private int _id;
        private string _title;
        private string _genre;
        private TimeSpan _time;
        private int _director;

        public FormUpdateMovies(string name, string genre, TimeSpan duration, int id, int director)
        {
            InitializeComponent();
            _title = name;
            _genre = genre;
            _time = duration;
            _director = director;
            _id = id;
            this.Load += new EventHandler(FormUpdateMovies_Load);
        }

        private void FormUpdateMovies_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            lblID.Text = "Pelicula con ID: " + _id.ToString();
            txtNameMovie.Text = _title;
            txtGender.Text = _genre;
            txtDuration.Text = _time.ToString();
            CargarDirectores();
        }

        private void CargarDirectores()
        {
            List<Directors> directors = new List<Directors>();
            using (var connection = Conection.GetConnection())
            {
                string query = "SELECT name FROM director";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader.GetString(0);
                    comboBox1.Items.Add(name);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private int obtenerID()
        {
            using (var connection = Conection.GetConnection())
            {
                string query = "SELECT PKDirector FROM director WHERE name = @name";
                int id = 0;
                MySqlCommand command = new MySqlCommand(query, connection);
                _ = command.Parameters.AddWithValue("@name", comboBox1.SelectedItem.ToString());
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    id = reader.GetInt32(0);

                }
                return id;
            }
        }

        private bool validarinputsMovie()
        {
            string input = txtDuration.Text;

            // Aceptar solo formato hh:mm:ss
            string pattern = @"^\d{1,2}:\d{2}:\d{2}$";
            if (string.IsNullOrWhiteSpace(txtNameMovie.Text) || string.IsNullOrWhiteSpace(txtGender.Text) || string.IsNullOrWhiteSpace(txtDuration.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return false;
            }
            if (!TimeSpan.TryParseExact(input, "hh\\:mm\\:ss", CultureInfo.InvariantCulture, out TimeSpan duracion))
            {
                MessageBox.Show("Formato de duración inválido. Usa el formato HH:mm:ss.");
                return false;
            }
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un director.");
                return false;
            }
            return true;
        }

        private void btnUpDirector_Click(object sender, EventArgs e)
        {
            if (validarinputsMovie())
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de la actualización de estos datos?", "Confirmación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    MoviesController moviesController = new MoviesController();
                    Form1 form1 = new Form1();
                    moviesController.updateMovies(txtNameMovie.Text, txtGender.Text, TimeSpan.Parse(txtDuration.Text), obtenerID(), _id);
                    form1.actualizarDatos();
                    this.Close();
                }
            }
            
        }
        private void txtDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ':')
            {
                e.Handled = true;
            }
        }
    }
}
