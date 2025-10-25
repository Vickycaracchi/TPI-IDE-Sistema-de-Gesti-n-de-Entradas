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
            this.lotesDataGridView = new System.Windows.Forms.DataGridView();
            this.eliminarButtonLote = new System.Windows.Forms.Button();
            this.modificarButtonLote = new System.Windows.Forms.Button();
            this.agregarButtonLote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lotesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lotesDataGridView
            // 
            this.lotesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lotesDataGridView.Location = new System.Drawing.Point(20, 20);
            this.lotesDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lotesDataGridView.Name = "lotesDataGridView";
            this.lotesDataGridView.RowHeadersWidth = 51;
            this.lotesDataGridView.RowTemplate.Height = 29;
            this.lotesDataGridView.Size = new System.Drawing.Size(700, 230);
            this.lotesDataGridView.TabIndex = 0;
            this.lotesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lotesDataGridView_CellContentClick);
            // 
            // eliminarButtonLote
            // 
            this.eliminarButtonLote.Location = new System.Drawing.Point(20, 266);
            this.eliminarButtonLote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eliminarButtonLote.Name = "eliminarButtonLote";
            this.eliminarButtonLote.Size = new System.Drawing.Size(143, 38);
            this.eliminarButtonLote.TabIndex = 1;
            this.eliminarButtonLote.Text = "Eliminar";
            this.eliminarButtonLote.UseVisualStyleBackColor = true;
            this.eliminarButtonLote.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // modificarButtonLote
            // 
            this.modificarButtonLote.Location = new System.Drawing.Point(195, 266);
            this.modificarButtonLote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modificarButtonLote.Name = "modificarButtonLote";
            this.modificarButtonLote.Size = new System.Drawing.Size(143, 38);
            this.modificarButtonLote.TabIndex = 2;
            this.modificarButtonLote.Text = "Modificar";
            this.modificarButtonLote.UseVisualStyleBackColor = true;
            this.modificarButtonLote.Click += new System.EventHandler(this.modificarButton_Click);
            // 
            // agregarButtonLote
            // 
            this.agregarButtonLote.Location = new System.Drawing.Point(373, 266);
            this.agregarButtonLote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.agregarButtonLote.Name = "agregarButtonLote";
            this.agregarButtonLote.Size = new System.Drawing.Size(143, 38);
            this.agregarButtonLote.TabIndex = 3;
            this.agregarButtonLote.Text = "Agregar";
            this.agregarButtonLote.UseVisualStyleBackColor = true;
            this.agregarButtonLote.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // LotesLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 324);
            this.Controls.Add(this.agregarButtonLote);
            this.Controls.Add(this.modificarButtonLote);
            this.Controls.Add(this.eliminarButtonLote);
            this.Controls.Add(this.lotesDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LotesLista";
            this.Text = "Gestión de Lotes";
            this.Load += new System.EventHandler(this.LotesLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lotesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView lotesDataGridView;
        private System.Windows.Forms.Button eliminarButtonLote;
        private System.Windows.Forms.Button modificarButtonLote;
        private System.Windows.Forms.Button agregarButtonLote;
    }
}
