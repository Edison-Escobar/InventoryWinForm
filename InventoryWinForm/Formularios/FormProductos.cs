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
    public partial class FormProductos : Form
    {
        private InventarioRepositorio repo;
        public FormProductos(InventarioRepositorio r)
        {
            InitializeComponent();
            repo = r;
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            cmbCategoria.DataSource = null;
            cmbCategoria.DataSource = repo.Categories;
            cmbCategoria.DisplayMember = "Nombre";
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = repo.Products;
        }

        private void btnAgregarproducto_Click(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una categoría.");
                return;
            }

            string nombre = txtProductoNombre.Text.Trim();
            if (nombre == "")
            {
                MessageBox.Show("Debe escribir un nombre de producto.");
                return;
            }

            if (nudPrecio.Value <= 0)
            {
                MessageBox.Show("El precio debe ser mayor que cero.");
                return;
            }

            if (nudStock.Value < 0)
            {
                MessageBox.Show("La cantidad no puede ser negativa.");
                return;
            }

            decimal precio = nudPrecio.Value;
            int stock = (int)nudStock.Value;
            Categoria cat = (Categoria)cmbCategoria.SelectedItem;

            bool ok = repo.AgregarProductos(nombre, cat.Id, precio, stock);

            if (!ok)
            {
                MessageBox.Show("Error al agregar producto. Verifique los datos.");
                return;
            }

            txtProductoNombre.Clear();
            nudPrecio.Value = 1;
            nudStock.Value = 0;
            ActualizarTabla();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un producto.");
                return;
            }

            Productos p = (Productos)dgvProductos.CurrentRow.DataBoundItem;
            repo.Products.Remove(p);
            ActualizarTabla();
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un producto.");
                return;
            }

            Productos p = (Productos)dgvProductos.CurrentRow.DataBoundItem;
            p.Nombre = txtProductoNombre.Text.Trim();
            p.Precio = nudPrecio.Value;


            Categoria cat = (Categoria)cmbCategoria.SelectedItem;
            ActualizarTabla();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
