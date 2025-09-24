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
            ((System.ComponentModel.ISupportInitialize)clientesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // clientesDataGridView
            // 
            clientesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientesDataGridView.Location = new Point(23, 24);
            clientesDataGridView.Name = "clientesDataGridView";
            clientesDataGridView.RowHeadersWidth = 51;
            clientesDataGridView.Size = new Size(748, 306);
            clientesDataGridView.TabIndex = 0;
            clientesDataGridView.CellContentClick += clientesDataGridView_CellContentClick;
            // 
            // eliminarButtonCliente
            // 
            eliminarButtonCliente.Location = new Point(23, 355);
            eliminarButtonCliente.Name = "eliminarButtonCliente";
            eliminarButtonCliente.Size = new Size(163, 50);
            eliminarButtonCliente.TabIndex = 1;
            eliminarButtonCliente.Text = "Eliminar";
            eliminarButtonCliente.UseVisualStyleBackColor = true;
            eliminarButtonCliente.Click += eliminarButton_Click;
            // 
            // modificarButtonCliente
            // 
            modificarButtonCliente.Location = new Point(223, 355);
            modificarButtonCliente.Name = "modificarButtonCliente";
            modificarButtonCliente.Size = new Size(163, 50);
            modificarButtonCliente.TabIndex = 2;
            modificarButtonCliente.Text = "Modificar";
            modificarButtonCliente.UseVisualStyleBackColor = true;
            modificarButtonCliente.Click += modificarButton_Click;
            // 
            // agregarButtonCliente
            // 
            agregarButtonCliente.Location = new Point(426, 355);
            agregarButtonCliente.Name = "agregarButtonCliente";
            agregarButtonCliente.Size = new Size(163, 50);
            agregarButtonCliente.TabIndex = 3;
            agregarButtonCliente.Text = "Agregar";
            agregarButtonCliente.UseVisualStyleBackColor = true;
            agregarButtonCliente.Click += agregarButton_Click;
            // 
            // ClientesLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(agregarButtonCliente);
            Controls.Add(modificarButtonCliente);
            Controls.Add(eliminarButtonCliente);
            Controls.Add(clientesDataGridView);
            Name = "ClientesLista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += ClientesLista_Load;
            ((System.ComponentModel.ISupportInitialize)clientesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView clientesDataGridView;
        private Button eliminarButtonCliente;
        private Button modificarButtonCliente;
        private Button agregarButtonCliente;
    }
}