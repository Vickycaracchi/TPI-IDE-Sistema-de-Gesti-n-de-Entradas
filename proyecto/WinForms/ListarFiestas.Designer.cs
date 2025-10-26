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
            ((System.ComponentModel.ISupportInitialize)fiestasDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 52);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 3;
            label1.Text = "Listado de Fiestas";
            // 
            // fiestasDataGridView
            // 
            fiestasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            fiestasDataGridView.Location = new Point(88, 90);
            fiestasDataGridView.Name = "fiestasDataGridView";
            fiestasDataGridView.Size = new Size(624, 308);
            fiestasDataGridView.TabIndex = 2;
            // 
            // ListarFiestas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(fiestasDataGridView);
            Name = "ListarFiestas";
            Text = "Form1";
            Load += ListarFiestas_Load;
            ((System.ComponentModel.ISupportInitialize)fiestasDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView fiestasDataGridView;
    }
}