using SistemaPuntoDeVenta.Library.Data;
using SistemaPuntoDeVenta.UI;
using System;
using System.Windows.Forms;

namespace SistemaPuntoDeVenta
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 🔹 Probar conexión al inicio
            if (!Conexion.TestConnection())
            {
                MessageBox.Show(
                    "No se pudo establecer conexión con la base de datos. Verifica la configuración.",
                    "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Cancela la ejecución de la app
            }
            else
            {
                MessageBox.Show(
                    "Conexión exitosa con la base de datos.",
                    "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Application.Run(new Login());
        }
    }
}
