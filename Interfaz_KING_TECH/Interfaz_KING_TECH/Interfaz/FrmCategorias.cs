using Interfaz_KING_TECH.Logica;
using Interfaz_KING_TECH.Modelos;

namespace Interfaz_KING_TECH.Interfaz
{
    public partial class FrmCategorias : Form
    {
        private CategoriaLogica logica = new CategoriaLogica();
        private int idSeleccionado = 0;

        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            Categoria categoria = new Categoria();
            categoria.Nombre = txtNombre.Text.Trim();
            categoria.Descripcion = txtDescripcion.Text.Trim();

            string error = logica.Guardar(categoria);

            if (error == "")
            {
                MessageBox.Show("Categoría guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarCategorias();
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
                MessageBox.Show("Seleccione una categoría de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCampos())
            {
                return;
            }

            Categoria categoria = new Categoria();
            categoria.IdCategoria = idSeleccionado;
            categoria.Nombre = txtNombre.Text.Trim();
            categoria.Descripcion = txtDescripcion.Text.Trim();

            string error = logica.Modificar(categoria);

            if (error == "")
            {
                MessageBox.Show("Categoría modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarCategorias();
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
                MessageBox.Show("Seleccione una categoría de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar la categoría?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                string error = logica.Eliminar(idSeleccionado);

                if (error == "")
                {
                    MessageBox.Show("Categoría eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarCategorias();
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
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvCategorias.Rows[e.RowIndex];
                idSeleccionado = Convert.ToInt32(fila.Cells["IdCategoria"].Value);
                txtNombre.Text = Convert.ToString(fila.Cells["Nombre"].Value);
                txtDescripcion.Text = Convert.ToString(fila.Cells["Descripcion"].Value);
                errorProvider.Clear();
            }
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarCategorias()
        {
            try
            {
                dgvCategorias.DataSource = logica.Consultar();
                dgvCategorias.Columns["IdCategoria"].HeaderText = "ID";
                dgvCategorias.Columns["Nombre"].HeaderText = "Nombre";
                dgvCategorias.Columns["Descripcion"].HeaderText = "Descripción";
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudieron cargar las categorías. Verifique la conexión con la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            if (txtDescripcion.Text.Trim() == "")
            {
                errorProvider.SetError(txtDescripcion, "La descripción es obligatoria.");
                valido = false;
            }

            return valido;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            idSeleccionado = 0;
            errorProvider.Clear();
            txtNombre.Focus();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

        }
    }
}