namespace WinForms
{
    partial class EventosLista
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
            eventosDataGridView = new DataGridView();
            eliminarButtonEvento = new Button();
            modificarButtonEvento = new Button();
            agregarButtonEvento = new Button();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)eventosDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // eventosDataGridView
            // 
            eventosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            eventosDataGridView.Location = new Point(132, 48);
            eventosDataGridView.Margin = new Padding(3, 2, 3, 2);
            eventosDataGridView.Name = "eventosDataGridView";
            eventosDataGridView.RowHeadersWidth = 51;
            eventosDataGridView.Size = new Size(732, 305);
            eventosDataGridView.TabIndex = 0;
            eventosDataGridView.CellContentClick += eventosDataGridView_CellContentClick;
            // 
            // eliminarButtonEvento
            // 
            eliminarButtonEvento.Location = new Point(249, 357);
            eliminarButtonEvento.Margin = new Padding(3, 2, 3, 2);
            eliminarButtonEvento.Name = "eliminarButtonEvento";
            eliminarButtonEvento.Size = new Size(143, 38);
            eliminarButtonEvento.TabIndex = 1;
            eliminarButtonEvento.Text = "Eliminar";
            eliminarButtonEvento.UseVisualStyleBackColor = true;
            eliminarButtonEvento.Click += eliminarButtonEvento_Click;
            // 
            // modificarButtonEvento
            // 
            modificarButtonEvento.Location = new Point(416, 357);
            modificarButtonEvento.Margin = new Padding(3, 2, 3, 2);
            modificarButtonEvento.Name = "modificarButtonEvento";
            modificarButtonEvento.Size = new Size(143, 38);
            modificarButtonEvento.TabIndex = 2;
            modificarButtonEvento.Text = "Modificar";
            modificarButtonEvento.UseVisualStyleBackColor = true;
            modificarButtonEvento.Click += modificarButtonEvento_Click;
            // 
            // agregarButtonEvento
            // 
            agregarButtonEvento.Location = new Point(580, 357);
            agregarButtonEvento.Margin = new Padding(3, 2, 3, 2);
            agregarButtonEvento.Name = "agregarButtonEvento";
            agregarButtonEvento.Size = new Size(143, 38);
            agregarButtonEvento.TabIndex = 3;
            agregarButtonEvento.Text = "Agregar";
            agregarButtonEvento.UseVisualStyleBackColor = true;
            agregarButtonEvento.Click += agregarButtonEvento_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(agregarButtonEvento);
            panel1.Controls.Add(modificarButtonEvento);
            panel1.Controls.Add(eliminarButtonEvento);
            panel1.Controls.Add(eventosDataGridView);
            panel1.Location = new Point(66, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(1020, 504);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(379, 4);
            label1.Name = "label1";
            label1.Size = new Size(244, 37);
            label1.TabIndex = 4;
            label1.Text = "Gestión de Eventos";
            label1.Click += label1_Click;
            // 
            // EventosLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 564);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EventosLista";
            Text = "Gestión de eventos";
            Load += EventosLista_Load;
            ((System.ComponentModel.ISupportInitialize)eventosDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView eventosDataGridView;
        private Button eliminarButtonEvento;
        private Button modificarButtonEvento;
        private Button agregarButtonEvento;
        private Panel panel1;
        private Label label1;
    }
}