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
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)clientesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fiestasDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)registrarCompraErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // clientesDataGridView
            // 
            clientesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientesDataGridView.Location = new Point(20, 26);
            clientesDataGridView.Margin = new Padding(3, 2, 3, 2);
            clientesDataGridView.Name = "clientesDataGridView";
            clientesDataGridView.RowHeadersWidth = 51;
            clientesDataGridView.Size = new Size(1156, 170);
            clientesDataGridView.TabIndex = 0;
            clientesDataGridView.CellContentClick += clientesDataGridView_CellContentClick;
            // 
            // cantidadTextBox
            // 
            cantidadTextBox.Location = new Point(353, 409);
            cantidadTextBox.Margin = new Padding(3, 2, 3, 2);
            cantidadTextBox.Name = "cantidadTextBox";
            cantidadTextBox.Size = new Size(110, 23);
            cantidadTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 411);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 5;
            label1.Text = "Cantidad de entradas";
            // 
            // enviarRegCompra
            // 
            enviarRegCompra.Location = new Point(801, 409);
            enviarRegCompra.Margin = new Padding(3, 2, 3, 2);
            enviarRegCompra.Name = "enviarRegCompra";
            enviarRegCompra.Size = new Size(130, 49);
            enviarRegCompra.TabIndex = 6;
            enviarRegCompra.Text = "Enviar";
            enviarRegCompra.UseVisualStyleBackColor = true;
            enviarRegCompra.Click += enviarRegCompra_click;
            // 
            // fiestasDataGridView
            // 
            fiestasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            fiestasDataGridView.Location = new Point(20, 216);
            fiestasDataGridView.Margin = new Padding(3, 2, 3, 2);
            fiestasDataGridView.Name = "fiestasDataGridView";
            fiestasDataGridView.RowHeadersWidth = 51;
            fiestasDataGridView.Size = new Size(1156, 189);
            fiestasDataGridView.TabIndex = 7;
            fiestasDataGridView.CellContentClick += fiestasDataGridView_CellContentClick;
            // 
            // registrarCompraErrorProvider
            // 
            registrarCompraErrorProvider.ContainerControl = this;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 199);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 8;
            label2.Text = "Fiesta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 9);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 9;
            label3.Text = "Cliente";
            // 
            // RegistrarCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 573);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(fiestasDataGridView);
            Controls.Add(enviarRegCompra);
            Controls.Add(label1);
            Controls.Add(cantidadTextBox);
            Controls.Add(clientesDataGridView);
            Margin = new Padding(3, 2, 3, 2);
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
        private Label label3;
        private Label label2;
    }
}