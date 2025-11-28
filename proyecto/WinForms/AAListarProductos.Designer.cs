namespace WinForms
{
    partial class ListarProductos
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
            productosDataGridView = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)productosDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // productosDataGridView
            // 
            productosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productosDataGridView.Location = new Point(12, 57);
            productosDataGridView.Name = "productosDataGridView";
            productosDataGridView.Size = new Size(732, 305);
            productosDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(155, 21);
            label1.TabIndex = 1;
            label1.Text = "Listado de Productos";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(productosDataGridView);
            panel1.Location = new Point(63, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(762, 447);
            panel1.TabIndex = 2;
            // 
            // ListarProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 543);
            Controls.Add(panel1);
            Name = "ListarProductos";
            Text = "Form1";
            Load += ListarProductos_Load;
            ((System.ComponentModel.ISupportInitialize)productosDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView productosDataGridView;
        private Label label1;
        private Panel panel1;
    }
}