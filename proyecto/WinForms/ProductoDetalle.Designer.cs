namespace WinForms
{
    partial class ProductoDetalle
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
            descripcionTextBox = new TextBox();
            precioTextBox = new TextBox();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(413, 284);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += enviarFormularioProducto;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 212);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 5;
            label3.Text = "Precio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 165);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 4;
            label2.Text = "Descripcion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 118);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // precioTextBox
            // 
            precioTextBox.Location = new Point(331, 212);
            precioTextBox.Name = "precioTextBox";
            precioTextBox.Size = new Size(100, 23);
            precioTextBox.TabIndex = 3;
            // 
            // descripcionTextBox
            // 
            descripcionTextBox.Location = new Point(331, 162);
            descripcionTextBox.Name = "descripcionTextBox";
            descripcionTextBox.Size = new Size(100, 23);
            descripcionTextBox.TabIndex = 1;

            // 
            // 
            // nombreTextBox
            nombreTextBox.Location = new Point(331, 115);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(104, 23);
            nombreTextBox.TabIndex = 0;
            // 
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
        
          
            // ProductoDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 391);
            Controls.Add(nombreTextBox);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(precioTextBox);
            Controls.Add(descripcionTextBox);
            Name = "ProductoDetalle";
            Text = "Form1";
            Load += ProductoDetalle_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox precioTextBox;
        private TextBox descripcionTextBox;
        private ErrorProvider errorProvider;
        private TextBox nombreTextBox;
    }
}