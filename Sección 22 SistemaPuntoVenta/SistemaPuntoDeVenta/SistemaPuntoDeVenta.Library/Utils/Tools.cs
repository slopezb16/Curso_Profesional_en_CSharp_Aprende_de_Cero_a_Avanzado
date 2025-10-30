using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaPuntoDeVenta.Library.Utils
{
    public class Tools
    {
        private static readonly string cadena = ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString;

        // 🔹 Versión simple (como la que ya tienes)
        public static DataSet HerramientaConsulta(string cmd)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                conexion.Open();
                DataSet resultado = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd, conexion);
                adapter.Fill(resultado);
                return resultado;
            }
        }

        // 🔹 Versión segura con parámetros
        public static DataSet HerramientaConsulta(string cmd, SqlParameter[] parametros)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand(cmd, conexion))
                {
                    if (parametros != null)
                        command.Parameters.AddRange(parametros);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet resultado = new DataSet();
                        adapter.Fill(resultado);
                        return resultado;
                    }
                }
            }
        }

        //
        public static Boolean ValidarFormulario(Control ObjetoError, ErrorProvider ErrorProvider)
        {
            Boolean SiError = false;

            foreach (Control campo in ObjetoError.Controls)
            {
                if (campo is ErrorTxtBox)
                {
                    ErrorTxtBox objeto = (ErrorTxtBox)campo;

                    if (objeto.Validar == true)
                    {
                        if (string.IsNullOrEmpty(objeto.Text.Trim()))
                        {
                            ErrorProvider.SetError(objeto, "Los campos no pueden estar vacios");
                            SiError = true;
                        }
                    }
                    if (objeto.ValidarNumeros == true)
                    {
                        int contador = 0, EncontrarLetras = 0;

                        foreach (char letra in objeto.Text.Trim())
                        {
                            if (char.IsLetter(objeto.Text.Trim(), contador))
                            {
                                EncontrarLetras++;
                            }
                            contador++;
                        }
                        if (EncontrarLetras != 0)
                        {
                            SiError = true;
                            ErrorProvider.SetError(objeto, "Solo se aceptan números");

                        }
                    }
                }
            }
            return SiError;
        }
    }
}