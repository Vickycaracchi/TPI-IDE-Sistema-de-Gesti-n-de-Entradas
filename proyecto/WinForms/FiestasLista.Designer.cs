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
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)FiestasDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // agregarButtonFiesta
            // 
            agregarButtonFiesta.Location = new Point(478, 356);
            agregarButtonFiesta.Margin = new Padding(3, 2, 3, 2);
            agregarButtonFiesta.Name = "agregarButtonFiesta";
            agregarButtonFiesta.Size = new Size(143, 38);
            agregarButtonFiesta.TabIndex = 7;
            agregarButtonFiesta.Text = "Agregar";
            agregarButtonFiesta.UseVisualStyleBackColor = true;
            agregarButtonFiesta.Click += agregarButtonFiesta_Click;
            // 
            // modificarButtonFiesta
            // 
            modificarButtonFiesta.Location = new Point(314, 356);
            modificarButtonFiesta.Margin = new Padding(3, 2, 3, 2);
            modificarButtonFiesta.Name = "modificarButtonFiesta";
            modificarButtonFiesta.Size = new Size(143, 38);
            modificarButtonFiesta.TabIndex = 6;
            modificarButtonFiesta.Text = "Modificar";
            modificarButtonFiesta.UseVisualStyleBackColor = true;
            modificarButtonFiesta.Click += modificarButtonFiesta_Click;
            // 
            // eliminarButtonFiesta
            // 
            eliminarButtonFiesta.Location = new Point(147, 356);
            eliminarButtonFiesta.Margin = new Padding(3, 2, 3, 2);
            eliminarButtonFiesta.Name = "eliminarButtonFiesta";
            eliminarButtonFiesta.Size = new Size(143, 38);
            eliminarButtonFiesta.TabIndex = 5;
            eliminarButtonFiesta.Text = "Eliminar";
            eliminarButtonFiesta.UseVisualStyleBackColor = true;
            eliminarButtonFiesta.Click += eliminarButtonFiesta_Click;
            // 
            // FiestasDataGridView
            // 
            FiestasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FiestasDataGridView.Location = new Point(47, 47);
            FiestasDataGridView.Margin = new Padding(3, 2, 3, 2);
            FiestasDataGridView.Name = "FiestasDataGridView";
            FiestasDataGridView.RowHeadersWidth = 51;
            FiestasDataGridView.Size = new Size(732, 305);
            FiestasDataGridView.TabIndex = 4;
            FiestasDataGridView.CellContentClick += FiestasDataGridView_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(291, 5);
            label1.Name = "label1";
            label1.Size = new Size(231, 37);
            label1.TabIndex = 8;
            label1.Text = "Gestión de Fiestas";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(agregarButtonFiesta);
            panel1.Controls.Add(modificarButtonFiesta);
            panel1.Controls.Add(eliminarButtonFiesta);
            panel1.Controls.Add(FiestasDataGridView);
            panel1.Location = new Point(9, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(832, 423);
            panel1.TabIndex = 9;
            // 
            // FiestasLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 462);
            Controls.Add(panel1);
            Name = "FiestasLista";
            Text = "Form1";
            Load += FiestasLista_Load;
            ((System.ComponentModel.ISupportInitialize)FiestasDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button agregarButtonFiesta;
        private Button modificarButtonFiesta;
        private Button eliminarButtonFiesta;
        private DataGridView FiestasDataGridView;
        private Label label1;
        private Panel panel1;
    }
}