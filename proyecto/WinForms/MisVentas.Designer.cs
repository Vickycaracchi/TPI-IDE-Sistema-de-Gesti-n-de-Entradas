namespace WinForms
{
    partial class MisVentas
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
            misVentasDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)misVentasDataGridView).BeginInit();
            SuspendLayout();
            // 
            // misVentasDataGridView
            // 
            misVentasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            misVentasDataGridView.Location = new Point(40, 37);
            misVentasDataGridView.Name = "misVentasDataGridView";
            misVentasDataGridView.RowHeadersWidth = 51;
            misVentasDataGridView.Size = new Size(716, 276);
            misVentasDataGridView.TabIndex = 0;
            misVentasDataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MisVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(misVentasDataGridView);
            Name = "MisVentas";
            Text = "Mis ventas";
            Load += MisVentas_Load;
            ((System.ComponentModel.ISupportInitialize)misVentasDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView misVentasDataGridView;
    }
}