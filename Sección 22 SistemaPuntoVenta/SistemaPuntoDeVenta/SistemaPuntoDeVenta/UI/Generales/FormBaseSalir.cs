using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPuntoDeVenta.UI
{
    public partial class FormBaseSalir : Form
    {
        public FormBaseSalir()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas salir del sistema?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1
            );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                // No hacer nada, el usuario canceló
            }
        }

        public virtual void Eliminar()
        {

        }

        public virtual void Nuevo()
        {

        }

        public virtual void Consultar()
        {

        }

        public virtual Boolean Guardar()
        {

            return false;
        }
    }
}
