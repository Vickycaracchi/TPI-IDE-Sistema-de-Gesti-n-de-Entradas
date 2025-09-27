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
            ((System.ComponentModel.ISupportInitialize)vendedoresDataGridView).BeginInit();
            SuspendLayout();
            // 
            // vendedoresDataGridView
            // 
            vendedoresDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vendedoresDataGridView.Location = new Point(23, 24);
            vendedoresDataGridView.Name = "vendedoresDataGridView";
            vendedoresDataGridView.RowHeadersWidth = 51;
            vendedoresDataGridView.Size = new Size(748, 306);
            vendedoresDataGridView.TabIndex = 0;
            vendedoresDataGridView.CellContentClick += vendedoresDataGridView_CellContentClick;
            // 
            // eliminar
            eliminarButtonVendedor.Location = new Point(23, 355);
            eliminarButtonVendedor.Name = "eliminarButtonVendedor";
            eliminarButtonVendedor.Size = new Size(163, 50);
            eliminarButtonVendedor.TabIndex = 1;
            eliminarButtonVendedor.Text = "Eliminar";
            eliminarButtonVendedor.UseVisualStyleBackColor = true;
            eliminarButtonVendedor.Click += eliminarButtonVendedor_Click;
            // 
            // modificar
            // 
            modificarButtonVendedor.Location = new Point(223, 355);
            modificarButtonVendedor.Name = "modificarButtonVendedor";
            modificarButtonVendedor.Size = new Size(163, 50);
            modificarButtonVendedor.TabIndex = 2;
            modificarButtonVendedor.Text = "Modificar";
            modificarButtonVendedor.UseVisualStyleBackColor = true;
            modificarButtonVendedor.Click += modificarButtonVendedor_Click;
            // 
            // agregar
            // 
            agregarButtonVendedor.Location = new Point(426, 355);
            agregarButtonVendedor.Name = "agregarButtonVendedor";
            agregarButtonVendedor.Size = new Size(163, 50);
            agregarButtonVendedor.TabIndex = 3;
            agregarButtonVendedor.Text = "Agregar";
            agregarButtonVendedor.UseVisualStyleBackColor = true;
            agregarButtonVendedor.Click += agregarButtonVendedor_Click;
            // 
            // lista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(agregarButtonVendedor);
            Controls.Add(modificarButtonVendedor);
            Controls.Add(eliminarButtonVendedor);
            Controls.Add(vendedoresDataGridView);
            Name = "VendedoresLista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Vendedores";
            Load += VendedoresLista_Load;
            ((System.ComponentModel.ISupportInitialize)vendedoresDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView vendedoresDataGridView;
        private Button eliminarButtonVendedor;
        private Button modificarButtonVendedor;
        private Button agregarButtonVendedor;
    }
}