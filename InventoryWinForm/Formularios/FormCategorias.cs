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
    public partial class FormCategorias : Form
    {
        private InventarioRepositorio repo;
        public FormCategorias(InventarioRepositorio r)
        {
            InitializeComponent();
            repo = r;
        }

        private void FormCategorias_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }
        private void ActualizarTabla()
        {
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = repo.Categories;
        }


        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            string nombre = txtCategoriaNombre.Text.Trim();
            if (nombre == "")
            {
                MessageBox.Show("Debe escribir un nombre de categoría.");
                return;
            }


            repo.AgregarCategoria(nombre);
            txtCategoriaNombre.Clear();
            ActualizarTabla();

        }

        private void btnBorrarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una categoría.");
                return;
            }

            Categoria c = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;


            bool tieneProductos = false;
            foreach (Productos p in repo.Products)
            {
                if (p.CategoriaNombre == c.Nombre)
                {
                    tieneProductos = true;
                    break;
                }
            }

            if (tieneProductos)
            {
                MessageBox.Show("No se puede eliminar la categoría, tiene productos asociados.");
                return;
            }

            repo.Categories.Remove(c);
            ActualizarTabla();
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar una categoría.");
                return;
            }

            string nuevoNombre = txtCategoriaNombre.Text.Trim();
            if (nuevoNombre == "")
            {
                MessageBox.Show("Debe escribir el nuevo nombre.");
                return;
            }

            Categoria c = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            c.Nombre = nuevoNombre;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
