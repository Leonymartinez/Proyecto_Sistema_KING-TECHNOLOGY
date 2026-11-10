using System;

namespace Interfaz_KING_TECH.Modelos
{
    public class Producto
    {
        private int idProducto;
        private string nombre = "";

        private decimal precio;
        private int stock;
        private DateTime fechaRegistro;
        private int idCategoria;
        private string nombreCategoria = "";

        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public DateTime FechaRegistro
        {
            get { return fechaRegistro; }
            set { fechaRegistro = value; }
        }

        public int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }

        public string NombreCategoria
        {
            get { return nombreCategoria; }
            set { nombreCategoria = value; }
        }

        public decimal ValorInventario
        {
            get { return precio * stock; }
        }

        public Producto()
        {
        }

        public decimal CalcularValorInventario()
        {
            return precio * stock;
        }
    }
}