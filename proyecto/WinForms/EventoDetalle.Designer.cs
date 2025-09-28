namespace WinForms
{
    partial class EventoDetalle
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
            nombreTextBox = new TextBox();
            descTextBox = new TextBox();
            lugarTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            errorProvider = new ErrorProvider(components);
            fechaPicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(141, 25);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(100, 23);
            nombreTextBox.TabIndex = 0;
            // 
            // descTextBox
            // 
            descTextBox.Location = new Point(141, 72);
            descTextBox.Name = "descTextBox";
            descTextBox.Size = new Size(100, 23);
            descTextBox.TabIndex = 1;
            // 
            // lugarTextBox
            // 
            lugarTextBox.Location = new Point(141, 168);
            lugarTextBox.Name = "lugarTextBox";
            lugarTextBox.Size = new Size(100, 23);
            lugarTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 28);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 75);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 5;
            label2.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 122);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 6;
            label3.Text = "Fecha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 176);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 7;
            label4.Text = "Lugar";
            // 
            // button1
            // 
            button1.Location = new Point(223, 222);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += enviarFormularioEvento;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // fechaPicker
            // 
            fechaPicker.Location = new Point(141, 122);
            fechaPicker.Margin = new Padding(3, 2, 3, 2);
            fechaPicker.Name = "fechaPicker";
            fechaPicker.Size = new Size(219, 23);
            fechaPicker.TabIndex = 9;
            fechaPicker.Value = new DateTime(2025, 1, 1, 12, 0, 0, 0);
            // 
            // EventoDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(fechaPicker);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lugarTextBox);
            Controls.Add(descTextBox);
            Controls.Add(nombreTextBox);
            Name = "EventoDetalle";
            Text = "EventoDetalle";
            Load += EventoDetalle_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombreTextBox;
        private TextBox descTextBox;
        private TextBox lugarTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private ErrorProvider errorProvider;
        private DateTimePicker fechaPicker;
    }
}