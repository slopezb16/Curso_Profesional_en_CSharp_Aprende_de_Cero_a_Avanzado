using SistemaPuntoDeVenta.Library.Utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaPuntoDeVenta.UI.Generales
{
    public partial class Facturacion : Procesos
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        // ==============================
        // 🚀 EVENTO LOAD (INICIALIZACIÓN)
        // ==============================
        private void Facturacion_Load(object sender, EventArgs e)
        {
            CargarDatosVendedor();
        }

        // ==============================
        // 🔍 EVENTO BUSCAR CLIENTE
        // ==============================
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        // ==============================
        // ⚙️ MÉTODOS PRIVADOS
        // ==============================

        /// <summary>
        /// Carga los datos del vendedor activo según el código de Login.
        /// </summary>
        private void CargarDatosVendedor()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Login.Codigo))
                {
                    MessageBox.Show("⚠️ No se encontró información del usuario activo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = $"SELECT username FROM Usuarios WHERE IdUsuario = '{Login.Codigo}'";
                DataSet ds = Tools.HerramientaConsulta(query);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    lbVendedor.Text = ds.Tables[0].Rows[0]["username"].ToString().Trim();
                }
                else
                {
                    lbVendedor.Text = "Usuario desconocido";
                    MessageBox.Show("⚠️ No se encontraron datos del usuario en la base de datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al cargar datos del vendedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Busca un cliente en la base de datos por su código.
        /// </summary>
        private void BuscarCliente()
        {
            string codigo = txtCodigoCliente.Text.Trim();

            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("⚠️ Debes ingresar un código de cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoCliente.Focus();
                return;
            }

            try
            {
                string query = $"SELECT Nombre, Apellido FROM Clientes WHERE IdCliente = '{codigo}'";
                DataSet ds = Tools.HerramientaConsulta(query);

                if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("❌ Cliente no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCliente.Clear();
                    txtCodigoCliente.Focus();
                    return;
                }

                DataRow cliente = ds.Tables[0].Rows[0];
                txtCliente.Text = $"{cliente["Nombre"].ToString().Trim()} {cliente["Apellido"].ToString().Trim()}";
                txtCodigoProducto.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al buscar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ====================================
        // 🫳 COLOCAR PRODUCTO SELECCIONADO
        // ====================================
        public static int contadorFila = 0;
        public static double total = 0;

        private void btnColocar_Click(object sender, EventArgs e)
        {
            // 🧩 Validar campos obligatorios
            if (Tools.ValidarFormulario(this, errorProvider1))
                return;

            // ✅ Validar que los valores numéricos sean correctos
            if (!double.TryParse(txtPrecio.Text, out double precio))
            {
                MessageBox.Show("⚠️ El precio ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtCantidad.Text, out double cantidad))
            {
                MessageBox.Show("⚠️ La cantidad ingresada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string codigo = txtCodigoProducto.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();

            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("⚠️ Debes ingresar un código de producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool existe = false;
            int filaExistente = -1;

            // 🔍 Buscar si el producto ya está en la lista
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.Cells[0].Value != null && fila.Cells[0].Value.ToString() == codigo)
                {
                    existe = true;
                    filaExistente = fila.Index;
                    break;
                }
            }

            // 🧮 Calcular importe (precio * cantidad)
            double importe = precio * cantidad;

            if (existe)
            {
                // 🔁 Actualizar la fila existente
                double cantidadActual = Convert.ToDouble(dataGridView1.Rows[filaExistente].Cells[3].Value);
                cantidadActual += cantidad;

                dataGridView1.Rows[filaExistente].Cells[3].Value = cantidadActual;
                dataGridView1.Rows[filaExistente].Cells[4].Value = precio * cantidadActual;
            }
            else
            {
                // ➕ Agregar nueva fila
                dataGridView1.Rows.Add(codigo, descripcion, precio, cantidad, importe);
                contadorFila++;
            }

            // 💰 Recalcular total
            RecalcularTotal();

            // 🧹 Limpiar campos del producto
            LimpiarCamposProducto();
        }

        private void RecalcularTotal()
        {
            total = 0;
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.Cells[4].Value != null)
                    total += Convert.ToDouble(fila.Cells[4].Value);
            }

            lbTotal.Text = $"USD$ {total:N2}";
        }

        private void LimpiarCamposProducto()
        {
            txtCodigoProducto.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtCodigoProducto.Focus();
        }

        // ====================================
        // 🗑️ ELIMINAR PRODUCTO SELECCIONADO
        // ====================================
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.Rows.Count == 0)
                return;

            if (MessageBox.Show("¿Deseas eliminar este producto de la lista?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                total -= Convert.ToDouble(dataGridView1.CurrentRow.Cells[4].Value);
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                contadorFila--;

                lbTotal.Text = $"USD$ {total:N2}";
            }
        }

        // ====================================
        // 👥 CONSULTAR CLIENTES
        // ====================================
        private void btnClientes_Click(object sender, EventArgs e)
        {
            using (var frm = new ConsultarCliente())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    txtCodigoCliente.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    txtCliente.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txtCodigoProducto.Focus();
                }
            }
        }

        // ====================================
        // 📦 CONSULTAR PRODUCTOS
        // ====================================
        private void btnProductos_Click(object sender, EventArgs e)
        {
            using (var frm = new ConsultarProductos())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    txtCodigoProducto.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txtDescripcion.Text = frm.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    txtPrecio.Text = frm.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    txtCantidad.Focus();
                }
            }
        }

        // ====================================
        // 🆕 NUEVA FACTURA
        // ====================================
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        public override void Nuevo()
        {
            txtCodigoCliente.Clear();
            txtCliente.Clear();
            txtCodigoProducto.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            lbTotal.Text = "USD$ 0.00";

            dataGridView1.Rows.Clear();
            contadorFila = 0;
            total = 0;

            txtCodigoCliente.Focus();
        }

        // ====================================
        // 🧾 FACTURAR
        // ====================================
        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (contadorFila == 0)
            {
                MessageBox.Show("⚠️ No hay productos en la factura.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string cmd = $"EXEC ActualizarFacturas '{txtCodigoCliente.Text.Trim()}'";
                DataSet ds = Tools.HerramientaConsulta(cmd);

                string numeroFactura = ds.Tables[0].Rows[0]["NumeroFactura"].ToString().Trim();

                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    cmd = $"EXEC ActualizarDetalles '{numeroFactura}', '{fila.Cells[0].Value}', '{fila.Cells[2].Value}', '{fila.Cells[3].Value}'";
                    Tools.HerramientaConsulta(cmd);
                }

                // Mostrar reporte
                cmd = $"EXEC DatosFactura {numeroFactura}";
                ds = Tools.HerramientaConsulta(cmd);

                //Factura frmFactura = new Factura();
                //frmFactura.reportViewer1.LocalReport.DataSources[0].Value = ds.Tables[0];
                //frmFactura.ShowDialog();

                Nuevo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al generar factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}