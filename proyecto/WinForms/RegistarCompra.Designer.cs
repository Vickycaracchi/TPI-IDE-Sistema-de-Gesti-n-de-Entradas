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
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)clientesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fiestasDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)registrarCompraErrorProvider).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // clientesDataGridView
            // 
            clientesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientesDataGridView.Location = new Point(14, 36);
            clientesDataGridView.Margin = new Padding(3, 2, 3, 2);
            clientesDataGridView.Name = "clientesDataGridView";
            clientesDataGridView.RowHeadersWidth = 51;
            clientesDataGridView.Size = new Size(1244, 305);
            clientesDataGridView.TabIndex = 0;
            clientesDataGridView.CellContentClick += clientesDataGridView_CellContentClick;
            // 
            // cantidadTextBox
            // 
            cantidadTextBox.Location = new Point(387, 693);
            cantidadTextBox.Margin = new Padding(3, 2, 3, 2);
            cantidadTextBox.Name = "cantidadTextBox";
            cantidadTextBox.Size = new Size(110, 23);
            cantidadTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(223, 695);
            label1.Name = "label1";
            label1.Size = new Size(157, 21);
            label1.TabIndex = 5;
            label1.Text = "Cantidad de entradas";
            // 
            // enviarRegCompra
            // 
            enviarRegCompra.Location = new Point(835, 693);
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
            fiestasDataGridView.Location = new Point(14, 370);
            fiestasDataGridView.Margin = new Padding(3, 2, 3, 2);
            fiestasDataGridView.Name = "fiestasDataGridView";
            fiestasDataGridView.RowHeadersWidth = 51;
            fiestasDataGridView.Size = new Size(1244, 305);
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
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(14, 346);
            label2.Name = "label2";
            label2.Size = new Size(112, 21);
            label2.TabIndex = 8;
            label2.Text = "Elija una fiesta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(14, 13);
            label3.Name = "label3";
            label3.Size = new Size(112, 21);
            label3.TabIndex = 9;
            label3.Text = "Elija un cliente:";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(fiestasDataGridView);
            panel1.Controls.Add(enviarRegCompra);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cantidadTextBox);
            panel1.Controls.Add(clientesDataGridView);
            panel1.Location = new Point(9, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1318, 748);
            panel1.TabIndex = 10;
            // 
            // RegistrarCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1362, 776);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RegistrarCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de clientes";
            Load += ClientesLista_Load;
            ((System.ComponentModel.ISupportInitialize)clientesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)fiestasDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)registrarCompraErrorProvider).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel1;
    }
}