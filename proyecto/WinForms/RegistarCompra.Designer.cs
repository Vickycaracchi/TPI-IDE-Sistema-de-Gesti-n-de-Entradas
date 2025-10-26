namespace WinForms
{
    partial class RegistrarCompra
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
            components = new System.ComponentModel.Container();
            clientesDataGridView = new DataGridView();
            cantidadTextBox = new TextBox();
            label1 = new Label();
            enviarRegCompra = new Button();
            fiestasDataGridView = new DataGridView();
            registrarCompraErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)clientesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fiestasDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)registrarCompraErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // clientesDataGridView
            // 
            clientesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientesDataGridView.Location = new Point(23, 12);
            clientesDataGridView.Name = "clientesDataGridView";
            clientesDataGridView.RowHeadersWidth = 51;
            clientesDataGridView.Size = new Size(1321, 227);
            clientesDataGridView.TabIndex = 0;
            clientesDataGridView.CellContentClick += clientesDataGridView_CellContentClick;
            // 
            // cantidadTextBox
            // 
            cantidadTextBox.Location = new Point(208, 259);
            cantidadTextBox.Name = "cantidadTextBox";
            cantidadTextBox.Size = new Size(125, 27);
            cantidadTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 262);
            label1.Name = "label1";
            label1.Size = new Size(151, 20);
            label1.TabIndex = 5;
            label1.Text = "Cantidad de entradas";
            // 
            // enviarRegCompra
            // 
            enviarRegCompra.Location = new Point(715, 245);
            enviarRegCompra.Name = "enviarRegCompra";
            enviarRegCompra.Size = new Size(149, 65);
            enviarRegCompra.TabIndex = 6;
            enviarRegCompra.Text = "Enviar";
            enviarRegCompra.UseVisualStyleBackColor = true;
            enviarRegCompra.Click += enviarRegCompra_click;
            // 
            // fiestasDataGridView
            // 
            fiestasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            fiestasDataGridView.Location = new Point(21, 312);
            fiestasDataGridView.Name = "fiestasDataGridView";
            fiestasDataGridView.RowHeadersWidth = 51;
            fiestasDataGridView.Size = new Size(1321, 252);
            fiestasDataGridView.TabIndex = 7;
            // 
            // registrarCompraErrorProvider
            // 
            registrarCompraErrorProvider.ContainerControl = this;
            // 
            // RegistrarCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1437, 587);
            Controls.Add(fiestasDataGridView);
            Controls.Add(enviarRegCompra);
            Controls.Add(label1);
            Controls.Add(cantidadTextBox);
            Controls.Add(clientesDataGridView);
            Name = "RegistrarCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de clientes";
            Load += ClientesLista_Load;
            ((System.ComponentModel.ISupportInitialize)clientesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)fiestasDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)registrarCompraErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView clientesDataGridView;
        private TextBox cantidadTextBox;
        private Label label1;
        private Button enviarRegCompra;
        private DataGridView fiestasDataGridView;
        private ErrorProvider registrarCompraErrorProvider;
    }
}