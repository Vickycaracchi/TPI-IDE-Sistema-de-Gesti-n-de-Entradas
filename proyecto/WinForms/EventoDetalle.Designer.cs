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
            NombreTextBox = new TextBox();
            DescTextBox = new TextBox();
            FechaTextBox = new TextBox();
            LugarTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // NombreTextBox
            // 
            NombreTextBox.Location = new Point(141, 25);
            NombreTextBox.Name = "NombreTextBox";
            NombreTextBox.Size = new Size(100, 23);
            NombreTextBox.TabIndex = 0;
            NombreTextBox.TextChanged += textBox1_TextChanged;
            // 
            // DescTextBox
            // 
            DescTextBox.Location = new Point(141, 72);
            DescTextBox.Name = "DescTextBox";
            DescTextBox.Size = new Size(100, 23);
            DescTextBox.TabIndex = 1;
            // 
            // FechaTextBox
            // 
            FechaTextBox.Location = new Point(141, 119);
            FechaTextBox.Name = "FechaTextBox";
            FechaTextBox.Size = new Size(100, 23);
            FechaTextBox.TabIndex = 2;
            // 
            // LugarTextBox
            // 
            LugarTextBox.Location = new Point(141, 168);
            LugarTextBox.Name = "LugarTextBox";
            LugarTextBox.Size = new Size(100, 23);
            LugarTextBox.TabIndex = 3;
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
            // 
            // EventoDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LugarTextBox);
            Controls.Add(FechaTextBox);
            Controls.Add(DescTextBox);
            Controls.Add(NombreTextBox);
            Name = "EventoDetalle";
            Text = "EventoDetalle";
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
    }
}