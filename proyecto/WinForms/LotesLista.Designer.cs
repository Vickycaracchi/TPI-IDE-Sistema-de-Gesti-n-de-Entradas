namespace WinForms
{
    partial class LotesLista
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
            lotesDataGridView = new DataGridView();
            eliminarButtonLote = new Button();
            modificarButtonLote = new Button();
            agregarButtonLote = new Button();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)lotesDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lotesDataGridView
            // 
            lotesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lotesDataGridView.Location = new Point(73, 55);
            lotesDataGridView.Margin = new Padding(3, 2, 3, 2);
            lotesDataGridView.Name = "lotesDataGridView";
            lotesDataGridView.RowHeadersWidth = 51;
            lotesDataGridView.RowTemplate.Height = 29;
            lotesDataGridView.Size = new Size(732, 305);
            lotesDataGridView.TabIndex = 0;
            lotesDataGridView.CellContentClick += lotesDataGridView_CellContentClick;
            // 
            // eliminarButtonLote
            // 
            eliminarButtonLote.Location = new Point(197, 364);
            eliminarButtonLote.Margin = new Padding(3, 2, 3, 2);
            eliminarButtonLote.Name = "eliminarButtonLote";
            eliminarButtonLote.Size = new Size(143, 38);
            eliminarButtonLote.TabIndex = 1;
            eliminarButtonLote.Text = "Eliminar";
            eliminarButtonLote.UseVisualStyleBackColor = true;
            eliminarButtonLote.Click += eliminarButton_Click;
            // 
            // modificarButtonLote
            // 
            modificarButtonLote.Location = new Point(372, 364);
            modificarButtonLote.Margin = new Padding(3, 2, 3, 2);
            modificarButtonLote.Name = "modificarButtonLote";
            modificarButtonLote.Size = new Size(143, 38);
            modificarButtonLote.TabIndex = 2;
            modificarButtonLote.Text = "Modificar";
            modificarButtonLote.UseVisualStyleBackColor = true;
            modificarButtonLote.Click += modificarButton_Click;
            // 
            // agregarButtonLote
            // 
            agregarButtonLote.Location = new Point(550, 364);
            agregarButtonLote.Margin = new Padding(3, 2, 3, 2);
            agregarButtonLote.Name = "agregarButtonLote";
            agregarButtonLote.Size = new Size(143, 38);
            agregarButtonLote.TabIndex = 3;
            agregarButtonLote.Text = "Agregar";
            agregarButtonLote.UseVisualStyleBackColor = true;
            agregarButtonLote.Click += agregarButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(323, 7);
            label1.Name = "label1";
            label1.Size = new Size(215, 37);
            label1.TabIndex = 5;
            label1.Text = "Gestión de Lotes";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(agregarButtonLote);
            panel1.Controls.Add(modificarButtonLote);
            panel1.Controls.Add(eliminarButtonLote);
            panel1.Controls.Add(lotesDataGridView);
            panel1.Location = new Point(131, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(862, 446);
            panel1.TabIndex = 6;
            // 
            // LotesLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1276, 518);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LotesLista";
            Text = "Gestión de Lotes";
            Load += LotesLista_Load;
            ((System.ComponentModel.ISupportInitialize)lotesDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView lotesDataGridView;
        private System.Windows.Forms.Button eliminarButtonLote;
        private System.Windows.Forms.Button modificarButtonLote;
        private System.Windows.Forms.Button agregarButtonLote;
        private Label label1;
        private Panel panel1;
    }
}
