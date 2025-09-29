namespace WinForms
{
    partial class inicio
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
            ingresarComoClienteToolStripMenuItem = new ToolStripMenuItem();
            ingresarComoVendedorToolStripMenuItem = new ToolStripMenuItem();
            registrarClienteToolStripMenuItem = new ToolStripMenuItem();
            registrarAdministradorToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            panelContenedor = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ingresarComoClienteToolStripMenuItem, ingresarComoVendedorToolStripMenuItem, registrarClienteToolStripMenuItem, registrarAdministradorToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ingresarComoClienteToolStripMenuItem
            // 
            ingresarComoClienteToolStripMenuItem.Name = "ingresarComoClienteToolStripMenuItem";
            ingresarComoClienteToolStripMenuItem.Size = new Size(133, 20);
            ingresarComoClienteToolStripMenuItem.Text = "Ingresar como cliente";
            ingresarComoClienteToolStripMenuItem.Click += ingresarComoClienteToolStripMenuItem_Click;
            // 
            // ingresarComoVendedorToolStripMenuItem
            // 
            ingresarComoVendedorToolStripMenuItem.Name = "ingresarComoVendedorToolStripMenuItem";
            ingresarComoVendedorToolStripMenuItem.Size = new Size(148, 20);
            ingresarComoVendedorToolStripMenuItem.Text = "Ingresar como Vendedor";
            ingresarComoVendedorToolStripMenuItem.Click += ingresarComoVendedorToolStripMenuItem_Click;
            // 
            // registrarClienteToolStripMenuItem
            // 
            registrarClienteToolStripMenuItem.Name = "registrarClienteToolStripMenuItem";
            registrarClienteToolStripMenuItem.Size = new Size(105, 20);
            registrarClienteToolStripMenuItem.Text = "Registrar Cliente";
            registrarClienteToolStripMenuItem.Click += registrarClienteToolStripMenuItem_Click;
            // 
            // registrarAdministradorToolStripMenuItem
            // 
            registrarAdministradorToolStripMenuItem.Name = "registrarAdministradorToolStripMenuItem";
            registrarAdministradorToolStripMenuItem.Size = new Size(144, 20);
            registrarAdministradorToolStripMenuItem.Text = "Registrar Administrador";
            registrarAdministradorToolStripMenuItem.Click += registrarAdministradorToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(202, 44);
            label1.Name = "label1";
            label1.Size = new Size(538, 15);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido! Antes de usar el sistema cree un administrador par apoder acceder al area de vendedores";
            // 
            // panelContenedor
            // 
            panelContenedor.Location = new Point(2, 73);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(981, 462);
            panelContenedor.TabIndex = 2;
            // 
            // inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 537);
            Controls.Add(panelContenedor);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "inicio";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += inicio_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ingresarComoClienteToolStripMenuItem;
        private ToolStripMenuItem ingresarComoVendedorToolStripMenuItem;
        private ToolStripMenuItem registrarClienteToolStripMenuItem;
        private ToolStripMenuItem registrarAdministradorToolStripMenuItem;
        private Label label1;
        private Panel panelContenedor;
    }
}