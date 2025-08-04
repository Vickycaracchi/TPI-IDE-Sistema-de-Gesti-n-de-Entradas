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
            eventosDataGridView.Location = new Point(52, 35);
            eventosDataGridView.Name = "eventosDataGridView";
            eventosDataGridView.RowHeadersWidth = 51;
            eventosDataGridView.Size = new Size(632, 264);
            eventosDataGridView.TabIndex = 0;
            // 
            // eliminarButtonEvento
            // 
            eliminarButtonEvento.Location = new Point(109, 344);
            eliminarButtonEvento.Name = "eliminarButtonEvento";
            eliminarButtonEvento.Size = new Size(94, 29);
            eliminarButtonEvento.TabIndex = 1;
            eliminarButtonEvento.Text = "Eliminar";
            eliminarButtonEvento.UseVisualStyleBackColor = true;
            eliminarButtonEvento.Click += eliminarButtonEvento_Click;
            // 
            // modificarButtonEvento
            // 
            modificarButtonEvento.Location = new Point(300, 344);
            modificarButtonEvento.Name = "modificarButtonEvento";
            modificarButtonEvento.Size = new Size(94, 29);
            modificarButtonEvento.TabIndex = 2;
            modificarButtonEvento.Text = "Modificar";
            modificarButtonEvento.UseVisualStyleBackColor = true;
            modificarButtonEvento.Click += modificarButtonEvento_Click;
            // 
            // agregarButtonEvento
            // 
            agregarButtonEvento.Location = new Point(487, 344);
            agregarButtonEvento.Name = "agregarButtonEvento";
            agregarButtonEvento.Size = new Size(94, 29);
            agregarButtonEvento.TabIndex = 3;
            agregarButtonEvento.Text = "Agregar";
            agregarButtonEvento.UseVisualStyleBackColor = true;
            agregarButtonEvento.Click += agregarButtonEvento_Click;
            // 
            // EventosLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(agregarButtonEvento);
            Controls.Add(modificarButtonEvento);
            Controls.Add(eliminarButtonEvento);
            Controls.Add(eventosDataGridView);
            Name = "EventosLista";
            Text = "Form1";
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