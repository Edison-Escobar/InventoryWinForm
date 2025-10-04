namespace InventoryWinForm.Formularios
{
    partial class FormDashboard
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
            btnCategorias = new Button();
            btnProductos = new Button();
            btnMovimientos = new Button();
            lblTotalProductos = new Label();
            lblTotalCategorias = new Label();
            lblInventarioValor = new Label();
            lblTopProductos = new Label();
            SuspendLayout();
            // 
            // btnCategorias
            // 
            btnCategorias.Location = new Point(76, 229);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(139, 23);
            btnCategorias.TabIndex = 0;
            btnCategorias.Text = "FormsCategoria";
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(276, 229);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(117, 23);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "FormProductos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnMovimientos
            // 
            btnMovimientos.Location = new Point(437, 229);
            btnMovimientos.Name = "btnMovimientos";
            btnMovimientos.Size = new Size(141, 23);
            btnMovimientos.TabIndex = 2;
            btnMovimientos.Text = "Form Movimirntos";
            btnMovimientos.UseVisualStyleBackColor = true;
            btnMovimientos.Click += btnMovimientos_Click;
            // 
            // lblTotalProductos
            // 
            lblTotalProductos.AutoSize = true;
            lblTotalProductos.Location = new Point(90, 24);
            lblTotalProductos.Name = "lblTotalProductos";
            lblTotalProductos.Size = new Size(38, 15);
            lblTotalProductos.TabIndex = 3;
            lblTotalProductos.Text = "label1";
            // 
            // lblTotalCategorias
            // 
            lblTotalCategorias.AutoSize = true;
            lblTotalCategorias.Location = new Point(239, 24);
            lblTotalCategorias.Name = "lblTotalCategorias";
            lblTotalCategorias.Size = new Size(38, 15);
            lblTotalCategorias.TabIndex = 4;
            lblTotalCategorias.Text = "label2";
            // 
            // lblInventarioValor
            // 
            lblInventarioValor.AutoSize = true;
            lblInventarioValor.Location = new Point(380, 24);
            lblInventarioValor.Name = "lblInventarioValor";
            lblInventarioValor.Size = new Size(38, 15);
            lblInventarioValor.TabIndex = 5;
            lblInventarioValor.Text = "label3";
            // 
            // lblTopProductos
            // 
            lblTopProductos.AutoSize = true;
            lblTopProductos.Location = new Point(540, 24);
            lblTopProductos.Name = "lblTopProductos";
            lblTopProductos.Size = new Size(38, 15);
            lblTopProductos.TabIndex = 6;
            lblTopProductos.Text = "label4";
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTopProductos);
            Controls.Add(lblInventarioValor);
            Controls.Add(lblTotalCategorias);
            Controls.Add(lblTotalProductos);
            Controls.Add(btnMovimientos);
            Controls.Add(btnProductos);
            Controls.Add(btnCategorias);
            Name = "FormDashboard";
            Text = "FormDashboard";
            Load += FormDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCategorias;
        private Button btnProductos;
        private Button btnMovimientos;
        private Label lblTotalProductos;
        private Label lblTotalCategorias;
        private Label lblInventarioValor;
        private Label lblTopProductos;
    }
}