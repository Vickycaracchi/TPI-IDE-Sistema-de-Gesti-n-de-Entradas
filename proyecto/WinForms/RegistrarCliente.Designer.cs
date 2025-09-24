namespace WinForms
{
    partial class RegistrarCliente
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
            idLabel = new Label();
            idTextBox = new TextBox();
            nombreLabel = new Label();
            nombreTextBox = new TextBox();
            apellidoLabel = new Label();
            apellidoTextBox = new TextBox();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            numeroTelefono = new Label();
            numeroTelefonoTextBox = new TextBox();
            instagramLabel = new Label();
            instagramTextBox = new TextBox();
            fechaNacLabel = new Label();
            fechaNacDatePicker = new DateTimePicker();
            button1 = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(52, 19);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(22, 20);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(251, 12);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(326, 27);
            idTextBox.TabIndex = 1;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new Point(52, 60);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(64, 20);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "Nombre";
            nombreLabel.Click += label1_Click;
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(251, 57);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(326, 27);
            nombreTextBox.TabIndex = 3;
            nombreTextBox.TextChanged += textBox1_TextChanged;
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new Point(52, 107);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new Size(66, 20);
            apellidoLabel.TabIndex = 4;
            apellidoLabel.Text = "Apellido";
            apellidoLabel.Click += label2_Click;
            // 
            // apellidoTextBox
            // 
            apellidoTextBox.Location = new Point(251, 104);
            apellidoTextBox.Name = "apellidoTextBox";
            apellidoTextBox.Size = new Size(326, 27);
            apellidoTextBox.TabIndex = 5;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(52, 159);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(46, 20);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(251, 152);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(326, 27);
            emailTextBox.TabIndex = 7;
            emailTextBox.TextChanged += emailTextBox_TextChanged;
            // 
            // numeroTelefono
            // 
            numeroTelefono.AutoSize = true;
            numeroTelefono.Location = new Point(52, 208);
            numeroTelefono.Name = "numeroTelefono";
            numeroTelefono.Size = new Size(144, 20);
            numeroTelefono.TabIndex = 8;
            numeroTelefono.Text = "Numero de telefono";
            numeroTelefono.Click += label5_Click;
            // 
            // numeroTelefonoTextBox
            // 
            numeroTelefonoTextBox.Location = new Point(251, 201);
            numeroTelefonoTextBox.Name = "numeroTelefonoTextBox";
            numeroTelefonoTextBox.Size = new Size(326, 27);
            numeroTelefonoTextBox.TabIndex = 9;
            // 
            // instagramLabel
            // 
            instagramLabel.AutoSize = true;
            instagramLabel.Location = new Point(52, 252);
            instagramLabel.Name = "instagramLabel";
            instagramLabel.Size = new Size(75, 20);
            instagramLabel.TabIndex = 10;
            instagramLabel.Text = "Instagram";
            // 
            // instagramTextBox
            // 
            instagramTextBox.Location = new Point(251, 249);
            instagramTextBox.Name = "instagramTextBox";
            instagramTextBox.Size = new Size(326, 27);
            instagramTextBox.TabIndex = 11;
            // 
            // fechaNacLabel
            // 
            fechaNacLabel.AutoSize = true;
            fechaNacLabel.Location = new Point(52, 297);
            fechaNacLabel.Name = "fechaNacLabel";
            fechaNacLabel.Size = new Size(146, 20);
            fechaNacLabel.TabIndex = 12;
            fechaNacLabel.Text = "Fecha de nacimiento";
            fechaNacLabel.Click += label3_Click;
            // 
            // fechaNacDatePicker
            // 
            fechaNacDatePicker.Location = new Point(251, 297);
            fechaNacDatePicker.Name = "fechaNacDatePicker";
            fechaNacDatePicker.Size = new Size(250, 27);
            fechaNacDatePicker.TabIndex = 13;
            fechaNacDatePicker.Value = new DateTime(2004, 4, 3, 0, 0, 0, 0);
            // 
            // button1
            // 
            button1.Location = new Point(251, 372);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 14;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += enviarFormularioCliente;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // RegistrarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 405);
            Controls.Add(fechaNacDatePicker);
            Controls.Add(idTextBox);
            Controls.Add(idLabel);
            Controls.Add(button1);
            Controls.Add(instagramTextBox);
            Controls.Add(numeroTelefonoTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(apellidoTextBox);
            Controls.Add(instagramLabel);
            Controls.Add(numeroTelefono);
            Controls.Add(emailLabel);
            Controls.Add(fechaNacLabel);
            Controls.Add(apellidoLabel);
            Controls.Add(nombreTextBox);
            Controls.Add(nombreLabel);
            Name = "RegistrarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistrarCliente";
            TopMost = true;
            Load += ClienteDetalle_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nombreLabel;
        private Label apellidoLabel;
        private Label fechaNacLabel;
        private Label emailLabel;
        private Label numeroTelefono;
        private Label instagramLabel;
        private TextBox nombreTextBox;
        private TextBox apellidoTextBox;
        private TextBox emailTextBox;
        private TextBox numeroTelefonoTextBox;
        private TextBox instagramTextBox;
        private Button button1;
        private ErrorProvider errorProvider;
        private TextBox idTextBox;
        private Label idLabel;
        private DateTimePicker fechaNacDatePicker;
    }
}