using System;
using System.Windows.Forms;
using SistemaPuntoDeVenta.Library.Utils; // Asegúrate de tener esta referencia

namespace SistemaPuntoDeVenta.UI.Generales
{
    public partial class MantenimientoClientes : Mantenimiento
    {
        public MantenimientoClientes()
        {
            InitializeComponent();
        }

        // 👉 Evento al cargar el formulario
        private void MantenimientoClientes_Load(object sender, EventArgs e)
        {
            // Aquí puedes inicializar algo si es necesario
        }

        // 👉 MÉTODO GUARDAR
        public override bool Guardar()
        {
            if (Tools.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {
                    // Construimos el comando SQL usando el procedimiento almacenado
                    string insertar = string.Format(
                        "EXEC ActualizarClientes {0}, '{1}', '{2}'",
                        string.IsNullOrWhiteSpace(textId_Cliente.Text) ? "0" : textId_Cliente.Text.Trim(),
                        textNombre.Text.Trim(),
                        textApellido.Text.Trim()
                    );

                    Tools.HerramientaConsulta(insertar);
                    MessageBox.Show("✅ Cliente guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (string.IsNullOrWhiteSpace(textId_Cliente.Text))
                {
                    MessageBox.Show("⚠️ Debes ingresar un ID de cliente válido para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string eliminar = string.Format("EXEC EliminarClientes {0}", textId_Cliente.Text.Trim());
                Tools.HerramientaConsulta(eliminar);
                MessageBox.Show("🗑️ Cliente eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show("❌ Ha ocurrido un error al eliminar: " + error.Message);
            }
        }

        // 👉 LIMPIAR CAMPOS (Botón Nuevo)
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            textId_Cliente.Text = "";
            textNombre.Text = "";
            textApellido.Text = "";
        }

        // 👉 GUARDAR (Botón Guardar)
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        // 👉 ELIMINAR (Botón Eliminar)
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textId_Cliente.Text))
            {
                MessageBox.Show("⚠️ Debes ingresar un ID de cliente válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "¿Seguro que deseas eliminar este cliente?",
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
            // Aquí puedes abrir un formulario de consulta si lo necesitas
            // ConsultarClientes consulta = new ConsultarClientes();
            // consulta.Show();
        }

        private void textId_Cliente_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void textApellido_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            ConsultarCliente ConsulClien = new ConsultarCliente();
            ConsulClien.Show();
        }
    }
}