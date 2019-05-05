using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFormsShort
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void selectionShortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelctionShort sh = new SelctionShort();
            sh.MdiParent = this;
            sh.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Created by HamdanHabibi", "About me", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bubleShortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BubleShort bs = new BubleShort();
            bs.MdiParent = this;
            bs.Show();
        }

        private void quikShortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuikShort qs = new QuikShort();
            qs.MdiParent = this;
            qs.Show();
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by HamdanHabibi","About me",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void margeSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MargeSort ms = new MargeSort();
            ms.MdiParent = this;
            ms.Show();
        }
    }
}
