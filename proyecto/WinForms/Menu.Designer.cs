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
            clienteABMToolStripMenuItem = new ToolStripMenuItem();
            eventosABMToolStripMenuItem = new ToolStripMenuItem();
            ingresarToolStripMenuItem = new ToolStripMenuItem();
            registrarseToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { clienteABMToolStripMenuItem, eventosABMToolStripMenuItem, ingresarToolStripMenuItem, registrarseToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // clienteABMToolStripMenuItem
            // 
            clienteABMToolStripMenuItem.Name = "clienteABMToolStripMenuItem";
            clienteABMToolStripMenuItem.Size = new Size(101, 24);
            clienteABMToolStripMenuItem.Text = "ClienteABM";
            clienteABMToolStripMenuItem.Click += clienteABMToolStripMenuItem_Click;
            // 
            // eventosABMToolStripMenuItem
            // 
            eventosABMToolStripMenuItem.Name = "eventosABMToolStripMenuItem";
            eventosABMToolStripMenuItem.Size = new Size(106, 24);
            eventosABMToolStripMenuItem.Text = "EventosABM";
            eventosABMToolStripMenuItem.Click += eventosABMToolStripMenuItem_Click;
            // 
            // ingresarToolStripMenuItem
            // 
            ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            ingresarToolStripMenuItem.Size = new Size(76, 24);
            ingresarToolStripMenuItem.Text = "Ingresar";
            // 
            // registrarseToolStripMenuItem
            // 
            registrarseToolStripMenuItem.Name = "registrarseToolStripMenuItem";
            registrarseToolStripMenuItem.Size = new Size(96, 24);
            registrarseToolStripMenuItem.Text = "Registrarse";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        private ToolStripMenuItem clienteABMToolStripMenuItem;
        private ToolStripMenuItem eventosABMToolStripMenuItem;
        private ToolStripMenuItem ingresarToolStripMenuItem;
        private ToolStripMenuItem registrarseToolStripMenuItem;
    }
}