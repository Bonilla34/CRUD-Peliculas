namespace CRUD_Movies.Views
{
    partial class FormUpdateMovies
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelDirector = new Panel();
            comboBox1 = new ComboBox();
            label2 = new Label();
            txtDuration = new TextBox();
            btnUpMovie = new Button();
            txtGender = new TextBox();
            txtNameMovie = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lblID = new Label();
            label1 = new Label();
            panelDirector.SuspendLayout();
            SuspendLayout();
            // 
            // panelDirector
            // 
            panelDirector.Controls.Add(comboBox1);
            panelDirector.Controls.Add(label2);
            panelDirector.Controls.Add(txtDuration);
            panelDirector.Controls.Add(btnUpMovie);
            panelDirector.Controls.Add(txtGender);
            panelDirector.Controls.Add(txtNameMovie);
            panelDirector.Controls.Add(label7);
            panelDirector.Controls.Add(label8);
            panelDirector.Controls.Add(label9);
            panelDirector.Location = new Point(23, 114);
            panelDirector.Name = "panelDirector";
            panelDirector.Size = new Size(755, 304);
            panelDirector.TabIndex = 15;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(152, 147);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(286, 33);
            comboBox1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 147);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 11;
            label2.Text = "Director";
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(152, 105);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(211, 31);
            txtDuration.TabIndex = 10;
            txtDuration.KeyPress += this.txtDuration_KeyPress;
            // 
            // btnUpMovie
            // 
            btnUpMovie.Location = new Point(299, 243);
            btnUpMovie.Name = "btnUpMovie";
            btnUpMovie.Size = new Size(112, 34);
            btnUpMovie.TabIndex = 9;
            btnUpMovie.Text = "Actualizar";
            btnUpMovie.UseVisualStyleBackColor = true;
            btnUpMovie.Click += btnUpDirector_Click;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(152, 58);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(558, 31);
            txtGender.TabIndex = 6;
            // 
            // txtNameMovie
            // 
            txtNameMovie.Location = new Point(152, 15);
            txtNameMovie.Name = "txtNameMovie";
            txtNameMovie.Size = new Size(558, 31);
            txtNameMovie.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 105);
            label7.Name = "label7";
            label7.Size = new Size(83, 25);
            label7.TabIndex = 3;
            label7.Text = "Duracion";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 58);
            label8.Name = "label8";
            label8.Size = new Size(69, 25);
            label8.TabIndex = 2;
            label8.Text = "Genero";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 15);
            label9.Name = "label9";
            label9.Size = new Size(78, 25);
            label9.TabIndex = 1;
            label9.Text = "Nombre";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(23, 86);
            lblID.Name = "lblID";
            lblID.Size = new Size(130, 25);
            lblID.TabIndex = 14;
            lblID.Text = "Pelicula con ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(23, 33);
            label1.Name = "label1";
            label1.Size = new Size(253, 41);
            label1.TabIndex = 13;
            label1.Text = "Actualizar Pelicula";
            // 
            // FormUpdateMovies
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelDirector);
            Controls.Add(lblID);
            Controls.Add(label1);
            Name = "FormUpdateMovies";
            Text = "FormUodateMovies";
            panelDirector.ResumeLayout(false);
            panelDirector.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelDirector;
        private Button btnUpMovie;
        private TextBox txtGender;
        private TextBox txtNameMovie;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lblID;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox txtDuration;
    }
}