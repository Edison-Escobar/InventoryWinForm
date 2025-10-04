namespace InventoryWinForm.Formularios
{
    partial class FormCategorias
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
            btnAgregarCategoria = new Button();
            btnEditarCategoria = new Button();
            btnBorrarCategoria = new Button();
            txtCategoriaNombre = new TextBox();
            dgvCategorias = new DataGridView();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarCategoria
            // 
            btnAgregarCategoria.Location = new Point(424, 277);
            btnAgregarCategoria.Name = "btnAgregarCategoria";
            btnAgregarCategoria.Size = new Size(75, 23);
            btnAgregarCategoria.TabIndex = 0;
            btnAgregarCategoria.Text = "Agregar";
            btnAgregarCategoria.UseVisualStyleBackColor = true;
            btnAgregarCategoria.Click += btnAgregarCategoria_Click;
            // 
            // btnEditarCategoria
            // 
            btnEditarCategoria.Location = new Point(544, 277);
            btnEditarCategoria.Name = "btnEditarCategoria";
            btnEditarCategoria.Size = new Size(75, 23);
            btnEditarCategoria.TabIndex = 1;
            btnEditarCategoria.Text = "Editar";
            btnEditarCategoria.UseVisualStyleBackColor = true;
            btnEditarCategoria.Click += btnEditarCategoria_Click;
            // 
            // btnBorrarCategoria
            // 
            btnBorrarCategoria.Location = new Point(668, 277);
            btnBorrarCategoria.Name = "btnBorrarCategoria";
            btnBorrarCategoria.Size = new Size(75, 23);
            btnBorrarCategoria.TabIndex = 2;
            btnBorrarCategoria.Text = "Eliminar";
            btnBorrarCategoria.UseVisualStyleBackColor = true;
            btnBorrarCategoria.Click += btnBorrarCategoria_Click;
            // 
            // txtCategoriaNombre
            // 
            txtCategoriaNombre.Location = new Point(424, 83);
            txtCategoriaNombre.Name = "txtCategoriaNombre";
            txtCategoriaNombre.Size = new Size(336, 23);
            txtCategoriaNombre.TabIndex = 3;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(12, 17);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.Size = new Size(374, 330);
            dgvCategorias.TabIndex = 4;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(544, 324);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrar);
            Controls.Add(dgvCategorias);
            Controls.Add(txtCategoriaNombre);
            Controls.Add(btnBorrarCategoria);
            Controls.Add(btnEditarCategoria);
            Controls.Add(btnAgregarCategoria);
            Name = "FormCategorias";
            Text = "FormCategorias";
            Load += FormCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarCategoria;
        private Button btnEditarCategoria;
        private Button btnBorrarCategoria;
        private TextBox txtCategoriaNombre;
        private DataGridView dgvCategorias;
        private Button btnCerrar;
    }
}