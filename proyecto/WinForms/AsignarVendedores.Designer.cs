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
            jefesComboBox = new ComboBox();
            vendedoresComboBox = new ComboBox();
            asignarButton = new Button();
            SuspendLayout();
            // 
            // jefesLabel
            // 
            jefesLabel.AutoSize = true;
            jefesLabel.Location = new Point(20, 30);
            jefesLabel.Name = "jefesLabel";
            jefesLabel.Size = new Size(35, 15);
            jefesLabel.TabIndex = 0;
            jefesLabel.Text = "Jefe:";
            // 
            // vendedoresLabel
            // 
            vendedoresLabel.AutoSize = true;
            vendedoresLabel.Location = new Point(20, 80);
            vendedoresLabel.Name = "vendedoresLabel";
            vendedoresLabel.Size = new Size(68, 15);
            vendedoresLabel.TabIndex = 1;
            vendedoresLabel.Text = "Vendedor:";
            // 
            // jefesComboBox
            // 
            jefesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            jefesComboBox.FormattingEnabled = true;
            jefesComboBox.Location = new Point(100, 27);
            jefesComboBox.Name = "jefesComboBox";
            jefesComboBox.Size = new Size(300, 23);
            jefesComboBox.TabIndex = 2;
            // 
            // vendedoresComboBox
            // 
            vendedoresComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            vendedoresComboBox.FormattingEnabled = true;
            vendedoresComboBox.Location = new Point(100, 77);
            vendedoresComboBox.Name = "vendedoresComboBox";
            vendedoresComboBox.Size = new Size(300, 23);
            vendedoresComboBox.TabIndex = 3;
            // 
            // asignarButton
            // 
            asignarButton.Location = new Point(100, 130);
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
            ClientSize = new Size(450, 200);
            Controls.Add(asignarButton);
            Controls.Add(vendedoresComboBox);
            Controls.Add(jefesComboBox);
            Controls.Add(vendedoresLabel);
            Controls.Add(jefesLabel);
            Name = "AsignarVendedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Asignar Vendedores";
            Load += AsignarVendedores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label jefesLabel;
        private Label vendedoresLabel;
        private ComboBox jefesComboBox;
        private ComboBox vendedoresComboBox;
        private Button asignarButton;
    }
}

