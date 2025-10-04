namespace InventoryWinForm.Formularios
{
    partial class FormProductos
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
            txtProductoNombre = new TextBox();
            cmbCategoria = new ComboBox();
            nudPrecio = new NumericUpDown();
            nudStock = new NumericUpDown();
            btnAgregarproducto = new Button();
            btnEditarProducto = new Button();
            btnEliminarProducto = new Button();
            dgvProductos = new DataGridView();
            btnCerrar = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // txtProductoNombre
            // 
            txtProductoNombre.Location = new Point(582, 35);
            txtProductoNombre.Name = "txtProductoNombre";
            txtProductoNombre.PlaceholderText = "Ingrese el Nombre del Producto";
            txtProductoNombre.Size = new Size(186, 23);
            txtProductoNombre.TabIndex = 0;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(421, 35);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(121, 23);
            cmbCategoria.TabIndex = 1;
            // 
            // nudPrecio
            // 
            nudPrecio.Location = new Point(621, 97);
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(120, 23);
            nudPrecio.TabIndex = 2;
            // 
            // nudStock
            // 
            nudStock.Location = new Point(621, 156);
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(120, 23);
            nudStock.TabIndex = 3;
            // 
            // btnAgregarproducto
            // 
            btnAgregarproducto.Location = new Point(457, 249);
            btnAgregarproducto.Name = "btnAgregarproducto";
            btnAgregarproducto.Size = new Size(75, 23);
            btnAgregarproducto.TabIndex = 4;
            btnAgregarproducto.Text = "Agregar";
            btnAgregarproducto.UseVisualStyleBackColor = true;
            btnAgregarproducto.Click += btnAgregarproducto_Click;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.Location = new Point(582, 249);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(75, 23);
            btnEditarProducto.TabIndex = 5;
            btnEditarProducto.Text = "Editar";
            btnEditarProducto.UseVisualStyleBackColor = true;
            btnEditarProducto.Click += btnEditarProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Location = new Point(691, 249);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(75, 23);
            btnEliminarProducto.TabIndex = 6;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = true;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(2, 12);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(413, 341);
            dgvProductos.TabIndex = 7;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(582, 301);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 8;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(421, 99);
            label1.Name = "label1";
            label1.Size = new Size(164, 15);
            label1.TabIndex = 9;
            label1.Text = "Ingrese el Precio del Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(421, 164);
            label2.Name = "label2";
            label2.Size = new Size(153, 15);
            label2.TabIndex = 10;
            label2.Text = "Ingrese el stok del Producto";
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(dgvProductos);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnEditarProducto);
            Controls.Add(btnAgregarproducto);
            Controls.Add(nudStock);
            Controls.Add(nudPrecio);
            Controls.Add(cmbCategoria);
            Controls.Add(txtProductoNombre);
            Name = "FormProductos";
            Text = "FormProductos";
            Load += FormProductos_Load;
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProductoNombre;
        private ComboBox cmbCategoria;
        private NumericUpDown nudPrecio;
        private NumericUpDown nudStock;
        private Button btnAgregarproducto;
        private Button btnEditarProducto;
        private Button btnEliminarProducto;
        private DataGridView dgvProductos;
        private Button btnCerrar;
        private Label label1;
        private Label label2;
    }
}