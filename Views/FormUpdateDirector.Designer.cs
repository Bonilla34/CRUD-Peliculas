namespace CRUD_Movies.Views
{
    partial class FormUpdateDirector
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
            label1 = new Label();
            lblID = new Label();
            txtAge = new TextBox();
            txtNameDirector = new TextBox();
            label8 = new Label();
            label9 = new Label();
            panelDirector = new Panel();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            btnUpDirector = new Button();
            label7 = new Label();
            panelDirector.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(260, 41);
            label1.TabIndex = 0;
            label1.Text = "Actualizar Director";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(12, 62);
            lblID.Name = "lblID";
            lblID.Size = new Size(136, 25);
            lblID.TabIndex = 1;
            lblID.Text = "Director con ID:";
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
            // panelDirector
            // 
            panelDirector.Controls.Add(groupBox1);
            panelDirector.Controls.Add(btnUpDirector);
            panelDirector.Controls.Add(txtAge);
            panelDirector.Controls.Add(txtNameDirector);
            panelDirector.Controls.Add(label7);
            panelDirector.Controls.Add(label8);
            panelDirector.Controls.Add(label9);
            panelDirector.Location = new Point(12, 90);
            panelDirector.Name = "panelDirector";
            panelDirector.Size = new Size(755, 304);
            panelDirector.TabIndex = 12;
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
            // btnUpDirector
            // 
            btnUpDirector.Location = new Point(299, 243);
            btnUpDirector.Name = "btnUpDirector";
            btnUpDirector.Size = new Size(112, 34);
            btnUpDirector.TabIndex = 9;
            btnUpDirector.Text = "Actualizar";
            btnUpDirector.UseVisualStyleBackColor = true;
            btnUpDirector.Click += btnUpDirector_Click;
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
            // FormUpdateDirector
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelDirector);
            Controls.Add(lblID);
            Controls.Add(label1);
            Name = "FormUpdateDirector";
            Text = "Form2";
            panelDirector.ResumeLayout(false);
            panelDirector.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblID;
        private TextBox txtAge;
        private TextBox txtNameDirector;
        private Label label8;
        private Label label9;
        private Panel panelDirector;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button3;
        private Button btnUpDirector;
        private DataGridView dataGridDirector;
        private Label label7;
        private Label label10;
    }
}