
namespace CRUD_Movies.Views
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            panelPeliculas = new Panel();
            btnAddMovie = new Button();
            dataGridMovies = new DataGridView();
            cBoxDirectors = new ComboBox();
            txtDuration = new TextBox();
            txtGender = new TextBox();
            txtNameMovie = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            panelDirector = new Panel();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            btnAddDirector = new Button();
            dataGridDirector = new DataGridView();
            txtAge = new TextBox();
            txtNameDirector = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            panelPeliculas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridMovies).BeginInit();
            panelDirector.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDirector).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(new object[] { "Peliculas", "Directores" });
            comboBox1.Location = new Point(416, 24);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(341, 33);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panelPeliculas
            // 
            panelPeliculas.Controls.Add(btnAddMovie);
            panelPeliculas.Controls.Add(dataGridMovies);
            panelPeliculas.Controls.Add(cBoxDirectors);
            panelPeliculas.Controls.Add(txtDuration);
            panelPeliculas.Controls.Add(txtGender);
            panelPeliculas.Controls.Add(txtNameMovie);
            panelPeliculas.Controls.Add(label5);
            panelPeliculas.Controls.Add(label4);
            panelPeliculas.Controls.Add(label3);
            panelPeliculas.Controls.Add(label2);
            panelPeliculas.Controls.Add(label1);
            panelPeliculas.Location = new Point(19, 78);
            panelPeliculas.Name = "panelPeliculas";
            panelPeliculas.Size = new Size(747, 488);
            panelPeliculas.TabIndex = 2;
            panelPeliculas.Visible = false;
            // 
            // btnAddMovie
            // 
            btnAddMovie.Location = new Point(279, 211);
            btnAddMovie.Name = "btnAddMovie";
            btnAddMovie.Size = new Size(112, 34);
            btnAddMovie.TabIndex = 9;
            btnAddMovie.Text = "Guardar";
            btnAddMovie.UseVisualStyleBackColor = true;
            btnAddMovie.Click += btnAddMovie_Click;
            // 
            // dataGridMovies
            // 
            dataGridMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMovies.Location = new Point(14, 251);
            dataGridMovies.Name = "dataGridMovies";
            dataGridMovies.RowHeadersWidth = 62;
            dataGridMovies.Size = new Size(696, 225);
            dataGridMovies.TabIndex = 8;
            dataGridMovies.CellClick += dataGridMovies_CellClick;
            // 
            // cBoxDirectors
            // 
            cBoxDirectors.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxDirectors.FormattingEnabled = true;
            cBoxDirectors.Location = new Point(152, 175);
            cBoxDirectors.Name = "cBoxDirectors";
            cBoxDirectors.Size = new Size(182, 33);
            cBoxDirectors.TabIndex = 3;
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(152, 140);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(90, 31);
            txtDuration.TabIndex = 7;
            txtDuration.KeyPress += txtDuration_KeyPress;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(152, 98);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(558, 31);
            txtGender.TabIndex = 6;
            // 
            // txtNameMovie
            // 
            txtNameMovie.Location = new Point(152, 55);
            txtNameMovie.Name = "txtNameMovie";
            txtNameMovie.Size = new Size(558, 31);
            txtNameMovie.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 183);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 4;
            label5.Text = "Director";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 140);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 3;
            label4.Text = "Duracion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 98);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 2;
            label3.Text = "Genero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 55);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(190, 25);
            label1.TabIndex = 0;
            label1.Text = "Agregar nueva Pelicula";
            label1.Click += label1_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 32);
            label6.Name = "label6";
            label6.Size = new Size(286, 25);
            label6.TabIndex = 12;
            label6.Text = "¿Con que tabla deseas interactuar?";
            // 
            // panelDirector
            // 
            panelDirector.Controls.Add(groupBox1);
            panelDirector.Controls.Add(btnAddDirector);
            panelDirector.Controls.Add(dataGridDirector);
            panelDirector.Controls.Add(txtAge);
            panelDirector.Controls.Add(txtNameDirector);
            panelDirector.Controls.Add(label7);
            panelDirector.Controls.Add(label8);
            panelDirector.Controls.Add(label9);
            panelDirector.Controls.Add(label10);
            panelDirector.Location = new Point(19, 81);
            panelDirector.Name = "panelDirector";
            panelDirector.Size = new Size(747, 488);
            panelDirector.TabIndex = 13;
            panelDirector.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(152, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 42);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(147, 7);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(61, 29);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "No";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(0, 7);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Sí";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnAddDirector
            // 
            btnAddDirector.Location = new Point(258, 197);
            btnAddDirector.Name = "btnAddDirector";
            btnAddDirector.Size = new Size(112, 34);
            btnAddDirector.TabIndex = 9;
            btnAddDirector.Text = "Guardar";
            btnAddDirector.UseVisualStyleBackColor = true;
            btnAddDirector.Click += btnAddDirector_Click_1;
            // 
            // dataGridDirector
            // 
            dataGridDirector.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDirector.Location = new Point(14, 251);
            dataGridDirector.Name = "dataGridDirector";
            dataGridDirector.RowHeadersWidth = 62;
            dataGridDirector.Size = new Size(696, 225);
            dataGridDirector.TabIndex = 8;
            dataGridDirector.CellClick += dataGridDirector_CellClick;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(152, 98);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(558, 31);
            txtAge.TabIndex = 6;
            txtAge.KeyPress += txtAge_KeyPress;
            // 
            // txtNameDirector
            // 
            txtNameDirector.Location = new Point(152, 55);
            txtNameDirector.Name = "txtNameDirector";
            txtNameDirector.Size = new Size(558, 31);
            txtNameDirector.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 140);
            label7.Name = "label7";
            label7.Size = new Size(112, 25);
            label7.TabIndex = 3;
            label7.Text = "¿Esta activo?";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 98);
            label8.Name = "label8";
            label8.Size = new Size(52, 25);
            label8.TabIndex = 2;
            label8.Text = "Edad";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 55);
            label9.Name = "label9";
            label9.Size = new Size(78, 25);
            label9.TabIndex = 1;
            label9.Text = "Nombre";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 12);
            label10.Name = "label10";
            label10.Size = new Size(198, 25);
            label10.TabIndex = 0;
            label10.Text = "Agregar nuevo Director";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 578);
            Controls.Add(panelDirector);
            Controls.Add(label6);
            Controls.Add(panelPeliculas);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Form1";
            panelPeliculas.ResumeLayout(false);
            panelPeliculas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridMovies).EndInit();
            panelDirector.ResumeLayout(false);
            panelDirector.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDirector).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private Panel panelPeliculas;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtNameMovie;
        private ComboBox cBoxDirectors;
        private TextBox txtDuration;
        private TextBox txtGender;
        private Button btnAddMovie;
        private DataGridView dataGridMovies;
        private Label label6;
        private Panel panelDirector;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button btnAddDirector;
        private DataGridView dataGridDirector;
        private TextBox txtAge;
        private TextBox txtNameDirector;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
