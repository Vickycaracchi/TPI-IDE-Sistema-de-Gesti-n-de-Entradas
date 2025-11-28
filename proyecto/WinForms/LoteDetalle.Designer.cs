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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            nombreTextBox = new TextBox();
            precioTextBox = new TextBox();
            fechaDesdeDateTimePicker = new DateTimePicker();
            fechaHastaDateTimePicker = new DateTimePicker();
            loteErrorProvider = new ErrorProvider(components);
            listaFiestas = new DataGridView();
            label6 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)loteErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listaFiestas).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(783, 258);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 0;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(653, 188);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 2;
            label4.Text = "Fecha Hasta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(653, 148);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 3;
            label3.Text = "Fecha Desde:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(653, 108);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Precio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(653, 68);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(753, 65);
            nombreTextBox.Margin = new Padding(3, 2, 3, 2);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(250, 23);
            nombreTextBox.TabIndex = 6;
            // 
            // precioTextBox
            // 
            precioTextBox.Location = new Point(753, 105);
            precioTextBox.Margin = new Padding(3, 2, 3, 2);
            precioTextBox.Name = "precioTextBox";
            precioTextBox.Size = new Size(250, 23);
            precioTextBox.TabIndex = 7;
            // 
            // fechaDesdeDateTimePicker
            // 
            fechaDesdeDateTimePicker.Location = new Point(753, 145);
            fechaDesdeDateTimePicker.Margin = new Padding(3, 2, 3, 2);
            fechaDesdeDateTimePicker.Name = "fechaDesdeDateTimePicker";
            fechaDesdeDateTimePicker.Size = new Size(250, 23);
            fechaDesdeDateTimePicker.TabIndex = 8;
            // 
            // fechaHastaDateTimePicker
            // 
            fechaHastaDateTimePicker.Location = new Point(753, 185);
            fechaHastaDateTimePicker.Margin = new Padding(3, 2, 3, 2);
            fechaHastaDateTimePicker.Name = "fechaHastaDateTimePicker";
            fechaHastaDateTimePicker.Size = new Size(250, 23);
            fechaHastaDateTimePicker.TabIndex = 9;
            // 
            // loteErrorProvider
            // 
            loteErrorProvider.ContainerControl = this;
            // 
            // listaFiestas
            // 
            listaFiestas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaFiestas.Location = new Point(12, 35);
            listaFiestas.Name = "listaFiestas";
            listaFiestas.RowHeadersWidth = 51;
            listaFiestas.Size = new Size(616, 274);
            listaFiestas.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(117, 15);
            label6.TabIndex = 12;
            label6.Text = "Seleccione una fiesta";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(728, 35);
            label5.Name = "label5";
            label5.Size = new Size(208, 21);
            label5.TabIndex = 13;
            label5.Text = "Ingrese los datos de la fiesta:";
            // 
            // LoteDetalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 331);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(listaFiestas);
            Controls.Add(fechaHastaDateTimePicker);
            Controls.Add(fechaDesdeDateTimePicker);
            Controls.Add(precioTextBox);
            Controls.Add(nombreTextBox);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoteDetalle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "LoteDetalle";
            Load += LoteDetalle_Load;
            ((System.ComponentModel.ISupportInitialize)loteErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)listaFiestas).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.DateTimePicker fechaDesdeDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaHastaDateTimePicker;
        private System.Windows.Forms.ErrorProvider loteErrorProvider;
        private Label label6;
        private DataGridView listaFiestas;
        private Label label5;
    }
}