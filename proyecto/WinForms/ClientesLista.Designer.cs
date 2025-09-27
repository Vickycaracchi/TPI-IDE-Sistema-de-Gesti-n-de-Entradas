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
            clientesDataGridView.Location = new Point(20, 18);
            clientesDataGridView.Margin = new Padding(3, 2, 3, 2);
            clientesDataGridView.Name = "clientesDataGridView";
            clientesDataGridView.RowHeadersWidth = 51;
            clientesDataGridView.Size = new Size(654, 230);
            clientesDataGridView.TabIndex = 0;
            clientesDataGridView.CellContentClick += clientesDataGridView_CellContentClick;
            // 
            // eliminarButtonCliente
            // 
            eliminarButtonCliente.Location = new Point(20, 266);
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
            modificarButtonCliente.Location = new Point(195, 266);
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
            agregarButtonCliente.Location = new Point(373, 266);
            agregarButtonCliente.Margin = new Padding(3, 2, 3, 2);
            agregarButtonCliente.Name = "agregarButtonCliente";
            agregarButtonCliente.Size = new Size(143, 38);
            agregarButtonCliente.TabIndex = 3;
            agregarButtonCliente.Text = "Agregar";
            agregarButtonCliente.UseVisualStyleBackColor = true;
            agregarButtonCliente.Click += agregarButton_Click;
            // 
            // ClientesLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(agregarButtonCliente);
            Controls.Add(modificarButtonCliente);
            Controls.Add(eliminarButtonCliente);
            Controls.Add(clientesDataGridView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ClientesLista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de clientes";
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