using System.Data.SqlClient;

namespace CRUD.WindowsForms
{
    public static class BD
    {
        private static readonly string connectionString =
            "Data Source=SLB;Initial Catalog=RegistroEmpleados;User ID=slopezb;Password=Santy990*++;TrustServerCertificate=True;";

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}