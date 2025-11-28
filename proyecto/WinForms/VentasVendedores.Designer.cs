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
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)ventasVendedoresDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ventasVendedoresDataGridView
            // 
            ventasVendedoresDataGridView.ColumnHeadersHeight = 29;
            ventasVendedoresDataGridView.Location = new Point(77, 49);
            ventasVendedoresDataGridView.Margin = new Padding(3, 2, 3, 2);
            ventasVendedoresDataGridView.Name = "ventasVendedoresDataGridView";
            ventasVendedoresDataGridView.RowHeadersWidth = 51;
            ventasVendedoresDataGridView.Size = new Size(732, 305);
            ventasVendedoresDataGridView.TabIndex = 0;
            ventasVendedoresDataGridView.CellContentClick += ventasVendedoresDataGridView_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(272, 7);
            label1.Name = "label1";
            label1.Size = new Size(327, 37);
            label1.TabIndex = 6;
            label1.Text = "Ventas de mis Vendedores";
           
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ventasVendedoresDataGridView);
            panel1.Location = new Point(174, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 404);
            panel1.TabIndex = 7;
            // 
            // VentasVendedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 464);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "VentasVendedores";
            Text = "Ventas de tus vendedores";
            Load += VentasVendedores_Load;
            ((System.ComponentModel.ISupportInitialize)ventasVendedoresDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ventasVendedoresDataGridView;
        private Label label1;
        private Panel panel1;
    }
}

