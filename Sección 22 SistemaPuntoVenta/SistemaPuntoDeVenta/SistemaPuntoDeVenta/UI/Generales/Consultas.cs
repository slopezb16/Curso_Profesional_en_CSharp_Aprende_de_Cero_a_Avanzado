using SistemaPuntoDeVenta.Library.Utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaPuntoDeVenta.UI.Generales
{
    public partial class Consultas : FormBaseSalir
    {
        public Consultas()
        {
            InitializeComponent();
        }

        public DataSet MostrarInfoDG(string tabla)
        {
            DataSet DS;
            string cmd = string.Format("SELECT * FROM " + tabla);
            DS = Tools.HerramientaConsulta(cmd);

            return DS;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}