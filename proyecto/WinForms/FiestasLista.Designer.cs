namespace WinForms
{
    partial class FiestasLista
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
            agregarButtonFiesta = new Button();
            modificarButtonFiesta = new Button();
            eliminarButtonFiesta = new Button();
            FiestasDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)FiestasDataGridView).BeginInit();
            SuspendLayout();
            // 
            // agregarButtonFiesta
            // 
            agregarButtonFiesta.Location = new Point(409, 257);
            agregarButtonFiesta.Margin = new Padding(3, 2, 3, 2);
            agregarButtonFiesta.Name = "agregarButtonFiesta";
            agregarButtonFiesta.Size = new Size(82, 22);
            agregarButtonFiesta.TabIndex = 7;
            agregarButtonFiesta.Text = "Agregar";
            agregarButtonFiesta.UseVisualStyleBackColor = true;
            this.agregarButtonFiesta.Click += new System.EventHandler(this.agregarButtonFiesta_Click);
            // 
            // modificarButtonFiesta
            // 
            modificarButtonFiesta.Location = new Point(245, 257);
            modificarButtonFiesta.Margin = new Padding(3, 2, 3, 2);
            modificarButtonFiesta.Name = "modificarButtonFiesta";
            modificarButtonFiesta.Size = new Size(82, 22);
            modificarButtonFiesta.TabIndex = 6;
            modificarButtonFiesta.Text = "Modificar";
            modificarButtonFiesta.UseVisualStyleBackColor = true;
            this.modificarButtonFiesta.Click += new System.EventHandler(this.modificarButtonFiesta_Click);
            // 
            // eliminarButtonFiesta
            // 
            eliminarButtonFiesta.Location = new Point(78, 257);
            eliminarButtonFiesta.Margin = new Padding(3, 2, 3, 2);
            eliminarButtonFiesta.Name = "eliminarButtonFiesta";
            eliminarButtonFiesta.Size = new Size(82, 22);
            eliminarButtonFiesta.TabIndex = 5;
            eliminarButtonFiesta.Text = "Eliminar";
            eliminarButtonFiesta.UseVisualStyleBackColor = true;
            this.eliminarButtonFiesta.Click += new System.EventHandler(this.eliminarButtonFiesta_Click);
            // 
            // FiestasDataGridView
            // 
            FiestasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FiestasDataGridView.Location = new Point(29, 25);
            FiestasDataGridView.Margin = new Padding(3, 2, 3, 2);
            FiestasDataGridView.Name = "FiestasDataGridView";
            FiestasDataGridView.RowHeadersWidth = 51;
            FiestasDataGridView.Size = new Size(553, 198);
            FiestasDataGridView.TabIndex = 4;
            // 
            // FiestasLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 306);
            Controls.Add(agregarButtonFiesta);
            Controls.Add(modificarButtonFiesta);
            Controls.Add(eliminarButtonFiesta);
            Controls.Add(FiestasDataGridView);
            Name = "FiestasLista";
            Text = "Form1";
            Load += FiestasLista_Load;
            ((System.ComponentModel.ISupportInitialize)FiestasDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button agregarButtonFiesta;
        private Button modificarButtonFiesta;
        private Button eliminarButtonFiesta;
        private DataGridView FiestasDataGridView;
    }
}