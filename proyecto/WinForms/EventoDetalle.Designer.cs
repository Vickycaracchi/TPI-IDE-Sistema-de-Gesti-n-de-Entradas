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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            errorProvider = new ErrorProvider(components);
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(124, 111);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(143, 23);
            nombreTextBox.TabIndex = 0;
            // 
            // descTextBox
            // 
            descTextBox.Location = new Point(124, 158);
            descTextBox.Name = "descTextBox";
            descTextBox.Size = new Size(143, 23);
            descTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 114);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 161);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 5;
            label2.Text = "Descripcion";
            // 
            // button1
            // 
            button1.Location = new Point(240, 206);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(43, 63);
            label3.Name = "label3";
            label3.Size = new Size(206, 21);
            label3.TabIndex = 9;
            label3.Text = "Ingrese los datos del evento:";
            // 
            // EventoDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 312);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Button button1;
        private ErrorProvider errorProvider;
        private Label label3;
    }
}