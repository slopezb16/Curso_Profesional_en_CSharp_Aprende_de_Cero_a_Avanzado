using SistemaPuntoDeVenta.Library.Utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaPuntoDeVenta.UI.Generales
{
    public partial class ConsultarCliente : Consultas
    {
        public ConsultarCliente()
        {
            InitializeComponent();
        }

        private void ConsultarCliente_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MostrarInfoDG("Clientes").Tables[0];
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet DS;
                string buscar;

                // Obtener el texto limpio
                string texto = textBox1.Text.Trim();

                // Si hay texto, buscar por nombre
                if (!string.IsNullOrEmpty(texto))
                {
                    buscar = $"SELECT * FROM Clientes WHERE Nombre LIKE ('%{texto}%')";
                }
                else
                {
                    // Si no hay texto, mostrar todos los clientes
                    buscar = "SELECT * FROM Clientes";
                }

                // Ejecutar consulta
                DS = Tools.HerramientaConsulta(buscar);

                // Mostrar resultados en el DataGridView
                dataGridView1.DataSource = DS.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("❌ No se puede conectar. Error: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
