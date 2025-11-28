namespace WinForms
{
    partial class VerMisVendedores
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
            label1 = new Label();
            misVendedoresDataGridView = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)misVendedoresDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(523, 27);
            label1.Name = "label1";
            label1.Size = new Size(260, 46);
            label1.TabIndex = 5;
            label1.Text = "Mis Vendedores";
            // 
            // misVendedoresDataGridView
            // 
            misVendedoresDataGridView.ColumnHeadersHeight = 29;
            misVendedoresDataGridView.Location = new Point(39, 93);
            misVendedoresDataGridView.Name = "misVendedoresDataGridView";
            misVendedoresDataGridView.RowHeadersWidth = 51;
            misVendedoresDataGridView.Size = new Size(1202, 305);
            misVendedoresDataGridView.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(misVendedoresDataGridView);
            panel1.Location = new Point(16, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(1279, 509);
            panel1.TabIndex = 6;
            // 
            // VerMisVendedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 587);
            Controls.Add(panel1);
            Name = "VerMisVendedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VerMisVendedores";
            Load += MisVendedores_Load;
            ((System.ComponentModel.ISupportInitialize)misVendedoresDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private DataGridView misVendedoresDataGridView;
        private Panel panel1;
    }
}