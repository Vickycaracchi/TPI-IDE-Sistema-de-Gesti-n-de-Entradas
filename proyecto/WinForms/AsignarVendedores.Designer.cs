namespace WinForms
{
    partial class AsignarVendedores
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            jefesLabel = new Label();
            vendedoresLabel = new Label();
            jefesDataGridView = new DataGridView();
            vendedoresDataGridView = new DataGridView();
            asignarButton = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)jefesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vendedoresDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // jefesLabel
            // 
            jefesLabel.AutoSize = true;
            jefesLabel.Font = new Font("Segoe UI", 14F);
            jefesLabel.Location = new Point(29, 5);
            jefesLabel.Name = "jefesLabel";
            jefesLabel.Size = new Size(112, 25);
            jefesLabel.TabIndex = 0;
            jefesLabel.Text = "Elija un Jefe";
            
            // 
            // vendedoresLabel
            // 
            vendedoresLabel.AutoSize = true;
            vendedoresLabel.Font = new Font("Segoe UI", 14F);
            vendedoresLabel.Location = new Point(26, 342);
            vendedoresLabel.Name = "vendedoresLabel";
            vendedoresLabel.Size = new Size(163, 25);
            vendedoresLabel.TabIndex = 1;
            vendedoresLabel.Text = "Elija un vendedor:";
            vendedoresLabel.Click += vendedoresLabel_Click;
            // 
            // jefesDataGridView
            // 
            jefesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            jefesDataGridView.Location = new Point(26, 35);
            jefesDataGridView.Margin = new Padding(3, 2, 3, 2);
            jefesDataGridView.Name = "jefesDataGridView";
            jefesDataGridView.RowHeadersWidth = 51;
            jefesDataGridView.Size = new Size(1244, 305);
            jefesDataGridView.TabIndex = 2;
           
            // 
            // vendedoresDataGridView
            // 
            vendedoresDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vendedoresDataGridView.Location = new Point(26, 368);
            vendedoresDataGridView.Margin = new Padding(3, 2, 3, 2);
            vendedoresDataGridView.Name = "vendedoresDataGridView";
            vendedoresDataGridView.RowHeadersWidth = 51;
            vendedoresDataGridView.Size = new Size(1244, 305);
            vendedoresDataGridView.TabIndex = 3;
           
            // 
            // asignarButton
            // 
            asignarButton.Location = new Point(26, 678);
            asignarButton.Name = "asignarButton";
            asignarButton.Size = new Size(143, 38);
            asignarButton.TabIndex = 4;
            asignarButton.Text = "Asignar";
            asignarButton.UseVisualStyleBackColor = true;
            asignarButton.Click += asignarButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(asignarButton);
            panel1.Controls.Add(vendedoresDataGridView);
            panel1.Controls.Add(jefesDataGridView);
            panel1.Controls.Add(vendedoresLabel);
            panel1.Controls.Add(jefesLabel);
            panel1.Location = new Point(5, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1313, 719);
            panel1.TabIndex = 5;
            // 
            // AsignarVendedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1461, 768);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AsignarVendedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Asignar Vendedores";
            Load += AsignarVendedores_Load;
            ((System.ComponentModel.ISupportInitialize)jefesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)vendedoresDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label jefesLabel;
        private Label vendedoresLabel;
        private DataGridView jefesDataGridView;
        private DataGridView vendedoresDataGridView;
        private Button asignarButton;
        private Panel panel1;
    }
}

