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
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)ListarComprasDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ListarComprasDataGridView
            // 
            ListarComprasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListarComprasDataGridView.Location = new Point(53, 40);
            ListarComprasDataGridView.Margin = new Padding(3, 2, 3, 2);
            ListarComprasDataGridView.Name = "ListarComprasDataGridView";
            ListarComprasDataGridView.RowHeadersWidth = 51;
            ListarComprasDataGridView.Size = new Size(732, 305);
            ListarComprasDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(57, 6);
            label1.Name = "label1";
            label1.Size = new Size(263, 21);
            label1.TabIndex = 2;
            label1.Text = "Fiestas para las que compro entrada:";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ListarComprasDataGridView);
            panel1.Location = new Point(51, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(841, 367);
            panel1.TabIndex = 3;
            // 
            // ListarCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 450);
            Controls.Add(panel1);
            Name = "ListarCompras";
            Text = "ListarCompras";
            Load += ListarCompras_Load;
            ((System.ComponentModel.ISupportInitialize)ListarComprasDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ListarComprasDataGridView;
        private Label label1;
        private Panel panel1;
    }
}