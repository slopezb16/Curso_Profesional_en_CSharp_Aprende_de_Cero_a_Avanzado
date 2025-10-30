using SistemaPuntoDeVenta.Library.Utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaPuntoDeVenta.UI.Generales
{
    public partial class ConsultarProductos : Consultas
    {
        public ConsultarProductos()
        {
            InitializeComponent();
        }

        private void ConsultarProductos_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MostrarInfoDG("Articulos").Tables[0];
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet DS;
                string buscar;

                // Si el TextBox NO está vacío → buscar por nombre
                if (!string.IsNullOrEmpty(textBox1.Text.Trim()))
                {
                    buscar = "SELECT * FROM Articulos WHERE Nombre LIKE ('%" + textBox1.Text.Trim() + "%')";
                }
                else
                {
                    // Si está vacío → mostrar todo
                    buscar = "SELECT * FROM Articulos";
                }

                DS = Tools.HerramientaConsulta(buscar);
                dataGridView1.DataSource = DS.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("No se puede conectar. Error: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
