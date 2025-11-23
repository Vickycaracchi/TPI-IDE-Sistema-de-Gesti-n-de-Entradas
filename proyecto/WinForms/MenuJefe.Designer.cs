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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { verMisVentasToolStripMenuItem, resgistrarNuevaVentaToolStripMenuItem, gestionDeClientesToolStripMenuItem, ventasDeTusVendedoresToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1209, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // verMisVentasToolStripMenuItem
            // 
            verMisVentasToolStripMenuItem.Name = "verMisVentasToolStripMenuItem";
            verMisVentasToolStripMenuItem.Size = new Size(75, 20);
            verMisVentasToolStripMenuItem.Text = "Mis ventas";
            verMisVentasToolStripMenuItem.Click += verMisVentasToolStripMenuItem_Click;
            // 
            // resgistrarNuevaVentaToolStripMenuItem
            // 
            resgistrarNuevaVentaToolStripMenuItem.Name = "resgistrarNuevaVentaToolStripMenuItem";
            resgistrarNuevaVentaToolStripMenuItem.Size = new Size(132, 20);
            resgistrarNuevaVentaToolStripMenuItem.Text = "Registrar nueva venta";
            resgistrarNuevaVentaToolStripMenuItem.Click += resgistrarNuevaVentaToolStripMenuItem_Click;
            // 
            // gestionDeClientesToolStripMenuItem
            // 
            gestionDeClientesToolStripMenuItem.Name = "gestionDeClientesToolStripMenuItem";
            gestionDeClientesToolStripMenuItem.Size = new Size(118, 20);
            gestionDeClientesToolStripMenuItem.Text = "Gestion de clientes";
            gestionDeClientesToolStripMenuItem.Click += gestionDeClientesToolStripMenuItem_Click;
            // 
            // ventasDeTusVendedoresToolStripMenuItem
            // 
            ventasDeTusVendedoresToolStripMenuItem.Name = "ventasDeTusVendedoresToolStripMenuItem";
            ventasDeTusVendedoresToolStripMenuItem.Size = new Size(160, 20);
            ventasDeTusVendedoresToolStripMenuItem.Text = "Ventas de tus vendedores";
            ventasDeTusVendedoresToolStripMenuItem.Click += ventasDeTusVendedoresToolStripMenuItem_Click;
            // 
            // panelContenedorJefe
            // 
            panelContenedorJefe.Location = new Point(0, 23);
            panelContenedorJefe.Margin = new Padding(3, 2, 3, 2);
            panelContenedorJefe.Name = "panelContenedorJefe";
            panelContenedorJefe.Size = new Size(1209, 464);
            panelContenedorJefe.TabIndex = 1;
            // 
            // MenuJefe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 486);
            Controls.Add(panelContenedorJefe);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
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
    }
}

