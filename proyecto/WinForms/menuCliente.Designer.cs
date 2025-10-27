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
            panelContenedor = new Panel();
            verMisComprasToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { verProductosToolStripMenuItem, verEventosToolStripMenuItem, verFiestas, verMisComprasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // verProductosToolStripMenuItem
            // 
            verProductosToolStripMenuItem.Name = "verProductosToolStripMenuItem";
            verProductosToolStripMenuItem.Size = new Size(92, 20);
            verProductosToolStripMenuItem.Text = "Ver Productos";
            verProductosToolStripMenuItem.Click += verProductosToolStripMenuItem_Click;
            // 
            // verEventosToolStripMenuItem
            // 
            verEventosToolStripMenuItem.Name = "verEventosToolStripMenuItem";
            verEventosToolStripMenuItem.Size = new Size(79, 20);
            verEventosToolStripMenuItem.Text = "Ver Eventos";
            verEventosToolStripMenuItem.Click += verEventosToolStripMenuItem_Click;
            // 
            // verFiestas
            // 
            verFiestas.Name = "verFiestas";
            verFiestas.Size = new Size(73, 20);
            verFiestas.Text = "Ver Fiestas";
            verFiestas.Click += verFiestas_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Location = new Point(5, 25);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(793, 424);
            panelContenedor.TabIndex = 1;
            // 
            // verMisComprasToolStripMenuItem
            // 
            verMisComprasToolStripMenuItem.Name = "verMisComprasToolStripMenuItem";
            verMisComprasToolStripMenuItem.Size = new Size(106, 20);
            verMisComprasToolStripMenuItem.Text = "Ver mis compras";
            verMisComprasToolStripMenuItem.Click += verMisComprasToolStripMenuItem_Click;
            // 
            // menuCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContenedor);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
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
    }
}