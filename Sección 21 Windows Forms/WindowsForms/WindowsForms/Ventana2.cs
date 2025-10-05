using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Ventana2 : Form
    {
        public Ventana2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // --- Productos seleccionados ---
            List<string> productos = new List<string>();

            if (checkBox1.Checked) productos.Add("MacBook Pro");
            if (checkBox2.Checked) productos.Add("HP Pavilion");
            if (checkBox3.Checked) productos.Add("Lenovo Legion");
            if (checkBox4.Checked) productos.Add("Asus Strix Rog");

            // --- Validar que haya al menos un producto ---
            if (productos.Count == 0)
            {
                MessageBox.Show("⚠️ Debes seleccionar al menos un producto.", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- Método de pago ---
            string metodoPago = "";
            if (radioButton1.Checked) metodoPago = "Tarjeta de crédito";
            else if (radioButton2.Checked) metodoPago = "Tarjeta de débito";

            // --- Validar método de pago ---
            if (string.IsNullOrEmpty(metodoPago))
            {
                MessageBox.Show("💳 Debes seleccionar un método de pago.", "Carrito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- Mostrar resumen de compra ---
            string resumen = "Productos seleccionados:\n" +
                             string.Join("\n", productos.Select(p => "• " + p)) +
                             $"\n\nMétodo de pago: {metodoPago}";

            MessageBox.Show(resumen, "🛍️ Resumen de compra", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // --- Confirmación ---
            DialogResult confirmar = MessageBox.Show("¿Deseas confirmar la compra?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                MessageBox.Show("✅ ¡Compra realizada con éxito!", "Gracias por tu compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Limpia selección si quieres
                LimpiarFormulario();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Confirmar si desea volver al login
            DialogResult result = MessageBox.Show("¿Deseas volver al login?", "Volver", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }

        private void LimpiarFormulario()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ventana3 ventana = new Ventana3();
            ventana.Show();
        }
    }
}