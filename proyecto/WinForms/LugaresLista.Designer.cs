namespace WinForms
{
    partial class LugaresLista
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
            this.lugaresDataGridView = new System.Windows.Forms.DataGridView();
            this.eliminarButtonLugar = new System.Windows.Forms.Button();
            this.modificarButtonLugar = new System.Windows.Forms.Button();
            this.agregarButtonLugar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lugaresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lugaresDataGridView
            // 
            this.lugaresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lugaresDataGridView.Location = new System.Drawing.Point(20, 20);
            this.lugaresDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lugaresDataGridView.Name = "lugaresDataGridView";
            this.lugaresDataGridView.RowHeadersWidth = 51;
            this.lugaresDataGridView.RowTemplate.Height = 29;
            this.lugaresDataGridView.Size = new System.Drawing.Size(496, 230);
            this.lugaresDataGridView.TabIndex = 0;
            this.lugaresDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lugaresDataGridView_CellContentClick);
            // 
            // eliminarButtonLugar
            // 
            this.eliminarButtonLugar.Location = new System.Drawing.Point(20, 266);
            this.eliminarButtonLugar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eliminarButtonLugar.Name = "eliminarButtonLugar";
            this.eliminarButtonLugar.Size = new System.Drawing.Size(143, 38);
            this.eliminarButtonLugar.TabIndex = 1;
            this.eliminarButtonLugar.Text = "Eliminar";
            this.eliminarButtonLugar.UseVisualStyleBackColor = true;
            this.eliminarButtonLugar.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // modificarButtonLugar
            // 
            this.modificarButtonLugar.Location = new System.Drawing.Point(195, 266);
            this.modificarButtonLugar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modificarButtonLugar.Name = "modificarButtonLugar";
            this.modificarButtonLugar.Size = new System.Drawing.Size(143, 38);
            this.modificarButtonLugar.TabIndex = 2;
            this.modificarButtonLugar.Text = "Modificar";
            this.modificarButtonLugar.UseVisualStyleBackColor = true;
            this.modificarButtonLugar.Click += new System.EventHandler(this.modificarButton_Click);
            // 
            // agregarButtonLugar
            // 
            this.agregarButtonLugar.Location = new System.Drawing.Point(373, 266);
            this.agregarButtonLugar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.agregarButtonLugar.Name = "agregarButtonLugar";
            this.agregarButtonLugar.Size = new System.Drawing.Size(143, 38);
            this.agregarButtonLugar.TabIndex = 3;
            this.agregarButtonLugar.Text = "Agregar";
            this.agregarButtonLugar.UseVisualStyleBackColor = true;
            this.agregarButtonLugar.Click += new System.EventHandler(this.agregarButton_Click);
            // 
            // LugaresLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 324);
            this.Controls.Add(this.agregarButtonLugar);
            this.Controls.Add(this.modificarButtonLugar);
            this.Controls.Add(this.eliminarButtonLugar);
            this.Controls.Add(this.lugaresDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LugaresLista";
            this.Text = "Gestión de Lugares";
            this.Load += new System.EventHandler(this.LugaresLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lugaresDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView lugaresDataGridView;
        private System.Windows.Forms.Button eliminarButtonLugar;
        private System.Windows.Forms.Button modificarButtonLugar;
        private System.Windows.Forms.Button agregarButtonLugar;
    }
}
