using InventoryWinForm.Data;
using InventoryWinForm.Formularios;

namespace InventoryWinForm
{
    public partial class Form1 : Form
    {
        private InventarioRepositorio repo = new InventarioRepositorio();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FormCategorias f = new FormCategorias(repo);
            f.ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            //FormProductos f = new FormProductos(repo);
            //f.ShowDialog();
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            //FormMovimientos f = new FormMovimientos(repo);
            //f.ShowDialog();
        }
    }
}
