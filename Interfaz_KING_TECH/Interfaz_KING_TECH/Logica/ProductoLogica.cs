using Interfaz_KING_TECH.Datos;
using Interfaz_KING_TECH.Modelos;

namespace Interfaz_KING_TECH.Logica
{
    public class ProductoLogica
    {
        private ProductoDatos datos = new ProductoDatos();

        public string Guardar(Producto producto)
        {
            string error = Validar(producto);
            if (error != "")
            {
                return error;
            }

            producto.FechaRegistro = DateTime.Now;

            try
            {
                datos.Insertar(producto);
                return "";
            }
            catch (Exception)
            {
                return "No se pudo guardar el producto. Verifique la conexión con la base de datos.";
            }
        }

        public List<Producto> Consultar()
        {
            return datos.Listar();
        }

        public List<Producto> Buscar(string nombre)
        {
            return datos.Buscar(nombre.Trim());
        }

        public string Modificar(Producto producto)
        {
            string error = Validar(producto);
            if (error != "")
            {
                return error;
            }

            try
            {
                datos.Modificar(producto);
                return "";
            }
            catch (Exception)
            {
                return "No se pudo modificar el producto.";
            }
        }

        public string Eliminar(int idProducto)
        {
            try
            {
                datos.Eliminar(idProducto);
                return "";
            }
            catch (Exception)
            {
                return "No se pudo eliminar el producto.";
            }
        }

        private string Validar(Producto producto)
        {
            if (producto.Nombre.Trim() == "")
            {
                return "El nombre del producto es obligatorio.";
            }

            if (producto.Precio <= 0)
            {
                return "El precio debe ser mayor que cero.";
            }

            if (producto.Stock < 0)
            {
                return "El stock debe ser igual o mayor que cero.";
            }

            if (producto.IdCategoria <= 0)
            {
                return "Debe seleccionar una categoría.";
            }

            return "";
        }
    }
}