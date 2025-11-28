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
            generarReporteToolStripMenuItem = new ToolStripMenuItem();
            verDatosReporteToolStripMenuItem = new ToolStripMenuItem();
            panelContenedor = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { listarVendedoresToolStripMenuItem, listarEventosToolStripMenuItem, gestiónProductosToolStripMenuItem, gestiónLugaresToolStripMenuItem, gestiónLotesToolStripMenuItem, gestiónFiestasToolStripMenuItem, asignarVendedoresToolStripMenuItem, generarReporteToolStripMenuItem, verDatosReporteToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1222, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // listarVendedoresToolStripMenuItem
            // 
            listarVendedoresToolStripMenuItem.Name = "listarVendedoresToolStripMenuItem";
            listarVendedoresToolStripMenuItem.Size = new Size(123, 20);
            listarVendedoresToolStripMenuItem.Text = "Gestión Vendedores";
            listarVendedoresToolStripMenuItem.Click += listarVendedoresToolStripMenuItem_Click;
            // 
            // listarEventosToolStripMenuItem
            // 
            listarEventosToolStripMenuItem.Name = "listarEventosToolStripMenuItem";
            listarEventosToolStripMenuItem.Size = new Size(103, 20);
            listarEventosToolStripMenuItem.Text = "Gestión Eventos";
            listarEventosToolStripMenuItem.Click += listarEventosToolStripMenuItem_Click;
            // 
            // gestiónProductosToolStripMenuItem
            // 
            gestiónProductosToolStripMenuItem.Name = "gestiónProductosToolStripMenuItem";
            gestiónProductosToolStripMenuItem.Size = new Size(116, 20);
            gestiónProductosToolStripMenuItem.Text = "Gestión Productos";
            gestiónProductosToolStripMenuItem.Click += gestiónProductosToolStripMenuItem_Click;
            // 
            // gestiónLugaresToolStripMenuItem
            // 
            gestiónLugaresToolStripMenuItem.Name = "gestiónLugaresToolStripMenuItem";
            gestiónLugaresToolStripMenuItem.Size = new Size(103, 20);
            gestiónLugaresToolStripMenuItem.Text = "Gestión Lugares";
            gestiónLugaresToolStripMenuItem.Click += gestiónLugaresToolStripMenuItem_Click;
            // 
            // gestiónLotesToolStripMenuItem
            // 
            gestiónLotesToolStripMenuItem.Name = "gestiónLotesToolStripMenuItem";
            gestiónLotesToolStripMenuItem.Size = new Size(90, 20);
            gestiónLotesToolStripMenuItem.Text = "Gestión Lotes";
            gestiónLotesToolStripMenuItem.Click += gestiónLotesToolStripMenuItem_Click;
            // 
            // gestiónFiestasToolStripMenuItem
            // 
            gestiónFiestasToolStripMenuItem.Name = "gestiónFiestasToolStripMenuItem";
            gestiónFiestasToolStripMenuItem.Size = new Size(97, 20);
            gestiónFiestasToolStripMenuItem.Text = "Gestión Fiestas";
            gestiónFiestasToolStripMenuItem.Click += gestiónFiestasToolStripMenuItem_Click;
            // 
            // asignarVendedoresToolStripMenuItem
            // 
            asignarVendedoresToolStripMenuItem.Name = "asignarVendedoresToolStripMenuItem";
            asignarVendedoresToolStripMenuItem.Size = new Size(123, 20);
            asignarVendedoresToolStripMenuItem.Text = "Asignar Vendedores";
            asignarVendedoresToolStripMenuItem.Click += asignarVendedoresToolStripMenuItem_Click;
            // 
            // generarReporteToolStripMenuItem
            // 
            generarReporteToolStripMenuItem.Name = "generarReporteToolStripMenuItem";
            generarReporteToolStripMenuItem.Size = new Size(101, 20);
            generarReporteToolStripMenuItem.Text = "Generar reporte";
            generarReporteToolStripMenuItem.Click += generarReporteToolStripMenuItem_Click;
            // 
            // verDatosReporteToolStripMenuItem
            // 
            verDatosReporteToolStripMenuItem.Name = "verDatosReporteToolStripMenuItem";
            verDatosReporteToolStripMenuItem.Size = new Size(108, 20);
            verDatosReporteToolStripMenuItem.Text = "Ver datos reporte";
            verDatosReporteToolStripMenuItem.Click += verDatosReporteToolStripMenuItem_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.AutoSize = true;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 24);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1222, 576);
            panelContenedor.TabIndex = 1;
            // 
            // MenuAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 600);
            Controls.Add(panelContenedor);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Administrador";
            WindowState = FormWindowState.Maximized;
            Load += MenuAdmin_Load;
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
        private ToolStripMenuItem verDatosReporteToolStripMenuItem;
    }
}