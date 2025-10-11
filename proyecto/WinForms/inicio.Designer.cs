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
            ingresarToolStripMenuItem = new ToolStripMenuItem();
            registrarUsuarioToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            panelContenedor = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ingresarToolStripMenuItem, registrarUsuarioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1125, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ingresarToolStripMenuItem
            // 
            ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            ingresarToolStripMenuItem.Size = new Size(76, 24);
            ingresarToolStripMenuItem.Text = "Ingresar";
            ingresarToolStripMenuItem.Click += ingresarToolStripMenuItem_Click;
            // 
            // registrarUsuarioToolStripMenuItem
            // 
            registrarUsuarioToolStripMenuItem.Name = "registrarUsuarioToolStripMenuItem";
            registrarUsuarioToolStripMenuItem.Size = new Size(134, 24);
            registrarUsuarioToolStripMenuItem.Text = "Registrar usuario";
            registrarUsuarioToolStripMenuItem.Click += registrarUsuarioToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(231, 59);
            label1.Name = "label1";
            label1.Size = new Size(684, 20);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido! Antes de usar el sistema cree un administrador par apoder acceder al area de vendedores";
            // 
            // panelContenedor
            // 
            panelContenedor.Location = new Point(2, 97);
            panelContenedor.Margin = new Padding(3, 4, 3, 4);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1121, 616);
            panelContenedor.TabIndex = 2;
            // 
            // inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 716);
            Controls.Add(panelContenedor);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "inicio";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ingresarToolStripMenuItem;
        private ToolStripMenuItem registrarUsuarioToolStripMenuItem;
        private Label label1;
        private Panel panelContenedor;
    }
}