using Milagro;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Milagro
{
    public partial class MainForm : Form
    {
        DiscoRepository repo = new DiscoRepository();

        public MainForm()
        {
            InitializeComponent();
            //CargarDiscos();
        }

        

        private void CargarDiscos()
        {
            List<Disco> discos = repo.ObtenerDisco();
            dgvDiscos.DataSource = discos;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                Disco nuevoDisco = new Disco
                {
                    Nombre = txtNombre.Text,
                    Artista = txtArtista.Text,
                    Genero = txtGenero.Text,
                    ANO = int.Parse(txtANo.Text),
                    Precio = decimal.Parse(txtPrecio.Text)
                };

                repo.InsertarDisco(nuevoDisco);
                MessageBox.Show("Disco agregado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDiscos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar disco: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Disco discoActualizado = new Disco
                {
                    Id = int.Parse(txtId.Text),
                    Nombre = txtNombre.Text,
                    Artista = txtArtista.Text,
                    Genero = txtGenero.Text,
                    ANO = int.Parse(txtANo.Text),
                    Precio = decimal.Parse(txtPrecio.Text)
                };

                repo.ActualizarDisco(discoActualizado);
                MessageBox.Show("Disco actualizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDiscos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar disco: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtId.Text);
                repo.EliminarDisco(id);
                MessageBox.Show("Disco eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDiscos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar disco: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDiscos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDiscos.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtNombre.Text = row.Cells[1].Value.ToString();
                txtArtista.Text = row.Cells[2].Value.ToString();
                txtGenero.Text = row.Cells[3].Value.ToString();
                txtANo.Text = row.Cells[4].Value.ToString();
                txtPrecio.Text = row.Cells[5].Value.ToString();
            }
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarDiscos();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //CargarDiscos();
        }
    }
}
