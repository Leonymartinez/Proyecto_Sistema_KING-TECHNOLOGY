using Microsoft.Data.SqlClient;
using Interfaz_KING_TECH.Modelos;

namespace Interfaz_KING_TECH.Datos
{
    public class CategoriaDatos
    {
        private Conexion conexion = new Conexion();

        public void Insertar(Categoria categoria)
        {
            SqlConnection con = conexion.ObtenerConexion();
            string sql = "INSERT INTO Categorias (Nombre, Descripcion) VALUES (@Nombre, @Descripcion)";
            SqlCommand comando = new SqlCommand(sql, con);
            comando.Parameters.AddWithValue("@Nombre", categoria.Nombre);
            comando.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);

            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();
            SqlConnection con = conexion.ObtenerConexion();
            string sql = "SELECT IdCategoria, Nombre, Descripcion FROM Categorias";
            SqlCommand comando = new SqlCommand(sql, con);

            con.Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Categoria categoria = new Categoria();
                categoria.IdCategoria = lector.GetInt32(0);
                categoria.Nombre = lector.GetString(1);
                categoria.Descripcion = lector.GetString(2);
                lista.Add(categoria);
            }
            con.Close();

            return lista;
        }

        public void Modificar(Categoria categoria)
        {
            SqlConnection con = conexion.ObtenerConexion();
            string sql = "UPDATE Categorias SET Nombre = @Nombre, Descripcion = @Descripcion WHERE IdCategoria = @IdCategoria";
            SqlCommand comando = new SqlCommand(sql, con);
            comando.Parameters.AddWithValue("@Nombre", categoria.Nombre);
            comando.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
            comando.Parameters.AddWithValue("@IdCategoria", categoria.IdCategoria);

            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void Eliminar(int idCategoria)
        {
            SqlConnection con = conexion.ObtenerConexion();
            string sql = "DELETE FROM Categorias WHERE IdCategoria = @IdCategoria";
            SqlCommand comando = new SqlCommand(sql, con);
            comando.Parameters.AddWithValue("@IdCategoria", idCategoria);

            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }
    }
}