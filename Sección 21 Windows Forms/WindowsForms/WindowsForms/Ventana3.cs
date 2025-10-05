using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Ventana3 : Form
    {
        private Dictionary<string, Image> imagenesProductos;

        public Ventana3()
        {
            InitializeComponent();
            InicializarImagenes();
            ConfigurarEventos();
        }

        private void InicializarImagenes()
        {
            // Asigna tus imágenes desde los recursos
            imagenesProductos = new Dictionary<string, Image>
            {
                { "Iphone16ProMax", Properties.Resources.Iphone16ProMax },   // ← debes tener imagenes en Resources
                { "SamsungGalaxyS23Ultra", Properties.Resources.GalaxyS23Ultra },
                { "XiaomiMI15", Properties.Resources.XiaomiMI15 },
                { "MotoG7Plus", Properties.Resources.MotoG7Plus},
                { "HuaweiP30", Properties.Resources.HuaweiP30 },
                { "Prueba", Properties.Resources.img1 },   // ← debes tener imagenes en Resources
            };
        }

        private void ConfigurarEventos()
        {
            listBox1.SelectedIndexChanged += (s, e) => MostrarImagen(listBox1.SelectedItem?.ToString());
            comboBox1.SelectedIndexChanged += (s, e) => MostrarImagen(comboBox1.SelectedItem?.ToString());
        }

        private void MostrarImagen(string producto)
        {
            if (string.IsNullOrEmpty(producto)) return;

            if (imagenesProductos.ContainsKey(producto))
            {
                pictureBox1.Image = imagenesProductos[producto];
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                MessageBox.Show("⚠️ No hay imagen disponible para este producto.", "Sin imagen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Image = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productoSeleccionado = listBox1.SelectedItem?.ToString() ?? comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(productoSeleccionado))
            {
                MessageBox.Show("❗ Por favor selecciona un producto primero.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"✅ Has seleccionado: {productoSeleccionado}", "Producto Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas volver al menú anterior?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Ventana2 v2 = new Ventana2();
                v2.Show();
            }
        }
    }
}