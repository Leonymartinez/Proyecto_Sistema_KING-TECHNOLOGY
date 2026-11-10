using Microsoft.Data.SqlClient;

namespace Interfaz_KING_TECH.Datos
{
    public class Conexion
    {
        private string cadenaConexion = "Server=.\\SQLEXPRESS;Database=KingTechnologyDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }

        public bool ProbarConexion()
        {
            try
            {
                SqlConnection conexion = ObtenerConexion();
                conexion.Open();
                conexion.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}