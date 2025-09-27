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
            ((System.ComponentModel.ISupportInitialize)eventosDataGridView).BeginInit();
            SuspendLayout();
            // 
            // eventosDataGridView
            // 
            eventosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            eventosDataGridView.Location = new Point(46, 26);
            eventosDataGridView.Margin = new Padding(3, 2, 3, 2);
            eventosDataGridView.Name = "eventosDataGridView";
            eventosDataGridView.RowHeadersWidth = 51;
            eventosDataGridView.Size = new Size(553, 198);
            eventosDataGridView.TabIndex = 0;
            eventosDataGridView.CellContentClick += eventosDataGridView_CellContentClick;
            // 
            // eliminarButtonEvento
            // 
            eliminarButtonEvento.Location = new Point(95, 258);
            eliminarButtonEvento.Margin = new Padding(3, 2, 3, 2);
            eliminarButtonEvento.Name = "eliminarButtonEvento";
            eliminarButtonEvento.Size = new Size(82, 22);
            eliminarButtonEvento.TabIndex = 1;
            eliminarButtonEvento.Text = "Eliminar";
            eliminarButtonEvento.UseVisualStyleBackColor = true;
            eliminarButtonEvento.Click += eliminarButtonEvento_Click;
            // 
            // modificarButtonEvento
            // 
            modificarButtonEvento.Location = new Point(262, 258);
            modificarButtonEvento.Margin = new Padding(3, 2, 3, 2);
            modificarButtonEvento.Name = "modificarButtonEvento";
            modificarButtonEvento.Size = new Size(82, 22);
            modificarButtonEvento.TabIndex = 2;
            modificarButtonEvento.Text = "Modificar";
            modificarButtonEvento.UseVisualStyleBackColor = true;
            modificarButtonEvento.Click += modificarButtonEvento_Click;
            // 
            // agregarButtonEvento
            // 
            agregarButtonEvento.Location = new Point(426, 258);
            agregarButtonEvento.Margin = new Padding(3, 2, 3, 2);
            agregarButtonEvento.Name = "agregarButtonEvento";
            agregarButtonEvento.Size = new Size(82, 22);
            agregarButtonEvento.TabIndex = 3;
            agregarButtonEvento.Text = "Agregar";
            agregarButtonEvento.UseVisualStyleBackColor = true;
            agregarButtonEvento.Click += agregarButtonEvento_Click;
            // 
            // EventosLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(agregarButtonEvento);
            Controls.Add(modificarButtonEvento);
            Controls.Add(eliminarButtonEvento);
            Controls.Add(eventosDataGridView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EventosLista";
            Text = "Gestión de eventos";
            Load += EventosLista_Load;
            ((System.ComponentModel.ISupportInitialize)eventosDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView eventosDataGridView;
        private Button eliminarButtonEvento;
        private Button modificarButtonEvento;
        private Button agregarButtonEvento;
    }
}