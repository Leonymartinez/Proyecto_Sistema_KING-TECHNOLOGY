using Interfaz_KING_TECH.Logica;
using Interfaz_KING_TECH.Modelos;

namespace Interfaz_KING_TECH.Interfaz
{
    public partial class FrmProductos : Form
    {
        private ProductoLogica productoLogica = new ProductoLogica();
        private CategoriaLogica categoriaLogica = new CategoriaLogica();
        private int idSeleccionado = 0;

        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarProductos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Producto> resultado = productoLogica.Buscar(txtBuscar.Text);

                if (resultado.Count == 0)
                {
                    MessageBox.Show("No se encontraron productos con ese nombre.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProductos();
                }
                else
                {
                    MostrarProductos(resultado);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo realizar la búsqueda. Verifique la conexión con la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            Producto producto = ObtenerProducto();
            string error = productoLogica.Guardar(producto);

            if (error == "")
            {
                MessageBox.Show("Producto guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarProductos();
            }
            else
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un producto de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCampos())
            {
                return;
            }

            Producto producto = ObtenerProducto();
            producto.IdProducto = idSeleccionado;
            string error = productoLogica.Modificar(producto);

            if (error == "")
            {
                MessageBox.Show("Producto modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarProductos();
            }
            else
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un producto de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar el producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                string error = productoLogica.Eliminar(idSeleccionado);

                if (error == "")
                {
                    MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarProductos();
                }
                else
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            txtBuscar.Clear();
            CargarProductos();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];
                idSeleccionado = Convert.ToInt32(fila.Cells["IdProducto"].Value);
                txtNombre.Text = Convert.ToString(fila.Cells["Nombre"].Value);
                txtPrecio.Text = Convert.ToString(fila.Cells["Precio"].Value);
                txtStock.Text = Convert.ToString(fila.Cells["Stock"].Value);
                cmbCategoria.SelectedValue = Convert.ToInt32(fila.Cells["IdCategoria"].Value);
                errorProvider.Clear();
            }
        }
        private void lblBuscar_Click(object sender, EventArgs e)
        {

        }

        private void CargarCategorias()
        {
            try
            {
                cmbCategoria.DisplayMember = "Nombre";
                cmbCategoria.ValueMember = "IdCategoria";
                cmbCategoria.DataSource = categoriaLogica.Consultar();
                cmbCategoria.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudieron cargar las categorías. Verifique la conexión con la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProductos()
        {
            try
            {
                MostrarProductos(productoLogica.Consultar());
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudieron cargar los productos. Verifique la conexión con la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarProductos(List<Producto> lista)
        {
            dgvProductos.DataSource = lista;
            dgvProductos.Columns["IdCategoria"].Visible = false;
            dgvProductos.Columns["IdProducto"].HeaderText = "ID";
            dgvProductos.Columns["FechaRegistro"].HeaderText = "Fecha de registro";
            dgvProductos.Columns["NombreCategoria"].HeaderText = "Categoría";
            dgvProductos.Columns["ValorInventario"].HeaderText = "Valor del inventario";
            dgvProductos.Columns["Precio"].DefaultCellStyle.Format = "N2";
            dgvProductos.Columns["ValorInventario"].DefaultCellStyle.Format = "N2";
        }

        private Producto ObtenerProducto()
        {
            Producto producto = new Producto();
            producto.Nombre = txtNombre.Text.Trim();
            producto.Precio = Convert.ToDecimal(txtPrecio.Text);
            producto.Stock = Convert.ToInt32(txtStock.Text);
            producto.IdCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
            return producto;
        }

        private bool ValidarCampos()
        {
            bool valido = true;
            errorProvider.Clear();

            if (txtNombre.Text.Trim() == "")
            {
                errorProvider.SetError(txtNombre, "El nombre es obligatorio.");
                valido = false;
            }

            decimal precio;
            if (txtPrecio.Text.Trim() == "")
            {
                errorProvider.SetError(txtPrecio, "El precio es obligatorio.");
                valido = false;
            }
            else if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                errorProvider.SetError(txtPrecio, "El precio debe ser un número válido.");
                valido = false;
            }
            else if (precio <= 0)
            {
                errorProvider.SetError(txtPrecio, "El precio debe ser mayor que cero.");
                valido = false;
            }

            int stock;
            if (txtStock.Text.Trim() == "")
            {
                errorProvider.SetError(txtStock, "El stock es obligatorio.");
                valido = false;
            }
            else if (!int.TryParse(txtStock.Text, out stock))
            {
                errorProvider.SetError(txtStock, "El stock debe ser un número entero válido.");
                valido = false;
            }
            else if (stock < 0)
            {
                errorProvider.SetError(txtStock, "El stock debe ser igual o mayor que cero.");
                valido = false;
            }

            if (cmbCategoria.SelectedIndex == -1)
            {
                errorProvider.SetError(cmbCategoria, "Debe seleccionar una categoría.");
                valido = false;
            }

            return valido;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            cmbCategoria.SelectedIndex = -1;
            idSeleccionado = 0;
            errorProvider.Clear();
            txtNombre.Focus();
        }
    }
}