namespace WinForms
{
    partial class menuCliente
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
            verProductosToolStripMenuItem = new ToolStripMenuItem();
            verEventosToolStripMenuItem = new ToolStripMenuItem();
            verFiestas = new ToolStripMenuItem();
            verMisComprasToolStripMenuItem = new ToolStripMenuItem();
            comrparProductosToolStripMenuItem = new ToolStripMenuItem();
            panelContenedor = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { verProductosToolStripMenuItem, verEventosToolStripMenuItem, verFiestas, verMisComprasToolStripMenuItem, comrparProductosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1806, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // verProductosToolStripMenuItem
            // 
            verProductosToolStripMenuItem.Name = "verProductosToolStripMenuItem";
            verProductosToolStripMenuItem.Size = new Size(114, 24);
            verProductosToolStripMenuItem.Text = "Ver Productos";
            verProductosToolStripMenuItem.Click += verProductosToolStripMenuItem_Click;
            // 
            // verEventosToolStripMenuItem
            // 
            verEventosToolStripMenuItem.Name = "verEventosToolStripMenuItem";
            verEventosToolStripMenuItem.Size = new Size(99, 24);
            verEventosToolStripMenuItem.Text = "Ver Eventos";
            verEventosToolStripMenuItem.Click += verEventosToolStripMenuItem_Click;
            // 
            // verFiestas
            // 
            verFiestas.Name = "verFiestas";
            verFiestas.Size = new Size(92, 24);
            verFiestas.Text = "Ver Fiestas";
            verFiestas.Click += verFiestas_Click;
            // 
            // verMisComprasToolStripMenuItem
            // 
            verMisComprasToolStripMenuItem.Name = "verMisComprasToolStripMenuItem";
            verMisComprasToolStripMenuItem.Size = new Size(132, 24);
            verMisComprasToolStripMenuItem.Text = "Ver mis compras";
            verMisComprasToolStripMenuItem.Click += verMisComprasToolStripMenuItem_Click;
            // 
            // comrparProductosToolStripMenuItem
            // 
            comrparProductosToolStripMenuItem.Name = "comrparProductosToolStripMenuItem";
            comrparProductosToolStripMenuItem.Size = new Size(152, 24);
            comrparProductosToolStripMenuItem.Text = "Comrpar productos";
            comrparProductosToolStripMenuItem.Click += comrparProductosToolStripMenuItem_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Location = new Point(6, 33);
            panelContenedor.Margin = new Padding(3, 4, 3, 4);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1773, 822);
            panelContenedor.TabIndex = 1;
            panelContenedor.Dock = DockStyle.Fill;
            // 
            // menuCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1806, 883);
            Controls.Add(panelContenedor);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "menuCliente";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += menuCliente_Load_1;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem verProductosToolStripMenuItem;
        private ToolStripMenuItem verEventosToolStripMenuItem;
        private Panel panelContenedor;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem verFiestas;
        private ToolStripMenuItem verMisComprasToolStripMenuItem;
        private ToolStripMenuItem comrparProductosToolStripMenuItem;
    }
}