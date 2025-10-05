using System;
using System.Windows.Forms;

namespace ContenedorMDI
{
    public partial class Form2 : Form
    {
        private Timer timer = new Timer();

        public Form2()
        {
            InitializeComponent();

            // Configurar el timer
            timer.Interval = 100; // cada 100 ms
            timer.Tick += Timer_Tick;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Formulario Hijo";
            this.BackColor = System.Drawing.Color.LightSteelBlue;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void IniciarCarga_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
                progressBar1.Value += 5;
            else
                timer.Stop();
        }
    }
}