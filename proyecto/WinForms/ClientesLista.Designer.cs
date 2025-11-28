namespace WinForms
{
    partial class ClientesLista
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
            clientesDataGridView = new DataGridView();
            eliminarButtonCliente = new Button();
            modificarButtonCliente = new Button();
            agregarButtonCliente = new Button();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)clientesDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // clientesDataGridView
            // 
            clientesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientesDataGridView.Location = new Point(15, 53);
            clientesDataGridView.Margin = new Padding(3, 2, 3, 2);
            clientesDataGridView.Name = "clientesDataGridView";
            clientesDataGridView.RowHeadersWidth = 51;
            clientesDataGridView.Size = new Size(1156, 305);
            clientesDataGridView.TabIndex = 0;
            clientesDataGridView.CellContentClick += clientesDataGridView_CellContentClick;
            // 
            // eliminarButtonCliente
            // 
            eliminarButtonCliente.Location = new Point(313, 362);
            eliminarButtonCliente.Margin = new Padding(3, 2, 3, 2);
            eliminarButtonCliente.Name = "eliminarButtonCliente";
            eliminarButtonCliente.Size = new Size(143, 38);
            eliminarButtonCliente.TabIndex = 1;
            eliminarButtonCliente.Text = "Eliminar";
            eliminarButtonCliente.UseVisualStyleBackColor = true;
            eliminarButtonCliente.Click += eliminarButton_Click;
            // 
            // modificarButtonCliente
            // 
            modificarButtonCliente.Location = new Point(488, 362);
            modificarButtonCliente.Margin = new Padding(3, 2, 3, 2);
            modificarButtonCliente.Name = "modificarButtonCliente";
            modificarButtonCliente.Size = new Size(143, 38);
            modificarButtonCliente.TabIndex = 2;
            modificarButtonCliente.Text = "Modificar";
            modificarButtonCliente.UseVisualStyleBackColor = true;
            modificarButtonCliente.Click += modificarButton_Click;
            // 
            // agregarButtonCliente
            // 
            agregarButtonCliente.Location = new Point(666, 362);
            agregarButtonCliente.Margin = new Padding(3, 2, 3, 2);
            agregarButtonCliente.Name = "agregarButtonCliente";
            agregarButtonCliente.Size = new Size(143, 38);
            agregarButtonCliente.TabIndex = 3;
            agregarButtonCliente.Text = "Agregar";
            agregarButtonCliente.UseVisualStyleBackColor = true;
            agregarButtonCliente.Click += agregarButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(464, 12);
            label1.Name = "label1";
            label1.Size = new Size(246, 37);
            label1.TabIndex = 5;
            label1.Text = "Gestión de Clientes";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(agregarButtonCliente);
            panel1.Controls.Add(modificarButtonCliente);
            panel1.Controls.Add(eliminarButtonCliente);
            panel1.Controls.Add(clientesDataGridView);
            panel1.Location = new Point(41, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(1188, 453);
            panel1.TabIndex = 6;
            // 
            // ClientesLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 583);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ClientesLista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de clientes";
            Load += ClientesLista_Load;
            ((System.ComponentModel.ISupportInitialize)clientesDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView clientesDataGridView;
        private Button eliminarButtonCliente;
        private Button modificarButtonCliente;
        private Button agregarButtonCliente;
        private Label label1;
        private Panel panel1;
    }
}