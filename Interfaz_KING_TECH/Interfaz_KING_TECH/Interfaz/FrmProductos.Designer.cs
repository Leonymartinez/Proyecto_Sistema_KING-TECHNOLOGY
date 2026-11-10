namespace Interfaz_KING_TECH.Interfaz
{
    partial class FrmProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            txtBuscar = new TextBox();
            cmbCategoria = new ComboBox();
            txtNombre = new TextBox();
            btnBuscar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvProductos = new DataGridView();
            lblNombre = new Label();
            lblPrecio = new Label();
            lblStock = new Label();
            lblBuscar = new Label();
            lblCategoria = new Label();
            btnGuardar = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(137, 72);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 0;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(137, 126);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 1;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(137, 172);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(100, 23);
            txtBuscar.TabIndex = 2;
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(137, 220);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(121, 23);
            cmbCategoria.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(137, 34);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(116, 291);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(344, 291);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(86, 23);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(462, 291);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(568, 291);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = SystemColors.ButtonHighlight;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(292, 34);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(482, 219);
            dgvProductos.TabIndex = 9;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(77, 37);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(77, 75);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 11;
            lblPrecio.Text = "Precio";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(77, 126);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 12;
            lblStock.Text = "Stock";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(77, 172);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(42, 15);
            lblBuscar.TabIndex = 13;
            lblBuscar.Text = "Buscar";
            lblBuscar.Click += lblBuscar_Click;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(70, 223);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 14;
            lblCategoria.Text = "Categoria";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(238, 291);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(lblCategoria);
            Controls.Add(lblBuscar);
            Controls.Add(lblStock);
            Controls.Add(lblPrecio);
            Controls.Add(lblNombre);
            Controls.Add(dgvProductos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnBuscar);
            Controls.Add(txtNombre);
            Controls.Add(cmbCategoria);
            Controls.Add(txtBuscar);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Name = "FrmProductos";
            Text = "FrmProductos";
            Load += FrmProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrecio;
        private TextBox txtStock;
        private TextBox txtBuscar;
        private ComboBox cmbCategoria;
        private TextBox txtNombre;
        private Button btnBuscar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvProductos;
        private Label lblNombre;
        private Label lblPrecio;
        private Label lblStock;
        private Label lblBuscar;
        private Label lblCategoria;
        private Button btnGuardar;
        private ErrorProvider errorProvider;
    }
}