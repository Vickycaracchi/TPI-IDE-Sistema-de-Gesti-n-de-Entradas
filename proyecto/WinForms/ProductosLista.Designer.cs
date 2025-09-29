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
            ((System.ComponentModel.ISupportInitialize)productosDataGridView).BeginInit();
            SuspendLayout();
            // 
            // agregarButtonProducto
            // 
            agregarButtonProducto.Location = new Point(426, 258);
            agregarButtonProducto.Margin = new Padding(3, 2, 3, 2);
            agregarButtonProducto.Name = "agregarButtonProducto";
            agregarButtonProducto.Size = new Size(82, 22);
            agregarButtonProducto.TabIndex = 3;
            agregarButtonProducto.Text = "Agregar";
            agregarButtonProducto.UseVisualStyleBackColor = true;
            agregarButtonProducto.Click += agregarButtonProducto_Click;
            // 
            // modificarButtonProducto
            // 
            modificarButtonProducto.Location = new Point(262, 258);
            modificarButtonProducto.Margin = new Padding(3, 2, 3, 2);
            modificarButtonProducto.Name = "modificarButtonProducto";
            modificarButtonProducto.Size = new Size(82, 22);
            modificarButtonProducto.TabIndex = 2;
            modificarButtonProducto.Text = "Modificar";
            modificarButtonProducto.UseVisualStyleBackColor = true;
            modificarButtonProducto.Click += modificarButtonProducto_Click;
            // 
            // eliminarButtonProducto
            // 
            eliminarButtonProducto.Location = new Point(95, 258);
            eliminarButtonProducto.Margin = new Padding(3, 2, 3, 2);
            eliminarButtonProducto.Name = "eliminarButtonProducto";
            eliminarButtonProducto.Size = new Size(82, 22);
            eliminarButtonProducto.TabIndex = 1;
            eliminarButtonProducto.Text = "Eliminar";
            eliminarButtonProducto.UseVisualStyleBackColor = true;
            eliminarButtonProducto.Click += eliminarButtonEvento_Click;
            // 
            // productosDataGridView
            // 
            productosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productosDataGridView.Location = new Point(46, 26);
            productosDataGridView.Margin = new Padding(3, 2, 3, 2);
            productosDataGridView.Name = "productosDataGridView";
            productosDataGridView.RowHeadersWidth = 51;
            productosDataGridView.Size = new Size(553, 198);
            productosDataGridView.TabIndex = 0;
            // 
            // ProductosLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(agregarButtonProducto);
            Controls.Add(modificarButtonProducto);
            Controls.Add(eliminarButtonProducto);
            Controls.Add(productosDataGridView);
            Name = "ProductosLista";
            Text = "Form1";
            Load += ProductosLista_Load;
            ((System.ComponentModel.ISupportInitialize)productosDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion


        private DataGridView productosDataGridView;
        private Button agregarButtonProducto;
        private Button modificarButtonProducto;
        private Button eliminarButtonProducto;
    }
}