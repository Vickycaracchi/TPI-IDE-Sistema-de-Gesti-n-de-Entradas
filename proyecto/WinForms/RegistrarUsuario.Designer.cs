namespace WinForms
{
    partial class RegistrarUsuario
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
            enviarRegistroUsuario = new Button();
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
            registrarUsuarioErrorProvider = new ErrorProvider(components);
            tipoComboBox = new ComboBox();
            fechaNacDatePicker = new DateTimePicker();
            instagramTextBox = new TextBox();
            numeroTelefonoTextBox = new TextBox();
            instagramLabel = new Label();
            numeroTelefono = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)registrarUsuarioErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // contrasenaTextBox
            // 
            contrasenaTextBox.Location = new Point(547, 233);
            contrasenaTextBox.Name = "contrasenaTextBox";
            contrasenaTextBox.Size = new Size(326, 27);
            contrasenaTextBox.TabIndex = 9;
            contrasenaTextBox.UseSystemPasswordChar = true;
            // 
            // contrasenaLabel
            // 
            contrasenaLabel.AutoSize = true;
            contrasenaLabel.Location = new Point(348, 236);
            contrasenaLabel.Name = "contrasenaLabel";
            contrasenaLabel.Size = new Size(83, 20);
            contrasenaLabel.TabIndex = 8;
            contrasenaLabel.Text = "Contrasena";
            // 
            // enviarRegistroUsuario
            // 
            enviarRegistroUsuario.Location = new Point(547, 515);
            enviarRegistroUsuario.Name = "enviarRegistroUsuario";
            enviarRegistroUsuario.Size = new Size(94, 29);
            enviarRegistroUsuario.TabIndex = 14;
            enviarRegistroUsuario.Text = "Enviar";
            enviarRegistroUsuario.UseVisualStyleBackColor = true;
            enviarRegistroUsuario.Click += enviarRegistroUsuario_Click;
            // 
            // cvuTextBox
            // 
            cvuTextBox.Location = new Point(547, 277);
            cvuTextBox.Name = "cvuTextBox";
            cvuTextBox.Size = new Size(326, 27);
            cvuTextBox.TabIndex = 11;
            // 
            // dniTextBox
            // 
            dniTextBox.Location = new Point(547, 30);
            dniTextBox.Name = "dniTextBox";
            dniTextBox.Size = new Size(326, 27);
            dniTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(547, 180);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(326, 27);
            emailTextBox.TabIndex = 7;
            // 
            // apellidoTextBox
            // 
            apellidoTextBox.Location = new Point(547, 132);
            apellidoTextBox.Name = "apellidoTextBox";
            apellidoTextBox.Size = new Size(326, 27);
            apellidoTextBox.TabIndex = 5;
            // 
            // cvuLabel
            // 
            cvuLabel.AutoSize = true;
            cvuLabel.Location = new Point(348, 280);
            cvuLabel.Name = "cvuLabel";
            cvuLabel.Size = new Size(33, 20);
            cvuLabel.TabIndex = 10;
            cvuLabel.Text = "Cvu";
            // 
            // dniLabel
            // 
            dniLabel.AutoSize = true;
            dniLabel.Location = new Point(348, 37);
            dniLabel.Name = "dniLabel";
            dniLabel.Size = new Size(32, 20);
            dniLabel.TabIndex = 0;
            dniLabel.Text = "Dni";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(348, 187);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(46, 20);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email";
            // 
            // fechaNacLabel
            // 
            fechaNacLabel.AutoSize = true;
            fechaNacLabel.Location = new Point(348, 327);
            fechaNacLabel.Name = "fechaNacLabel";
            fechaNacLabel.Size = new Size(39, 20);
            fechaNacLabel.TabIndex = 12;
            fechaNacLabel.Text = "Tipo";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new Point(348, 135);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new Size(66, 20);
            apellidoLabel.TabIndex = 4;
            apellidoLabel.Text = "Apellido";
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(547, 85);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(326, 27);
            nombreTextBox.TabIndex = 3;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(348, 88);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(64, 20);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "Nombre";
            // 
            // registrarUsuarioErrorProvider
            // 
            registrarUsuarioErrorProvider.ContainerControl = this;
            // 
            // tipoComboBox
            // 
            tipoComboBox.FormattingEnabled = true;
            tipoComboBox.Location = new Point(547, 327);
            tipoComboBox.Name = "tipoComboBox";
            tipoComboBox.Size = new Size(151, 28);
            tipoComboBox.TabIndex = 15;
            // 
            // fechaNacDatePicker
            // 
            fechaNacDatePicker.Location = new Point(547, 468);
            fechaNacDatePicker.Name = "fechaNacDatePicker";
            fechaNacDatePicker.Size = new Size(250, 27);
            fechaNacDatePicker.TabIndex = 21;
            fechaNacDatePicker.Value = new DateTime(2004, 4, 3, 0, 0, 0, 0);
            // 
            // instagramTextBox
            // 
            instagramTextBox.Location = new Point(547, 420);
            instagramTextBox.Name = "instagramTextBox";
            instagramTextBox.Size = new Size(326, 27);
            instagramTextBox.TabIndex = 19;
            // 
            // numeroTelefonoTextBox
            // 
            numeroTelefonoTextBox.Location = new Point(547, 372);
            numeroTelefonoTextBox.Name = "numeroTelefonoTextBox";
            numeroTelefonoTextBox.Size = new Size(326, 27);
            numeroTelefonoTextBox.TabIndex = 17;
            // 
            // instagramLabel
            // 
            instagramLabel.AutoSize = true;
            instagramLabel.Location = new Point(348, 423);
            instagramLabel.Name = "instagramLabel";
            instagramLabel.Size = new Size(75, 20);
            instagramLabel.TabIndex = 18;
            instagramLabel.Text = "Instagram";
            // 
            // numeroTelefono
            // 
            numeroTelefono.AutoSize = true;
            numeroTelefono.Location = new Point(348, 379);
            numeroTelefono.Name = "numeroTelefono";
            numeroTelefono.Size = new Size(144, 20);
            numeroTelefono.TabIndex = 16;
            numeroTelefono.Text = "Numero de telefono";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(348, 468);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 20;
            label1.Text = "Fecha de nacimiento";
            // 
            // RegistrarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 657);
            Controls.Add(fechaNacDatePicker);
            Controls.Add(instagramTextBox);
            Controls.Add(numeroTelefonoTextBox);
            Controls.Add(instagramLabel);
            Controls.Add(numeroTelefono);
            Controls.Add(label1);
            Controls.Add(tipoComboBox);
            Controls.Add(contrasenaTextBox);
            Controls.Add(contrasenaLabel);
            Controls.Add(enviarRegistroUsuario);
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
            Name = "RegistrarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar usuario";
            ((System.ComponentModel.ISupportInitialize)registrarUsuarioErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox contrasenaTextBox;
        private Label contrasenaLabel;
        private Button enviarRegistroUsuario;
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
        private ErrorProvider registrarUsuarioErrorProvider;
        private ComboBox tipoComboBox;
        private DateTimePicker fechaNacDatePicker;
        private TextBox instagramTextBox;
        private TextBox numeroTelefonoTextBox;
        private Label instagramLabel;
        private Label numeroTelefono;
        private Label label1;
    }
}