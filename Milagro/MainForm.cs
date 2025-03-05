using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milagro
{
    public partial class MainForm : Form
    {
        private DiscoRepository repo;
        public MainForm()
        {
            InitializeComponent();
            repo = new DiscoRepository();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            CargarDiscos();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarDiscos();
        }

        private void CargarDiscos()
        {
            List<Disco> discos = repo.ObtenerDisco();
            dataGridView1.DataSource = discos;
        }
    }
}
