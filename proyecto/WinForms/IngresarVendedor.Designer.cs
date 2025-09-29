namespace WinForms
{
    partial class IngresarVendedor
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
            emailLabel = new Label();
            emailTextBox = new TextBox();
            contrasenaLabel = new Label();
            contrasenaTextBox = new TextBox();
            enviarLoginVendedor = new Button();
            ingresarVendedorErrorProvider = new ErrorProvider(components);
            nombreLabel = new Label();
            nombreTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ingresarVendedorErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(207, 81);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(36, 15);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(360, 76);
            emailTextBox.Margin = new Padding(3, 2, 3, 2);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(110, 23);
            emailTextBox.TabIndex = 1;
            // 
            // contrasenaLabel
            // 
            contrasenaLabel.AutoSize = true;
            contrasenaLabel.Location = new Point(207, 197);
            contrasenaLabel.Name = "contrasenaLabel";
            contrasenaLabel.Size = new Size(67, 15);
            contrasenaLabel.TabIndex = 4;
            contrasenaLabel.Text = "Contrasena";
            // 
            // contrasenaTextBox
            // 
            contrasenaTextBox.Location = new Point(360, 192);
            contrasenaTextBox.Margin = new Padding(3, 2, 3, 2);
            contrasenaTextBox.Name = "contrasenaTextBox";
            contrasenaTextBox.Size = new Size(110, 23);
            contrasenaTextBox.TabIndex = 5;
            // 
            // enviarLoginVendedor
            // 
            enviarLoginVendedor.Location = new Point(301, 266);
            enviarLoginVendedor.Margin = new Padding(3, 2, 3, 2);
            enviarLoginVendedor.Name = "enviarLoginVendedor";
            enviarLoginVendedor.Size = new Size(82, 22);
            enviarLoginVendedor.TabIndex = 6;
            enviarLoginVendedor.Text = "Enviar";
            enviarLoginVendedor.UseVisualStyleBackColor = true;
            enviarLoginVendedor.Click += enviarLoginVendedor_Click;
            // 
            // ingresarVendedorErrorProvider
            // 
            ingresarVendedorErrorProvider.ContainerControl = this;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(207, 142);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(51, 15);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "Nombre";
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(360, 137);
            nombreTextBox.Margin = new Padding(3, 2, 3, 2);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(110, 23);
            nombreTextBox.TabIndex = 3;
            // 
            // IngresarVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(nombreTextBox);
            Controls.Add(nombreLabel);
            Controls.Add(enviarLoginVendedor);
            Controls.Add(contrasenaTextBox);
            Controls.Add(contrasenaLabel);
            Controls.Add(emailTextBox);
            Controls.Add(emailLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "IngresarVendedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IngresarVendedor";
            Load += IngresarVendedor_Load;
            ((System.ComponentModel.ISupportInitialize)ingresarVendedorErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label emailLabel;
        private TextBox emailTextBox;
        private Label contrasenaLabel;
        private TextBox contrasenaTextBox;
        private Button enviarLoginVendedor;
        private ErrorProvider ingresarVendedorErrorProvider;
        private Label nombreLabel;
        private TextBox nombreTextBox;
    }
}