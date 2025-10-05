using System;
using System.Windows.Forms;

namespace ContenedorMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Evento: abrir nuevo formulario hijo
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Creamos y abrimos Form2 como formulario hijo
            Form2 childForm = new Form2
            {
                MdiParent = this,
                Text = "Documento " + MdiChildren.Length
            };
            childForm.Show();
        }

        // Evento: cerrar la ventana activa dentro del contenedor
        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
        }

        // Evento: guardar (ejemplo básico)
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simulación de guardado de archivo...", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Evento: salir completamente del programa
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}