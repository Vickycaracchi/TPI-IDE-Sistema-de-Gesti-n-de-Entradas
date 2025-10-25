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
            vendedoresDataGridView.Location = new Point(20, 18);
            vendedoresDataGridView.Margin = new Padding(3, 2, 3, 2);
            vendedoresDataGridView.Name = "vendedoresDataGridView";
            vendedoresDataGridView.RowHeadersWidth = 51;
            vendedoresDataGridView.Size = new Size(1153, 230);
            vendedoresDataGridView.TabIndex = 0;
            vendedoresDataGridView.CellContentClick += vendedoresDataGridView_CellContentClick;
            // 
            // eliminarButtonVendedor
            // 
            eliminarButtonVendedor.Location = new Point(20, 266);
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
            modificarButtonVendedor.Location = new Point(195, 266);
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
            agregarButtonVendedor.Location = new Point(373, 266);
            agregarButtonVendedor.Margin = new Padding(3, 2, 3, 2);
            agregarButtonVendedor.Name = "agregarButtonVendedor";
            agregarButtonVendedor.Size = new Size(143, 38);
            agregarButtonVendedor.TabIndex = 3;
            agregarButtonVendedor.Text = "Agregar";
            agregarButtonVendedor.UseVisualStyleBackColor = true;
            agregarButtonVendedor.Click += agregarButtonVendedor_Click;
            // 
            // VendedoresLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 338);
            Controls.Add(agregarButtonVendedor);
            Controls.Add(modificarButtonVendedor);
            Controls.Add(eliminarButtonVendedor);
            Controls.Add(vendedoresDataGridView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "VendedoresLista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Vendedores";
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