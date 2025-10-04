using InventoryWinForm.Data;
using InventoryWinForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryWinForm.Formularios
{
    public partial class FormMovimientos : Form
    {
        private InventarioRepositorio repo;
        public FormMovimientos(InventarioRepositorio r)
        {
            InitializeComponent();
            repo = r;

        }

        private void FormMovimientos_Load(object sender, EventArgs e)
        {
            cmbProductos.DataSource = null;
            cmbProductos.DataSource = repo.Products;
            cmbProductos.DisplayMember = "Nombre";

            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Entrada");
            cmbTipo.Items.Add("Salida");

            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            dgvMovimientos.DataSource = null;
            dgvMovimientos.DataSource = repo.Movements;
        }

        private void btnRegistrarMovimiento_Click(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedItem == null || cmbTipo.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar producto y tipo.");
                return;
            }

            Productos p = (Productos)cmbProductos.SelectedItem;
            string tipo = cmbTipo.SelectedItem.ToString();
            int cantidad = (int)nudCantidad.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show("Cantidad inválida.");
                return;
            }

            bool ok = repo.AgregarMovimiento(p.Id, tipo, cantidad);

            if (!ok)
            {
                MessageBox.Show("No se pudo registrar el movimiento. Revise el stock o los datos.");
                return;
            }

            MessageBox.Show("Movimiento registrado correctamente.");
            ActualizarTabla();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
