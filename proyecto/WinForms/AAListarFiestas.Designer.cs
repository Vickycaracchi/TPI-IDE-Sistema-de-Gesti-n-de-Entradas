namespace WinForms
{
    partial class ListarFiestas
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
            fiestasDataGridView = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)fiestasDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(132, 21);
            label1.TabIndex = 3;
            label1.Text = "Listado de Fiestas";
            // 
            // fiestasDataGridView
            // 
            fiestasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            fiestasDataGridView.Location = new Point(12, 45);
            fiestasDataGridView.Name = "fiestasDataGridView";
            fiestasDataGridView.Size = new Size(732, 305);
            fiestasDataGridView.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(fiestasDataGridView);
            panel1.Location = new Point(60, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 378);
            panel1.TabIndex = 4;
            // 
            // ListarFiestas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 473);
            Controls.Add(panel1);
            Name = "ListarFiestas";
            Text = "Form1";
            Load += ListarFiestas_Load;
            ((System.ComponentModel.ISupportInitialize)fiestasDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView fiestasDataGridView;
        private Panel panel1;
    }
}