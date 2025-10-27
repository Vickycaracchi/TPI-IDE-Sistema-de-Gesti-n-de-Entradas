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
            ((System.ComponentModel.ISupportInitialize)lotesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // lotesDataGridView
            // 
            lotesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lotesDataGridView.Location = new Point(20, 20);
            lotesDataGridView.Margin = new Padding(3, 2, 3, 2);
            lotesDataGridView.Name = "lotesDataGridView";
            lotesDataGridView.RowHeadersWidth = 51;
            lotesDataGridView.RowTemplate.Height = 29;
            lotesDataGridView.Size = new Size(700, 230);
            lotesDataGridView.TabIndex = 0;
            lotesDataGridView.CellContentClick += lotesDataGridView_CellContentClick;
            // 
            // eliminarButtonLote
            // 
            eliminarButtonLote.Location = new Point(20, 266);
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
            modificarButtonLote.Location = new Point(195, 266);
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
            agregarButtonLote.Location = new Point(373, 266);
            agregarButtonLote.Margin = new Padding(3, 2, 3, 2);
            agregarButtonLote.Name = "agregarButtonLote";
            agregarButtonLote.Size = new Size(143, 38);
            agregarButtonLote.TabIndex = 3;
            agregarButtonLote.Text = "Agregar";
            agregarButtonLote.UseVisualStyleBackColor = true;
            agregarButtonLote.Click += agregarButton_Click;
            // 
            // LotesLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 324);
            Controls.Add(agregarButtonLote);
            Controls.Add(modificarButtonLote);
            Controls.Add(eliminarButtonLote);
            Controls.Add(lotesDataGridView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LotesLista";
            Text = "Gestión de Lotes";
            Load += LotesLista_Load;
            ((System.ComponentModel.ISupportInitialize)lotesDataGridView).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView lotesDataGridView;
        private System.Windows.Forms.Button eliminarButtonLote;
        private System.Windows.Forms.Button modificarButtonLote;
        private System.Windows.Forms.Button agregarButtonLote;
    }
}
