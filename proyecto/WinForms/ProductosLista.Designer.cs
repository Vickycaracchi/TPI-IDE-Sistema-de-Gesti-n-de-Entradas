namespace WinForms
{
    partial class ProductosLista
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
            agregarButtonProducto = new Button();
            modificarButtonProducto = new Button();
            eliminarButtonProducto = new Button();
            productosDataGridView = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)productosDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // agregarButtonProducto
            // 
            agregarButtonProducto.Location = new Point(557, 370);
            agregarButtonProducto.Margin = new Padding(3, 2, 3, 2);
            agregarButtonProducto.Name = "agregarButtonProducto";
            agregarButtonProducto.Size = new Size(143, 38);
            agregarButtonProducto.TabIndex = 3;
            agregarButtonProducto.Text = "Agregar";
            agregarButtonProducto.UseVisualStyleBackColor = true;
            agregarButtonProducto.Click += agregarButtonProducto_Click;
            // 
            // modificarButtonProducto
            // 
            modificarButtonProducto.Location = new Point(393, 370);
            modificarButtonProducto.Margin = new Padding(3, 2, 3, 2);
            modificarButtonProducto.Name = "modificarButtonProducto";
            modificarButtonProducto.Size = new Size(143, 38);
            modificarButtonProducto.TabIndex = 2;
            modificarButtonProducto.Text = "Modificar";
            modificarButtonProducto.UseVisualStyleBackColor = true;
            modificarButtonProducto.Click += modificarButtonProducto_Click;
            // 
            // eliminarButtonProducto
            // 
            eliminarButtonProducto.Location = new Point(226, 370);
            eliminarButtonProducto.Margin = new Padding(3, 2, 3, 2);
            eliminarButtonProducto.Name = "eliminarButtonProducto";
            eliminarButtonProducto.Size = new Size(143, 38);
            eliminarButtonProducto.TabIndex = 1;
            eliminarButtonProducto.Text = "Eliminar";
            eliminarButtonProducto.UseVisualStyleBackColor = true;
            eliminarButtonProducto.Click += eliminarButtonEvento_Click;
            // 
            // productosDataGridView
            // 
            productosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productosDataGridView.Location = new Point(108, 48);
            productosDataGridView.Margin = new Padding(3, 2, 3, 2);
            productosDataGridView.Name = "productosDataGridView";
            productosDataGridView.RowHeadersWidth = 51;
            productosDataGridView.Size = new Size(732, 305);
            productosDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(329, 4);
            label1.Name = "label1";
            label1.Size = new Size(271, 37);
            label1.TabIndex = 5;
            label1.Text = "Gestión de Productos";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(agregarButtonProducto);
            panel1.Controls.Add(modificarButtonProducto);
            panel1.Controls.Add(eliminarButtonProducto);
            panel1.Controls.Add(productosDataGridView);
            panel1.Location = new Point(163, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(941, 482);
            panel1.TabIndex = 6;
            // 
            // ProductosLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 672);
            Controls.Add(panel1);
            Name = "ProductosLista";
            Text = "Gestion de productos";
            Load += ProductosLista_Load;
            ((System.ComponentModel.ISupportInitialize)productosDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion


        private DataGridView productosDataGridView;
        private Button agregarButtonProducto;
        private Button modificarButtonProducto;
        private Button eliminarButtonProducto;
        private Label label1;
        private Panel panel1;
    }
}