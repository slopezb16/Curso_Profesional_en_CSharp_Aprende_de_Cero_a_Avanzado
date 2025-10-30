using System;

namespace SistemaPuntoDeVenta.UI.Generales
{
    public partial class Mantenimiento : FormBaseSalir
    {
        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }
    }
}
