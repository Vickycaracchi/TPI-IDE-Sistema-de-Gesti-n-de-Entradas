namespace WinForms
{
    partial class VendedoresLista
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
            vendedoresDataGridView = new DataGridView();
            eliminarButtonVendedor = new Button();
            modificarButtonVendedor = new Button();
            agregarButtonVendedor = new Button();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)vendedoresDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // vendedoresDataGridView
            // 
            vendedoresDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vendedoresDataGridView.Location = new Point(30, 52);
            vendedoresDataGridView.Margin = new Padding(3, 2, 3, 2);
            vendedoresDataGridView.Name = "vendedoresDataGridView";
            vendedoresDataGridView.RowHeadersWidth = 51;
            vendedoresDataGridView.Size = new Size(1495, 305);
            vendedoresDataGridView.TabIndex = 0;
            vendedoresDataGridView.CellContentClick += vendedoresDataGridView_CellContentClick;
            // 
            // eliminarButtonVendedor
            // 
            eliminarButtonVendedor.Location = new Point(525, 370);
            eliminarButtonVendedor.Margin = new Padding(3, 2, 3, 2);
            eliminarButtonVendedor.Name = "eliminarButtonVendedor";
            eliminarButtonVendedor.Size = new Size(143, 38);
            eliminarButtonVendedor.TabIndex = 1;
            eliminarButtonVendedor.Text = "Eliminar";
            eliminarButtonVendedor.UseVisualStyleBackColor = true;
            eliminarButtonVendedor.Click += eliminarButtonVendedor_Click;
            // 
            // modificarButtonVendedor
            // 
            modificarButtonVendedor.Location = new Point(700, 370);
            modificarButtonVendedor.Margin = new Padding(3, 2, 3, 2);
            modificarButtonVendedor.Name = "modificarButtonVendedor";
            modificarButtonVendedor.Size = new Size(143, 38);
            modificarButtonVendedor.TabIndex = 2;
            modificarButtonVendedor.Text = "Modificar";
            modificarButtonVendedor.UseVisualStyleBackColor = true;
            modificarButtonVendedor.Click += modificarButtonVendedor_Click;
            // 
            // agregarButtonVendedor
            // 
            agregarButtonVendedor.Location = new Point(878, 370);
            agregarButtonVendedor.Margin = new Padding(3, 2, 3, 2);
            agregarButtonVendedor.Name = "agregarButtonVendedor";
            agregarButtonVendedor.Size = new Size(143, 38);
            agregarButtonVendedor.TabIndex = 3;
            agregarButtonVendedor.Text = "Agregar";
            agregarButtonVendedor.UseVisualStyleBackColor = true;
            agregarButtonVendedor.Click += agregarButtonVendedor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(652, 4);
            label1.Name = "label1";
            label1.Size = new Size(292, 37);
            label1.TabIndex = 6;
            label1.Text = "Gestión de Vendedores";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(agregarButtonVendedor);
            panel1.Controls.Add(modificarButtonVendedor);
            panel1.Controls.Add(eliminarButtonVendedor);
            panel1.Controls.Add(vendedoresDataGridView);
            panel1.Location = new Point(9, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(1528, 523);
            panel1.TabIndex = 7;
            // 
            // VendedoresLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1555, 759);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "VendedoresLista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Vendedores";
            Load += VendedoresLista_Load;
            ((System.ComponentModel.ISupportInitialize)vendedoresDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView vendedoresDataGridView;
        private Button eliminarButtonVendedor;
        private Button modificarButtonVendedor;
        private Button agregarButtonVendedor;
        private Label label1;
        private Panel panel1;
    }
}