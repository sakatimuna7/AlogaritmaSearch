namespace frm_search
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linierSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bubleSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.margeSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linierSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binnarySearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpSeacrhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linierSortToolStripMenuItem,
            this.bubleSortToolStripMenuItem,
            this.margeSortToolStripMenuItem,
            this.quickSortToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.sortToolStripMenuItem.Text = "Sort";
            // 
            // linierSortToolStripMenuItem
            // 
            this.linierSortToolStripMenuItem.Name = "linierSortToolStripMenuItem";
            this.linierSortToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.linierSortToolStripMenuItem.Text = "Selection Sort";
            this.linierSortToolStripMenuItem.Click += new System.EventHandler(this.linierSortToolStripMenuItem_Click);
            // 
            // bubleSortToolStripMenuItem
            // 
            this.bubleSortToolStripMenuItem.Name = "bubleSortToolStripMenuItem";
            this.bubleSortToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bubleSortToolStripMenuItem.Text = "Buble Sort";
            this.bubleSortToolStripMenuItem.Click += new System.EventHandler(this.bubleSortToolStripMenuItem_Click);
            // 
            // margeSortToolStripMenuItem
            // 
            this.margeSortToolStripMenuItem.Name = "margeSortToolStripMenuItem";
            this.margeSortToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.margeSortToolStripMenuItem.Text = "Marge Sort";
            this.margeSortToolStripMenuItem.Click += new System.EventHandler(this.margeSortToolStripMenuItem_Click);
            // 
            // quickSortToolStripMenuItem
            // 
            this.quickSortToolStripMenuItem.Name = "quickSortToolStripMenuItem";
            this.quickSortToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quickSortToolStripMenuItem.Text = "Quick Sort";
            this.quickSortToolStripMenuItem.Click += new System.EventHandler(this.quickSortToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linierSearchToolStripMenuItem,
            this.binnarySearchToolStripMenuItem,
            this.jumpSeacrhToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // linierSearchToolStripMenuItem
            // 
            this.linierSearchToolStripMenuItem.Name = "linierSearchToolStripMenuItem";
            this.linierSearchToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.linierSearchToolStripMenuItem.Text = "Linier Search";
            this.linierSearchToolStripMenuItem.Click += new System.EventHandler(this.linierSearchToolStripMenuItem_Click);
            // 
            // binnarySearchToolStripMenuItem
            // 
            this.binnarySearchToolStripMenuItem.Name = "binnarySearchToolStripMenuItem";
            this.binnarySearchToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.binnarySearchToolStripMenuItem.Text = "Binnary Search";
            this.binnarySearchToolStripMenuItem.Click += new System.EventHandler(this.binnarySearchToolStripMenuItem_Click);
            // 
            // jumpSeacrhToolStripMenuItem
            // 
            this.jumpSeacrhToolStripMenuItem.Name = "jumpSeacrhToolStripMenuItem";
            this.jumpSeacrhToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.jumpSeacrhToolStripMenuItem.Text = "Jump Seacrh";
            this.jumpSeacrhToolStripMenuItem.Click += new System.EventHandler(this.jumpSeacrhToolStripMenuItem_Click);
            // 
            // aboutmeToolStripMenuItem
            // 
            this.aboutmeToolStripMenuItem.Name = "aboutmeToolStripMenuItem";
            this.aboutmeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.aboutmeToolStripMenuItem.Text = "About Me";
            this.aboutmeToolStripMenuItem.Click += new System.EventHandler(this.aboutmeToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.aboutmeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(559, 262);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linierSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bubleSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem margeSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linierSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binnarySearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jumpSeacrhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutmeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;

    }
}

