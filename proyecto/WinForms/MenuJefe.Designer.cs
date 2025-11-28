namespace WinForms
{
    partial class MenuJefe
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
            verMisVentasToolStripMenuItem = new ToolStripMenuItem();
            resgistrarNuevaVentaToolStripMenuItem = new ToolStripMenuItem();
            gestionDeClientesToolStripMenuItem = new ToolStripMenuItem();
            ventasDeTusVendedoresToolStripMenuItem = new ToolStripMenuItem();
            panelContenedorJefe = new Panel();
            misVendedoresToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { verMisVentasToolStripMenuItem, resgistrarNuevaVentaToolStripMenuItem, gestionDeClientesToolStripMenuItem, ventasDeTusVendedoresToolStripMenuItem, misVendedoresToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1382, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // verMisVentasToolStripMenuItem
            // 
            verMisVentasToolStripMenuItem.Name = "verMisVentasToolStripMenuItem";
            verMisVentasToolStripMenuItem.Size = new Size(92, 24);
            verMisVentasToolStripMenuItem.Text = "Mis ventas";
            verMisVentasToolStripMenuItem.Click += verMisVentasToolStripMenuItem_Click;
            // 
            // resgistrarNuevaVentaToolStripMenuItem
            // 
            resgistrarNuevaVentaToolStripMenuItem.Name = "resgistrarNuevaVentaToolStripMenuItem";
            resgistrarNuevaVentaToolStripMenuItem.Size = new Size(165, 24);
            resgistrarNuevaVentaToolStripMenuItem.Text = "Registrar nueva venta";
            resgistrarNuevaVentaToolStripMenuItem.Click += resgistrarNuevaVentaToolStripMenuItem_Click;
            // 
            // gestionDeClientesToolStripMenuItem
            // 
            gestionDeClientesToolStripMenuItem.Name = "gestionDeClientesToolStripMenuItem";
            gestionDeClientesToolStripMenuItem.Size = new Size(148, 24);
            gestionDeClientesToolStripMenuItem.Text = "Gestion de clientes";
            gestionDeClientesToolStripMenuItem.Click += gestionDeClientesToolStripMenuItem_Click;
            // 
            // ventasDeTusVendedoresToolStripMenuItem
            // 
            ventasDeTusVendedoresToolStripMenuItem.Name = "ventasDeTusVendedoresToolStripMenuItem";
            ventasDeTusVendedoresToolStripMenuItem.Size = new Size(191, 24);
            ventasDeTusVendedoresToolStripMenuItem.Text = "Ventas de tus vendedores";
            ventasDeTusVendedoresToolStripMenuItem.Click += ventasDeTusVendedoresToolStripMenuItem_Click;
            // 
            // panelContenedorJefe
            // 
            panelContenedorJefe.Dock = DockStyle.Fill;
            panelContenedorJefe.Location = new Point(0, 30);
            panelContenedorJefe.Name = "panelContenedorJefe";
            panelContenedorJefe.Size = new Size(1382, 618);
            panelContenedorJefe.TabIndex = 1;
            // 
            // misVendedoresToolStripMenuItem
            // 
            misVendedoresToolStripMenuItem.Name = "misVendedoresToolStripMenuItem";
            misVendedoresToolStripMenuItem.Size = new Size(127, 24);
            misVendedoresToolStripMenuItem.Text = "Mis vendedores";
            misVendedoresToolStripMenuItem.Click += misVendedoresToolStripMenuItem_Click;
            // 
            // MenuJefe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 648);
            Controls.Add(panelContenedorJefe);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuJefe";
            Text = "Menú Jefe";
            WindowState = FormWindowState.Maximized;
            Load += MenuJefe_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem verMisVentasToolStripMenuItem;
        private ToolStripMenuItem resgistrarNuevaVentaToolStripMenuItem;
        private ToolStripMenuItem gestionDeClientesToolStripMenuItem;
        private ToolStripMenuItem ventasDeTusVendedoresToolStripMenuItem;
        private Panel panelContenedorJefe;
        private ToolStripMenuItem misVendedoresToolStripMenuItem;
    }
}

