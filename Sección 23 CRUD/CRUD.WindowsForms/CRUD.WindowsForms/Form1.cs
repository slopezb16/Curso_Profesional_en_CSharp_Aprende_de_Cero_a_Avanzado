using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUD.WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ============================
        // 🚀 EVENTO LOAD (INICIALIZACIÓN)
        // ============================
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
                MessageBox.Show("✅ Conexión exitosa a la base de datos.", "Conectado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error al conectar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================
        // 📦 MÉTODOS CRUD
        // ============================

        /// <summary>
        /// Obtiene todos los empleados de la base de datos y los muestra en el DataGridView.
        /// </summary>
        private void CargarDatos()
        {
            try
            {
                using (SqlConnection conn = BD.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT * FROM Empleados";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error al cargar los datos: {ex.Message}");
            }
        }

        /// <summary>
        /// Inserta un nuevo registro en la tabla Empleados.
        /// </summary>
        private void Insertar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = BD.ObtenerConexion())
                {
                    conn.Open();
                    string query = "INSERT INTO Empleados (Codigo, Nombre, Apellido, Direccion) VALUES (@Codigo, @Nombre, @Apellido, @Direccion)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nombre", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@Apellido", textBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@Codigo", textBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@Direccion", textBox4.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("✅ Registro insertado correctamente.");
                    CargarDatos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error al insertar: {ex.Message}");
            }
        }

        /// <summary>
        /// Actualiza un registro existente según su código.
        /// </summary>
        private void Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = BD.ObtenerConexion())
                {
                    conn.Open();
                    string query = "UPDATE Empleados SET Nombre=@Nombre, Apellido=@Apellido, Direccion=@Direccion WHERE Codigo=@Codigo";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Nombre", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@Apellido", textBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@Codigo", textBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@Direccion", textBox4.Text.Trim());

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("✅ Registro actualizado correctamente.");
                    else
                        MessageBox.Show("⚠️ No se encontró un registro con ese código.");

                    CargarDatos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error al actualizar: {ex.Message}");
            }
        }

        /// <summary>
        /// Elimina un registro de la tabla según su código.
        /// </summary>
        private void Borrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("⚠️ Debes ingresar un código para eliminar.");
                    return;
                }

                using (SqlConnection conn = BD.ObtenerConexion())
                {
                    conn.Open();
                    string query = "DELETE FROM Empleados WHERE Codigo=@Codigo";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Codigo", textBox3.Text.Trim());

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                        MessageBox.Show("🗑️ Registro eliminado correctamente.");
                    else
                        MessageBox.Show("⚠️ No existe un registro con ese código.");

                    CargarDatos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error al eliminar: {ex.Message}");
            }
        }

        /// <summary>
        /// Limpia todos los TextBox del formulario.
        /// </summary>
        private void LimpiarCeldas_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        /// <summary>
        /// Seleccionar del gridview y llenar los textbox.
        /// </summary>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value?.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value?.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells["Codigo"].Value?.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value?.ToString();
            }
        }
    }
}