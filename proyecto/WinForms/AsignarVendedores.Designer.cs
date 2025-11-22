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
            ((System.ComponentModel.ISupportInitialize)jefesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vendedoresDataGridView).BeginInit();
            SuspendLayout();
            // 
            // jefesLabel
            // 
            jefesLabel.AutoSize = true;
            jefesLabel.Location = new Point(20, 9);
            jefesLabel.Name = "jefesLabel";
            jefesLabel.Size = new Size(35, 15);
            jefesLabel.TabIndex = 0;
            jefesLabel.Text = "Jefes:";
            // 
            // vendedoresLabel
            // 
            vendedoresLabel.AutoSize = true;
            vendedoresLabel.Location = new Point(20, 199);
            vendedoresLabel.Name = "vendedoresLabel";
            vendedoresLabel.Size = new Size(68, 15);
            vendedoresLabel.TabIndex = 1;
            vendedoresLabel.Text = "Vendedores:";
            // 
            // jefesDataGridView
            // 
            jefesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            jefesDataGridView.Location = new Point(20, 26);
            jefesDataGridView.Margin = new Padding(3, 2, 3, 2);
            jefesDataGridView.Name = "jefesDataGridView";
            jefesDataGridView.RowHeadersWidth = 51;
            jefesDataGridView.Size = new Size(1156, 170);
            jefesDataGridView.TabIndex = 2;
            // 
            // vendedoresDataGridView
            // 
            vendedoresDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vendedoresDataGridView.Location = new Point(20, 216);
            vendedoresDataGridView.Margin = new Padding(3, 2, 3, 2);
            vendedoresDataGridView.Name = "vendedoresDataGridView";
            vendedoresDataGridView.RowHeadersWidth = 51;
            vendedoresDataGridView.Size = new Size(1156, 170);
            vendedoresDataGridView.TabIndex = 3;
            // 
            // asignarButton
            // 
            asignarButton.Location = new Point(20, 409);
            asignarButton.Name = "asignarButton";
            asignarButton.Size = new Size(143, 38);
            asignarButton.TabIndex = 4;
            asignarButton.Text = "Asignar";
            asignarButton.UseVisualStyleBackColor = true;
            asignarButton.Click += asignarButton_Click;
            // 
            // AsignarVendedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 470);
            Controls.Add(asignarButton);
            Controls.Add(vendedoresDataGridView);
            Controls.Add(jefesDataGridView);
            Controls.Add(vendedoresLabel);
            Controls.Add(jefesLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AsignarVendedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Asignar Vendedores";
            Load += AsignarVendedores_Load;
            ((System.ComponentModel.ISupportInitialize)jefesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)vendedoresDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label jefesLabel;
        private Label vendedoresLabel;
        private DataGridView jefesDataGridView;
        private DataGridView vendedoresDataGridView;
        private Button asignarButton;
    }
}

