using System;
using System.Windows.Forms;
using SistemaPuntoDeVenta.Library.Utils; // Asegúrate de tener esta referencia

namespace SistemaPuntoDeVenta.UI.Generales
{
    public partial class MantenimientoProductos : Mantenimiento
    {
        public MantenimientoProductos()
        {
            InitializeComponent();
        }

        // 👉 Evento al cargar el formulario
        private void MantenimientoProductos_Load(object sender, EventArgs e)
        {
            // Aquí podrías inicializar algo si lo necesitas
        }

        // 👉 MÉTODO GUARDAR
        public override bool Guardar()
        {
            if (Tools.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {
                    // Construimos el comando SQL usando tu procedimiento almacenado
                    string insertar = string.Format(
                        "EXEC ActualizarArticulos {0}, '{1}', '{2}', '{3}', {4}, {5}",
                        textId_Articulo.Text.Trim(),
                        textCodigo.Text.Trim(),
                        textNombre.Text.Trim(),
                        textDescripcion.Text.Trim(),
                        textPrecio.Text.Trim(),
                        textStock.Text.Trim()
                    );

                    Tools.HerramientaConsulta(insertar);
                    MessageBox.Show("✅ Artículo guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                catch (Exception error)
                {
                    MessageBox.Show("❌ Ha ocurrido un error al guardar: " + error.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        // 👉 MÉTODO ELIMINAR
        public override void Eliminar()
        {
            try
            {
                string eliminar = string.Format("EXEC EliminarArticulos {0}", textId_Articulo.Text.Trim());
                Tools.HerramientaConsulta(eliminar);
                MessageBox.Show("🗑️ Artículo eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show("❌ Ha ocurrido un error al eliminar: " + error.Message);
            }
        }

        // 👉 LIMPIAR CAMPOS (Botón Nuevo)
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            textId_Articulo.Text = "";
            textCodigo.Text = "";
            textNombre.Text = "";
            textDescripcion.Text = "";
            textPrecio.Text = "";
            textStock.Text = "";
            //errorProvider1.Clear();
        }

        // 👉 GUARDAR (Botón Guardar)
        //private void btnGuardar_Click(object sender, EventArgs e)
        //{
        //    Guardar();
        //}

        // 👉 ELIMINAR (Botón Eliminar)
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Seguro que deseas eliminar este artículo?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                Eliminar();
            }
        }

        // 👉 CONSULTAR (Botón Consultar)
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarProductos consulta = new ConsultarProductos();
            consulta.Show();
        }

        private void textId_Articulo_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void textCodigo_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void textDescripcion_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void textPrecio_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void textStock_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}