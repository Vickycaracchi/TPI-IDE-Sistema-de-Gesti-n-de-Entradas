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
            ((System.ComponentModel.ISupportInitialize)EventosDataGridView).BeginInit();
            SuspendLayout();
            // 
            // EventosDataGridView
            // 
            EventosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EventosDataGridView.Location = new Point(76, 76);
            EventosDataGridView.Name = "EventosDataGridView";
            EventosDataGridView.Size = new Size(624, 308);
            EventosDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 38);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 1;
            label1.Text = "Listado de Eventos";
            // 
            // ListarEventos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(EventosDataGridView);
            Name = "ListarEventos";
            Text = "Form1";
            Load += ListarEventos_Load;
            ((System.ComponentModel.ISupportInitialize)EventosDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView EventosDataGridView;
        private Label label1;
    }
}