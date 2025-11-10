namespace CRUD.WindowsForms
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            Insertar = new Button();
            Actualizar = new Button();
            Borrar = new Button();
            LimpiarCeldas = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(103, 345);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(982, 297);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(103, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(982, 181);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(783, 54);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 7;
            label4.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(542, 54);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 6;
            label3.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(285, 54);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 5;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 54);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(783, 106);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(542, 106);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(285, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(63, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(543, 64);
            label5.Name = "label5";
            label5.Size = new Size(227, 38);
            label5.TabIndex = 8;
            label5.Text = "Base Empleados";
            // 
            // Insertar
            // 
            Insertar.Location = new Point(1184, 130);
            Insertar.Name = "Insertar";
            Insertar.Size = new Size(112, 34);
            Insertar.TabIndex = 9;
            Insertar.Text = "Insertar";
            Insertar.UseVisualStyleBackColor = true;
            Insertar.Click += Insertar_Click;
            // 
            // Actualizar
            // 
            Actualizar.Location = new Point(1184, 218);
            Actualizar.Name = "Actualizar";
            Actualizar.Size = new Size(112, 34);
            Actualizar.TabIndex = 10;
            Actualizar.Text = "Actualizar";
            Actualizar.UseVisualStyleBackColor = true;
            Actualizar.Click += Actualizar_Click;
            // 
            // Borrar
            // 
            Borrar.Location = new Point(1184, 301);
            Borrar.Name = "Borrar";
            Borrar.Size = new Size(112, 34);
            Borrar.TabIndex = 11;
            Borrar.Text = "Borrar";
            Borrar.UseVisualStyleBackColor = true;
            Borrar.Click += Borrar_Click;
            // 
            // LimpiarCeldas
            // 
            LimpiarCeldas.Location = new Point(1148, 387);
            LimpiarCeldas.Name = "LimpiarCeldas";
            LimpiarCeldas.Size = new Size(190, 34);
            LimpiarCeldas.TabIndex = 12;
            LimpiarCeldas.Text = "Limpiar Celdas";
            LimpiarCeldas.UseVisualStyleBackColor = true;
            LimpiarCeldas.Click += LimpiarCeldas_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo2;
            ClientSize = new Size(1414, 693);
            Controls.Add(LimpiarCeldas);
            Controls.Add(Borrar);
            Controls.Add(Actualizar);
            Controls.Add(Insertar);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Button Insertar;
        private Button Actualizar;
        private Button Borrar;
        private Button LimpiarCeldas;
    }
}
