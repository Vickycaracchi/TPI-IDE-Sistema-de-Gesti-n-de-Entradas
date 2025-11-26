namespace WinForms
{
    partial class VentasVendedores
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            ventasVendedoresDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ventasVendedoresDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ventasVendedoresDataGridView
            // 
            ventasVendedoresDataGridView.ColumnHeadersHeight = 29;
            ventasVendedoresDataGridView.Location = new Point(117, 55);
            ventasVendedoresDataGridView.Name = "ventasVendedoresDataGridView";
            ventasVendedoresDataGridView.RowHeadersWidth = 51;
            ventasVendedoresDataGridView.Size = new Size(925, 371);
            ventasVendedoresDataGridView.TabIndex = 0;
            // 
            // VentasVendedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 619);
            Controls.Add(ventasVendedoresDataGridView);
            Name = "VentasVendedores";
            Text = "Ventas de tus vendedores";
            Load += VentasVendedores_Load;
            ((System.ComponentModel.ISupportInitialize)ventasVendedoresDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ventasVendedoresDataGridView;
    }
}

