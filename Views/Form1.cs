using System.Globalization;
using CRUD_Movies.Controller;
using CRUD_Movies.Data;
using CRUD_Movies.Models;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;


namespace CRUD_Movies.Views
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Directors> directors = DirectorController.GetDirectors();
            List<Movies> movies = MoviesController.GetMovies();
            dataGridDirector.DataSource = directors;
            dataGridMovies.DataSource = MoviesController.GetMovies();
            botones();
            CargarDirectores();

        }

        public void botones()
        {


            if (!dataGridMovies.Columns.Contains("btnEditar") && !dataGridMovies.Columns.Contains("btnEliminar"))
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.HeaderText = "Acciones";         // Texto en el encabezado
                btnDelete.Text = "Eliminar";               // Texto que mostrará el botón
                btnDelete.UseColumnTextForButtonValue = true;
                btnDelete.Name = "btnEliminar";

                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.HeaderText = "Acciones";
                btnEdit.Text = "Editar";
                btnEdit.UseColumnTextForButtonValue = true;
                btnEdit.Name = "btnEditar";

                dataGridMovies.Columns.Add(btnEdit);
                dataGridMovies.Columns.Add(btnDelete);
            }

            if (!dataGridDirector.Columns.Contains("btnEditar") && !dataGridDirector.Columns.Contains("btnEliminar"))
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.HeaderText = "Acciones";
                btnDelete.Text = "Eliminar";
                btnDelete.UseColumnTextForButtonValue = true;
                btnDelete.Name = "btnEliminar";

                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.HeaderText = "Acciones";
                btnEdit.Text = "Editar";
                btnEdit.UseColumnTextForButtonValue = true;
                btnEdit.Name = "btnEditar";

                dataGridDirector.Columns.Add(btnEdit);
                dataGridDirector.Columns.Add(btnDelete);
            }
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
                    cBoxDirectors.Items.Add(name);
                }
            }
        }

        public void actualizarDatos()
        {
            dataGridDirector.DataSource = DirectorController.GetDirectors();
            dataGridMovies.DataSource = MoviesController.GetMovies();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Peliculas")
            {
                panelPeliculas.Visible = true;
                panelDirector.Visible = false;
            }
            else if (comboBox1.SelectedItem.ToString() == "Directores")
            {
                panelPeliculas.Visible = false;
                panelDirector.Visible = true;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private int obtenerID()
        {
            using (var connection = Conection.GetConnection())
            {
                string query = "SELECT PKDirector FROM director WHERE name = @name";
                int id = 0;
                MySqlCommand command = new MySqlCommand(query, connection);
                _ = command.Parameters.AddWithValue("@name", cBoxDirectors.SelectedItem.ToString());
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    id = reader.GetInt32(0);

                }
                return id;
            }
        }
        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            MoviesController moviesController = new MoviesController();
            if (validarinputsMovie())
            {
                moviesController.addMovies(txtNameMovie.Text, txtGender.Text, TimeSpan.Parse(txtDuration.Text), obtenerID());
                actualizarDatos();
            }
        }

        private void btnAddDirector_Click(object sender, EventArgs e)
        {
            DirectorController directorController = new DirectorController();
            if (validarInputsDirector())
            {
                bool isActive = false;
                if (radioButton1.Checked)
                {
                    isActive = true;
                }
                directorController.addDirector(txtNameDirector.Text, txtAge.Text, isActive);
                actualizarDatos();
            }
        }

        private void dataGridDirector_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var grid = (DataGridView)sender;

                if (grid.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                    int id = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["PKDirector"].Value);
                    string name = grid.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                    int age = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["Age"].Value);
                    FormUpdateDirector formUpdateDirector = new FormUpdateDirector(id, name, age);
                    formUpdateDirector.ShowDialog();
                    actualizarDatos();
                }

                else if (grid.Columns[e.ColumnIndex].Name == "btnEliminar")
                {
                    int id = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["PKDirector"].Value);
                    DialogResult result = MessageBox.Show($"¿Estás seguro de eliminar el registro con ID: {id}?", "Confirmar eliminación", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        DirectorController directorController = new DirectorController();
                        directorController.deleteDirector(id);
                        actualizarDatos();
                    }
                }
            }
        }
        private void dataGridMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var grid = (DataGridView)sender;

                if (grid.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                    int id = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["PKMovie"].Value);
                    string name = grid.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                    string gender = grid.Rows[e.RowIndex].Cells["Genre"].Value.ToString();
                    TimeSpan duration = (TimeSpan)grid.Rows[e.RowIndex].Cells["Duration"].Value;
                    int director = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["FKDirector"].Value);
                    FormUpdateMovies formUpdateMovies = new FormUpdateMovies(name, gender, duration, id, director);
                    formUpdateMovies.ShowDialog();
                    actualizarDatos();

                }

                // Verificar si se hizo clic en el botón "Eliminar"
                else if (grid.Columns[e.ColumnIndex].Name == "btnEliminar")
                {
                    int id = Convert.ToInt32(grid.Rows[e.RowIndex].Cells["PKMovie"].Value);
                    DialogResult result = MessageBox.Show($"¿Estás seguro de eliminar el registro con ID: {id}?", "Confirmar eliminación", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        MoviesController moviesController = new MoviesController();
                        moviesController.deleteMovies(id);
                        actualizarDatos();
                    }
                }
            }
        }

        private bool validarinputsMovie()
        {
            string pattern = @"^(\d{1,2}:\d{2}:\d{2}|\d{1,2}:\d{2})$";
            if (string.IsNullOrWhiteSpace(txtNameMovie.Text) || string.IsNullOrWhiteSpace(txtGender.Text) || string.IsNullOrWhiteSpace(txtDuration.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return false;
            }
            if (!TimeSpan.TryParseExact(txtDuration.Text, "hh\\:mm\\:ss", CultureInfo.InvariantCulture, out TimeSpan duracion))
            {
                MessageBox.Show("Formato de duración inválido. Usa el formato HH:mm:ss.");
                return false;
            }
            if (cBoxDirectors.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un director.");
                return false;
            }
            return true;
        }

        private bool validarInputsDirector()
        {
            if (string.IsNullOrWhiteSpace(txtNameDirector.Text) || string.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return false;
            }
            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("La edad debe ser un número entero.");
                return false;
            }
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Por favor, selecciona un estado de actividad.");
                return false;
            }
            return true;
        }

        private void txtDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ':')
            {
                e.Handled = true;
            }
        }

        private void btnAddDirector_Click_1(object sender, EventArgs e)
        {
            DirectorController directorController = new DirectorController();
            if (validarInputsDirector())
            {
                bool isActive = false;
                if (radioButton1.Checked)
                {
                    isActive = true;
                }
                directorController.addDirector(txtNameDirector.Text, txtAge.Text, isActive);
                actualizarDatos();
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
