using Interfaz_KING_TECH.Datos;

namespace Interfaz_KING_TECH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();

            if (conexion.ProbarConexion())
            {
                MessageBox.Show("Conexión exitosa con SQL Server");
            }
            else
            {
                MessageBox.Show("No se pudo conectar con SQL Server");
            }
        }
    }
}
