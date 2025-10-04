using InventoryWinForm.Data;
using InventoryWinForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryWinForm.Formularios
{
    public partial class FormDashboard : Form
    {
        private InventarioRepositorio repo = new InventarioRepositorio();
        public FormDashboard()
        {
            InitializeComponent();

        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            ActualizarIndicadores();
        }

        private void FormDashboard_Activated(object sender, EventArgs e)
        {
            ActualizarIndicadores();
        }

        private void ActualizarIndicadores()
        {
            lblTotalProductos.Text = "Productos: " + repo.TotalProductos();
            lblTotalCategorias.Text = "Categorías: " + repo.TotalCategorias();
            lblInventarioValor.Text = "Valor Inventario: Q " + repo.ValorDelInventario();

            Productos top = repo.GetTopStockProduct();
            if (top != null)
                lblTopProductos.Text = $"{top.Nombre} ({top.Stock} unidades)";
            else
                lblTopProductos.Text = "N/A";
        }



        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FormCategorias f = new FormCategorias(repo);
            f.ShowDialog();
        }


        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormProductos f = new FormProductos(repo);
            f.ShowDialog();
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            FormMovimientos f = new FormMovimientos(repo);
            f.ShowDialog();

        }
    }
}
