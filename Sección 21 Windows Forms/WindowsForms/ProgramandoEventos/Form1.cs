using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramandoEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Programando Eventos 🧠";
            this.BackColor = System.Drawing.Color.Beige;

            // Crear un botón dinámicamente
            Button btnSaludo = new Button
            {
                Text = "Saludar",
                Location = new System.Drawing.Point(50, 50),
                AutoSize = true
            };

            // Asociar un evento (programar el evento Click)
            btnSaludo.Click += button1_Click;

            // Agregar el botón al formulario
            this.Controls.Add(btnSaludo);
        }

        // Evento Click del botón
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Hola! Has hecho clic en el botón.", "Evento Click");
        }
    }
}
