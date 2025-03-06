namespace Milagro
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvDiscos;
        private System.Windows.Forms.TextBox txtId, txtNombre, txtArtista, txtGenero, txtANo, txtPrecio;
        private System.Windows.Forms.Label lblId, lblNombre, lblArtista, lblGenero, lblANo, lblPrecio;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnCargar = new Button();
            btnInsertar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            dgvDiscos = new DataGridView();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtArtista = new TextBox();
            txtGenero = new TextBox();
            txtANo = new TextBox();
            txtPrecio = new TextBox();
            lblId = new Label();
            lblNombre = new Label();
            lblArtista = new Label();
            lblGenero = new Label();
            lblANo = new Label();
            lblPrecio = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDiscos).BeginInit();
            SuspendLayout();
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(27, 31);
            btnCargar.Margin = new Padding(4, 5, 4, 5);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(100, 35);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Cargar";
            btnCargar.Click += btnCargar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(27, 400);
            btnInsertar.Margin = new Padding(4, 5, 4, 5);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(100, 35);
            btnInsertar.TabIndex = 2;
            btnInsertar.Text = "Insertar";
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(133, 400);
            btnActualizar.Margin = new Padding(4, 5, 4, 5);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(100, 35);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(240, 400);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 35);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvDiscos
            // 
            dgvDiscos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiscos.Location = new Point(16, 92);
            dgvDiscos.Margin = new Padding(4, 5, 4, 5);
            dgvDiscos.Name = "dgvDiscos";
            dgvDiscos.RowHeadersWidth = 51;
            dgvDiscos.Size = new Size(667, 277);
            dgvDiscos.TabIndex = 0;
            dgvDiscos.CellClick += dgvDiscos_CellClick;
            // 
            // txtId
            // 
            txtId.Location = new Point(83, 454);
            txtId.Margin = new Padding(4, 5, 4, 5);
            txtId.Name = "txtId";
            txtId.Size = new Size(132, 27);
            txtId.TabIndex = 11;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(83, 500);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(132, 27);
            txtNombre.TabIndex = 12;
            // 
            // txtArtista
            // 
            txtArtista.Location = new Point(316, 500);
            txtArtista.Margin = new Padding(4, 5, 4, 5);
            txtArtista.Name = "txtArtista";
            txtArtista.Size = new Size(132, 27);
            txtArtista.TabIndex = 13;
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(316, 454);
            txtGenero.Margin = new Padding(4, 5, 4, 5);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(132, 27);
            txtGenero.TabIndex = 14;
            // 
            // txtANo
            // 
            txtANo.Location = new Point(534, 454);
            txtANo.Margin = new Padding(4, 5, 4, 5);
            txtANo.Name = "txtANo";
            txtANo.Size = new Size(132, 27);
            txtANo.TabIndex = 15;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(534, 500);
            txtPrecio.Margin = new Padding(4, 5, 4, 5);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(132, 27);
            txtPrecio.TabIndex = 16;
            // 
            // lblId
            // 
            lblId.Location = new Point(30, 454);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(32, 35);
            lblId.TabIndex = 5;
            lblId.Text = "ID:";
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(3, 500);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(72, 35);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre:";
            // 
            // lblArtista
            // 
            lblArtista.Location = new Point(249, 500);
            lblArtista.Margin = new Padding(4, 0, 4, 0);
            lblArtista.Name = "lblArtista";
            lblArtista.Size = new Size(59, 35);
            lblArtista.TabIndex = 7;
            lblArtista.Text = "Artista:";
            // 
            // lblGenero
            // 
            lblGenero.Location = new Point(249, 454);
            lblGenero.Margin = new Padding(4, 0, 4, 0);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(71, 35);
            lblGenero.TabIndex = 8;
            lblGenero.Text = "Género:";
            // 
            // lblANo
            // 
            lblANo.Location = new Point(481, 454);
            lblANo.Margin = new Padding(4, 0, 4, 0);
            lblANo.Name = "lblANo";
            lblANo.Size = new Size(45, 35);
            lblANo.TabIndex = 9;
            lblANo.Text = "Año:";
            // 
            // lblPrecio
            // 
            lblPrecio.Location = new Point(481, 500);
            lblPrecio.Margin = new Padding(4, 0, 4, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(52, 35);
            lblPrecio.TabIndex = 10;
            lblPrecio.Text = "Precio:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 555);
            Controls.Add(dgvDiscos);
            Controls.Add(btnCargar);
            Controls.Add(btnInsertar);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(lblId);
            Controls.Add(lblNombre);
            Controls.Add(lblArtista);
            Controls.Add(lblGenero);
            Controls.Add(lblANo);
            Controls.Add(lblPrecio);
            Controls.Add(txtId);
            Controls.Add(txtNombre);
            Controls.Add(txtArtista);
            Controls.Add(txtGenero);
            Controls.Add(txtANo);
            Controls.Add(txtPrecio);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "Gestor de Discos";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDiscos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
