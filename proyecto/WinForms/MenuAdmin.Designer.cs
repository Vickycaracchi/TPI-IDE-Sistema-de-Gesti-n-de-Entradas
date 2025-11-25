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
            menuStrip1 = new MenuStrip();
            listarVendedoresToolStripMenuItem = new ToolStripMenuItem();
            listarEventosToolStripMenuItem = new ToolStripMenuItem();
            gestiónProductosToolStripMenuItem = new ToolStripMenuItem();
            gestiónLugaresToolStripMenuItem = new ToolStripMenuItem();
            gestiónLotesToolStripMenuItem = new ToolStripMenuItem();
            gestiónFiestasToolStripMenuItem = new ToolStripMenuItem();
            asignarVendedoresToolStripMenuItem = new ToolStripMenuItem();
            panelContenedor = new Panel();
            generarReporteToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { listarVendedoresToolStripMenuItem, listarEventosToolStripMenuItem, gestiónProductosToolStripMenuItem, gestiónLugaresToolStripMenuItem, gestiónLotesToolStripMenuItem, gestiónFiestasToolStripMenuItem, asignarVendedoresToolStripMenuItem, generarReporteToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1143, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // listarVendedoresToolStripMenuItem
            // 
            listarVendedoresToolStripMenuItem.Name = "listarVendedoresToolStripMenuItem";
            listarVendedoresToolStripMenuItem.Size = new Size(155, 24);
            listarVendedoresToolStripMenuItem.Text = "Gestión Vendedores";
            listarVendedoresToolStripMenuItem.Click += listarVendedoresToolStripMenuItem_Click;
            // 
            // listarEventosToolStripMenuItem
            // 
            listarEventosToolStripMenuItem.Name = "listarEventosToolStripMenuItem";
            listarEventosToolStripMenuItem.Size = new Size(128, 24);
            listarEventosToolStripMenuItem.Text = "Gestión Eventos";
            listarEventosToolStripMenuItem.Click += listarEventosToolStripMenuItem_Click;
            // 
            // gestiónProductosToolStripMenuItem
            // 
            gestiónProductosToolStripMenuItem.Name = "gestiónProductosToolStripMenuItem";
            gestiónProductosToolStripMenuItem.Size = new Size(143, 24);
            gestiónProductosToolStripMenuItem.Text = "Gestión Productos";
            gestiónProductosToolStripMenuItem.Click += gestiónProductosToolStripMenuItem_Click;
            // 
            // gestiónLugaresToolStripMenuItem
            // 
            gestiónLugaresToolStripMenuItem.Name = "gestiónLugaresToolStripMenuItem";
            gestiónLugaresToolStripMenuItem.Size = new Size(128, 24);
            gestiónLugaresToolStripMenuItem.Text = "Gestión Lugares";
            gestiónLugaresToolStripMenuItem.Click += gestiónLugaresToolStripMenuItem_Click;
            // 
            // gestiónLotesToolStripMenuItem
            // 
            gestiónLotesToolStripMenuItem.Name = "gestiónLotesToolStripMenuItem";
            gestiónLotesToolStripMenuItem.Size = new Size(112, 24);
            gestiónLotesToolStripMenuItem.Text = "Gestión Lotes";
            gestiónLotesToolStripMenuItem.Click += gestiónLotesToolStripMenuItem_Click;
            // 
            // gestiónFiestasToolStripMenuItem
            // 
            gestiónFiestasToolStripMenuItem.Name = "gestiónFiestasToolStripMenuItem";
            gestiónFiestasToolStripMenuItem.Size = new Size(121, 24);
            gestiónFiestasToolStripMenuItem.Text = "Gestión Fiestas";
            gestiónFiestasToolStripMenuItem.Click += gestiónFiestasToolStripMenuItem_Click;
            // 
            // asignarVendedoresToolStripMenuItem
            // 
            asignarVendedoresToolStripMenuItem.Name = "asignarVendedoresToolStripMenuItem";
            asignarVendedoresToolStripMenuItem.Size = new Size(155, 24);
            asignarVendedoresToolStripMenuItem.Text = "Asignar Vendedores";
            asignarVendedoresToolStripMenuItem.Click += asignarVendedoresToolStripMenuItem_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.AutoSize = true;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 30);
            panelContenedor.Margin = new Padding(3, 4, 3, 4);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1143, 770);
            panelContenedor.TabIndex = 1;
            // 
            // generarReporteToolStripMenuItem
            // 
            generarReporteToolStripMenuItem.Name = "generarReporteToolStripMenuItem";
            generarReporteToolStripMenuItem.Size = new Size(128, 24);
            generarReporteToolStripMenuItem.Text = "Generar reporte";
            generarReporteToolStripMenuItem.Click += generarReporteToolStripMenuItem_Click;
            // 
            // MenuAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 800);
            Controls.Add(panelContenedor);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Administrador";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listarVendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarEventosToolStripMenuItem;
        private System.Windows.Forms.Panel panelContenedor;
        private ToolStripMenuItem gestiónProductosToolStripMenuItem;
        private ToolStripMenuItem gestiónLugaresToolStripMenuItem;
        private ToolStripMenuItem gestiónLotesToolStripMenuItem;
        private ToolStripMenuItem gestiónFiestasToolStripMenuItem;
        private ToolStripMenuItem asignarVendedoresToolStripMenuItem;
        private ToolStripMenuItem generarReporteToolStripMenuItem;
    }
}