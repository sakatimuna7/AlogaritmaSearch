namespace WFormsShort
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.shortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionShortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bubleShortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quikShortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.margeSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shortToolStripMenuItem,
            this.aboutMeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(380, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // shortToolStripMenuItem
            // 
            this.shortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectionShortToolStripMenuItem,
            this.bubleShortToolStripMenuItem,
            this.quikShortToolStripMenuItem,
            this.margeSortToolStripMenuItem});
            this.shortToolStripMenuItem.Name = "shortToolStripMenuItem";
            this.shortToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.shortToolStripMenuItem.Text = "Menu";
            // 
            // selectionShortToolStripMenuItem
            // 
            this.selectionShortToolStripMenuItem.Name = "selectionShortToolStripMenuItem";
            this.selectionShortToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.selectionShortToolStripMenuItem.Text = "Selection Sort";
            this.selectionShortToolStripMenuItem.Click += new System.EventHandler(this.selectionShortToolStripMenuItem_Click);
            // 
            // bubleShortToolStripMenuItem
            // 
            this.bubleShortToolStripMenuItem.Name = "bubleShortToolStripMenuItem";
            this.bubleShortToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bubleShortToolStripMenuItem.Text = "Buble Sort";
            this.bubleShortToolStripMenuItem.Click += new System.EventHandler(this.bubleShortToolStripMenuItem_Click);
            // 
            // quikShortToolStripMenuItem
            // 
            this.quikShortToolStripMenuItem.Name = "quikShortToolStripMenuItem";
            this.quikShortToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quikShortToolStripMenuItem.Text = "Quik Sort";
            this.quikShortToolStripMenuItem.Click += new System.EventHandler(this.quikShortToolStripMenuItem_Click);
            // 
            // aboutMeToolStripMenuItem
            // 
            this.aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            this.aboutMeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.aboutMeToolStripMenuItem.Text = "About me";
            this.aboutMeToolStripMenuItem.Click += new System.EventHandler(this.aboutMeToolStripMenuItem_Click);
            // 
            // margeSortToolStripMenuItem
            // 
            this.margeSortToolStripMenuItem.Name = "margeSortToolStripMenuItem";
            this.margeSortToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.margeSortToolStripMenuItem.Text = "Marge Sort";
            this.margeSortToolStripMenuItem.Click += new System.EventHandler(this.margeSortToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 262);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectionShortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bubleShortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quikShortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem margeSortToolStripMenuItem;
    }
}

