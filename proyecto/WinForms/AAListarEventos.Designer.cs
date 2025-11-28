namespace WinForms
{
    partial class ListarEventos
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
            EventosDataGridView = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)EventosDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // EventosDataGridView
            // 
            EventosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EventosDataGridView.Location = new Point(36, 47);
            EventosDataGridView.Name = "EventosDataGridView";
            EventosDataGridView.Size = new Size(732, 305);
            EventosDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(36, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 21);
            label1.TabIndex = 1;
            label1.Text = "Listado de Eventos";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(EventosDataGridView);
            panel1.Location = new Point(56, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 379);
            panel1.TabIndex = 2;
            // 
            // ListarEventos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 478);
            Controls.Add(panel1);
            Name = "ListarEventos";
            Text = "Form1";
            Load += ListarEventos_Load;
            ((System.ComponentModel.ISupportInitialize)EventosDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView EventosDataGridView;
        private Label label1;
        private Panel panel1;
    }
}