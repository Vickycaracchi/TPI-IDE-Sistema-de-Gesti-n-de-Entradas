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
            lugaresDataGridView = new DataGridView();
            eliminarButtonLugar = new Button();
            modificarButtonLugar = new Button();
            agregarButtonLugar = new Button();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)lugaresDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lugaresDataGridView
            // 
            lugaresDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lugaresDataGridView.Location = new Point(20, 50);
            lugaresDataGridView.Margin = new Padding(3, 2, 3, 2);
            lugaresDataGridView.Name = "lugaresDataGridView";
            lugaresDataGridView.RowHeadersWidth = 51;
            lugaresDataGridView.RowTemplate.Height = 29;
            lugaresDataGridView.Size = new Size(732, 305);
            lugaresDataGridView.TabIndex = 0;
            lugaresDataGridView.CellContentClick += lugaresDataGridView_CellContentClick;
            // 
            // eliminarButtonLugar
            // 
            eliminarButtonLugar.Location = new Point(117, 359);
            eliminarButtonLugar.Margin = new Padding(3, 2, 3, 2);
            eliminarButtonLugar.Name = "eliminarButtonLugar";
            eliminarButtonLugar.Size = new Size(143, 38);
            eliminarButtonLugar.TabIndex = 1;
            eliminarButtonLugar.Text = "Eliminar";
            eliminarButtonLugar.UseVisualStyleBackColor = true;
            eliminarButtonLugar.Click += eliminarButton_Click;
            // 
            // modificarButtonLugar
            // 
            modificarButtonLugar.Location = new Point(292, 359);
            modificarButtonLugar.Margin = new Padding(3, 2, 3, 2);
            modificarButtonLugar.Name = "modificarButtonLugar";
            modificarButtonLugar.Size = new Size(143, 38);
            modificarButtonLugar.TabIndex = 2;
            modificarButtonLugar.Text = "Modificar";
            modificarButtonLugar.UseVisualStyleBackColor = true;
            modificarButtonLugar.Click += modificarButton_Click;
            // 
            // agregarButtonLugar
            // 
            agregarButtonLugar.Location = new Point(470, 359);
            agregarButtonLugar.Margin = new Padding(3, 2, 3, 2);
            agregarButtonLugar.Name = "agregarButtonLugar";
            agregarButtonLugar.Size = new Size(143, 38);
            agregarButtonLugar.TabIndex = 3;
            agregarButtonLugar.Text = "Agregar";
            agregarButtonLugar.UseVisualStyleBackColor = true;
            agregarButtonLugar.Click += agregarButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(255, 6);
            label1.Name = "label1";
            label1.Size = new Size(244, 37);
            label1.TabIndex = 5;
            label1.Text = "Gestión de Lugares";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(agregarButtonLugar);
            panel1.Controls.Add(modificarButtonLugar);
            panel1.Controls.Add(eliminarButtonLugar);
            panel1.Controls.Add(lugaresDataGridView);
            panel1.Location = new Point(10, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(775, 414);
            panel1.TabIndex = 6;
            // 
            // LugaresLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 490);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LugaresLista";
            Text = "Gestión de Lugares";
            Load += LugaresLista_Load;
            ((System.ComponentModel.ISupportInitialize)lugaresDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView lugaresDataGridView;
        private System.Windows.Forms.Button eliminarButtonLugar;
        private System.Windows.Forms.Button modificarButtonLugar;
        private System.Windows.Forms.Button agregarButtonLugar;
        private Label label1;
        private Panel panel1;
    }
}
