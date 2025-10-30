using System.Configuration;
using System.Data.SqlClient;

namespace SistemaPuntoDeVenta.Library.Data
{
    public class Conexion
    {
        //private static string cadena = "Data Source=SLB;Initial Catalog=SistemaPuntoDeVenta;Persist Security Info=True;User ID=slopezb;Password=Santy990*++";

        private static readonly string cadena = ConfigurationManager.ConnectionStrings["ConexionSQL"].ConnectionString;

        /// <summary>
        /// Opens and returns a SQL connection.
        /// </summary>
        public static SqlConnection GetConnection()
        {
            SqlConnection conexion = new SqlConnection(cadena);
            try
            {
                conexion.Open();
                return conexion;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Tests if the database connection can be established successfully.
        /// </summary>
        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}