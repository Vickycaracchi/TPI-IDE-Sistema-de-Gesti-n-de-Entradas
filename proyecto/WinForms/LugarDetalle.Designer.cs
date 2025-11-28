namespace WinForms
{
    partial class LugarDetalle
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
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            nombreTextBox = new TextBox();
            direccionTextBox = new TextBox();
            ciudadTextBox = new TextBox();
            lugarErrorProvider = new ErrorProvider(components);
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)lugarErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(180, 224);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(100, 35);
            button1.TabIndex = 0;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 164);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 1;
            label3.Text = "Ciudad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 114);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Dirección";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 64);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(150, 61);
            nombreTextBox.Margin = new Padding(3, 2, 3, 2);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(250, 23);
            nombreTextBox.TabIndex = 4;
            // 
            // direccionTextBox
            // 
            direccionTextBox.Location = new Point(150, 111);
            direccionTextBox.Margin = new Padding(3, 2, 3, 2);
            direccionTextBox.Name = "direccionTextBox";
            direccionTextBox.Size = new Size(250, 23);
            direccionTextBox.TabIndex = 5;
            // 
            // ciudadTextBox
            // 
            ciudadTextBox.Location = new Point(150, 161);
            ciudadTextBox.Margin = new Padding(3, 2, 3, 2);
            ciudadTextBox.Name = "ciudadTextBox";
            ciudadTextBox.Size = new Size(250, 23);
            ciudadTextBox.TabIndex = 6;
            // 
            // lugarErrorProvider
            // 
            lugarErrorProvider.ContainerControl = this;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(50, 21);
            label4.Name = "label4";
            label4.Size = new Size(195, 21);
            label4.TabIndex = 10;
            label4.Text = "Ingrese los datos del lugar:";
            // 
            // LugarDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 300);
            Controls.Add(label4);
            Controls.Add(ciudadTextBox);
            Controls.Add(direccionTextBox);
            Controls.Add(nombreTextBox);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LugarDetalle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Detalle de Lugar";
            Load += LugarDetalle_Load;
            ((System.ComponentModel.ISupportInitialize)lugarErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox ciudadTextBox;
        private System.Windows.Forms.ErrorProvider lugarErrorProvider;
        private Label label4;
    }
}
