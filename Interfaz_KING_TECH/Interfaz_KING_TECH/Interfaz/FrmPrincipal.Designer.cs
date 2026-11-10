namespace Interfaz_KING_TECH.Interfaz
{
    partial class FrmPrincipal
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
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            btnCategorias = new Button();
            btnProductos = new Button();
            btnSalir = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Bookman Old Style", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(75, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(280, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "KING TECHNOLOGY";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitulo.Location = new Point(104, 65);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(211, 16);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Sistema de Gestion de Productos";
            lblSubtitulo.Click += lblSubtitulo_Click;
            // 
            // btnCategorias
            // 
            btnCategorias.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCategorias.ForeColor = SystemColors.ActiveCaptionText;
            btnCategorias.Location = new Point(89, 100);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(247, 93);
            btnCategorias.TabIndex = 2;
            btnCategorias.Text = "GESTIÓN DE CATEGORÍAS\r\n";
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnProductos
            // 
            btnProductos.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProductos.ForeColor = SystemColors.ActiveCaptionText;
            btnProductos.Location = new Point(89, 199);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(247, 93);
            btnProductos.TabIndex = 3;
            btnProductos.Text = "GESTIÓN DE PRODUCTOS";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.ActiveCaptionText;
            btnSalir.Location = new Point(89, 298);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(247, 36);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "SALIR DEL SISTEMA";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(btnProductos);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(lblSubtitulo);
            panel1.Controls.Add(btnCategorias);
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(176, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(435, 363);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Button btnCategorias;
        private Button btnProductos;
        private Button btnSalir;
        private Panel panel1;
    }
}