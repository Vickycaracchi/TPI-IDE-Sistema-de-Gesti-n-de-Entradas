namespace WinForms
{
    partial class RegistrarVendedor
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
            contrasenaTextBox = new TextBox();
            contrasenaLabel = new Label();
            enviarRegistroVendedor = new Button();
            cvuTextBox = new TextBox();
            dniTextBox = new TextBox();
            emailTextBox = new TextBox();
            apellidoTextBox = new TextBox();
            cvuLabel = new Label();
            dniLabel = new Label();
            emailLabel = new Label();
            fechaNacLabel = new Label();
            apellidoLabel = new Label();
            nombreTextBox = new TextBox();
            nombreLabel = new Label();
            tipoListBox = new ListBox();
            registrarVendedorErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)registrarVendedorErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // contrasenaTextBox
            // 
            contrasenaTextBox.Location = new Point(547, 306);
            contrasenaTextBox.Name = "contrasenaTextBox";
            contrasenaTextBox.Size = new Size(326, 27);
            contrasenaTextBox.TabIndex = 9;
            contrasenaTextBox.UseSystemPasswordChar = true;
            // 
            // contrasenaLabel
            // 
            contrasenaLabel.AutoSize = true;
            contrasenaLabel.Location = new Point(348, 309);
            contrasenaLabel.Name = "contrasenaLabel";
            contrasenaLabel.Size = new Size(83, 20);
            contrasenaLabel.TabIndex = 8;
            contrasenaLabel.Text = "Contrasena";
            // 
            // enviarRegistroVendedor
            // 
            enviarRegistroVendedor.Location = new Point(547, 515);
            enviarRegistroVendedor.Name = "enviarRegistroVendedor";
            enviarRegistroVendedor.Size = new Size(94, 29);
            enviarRegistroVendedor.TabIndex = 14;
            enviarRegistroVendedor.Text = "Enviar";
            enviarRegistroVendedor.UseVisualStyleBackColor = true;
            enviarRegistroVendedor.Click += enviarRegistroVendedor_Click;
            // 
            // cvuTextBox
            // 
            cvuTextBox.Location = new Point(547, 350);
            cvuTextBox.Name = "cvuTextBox";
            cvuTextBox.Size = new Size(326, 27);
            cvuTextBox.TabIndex = 11;
            // 
            // dniTextBox
            // 
            dniTextBox.Location = new Point(547, 103);
            dniTextBox.Name = "dniTextBox";
            dniTextBox.Size = new Size(326, 27);
            dniTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(547, 253);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(326, 27);
            emailTextBox.TabIndex = 7;
            // 
            // apellidoTextBox
            // 
            apellidoTextBox.Location = new Point(547, 205);
            apellidoTextBox.Name = "apellidoTextBox";
            apellidoTextBox.Size = new Size(326, 27);
            apellidoTextBox.TabIndex = 5;
            // 
            // cvuLabel
            // 
            cvuLabel.AutoSize = true;
            cvuLabel.Location = new Point(348, 353);
            cvuLabel.Name = "cvuLabel";
            cvuLabel.Size = new Size(33, 20);
            cvuLabel.TabIndex = 10;
            cvuLabel.Text = "Cvu";
            // 
            // dniLabel
            // 
            dniLabel.AutoSize = true;
            dniLabel.Location = new Point(348, 110);
            dniLabel.Name = "dniLabel";
            dniLabel.Size = new Size(32, 20);
            dniLabel.TabIndex = 0;
            dniLabel.Text = "Dni";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(348, 260);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(46, 20);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email";
            // 
            // fechaNacLabel
            // 
            fechaNacLabel.AutoSize = true;
            fechaNacLabel.Location = new Point(348, 400);
            fechaNacLabel.Name = "fechaNacLabel";
            fechaNacLabel.Size = new Size(39, 20);
            fechaNacLabel.TabIndex = 12;
            fechaNacLabel.Text = "Tipo";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new Point(348, 208);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new Size(66, 20);
            apellidoLabel.TabIndex = 4;
            apellidoLabel.Text = "Apellido";
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(547, 158);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(326, 27);
            nombreTextBox.TabIndex = 3;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(348, 161);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(64, 20);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "Nombre";
            // 
            // tipoListBox
            // 
            tipoListBox.FormattingEnabled = true;
            tipoListBox.Location = new Point(547, 400);
            tipoListBox.Name = "tipoListBox";
            tipoListBox.Size = new Size(326, 24);
            tipoListBox.TabIndex = 13;
            // 
            // registrarVendedorErrorProvider
            // 
            registrarVendedorErrorProvider.ContainerControl = this;
            // 
            // RegistrarVendedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 657);
            Controls.Add(tipoListBox);
            Controls.Add(contrasenaTextBox);
            Controls.Add(contrasenaLabel);
            Controls.Add(enviarRegistroVendedor);
            Controls.Add(cvuTextBox);
            Controls.Add(dniTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(apellidoTextBox);
            Controls.Add(cvuLabel);
            Controls.Add(dniLabel);
            Controls.Add(emailLabel);
            Controls.Add(fechaNacLabel);
            Controls.Add(apellidoLabel);
            Controls.Add(nombreTextBox);
            Controls.Add(nombreLabel);
            Name = "RegistrarVendedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrarVendedor";
            ((System.ComponentModel.ISupportInitialize)registrarVendedorErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox contrasenaTextBox;
        private Label contrasenaLabel;
        private DateTimePicker fechaNacDatePicker;
        private Button enviarRegistroVendedor;
        private TextBox cvuTextBox;
        private TextBox dniTextBox;
        private TextBox emailTextBox;
        private TextBox apellidoTextBox;
        private Label cvuLabel;
        private Label dniLabel;
        private Label emailLabel;
        private Label fechaNacLabel;
        private Label apellidoLabel;
        private TextBox nombreTextBox;
        private Label nombreLabel;
        private ListBox tipoListBox;
        private ErrorProvider registrarVendedorErrorProvider;
    }
}