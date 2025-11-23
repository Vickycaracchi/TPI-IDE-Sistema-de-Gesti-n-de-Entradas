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
            ventasVendedoresDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ventasVendedoresDataGridView.Dock = DockStyle.Fill;
            ventasVendedoresDataGridView.Location = new Point(0, 0);
            ventasVendedoresDataGridView.Margin = new Padding(3, 2, 3, 2);
            ventasVendedoresDataGridView.Name = "ventasVendedoresDataGridView";
            ventasVendedoresDataGridView.RowHeadersWidth = 51;
            ventasVendedoresDataGridView.Size = new Size(1209, 464);
            ventasVendedoresDataGridView.TabIndex = 0;
            // 
            // VentasVendedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 464);
            Controls.Add(ventasVendedoresDataGridView);
            Margin = new Padding(3, 2, 3, 2);
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

