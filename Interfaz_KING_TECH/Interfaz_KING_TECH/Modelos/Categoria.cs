namespace Interfaz_KING_TECH.Modelos
{
    public class Categoria
    {
        private int idCategoria;
        private string nombre = "";
        private string descripcion = "";

        public int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public Categoria()
        {
        }

        public Categoria(int idCategoria, string nombre, string descripcion)
        {
            this.idCategoria = idCategoria;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
    }
}