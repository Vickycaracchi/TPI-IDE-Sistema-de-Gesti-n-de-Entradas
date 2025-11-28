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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)ingresarVendedorErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // DniLabel
            // 
            DniLabel.AutoSize = true;
            DniLabel.Font = new Font("Segoe UI", 14F);
            DniLabel.Location = new Point(207, 102);
            DniLabel.Name = "DniLabel";
            DniLabel.Size = new Size(41, 25);
            DniLabel.TabIndex = 0;
            DniLabel.Text = "Dni";
            // 
            // DniTextBox
            // 
            DniTextBox.Location = new Point(359, 102);
            DniTextBox.Margin = new Padding(3, 2, 3, 2);
            DniTextBox.Name = "DniTextBox";
            DniTextBox.Size = new Size(127, 23);
            DniTextBox.TabIndex = 1;
            // 
            // contrasenaLabel
            // 
            contrasenaLabel.AutoSize = true;
            contrasenaLabel.Font = new Font("Segoe UI", 14F);
            contrasenaLabel.Location = new Point(207, 154);
            contrasenaLabel.Name = "contrasenaLabel";
            contrasenaLabel.Size = new Size(108, 25);
            contrasenaLabel.TabIndex = 4;
            contrasenaLabel.Text = "Contrasena";
            // 
            // contrasenaTextBox
            // 
            contrasenaTextBox.Location = new Point(359, 159);
            contrasenaTextBox.Margin = new Padding(3, 2, 3, 2);
            contrasenaTextBox.Name = "contrasenaTextBox";
            contrasenaTextBox.Size = new Size(127, 23);
            contrasenaTextBox.TabIndex = 5;
            // 
            // enviarLoginVendedor
            // 
            enviarLoginVendedor.Location = new Point(274, 216);
            enviarLoginVendedor.Margin = new Padding(3, 2, 3, 2);
            enviarLoginVendedor.Name = "enviarLoginVendedor";
            enviarLoginVendedor.Size = new Size(143, 38);
            enviarLoginVendedor.TabIndex = 6;
            enviarLoginVendedor.Text = "Enviar";
            enviarLoginVendedor.UseVisualStyleBackColor = true;
            enviarLoginVendedor.Click += enviarLoginVendedor_Click;
            // 
            // ingresarVendedorErrorProvider
            // 
            ingresarVendedorErrorProvider.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(125, 49);
            label1.Name = "label1";
            label1.Size = new Size(434, 25);
            label1.TabIndex = 7;
            label1.Text = "Bienvenido! Iniciá Sesión para acceder a tu cuenta";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label1);
            Controls.Add(enviarLoginVendedor);
            Controls.Add(contrasenaTextBox);
            Controls.Add(contrasenaLabel);
            Controls.Add(DniTextBox);
            Controls.Add(DniLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
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
        private Label label1;
    }
}