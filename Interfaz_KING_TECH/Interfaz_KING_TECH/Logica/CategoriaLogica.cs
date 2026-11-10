using Interfaz_KING_TECH.Datos;
using Interfaz_KING_TECH.Modelos;

namespace Interfaz_KING_TECH.Logica
{
    public class CategoriaLogica
    {
        private CategoriaDatos datos = new CategoriaDatos();

        public string Guardar(Categoria categoria)
        {
            string error = Validar(categoria);
            if (error != "")
            {
                return error;
            }

            try
            {
                datos.Insertar(categoria);
                return "";
            }
            catch (Exception)
            {
                return "No se pudo guardar la categoría. Verifique la conexión con la base de datos.";
            }
        }

        public List<Categoria> Consultar()
        {
            return datos.Listar();
        }

        public string Modificar(Categoria categoria)
        {
            string error = Validar(categoria);
            if (error != "")
            {
                return error;
            }

            try
            {
                datos.Modificar(categoria);
                return "";
            }
            catch (Exception)
            {
                return "No se pudo modificar la categoría.";
            }
        }

        public string Eliminar(int idCategoria)
        {
            try
            {
                datos.Eliminar(idCategoria);
                return "";
            }
            catch (Exception)
            {
                return "No se puede eliminar la categoría. Es posible que tenga productos asociados.";
            }
        }

        private string Validar(Categoria categoria)
        {
            if (categoria.Nombre.Trim() == "")
            {
                return "El nombre de la categoría es obligatorio.";
            }

            if (categoria.Descripcion.Trim() == "")
            {
                return "La descripción de la categoría es obligatoria.";
            }

            return "";
        }
    }
}