namespace WinForms
{
    partial class RegistrarFiesta
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
            EventosDataGridView = new DataGridView();
            enviarRegFiesta = new Button();
            LugaresDataGridView = new DataGridView();
            fechaPicker = new DateTimePicker();
            label3 = new Label();
            registrarFiestaErrorProvider = new ErrorProvider(components);
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)EventosDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LugaresDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)registrarFiestaErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // EventosDataGridView
            // 
            EventosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EventosDataGridView.Location = new Point(12, 254);
            EventosDataGridView.Margin = new Padding(3, 2, 3, 2);
            EventosDataGridView.Name = "EventosDataGridView";
            EventosDataGridView.RowHeadersWidth = 51;
            EventosDataGridView.Size = new Size(1156, 189);
            EventosDataGridView.TabIndex = 12;
            // 
            // enviarRegFiesta
            // 
            enviarRegFiesta.Location = new Point(831, 482);
            enviarRegFiesta.Margin = new Padding(3, 2, 3, 2);
            enviarRegFiesta.Name = "enviarRegFiesta";
            enviarRegFiesta.Size = new Size(130, 49);
            enviarRegFiesta.TabIndex = 11;
            enviarRegFiesta.Text = "Enviar";
            enviarRegFiesta.UseVisualStyleBackColor = true;
            enviarRegFiesta.Click += enviarRegFiesta_click;
            // 
            // LugaresDataGridView
            // 
            LugaresDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LugaresDataGridView.Location = new Point(12, 45);
            LugaresDataGridView.Margin = new Padding(3, 2, 3, 2);
            LugaresDataGridView.Name = "LugaresDataGridView";
            LugaresDataGridView.RowHeadersWidth = 51;
            LugaresDataGridView.Size = new Size(1156, 170);
            LugaresDataGridView.TabIndex = 8;
            // 
            // fechaPicker
            // 
            fechaPicker.Location = new Point(301, 493);
            fechaPicker.Margin = new Padding(3, 2, 3, 2);
            fechaPicker.Name = "fechaPicker";
            fechaPicker.Size = new Size(219, 23);
            fechaPicker.TabIndex = 14;
            fechaPicker.Value = new DateTime(2025, 1, 1, 12, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(257, 499);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 13;
            label3.Text = "Fecha";
            // 
            // registrarFiestaErrorProvider
            // 
            registrarFiestaErrorProvider.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 23);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 15;
            label1.Text = "Lugar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 227);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 16;
            label2.Text = "Evento";
            label2.Click += label2_Click;
            // 
            // RegistrarFiesta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 577);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(fechaPicker);
            Controls.Add(label3);
            Controls.Add(EventosDataGridView);
            Controls.Add(enviarRegFiesta);
            Controls.Add(LugaresDataGridView);
            Name = "RegistrarFiesta";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += RegistrarFiesta_Load;
            ((System.ComponentModel.ISupportInitialize)EventosDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)LugaresDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)registrarFiestaErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView EventosDataGridView;
        private Button enviarRegFiesta;
        private DataGridView LugaresDataGridView;
        private DateTimePicker fechaPicker;
        private Label label3;
        private ErrorProvider registrarFiestaErrorProvider;
        private Label label2;
        private Label label1;
    }
}