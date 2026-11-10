using Microsoft.Data.SqlClient;
using Interfaz_KING_TECH.Modelos;

namespace Interfaz_KING_TECH.Datos
{
    public class ProductoDatos
    {
        private Conexion conexion = new Conexion();

        public void Insertar(Producto producto)
        {
            SqlConnection con = conexion.ObtenerConexion();
            string sql = "INSERT INTO Productos (Nombre, Precio, Stock, FechaRegistro, IdCategoria) VALUES (@Nombre, @Precio, @Stock, @FechaRegistro, @IdCategoria)";
            SqlCommand comando = new SqlCommand(sql, con);
            comando.Parameters.AddWithValue("@Nombre", producto.Nombre);
            comando.Parameters.AddWithValue("@Precio", producto.Precio);
            comando.Parameters.AddWithValue("@Stock", producto.Stock);
            comando.Parameters.AddWithValue("@FechaRegistro", producto.FechaRegistro);
            comando.Parameters.AddWithValue("@IdCategoria", producto.IdCategoria);

            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

        public List<Producto> Buscar(string nombre)
        {
            List<Producto> lista = new List<Producto>();
            SqlConnection con = conexion.ObtenerConexion();
            string sql = "SELECT p.IdProducto, p.Nombre, p.Precio, p.Stock, p.FechaRegistro, p.IdCategoria, c.Nombre " +
                         "FROM Productos p INNER JOIN Categorias c ON p.IdCategoria = c.IdCategoria " +
                         "WHERE p.Nombre LIKE @Nombre";
            SqlCommand comando = new SqlCommand(sql, con);
            comando.Parameters.AddWithValue("@Nombre", "%" + nombre + "%");

            con.Open();
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Producto producto = new Producto();
                producto.IdProducto = lector.GetInt32(0);
                producto.Nombre = lector.GetString(1);
                producto.Precio = lector.GetDecimal(2);
                producto.Stock = lector.GetInt32(3);
                producto.FechaRegistro = lector.GetDateTime(4);
                producto.IdCategoria = lector.GetInt32(5);
                producto.NombreCategoria = lector.GetString(6);
                lista.Add(producto);
            }
            con.Close();

            return lista;
        }

        public List<Producto> Listar()
        {
            return Buscar("");
        }

        public void Modificar(Producto producto)
        {
            SqlConnection con = conexion.ObtenerConexion();
            string sql = "UPDATE Productos SET Nombre = @Nombre, Precio = @Precio, Stock = @Stock, IdCategoria = @IdCategoria WHERE IdProducto = @IdProducto";
            SqlCommand comando = new SqlCommand(sql, con);
            comando.Parameters.AddWithValue("@Nombre", producto.Nombre);
            comando.Parameters.AddWithValue("@Precio", producto.Precio);
            comando.Parameters.AddWithValue("@Stock", producto.Stock);
            comando.Parameters.AddWithValue("@IdCategoria", producto.IdCategoria);
            comando.Parameters.AddWithValue("@IdProducto", producto.IdProducto);

            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void Eliminar(int idProducto)
        {
            SqlConnection con = conexion.ObtenerConexion();
            string sql = "DELETE FROM Productos WHERE IdProducto = @IdProducto";
            SqlCommand comando = new SqlCommand(sql, con);
            comando.Parameters.AddWithValue("@IdProducto", idProducto);

            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }
    }
}