namespace WinForms
{
    partial class IngresarCliente
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
            nombreLabel = new Label();
            nombreTextBox = new TextBox();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            contrasenaLabel = new Label();
            contrasenaTextBox = new TextBox();
            ingresarButton = new Button();
            loginErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)loginErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(182, 85);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(64, 20);
            nombreLabel.TabIndex = 0;
            nombreLabel.Text = "Nombre";
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(424, 85);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(125, 27);
            nombreTextBox.TabIndex = 1;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(182, 161);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(46, 20);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(424, 154);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(125, 27);
            emailTextBox.TabIndex = 3;
            // 
            // contrasenaLabel
            // 
            contrasenaLabel.AutoSize = true;
            contrasenaLabel.Location = new Point(182, 230);
            contrasenaLabel.Name = "contrasenaLabel";
            contrasenaLabel.Size = new Size(83, 20);
            contrasenaLabel.TabIndex = 4;
            contrasenaLabel.Text = "Contrasena";
            // 
            // contrasenaTextBox
            // 
            contrasenaTextBox.Location = new Point(424, 223);
            contrasenaTextBox.Name = "contrasenaTextBox";
            contrasenaTextBox.Size = new Size(125, 27);
            contrasenaTextBox.TabIndex = 5;
            contrasenaTextBox.UseSystemPasswordChar = true;
            // 
            // ingresarButton
            // 
            ingresarButton.Location = new Point(304, 300);
            ingresarButton.Name = "ingresarButton";
            ingresarButton.Size = new Size(94, 29);
            ingresarButton.TabIndex = 6;
            ingresarButton.Text = "Ingresar";
            ingresarButton.UseVisualStyleBackColor = true;
            ingresarButton.Click += ingresarButton_Click;
            // 
            // loginErrorProvider
            // 
            loginErrorProvider.ContainerControl = this;
            // 
            // IngresarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ingresarButton);
            Controls.Add(contrasenaTextBox);
            Controls.Add(contrasenaLabel);
            Controls.Add(emailTextBox);
            Controls.Add(emailLabel);
            Controls.Add(nombreTextBox);
            Controls.Add(nombreLabel);
            Name = "IngresarCliente";
            Text = "IngresarCliente";
            ((System.ComponentModel.ISupportInitialize)loginErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nombreLabel;
        private TextBox nombreTextBox;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Label contrasenaLabel;
        private TextBox contrasenaTextBox;
        private Button ingresarButton;
        private ErrorProvider loginErrorProvider;
    }
}