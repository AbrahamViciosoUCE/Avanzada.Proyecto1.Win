namespace Avanzada.Proyecto1.Win
{
    partial class MainForm
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            productosToolStripMenuItem = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            MainPanel = new Panel();
            suppliersToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { productosToolStripMenuItem, categoriasToolStripMenuItem, suppliersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(895, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(66, 20);
            productosToolStripMenuItem.Text = "Products";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(75, 20);
            categoriasToolStripMenuItem.Text = "Categories";
            categoriasToolStripMenuItem.Click += categoriasToolStripMenuItem_Click;
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 24);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(895, 491);
            MainPanel.TabIndex = 1;
            // 
            // suppliersToolStripMenuItem
            // 
            suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            suppliersToolStripMenuItem.Size = new Size(67, 20);
            suppliersToolStripMenuItem.Text = "Suppliers";
            suppliersToolStripMenuItem.Click += suppliersToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 515);
            Controls.Add(MainPanel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Northwind";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem productosToolStripMenuItem;
        private Panel MainPanel;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem suppliersToolStripMenuItem;
    }
}
