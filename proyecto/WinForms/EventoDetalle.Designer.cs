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
            NombreTextBox = new TextBox();
            DescTextBox = new TextBox();
            FechaTextBox = new TextBox();
            LugarTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // NombreTextBox
            // 
            NombreTextBox.Location = new Point(161, 33);
            NombreTextBox.Margin = new Padding(3, 4, 3, 4);
            NombreTextBox.Name = "NombreTextBox";
            NombreTextBox.Size = new Size(114, 27);
            NombreTextBox.TabIndex = 0;
            // 
            // DescTextBox
            // 
            DescTextBox.Location = new Point(161, 96);
            DescTextBox.Margin = new Padding(3, 4, 3, 4);
            DescTextBox.Name = "DescTextBox";
            DescTextBox.Size = new Size(114, 27);
            DescTextBox.TabIndex = 1;
            // 
            // FechaTextBox
            // 
            FechaTextBox.Location = new Point(161, 159);
            FechaTextBox.Margin = new Padding(3, 4, 3, 4);
            FechaTextBox.Name = "FechaTextBox";
            FechaTextBox.Size = new Size(114, 27);
            FechaTextBox.TabIndex = 2;
            // 
            // LugarTextBox
            // 
            LugarTextBox.Location = new Point(161, 224);
            LugarTextBox.Margin = new Padding(3, 4, 3, 4);
            LugarTextBox.Name = "LugarTextBox";
            LugarTextBox.Size = new Size(114, 27);
            LugarTextBox.TabIndex = 3;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 163);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 6;
            label3.Text = "Fecha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 235);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 7;
            label4.Text = "Lugar";
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
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LugarTextBox);
            Controls.Add(FechaTextBox);
            Controls.Add(DescTextBox);
            Controls.Add(NombreTextBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EventoDetalle";
            Text = "EventoDetalle";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NombreTextBox;
        private TextBox DescTextBox;
        private TextBox FechaTextBox;
        private TextBox LugarTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private ErrorProvider errorProvider;
    }
}