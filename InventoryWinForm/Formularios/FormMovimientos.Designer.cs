namespace InventoryWinForm.Formularios
{
    partial class FormMovimientos
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
            cmbProductos = new ComboBox();
            cmbTipo = new ComboBox();
            nudCantidad = new NumericUpDown();
            btnRegistrarMovimiento = new Button();
            dgvMovimientos = new DataGridView();
            label1 = new Label();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).BeginInit();
            SuspendLayout();
            // 
            // cmbProductos
            // 
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(508, 40);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(121, 23);
            cmbProductos.TabIndex = 0;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(508, 91);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(121, 23);
            cmbTipo.TabIndex = 1;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(521, 179);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(120, 23);
            nudCantidad.TabIndex = 2;
            // 
            // btnRegistrarMovimiento
            // 
            btnRegistrarMovimiento.Location = new Point(508, 264);
            btnRegistrarMovimiento.Name = "btnRegistrarMovimiento";
            btnRegistrarMovimiento.Size = new Size(160, 23);
            btnRegistrarMovimiento.TabIndex = 3;
            btnRegistrarMovimiento.Text = "Registrar Movimiento";
            btnRegistrarMovimiento.UseVisualStyleBackColor = true;
            btnRegistrarMovimiento.Click += btnRegistrarMovimiento_Click;
            // 
            // dgvMovimientos
            // 
            dgvMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovimientos.Location = new Point(12, 12);
            dgvMovimientos.Name = "dgvMovimientos";
            dgvMovimientos.Size = new Size(436, 352);
            dgvMovimientos.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(480, 150);
            label1.Name = "label1";
            label1.Size = new Size(223, 15);
            label1.TabIndex = 5;
            label1.Text = "Ingrese La entrada o la salida Del Prodcto";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(554, 311);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormMovimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrar);
            Controls.Add(label1);
            Controls.Add(dgvMovimientos);
            Controls.Add(btnRegistrarMovimiento);
            Controls.Add(nudCantidad);
            Controls.Add(cmbTipo);
            Controls.Add(cmbProductos);
            Name = "FormMovimientos";
            Text = "FormMovimientos";
            Load += FormMovimientos_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbProductos;
        private ComboBox cmbTipo;
        private NumericUpDown nudCantidad;
        private Button btnRegistrarMovimiento;
        private DataGridView dgvMovimientos;
        private Label label1;
        private Button btnCerrar;
    }
}