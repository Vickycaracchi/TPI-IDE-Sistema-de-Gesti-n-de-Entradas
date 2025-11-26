namespace WinForms
{
    partial class ComprarProducto
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
            CompraProdListaComprasDataGridView = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            CompraProdsproductosDataGridView = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)CompraProdListaComprasDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CompraProdsproductosDataGridView).BeginInit();
            SuspendLayout();
            // 
            // CompraProdListaComprasDataGridView
            // 
            CompraProdListaComprasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CompraProdListaComprasDataGridView.Location = new Point(76, 85);
            CompraProdListaComprasDataGridView.Name = "CompraProdListaComprasDataGridView";
            CompraProdListaComprasDataGridView.RowHeadersWidth = 51;
            CompraProdListaComprasDataGridView.Size = new Size(772, 263);
            CompraProdListaComprasDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 41);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 1;
            label1.Text = "Mis compras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(897, 41);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 3;
            label2.Text = "Productos";
            // 
            // CompraProdsproductosDataGridView
            // 
            CompraProdsproductosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CompraProdsproductosDataGridView.Location = new Point(897, 85);
            CompraProdsproductosDataGridView.Name = "CompraProdsproductosDataGridView";
            CompraProdsproductosDataGridView.RowHeadersWidth = 51;
            CompraProdsproductosDataGridView.Size = new Size(710, 263);
            CompraProdsproductosDataGridView.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(775, 393);
            button1.Name = "button1";
            button1.Size = new Size(197, 46);
            button1.TabIndex = 4;
            button1.Text = "Comprar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ComprarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1702, 925);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(CompraProdsproductosDataGridView);
            Controls.Add(label1);
            Controls.Add(CompraProdListaComprasDataGridView);
            Name = "ComprarProducto";
            Text = "ComprarProducto";
            Load += ComprarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)CompraProdListaComprasDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)CompraProdsproductosDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView CompraProdListaComprasDataGridView;
        private Label label1;
        private Label label2;
        private DataGridView CompraProdsproductosDataGridView;
        private Button button1;
    }
}