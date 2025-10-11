namespace WinForms
{
    partial class Login
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
            DniLabel = new Label();
            DniTextBox = new TextBox();
            contrasenaLabel = new Label();
            contrasenaTextBox = new TextBox();
            enviarLoginVendedor = new Button();
            ingresarVendedorErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)ingresarVendedorErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // DniLabel
            // 
            DniLabel.AutoSize = true;
            DniLabel.Location = new Point(267, 121);
            DniLabel.Name = "DniLabel";
            DniLabel.Size = new Size(32, 20);
            DniLabel.TabIndex = 0;
            DniLabel.Text = "Dni";
            // 
            // DniTextBox
            // 
            DniTextBox.Location = new Point(441, 114);
            DniTextBox.Name = "DniTextBox";
            DniTextBox.Size = new Size(125, 27);
            DniTextBox.TabIndex = 1;
            // 
            // contrasenaLabel
            // 
            contrasenaLabel.AutoSize = true;
            contrasenaLabel.Location = new Point(267, 191);
            contrasenaLabel.Name = "contrasenaLabel";
            contrasenaLabel.Size = new Size(83, 20);
            contrasenaLabel.TabIndex = 4;
            contrasenaLabel.Text = "Contrasena";
            // 
            // contrasenaTextBox
            // 
            contrasenaTextBox.Location = new Point(441, 184);
            contrasenaTextBox.Name = "contrasenaTextBox";
            contrasenaTextBox.Size = new Size(125, 27);
            contrasenaTextBox.TabIndex = 5;
            // 
            // enviarLoginVendedor
            // 
            enviarLoginVendedor.Location = new Point(344, 273);
            enviarLoginVendedor.Name = "enviarLoginVendedor";
            enviarLoginVendedor.Size = new Size(94, 29);
            enviarLoginVendedor.TabIndex = 6;
            enviarLoginVendedor.Text = "Enviar";
            enviarLoginVendedor.UseVisualStyleBackColor = true;
            enviarLoginVendedor.Click += enviarLoginVendedor_Click;
            // 
            // ingresarVendedorErrorProvider
            // 
            ingresarVendedorErrorProvider.ContainerControl = this;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(enviarLoginVendedor);
            Controls.Add(contrasenaTextBox);
            Controls.Add(contrasenaLabel);
            Controls.Add(DniTextBox);
            Controls.Add(DniLabel);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)ingresarVendedorErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DniLabel;
        private TextBox DniTextBox;
        private Label contrasenaLabel;
        private TextBox contrasenaTextBox;
        private Button enviarLoginVendedor;
        private ErrorProvider ingresarVendedorErrorProvider;
    }
}