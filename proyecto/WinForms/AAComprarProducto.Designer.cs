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
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)CompraProdListaComprasDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CompraProdsproductosDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // CompraProdListaComprasDataGridView
            // 
            CompraProdListaComprasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CompraProdListaComprasDataGridView.Location = new Point(42, 47);
            CompraProdListaComprasDataGridView.Margin = new Padding(3, 2, 3, 2);
            CompraProdListaComprasDataGridView.Name = "CompraProdListaComprasDataGridView";
            CompraProdListaComprasDataGridView.RowHeadersWidth = 51;
            CompraProdListaComprasDataGridView.Size = new Size(676, 197);
            CompraProdListaComprasDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(45, 14);
            label1.Name = "label1";
            label1.Size = new Size(245, 21);
            label1.TabIndex = 1;
            label1.Text = "Fiesta para la que quiere comprar:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(761, 14);
            label2.Name = "label2";
            label2.Size = new Size(151, 21);
            label2.TabIndex = 3;
            label2.Text = "Producto a comprar:";
            // 
            // CompraProdsproductosDataGridView
            // 
            CompraProdsproductosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CompraProdsproductosDataGridView.Location = new Point(761, 47);
            CompraProdsproductosDataGridView.Margin = new Padding(3, 2, 3, 2);
            CompraProdsproductosDataGridView.Name = "CompraProdsproductosDataGridView";
            CompraProdsproductosDataGridView.RowHeadersWidth = 51;
            CompraProdsproductosDataGridView.Size = new Size(621, 197);
            CompraProdsproductosDataGridView.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(654, 278);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(172, 34);
            button1.TabIndex = 4;
            button1.Text = "Comprar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(CompraProdsproductosDataGridView);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(CompraProdListaComprasDataGridView);
            panel1.Location = new Point(34, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(1408, 362);
            panel1.TabIndex = 5;
            // 
            // ComprarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1489, 694);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ComprarProducto";
            Text = "ComprarProducto";
            Load += ComprarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)CompraProdListaComprasDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)CompraProdsproductosDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView CompraProdListaComprasDataGridView;
        private Label label1;
        private Label label2;
        private DataGridView CompraProdsproductosDataGridView;
        private Button button1;
        private Panel panel1;
    }
}