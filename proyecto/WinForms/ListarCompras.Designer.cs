namespace WinForms
{
    partial class ListarCompras
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
            ListarComprasDataGridView = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)ListarComprasDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ListarComprasDataGridView
            // 
            ListarComprasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListarComprasDataGridView.Location = new Point(80, 94);
            ListarComprasDataGridView.Margin = new Padding(3, 2, 3, 2);
            ListarComprasDataGridView.Name = "ListarComprasDataGridView";
            ListarComprasDataGridView.RowHeadersWidth = 51;
            ListarComprasDataGridView.Size = new Size(626, 207);
            ListarComprasDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 60);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 2;
            label1.Text = "Mis compras";
            label1.Click += label1_Click;
            // 
            // ListarCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(ListarComprasDataGridView);
            Name = "ListarCompras";
            Text = "ListarCompras";
            Load += ListarCompras_Load;
            ((System.ComponentModel.ISupportInitialize)ListarComprasDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ListarComprasDataGridView;
        private Label label1;
    }
}