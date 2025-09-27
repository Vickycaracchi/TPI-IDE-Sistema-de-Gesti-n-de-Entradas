namespace WinForms
{
    partial class MenuAdmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarVendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarEventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarClientesToolStripMenuItem,
            this.listarVendedoresToolStripMenuItem,
            this.listarEventosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listarClientesToolStripMenuItem
            // 
            this.listarClientesToolStripMenuItem.Name = "listarClientesToolStripMenuItem";
            this.listarClientesToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.listarClientesToolStripMenuItem.Text = "Listar Clientes";
            this.listarClientesToolStripMenuItem.Click += new System.EventHandler(this.listarClientesToolStripMenuItem_Click);
            // 
            // listarVendedoresToolStripMenuItem
            // 
            this.listarVendedoresToolStripMenuItem.Name = "listarVendedoresToolStripMenuItem";
            this.listarVendedoresToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.listarVendedoresToolStripMenuItem.Text = "Listar Vendedores";
            this.listarVendedoresToolStripMenuItem.Click += new System.EventHandler(this.listarVendedoresToolStripMenuItem_Click);
            // 
            // listarEventosToolStripMenuItem
            // 
            this.listarEventosToolStripMenuItem.Name = "listarEventosToolStripMenuItem";
            this.listarEventosToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.listarEventosToolStripMenuItem.Text = "Listar Eventos";
            this.listarEventosToolStripMenuItem.Click += new System.EventHandler(this.listarEventosToolStripMenuItem_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 24);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1000, 576);
            this.panelContenedor.TabIndex = 1;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuAdmin";
            this.Text = "Menú Administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarVendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarEventosToolStripMenuItem;
        private System.Windows.Forms.Panel panelContenedor;
    }
}