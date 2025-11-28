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
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)misVentasDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // misVentasDataGridView
            // 
            misVentasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            misVentasDataGridView.Location = new Point(62, 55);
            misVentasDataGridView.Margin = new Padding(3, 2, 3, 2);
            misVentasDataGridView.Name = "misVentasDataGridView";
            misVentasDataGridView.RowHeadersWidth = 51;
            misVentasDataGridView.Size = new Size(732, 305);
            misVentasDataGridView.TabIndex = 0;
            misVentasDataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(354, 10);
            label1.Name = "label1";
            label1.Size = new Size(144, 37);
            label1.TabIndex = 6;
            label1.Text = "Mis Ventas";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(misVentasDataGridView);
            panel1.Location = new Point(90, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(861, 429);
            panel1.TabIndex = 7;
            // 
            // MisVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 605);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MisVentas";
            Text = "Mis ventas";
            Load += MisVentas_Load;
            ((System.ComponentModel.ISupportInitialize)misVentasDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView misVentasDataGridView;
        private Label label1;
        private Panel panel1;
    }
}