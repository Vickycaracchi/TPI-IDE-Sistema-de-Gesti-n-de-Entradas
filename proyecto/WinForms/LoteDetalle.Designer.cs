namespace WinForms
{
    partial class LoteDetalle
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.fechaDesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaHastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cantidadLoteTextBox = new System.Windows.Forms.TextBox();
            this.loteErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.loteErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 280);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cantidad Lote:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Precio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(150, 57);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(250, 23);
            this.nombreTextBox.TabIndex = 6;
            // 
            // precioTextBox
            // 
            this.precioTextBox.Location = new System.Drawing.Point(150, 97);
            this.precioTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(250, 23);
            this.precioTextBox.TabIndex = 7;
            // 
            // fechaDesdeDateTimePicker
            // 
            this.fechaDesdeDateTimePicker.Location = new System.Drawing.Point(150, 137);
            this.fechaDesdeDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fechaDesdeDateTimePicker.Name = "fechaDesdeDateTimePicker";
            this.fechaDesdeDateTimePicker.Size = new System.Drawing.Size(250, 23);
            this.fechaDesdeDateTimePicker.TabIndex = 8;
            // 
            // fechaHastaDateTimePicker
            // 
            this.fechaHastaDateTimePicker.Location = new System.Drawing.Point(150, 177);
            this.fechaHastaDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fechaHastaDateTimePicker.Name = "fechaHastaDateTimePicker";
            this.fechaHastaDateTimePicker.Size = new System.Drawing.Size(250, 23);
            this.fechaHastaDateTimePicker.TabIndex = 9;
            // 
            // cantidadLoteTextBox
            // 
            this.cantidadLoteTextBox.Location = new System.Drawing.Point(150, 217);
            this.cantidadLoteTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cantidadLoteTextBox.Name = "cantidadLoteTextBox";
            this.cantidadLoteTextBox.Size = new System.Drawing.Size(250, 23);
            this.cantidadLoteTextBox.TabIndex = 10;
            // 
            // loteErrorProvider
            // 
            this.loteErrorProvider.ContainerControl = this;
            // 
            // LoteDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.cantidadLoteTextBox);
            this.Controls.Add(this.fechaHastaDateTimePicker);
            this.Controls.Add(this.fechaDesdeDateTimePicker);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoteDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoteDetalle";
            this.Load += new System.EventHandler(this.LoteDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loteErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.DateTimePicker fechaDesdeDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaHastaDateTimePicker;
        private System.Windows.Forms.TextBox cantidadLoteTextBox;
        private System.Windows.Forms.ErrorProvider loteErrorProvider;
    }
}