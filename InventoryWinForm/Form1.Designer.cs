namespace InventoryWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCategorias = new Button();
            btnProductos = new Button();
            btnMovimientos = new Button();
            SuspendLayout();
            // 
            // btnCategorias
            // 
            btnCategorias.Location = new Point(107, 128);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(75, 23);
            btnCategorias.TabIndex = 0;
            btnCategorias.Text = "button1";
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(304, 128);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(75, 23);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "button2";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnMovimientos
            // 
            btnMovimientos.Location = new Point(473, 128);
            btnMovimientos.Name = "btnMovimientos";
            btnMovimientos.Size = new Size(75, 23);
            btnMovimientos.TabIndex = 2;
            btnMovimientos.Text = "button3";
            btnMovimientos.UseVisualStyleBackColor = true;
            btnMovimientos.Click += btnMovimientos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMovimientos);
            Controls.Add(btnProductos);
            Controls.Add(btnCategorias);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCategorias;
        private Button btnProductos;
        private Button btnMovimientos;
    }
}
