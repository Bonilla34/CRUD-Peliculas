using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_Movies.Controller;

namespace CRUD_Movies.Views
{
    public partial class FormUpdateDirector : Form
    {
        private int _id;
        private string _name;
        private int _age;

        public FormUpdateDirector(int id, string name, int age)
        {
            InitializeComponent();
            _id = id;
            _name = name;
            _age = age;
            this.Load += new EventHandler(FormUpdateDirector_Load);

        }

        private void FormUpdateDirector_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            lblID.Text = "Director con ID: " + _id.ToString();
            txtNameDirector.Text = _name;
            txtAge.Text = _age.ToString();
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

        private void btnUpDirector_Click(object sender, EventArgs e)
        {
            if (validarInputsDirector())
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de la actualización de estos datos?", "Confirmación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    DirectorController directorController = new DirectorController();
                    Form1 form1 = new Form1();
                    bool isActive = false;
                    if (radioButton1.Checked)
                    {
                        isActive = true;
                    }
                    directorController.updateDirector(txtNameDirector.Text, txtAge.Text, isActive, _id);
                    form1.actualizarDatos();
                    this.Close();
                }
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
