using SistemaPuntoDeVenta.Library.Utils;
using System;
using System.Windows.Forms;

namespace SistemaPuntoDeVenta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Consulta_Click(object sender, EventArgs e)
        {
            Tools.HerramientaConsulta("SELECT * FROM [SistemaPuntoDeVenta].[dbo].[Clientes]" +
                "WHERE IdCliente = 1");
        }
    }
}