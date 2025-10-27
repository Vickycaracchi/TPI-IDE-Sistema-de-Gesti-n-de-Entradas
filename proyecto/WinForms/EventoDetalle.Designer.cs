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
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(161, 33);
            nombreTextBox.Margin = new Padding(3, 4, 3, 4);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(114, 27);
            nombreTextBox.TabIndex = 0;
            // 
            // descTextBox
            // 
            descTextBox.Location = new Point(161, 96);
            descTextBox.Margin = new Padding(3, 4, 3, 4);
            descTextBox.Name = "descTextBox";
            descTextBox.Size = new Size(114, 27);
            descTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 37);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 100);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 5;
            label2.Text = "Descripcion";
            // 
            // button1
            // 
            button1.Location = new Point(255, 296);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 8;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += enviarFormularioEvento;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // EventoDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(descTextBox);
            Controls.Add(nombreTextBox);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}