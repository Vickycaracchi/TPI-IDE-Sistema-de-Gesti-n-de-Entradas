namespace WinForms
{
    partial class Menu
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
            menuStrip1 = new MenuStrip();
            ingresarCliente = new ToolStripMenuItem();
            registrarCliente = new ToolStripMenuItem();
            registarVendedor = new ToolStripMenuItem();
            ingresarVendedor = new ToolStripMenuItem();
            nombreVendedor = new Label();
            tipoVendedor = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ingresarCliente, registrarCliente, registarVendedor, ingresarVendedor });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // ingresarCliente
            // 
            ingresarCliente.Name = "ingresarCliente";
            ingresarCliente.Size = new Size(126, 24);
            ingresarCliente.Text = "Ingresar Cliente";
            ingresarCliente.Click += ingresarToolStripMenuItem_Click;
            // 
            // registrarCliente
            // 
            registrarCliente.Name = "registrarCliente";
            registrarCliente.Size = new Size(132, 24);
            registrarCliente.Text = "Registrar Cliente";
            registrarCliente.Click += registrarseToolStripMenuItem_Click;
            // 
            // registarVendedor
            // 
            registarVendedor.Name = "registarVendedor";
            registarVendedor.Size = new Size(145, 24);
            registarVendedor.Text = "Registar Vendedor";
            registarVendedor.Click += registarVendedorToolStripMenuItem_Click;
            // 
            // ingresarVendedor
            // 
            ingresarVendedor.Name = "ingresarVendedor";
            ingresarVendedor.Size = new Size(144, 24);
            ingresarVendedor.Text = "Ingresar Vendedor";
            ingresarVendedor.Click += ingresarVendedor_Click;
            // 
            // nombreVendedor
            // 
            nombreVendedor.AutoSize = true;
            nombreVendedor.Location = new Point(98, 182);
            nombreVendedor.Name = "nombreVendedor";
            nombreVendedor.Size = new Size(90, 20);
            nombreVendedor.TabIndex = 5;
            nombreVendedor.Text = "Contenido 1";
            // 
            // tipoVendedor
            // 
            tipoVendedor.AutoSize = true;
            tipoVendedor.Location = new Point(533, 182);
            tipoVendedor.Name = "tipoVendedor";
            tipoVendedor.Size = new Size(90, 20);
            tipoVendedor.TabIndex = 6;
            tipoVendedor.Text = "Contenido 2";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tipoVendedor);
            Controls.Add(nombreVendedor);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ingresarCliente;
        private ToolStripMenuItem registrarCliente;
        private ToolStripMenuItem registarVendedor;
        private ToolStripMenuItem ingresarVendedor;
        private Label nombreVendedor;
        private Label tipoVendedor;
    }
}