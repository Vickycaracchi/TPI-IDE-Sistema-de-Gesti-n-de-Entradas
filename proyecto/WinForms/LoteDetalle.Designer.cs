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
            ((System.ComponentModel.ISupportInitialize)loteErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listaFiestas).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(895, 344);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(746, 211);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 2;
            label4.Text = "Fecha Hasta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(746, 157);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 3;
            label3.Text = "Fecha Desde:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(746, 104);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 4;
            label2.Text = "Precio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(746, 51);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 5;
            label1.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(861, 47);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(285, 27);
            nombreTextBox.TabIndex = 6;
            // 
            // precioTextBox
            // 
            precioTextBox.Location = new Point(861, 100);
            precioTextBox.Name = "precioTextBox";
            precioTextBox.Size = new Size(285, 27);
            precioTextBox.TabIndex = 7;
            // 
            // fechaDesdeDateTimePicker
            // 
            fechaDesdeDateTimePicker.Location = new Point(861, 153);
            fechaDesdeDateTimePicker.Name = "fechaDesdeDateTimePicker";
            fechaDesdeDateTimePicker.Size = new Size(285, 27);
            fechaDesdeDateTimePicker.TabIndex = 8;
            // 
            // fechaHastaDateTimePicker
            // 
            fechaHastaDateTimePicker.Location = new Point(861, 207);
            fechaHastaDateTimePicker.Name = "fechaHastaDateTimePicker";
            fechaHastaDateTimePicker.Size = new Size(285, 27);
            fechaHastaDateTimePicker.TabIndex = 9;
            // 
            // loteErrorProvider
            // 
            loteErrorProvider.ContainerControl = this;
            // 
            // listaFiestas
            // 
            listaFiestas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaFiestas.Location = new Point(14, 47);
            listaFiestas.Margin = new Padding(3, 4, 3, 4);
            listaFiestas.Name = "listaFiestas";
            listaFiestas.RowHeadersWidth = 51;
            listaFiestas.Size = new Size(704, 365);
            listaFiestas.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 12);
            label6.Name = "label6";
            label6.Size = new Size(148, 20);
            label6.TabIndex = 12;
            label6.Text = "Seleccione una fiesta";
            label6.Click += label6_Click;
            // 
            // LoteDetalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 441);
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
    }
}