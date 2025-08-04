namespace WinForms
{
    partial class ClienteDetalle
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
            label1 = new Label();
            nombreTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            apellidoTextBox = new TextBox();
            fechaNacTextBox = new TextBox();
            emailTextBox = new TextBox();
            numeroTelefonoTextBox = new TextBox();
            instagramTextBox = new TextBox();
            button1 = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 125);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(441, 122);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(125, 27);
            nombreTextBox.TabIndex = 1;
            nombreTextBox.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 172);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 282);
            label3.Name = "label3";
            label3.Size = new Size(146, 20);
            label3.TabIndex = 3;
            label3.Text = "Fecha de nacimiento";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(242, 79);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 4;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(242, 221);
            label5.Name = "label5";
            label5.Size = new Size(144, 20);
            label5.TabIndex = 5;
            label5.Text = "Numero de telefono";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(242, 338);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 6;
            label6.Text = "Instagram";
            // 
            // apellidoTextBox
            // 
            apellidoTextBox.Location = new Point(441, 169);
            apellidoTextBox.Name = "apellidoTextBox";
            apellidoTextBox.Size = new Size(125, 27);
            apellidoTextBox.TabIndex = 7;
            // 
            // fechaNacTextBox
            // 
            fechaNacTextBox.Location = new Point(441, 275);
            fechaNacTextBox.Name = "fechaNacTextBox";
            fechaNacTextBox.Size = new Size(125, 27);
            fechaNacTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(441, 72);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(125, 27);
            emailTextBox.TabIndex = 9;
            emailTextBox.TextChanged += emailTextBox_TextChanged;
            // 
            // numeroTelefonoTextBox
            // 
            numeroTelefonoTextBox.Location = new Point(441, 214);
            numeroTelefonoTextBox.Name = "numeroTelefonoTextBox";
            numeroTelefonoTextBox.Size = new Size(125, 27);
            numeroTelefonoTextBox.TabIndex = 10;
            // 
            // instagramTextBox
            // 
            instagramTextBox.Location = new Point(441, 335);
            instagramTextBox.Name = "instagramTextBox";
            instagramTextBox.Size = new Size(125, 27);
            instagramTextBox.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(441, 385);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += enviarFormulario;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // ClienteDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1361, 503);
            Controls.Add(button1);
            Controls.Add(instagramTextBox);
            Controls.Add(numeroTelefonoTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(fechaNacTextBox);
            Controls.Add(apellidoTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nombreTextBox);
            Controls.Add(label1);
            Name = "ClienteDetalle";
            Text = "ClienteDetalle";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox nombreTextBox;
        private TextBox apellidoTextBox;
        private TextBox fechaNacTextBox;
        private TextBox emailTextBox;
        private TextBox numeroTelefonoTextBox;
        private TextBox instagramTextBox;
        private Button button1;
        private ErrorProvider errorProvider;
    }
}