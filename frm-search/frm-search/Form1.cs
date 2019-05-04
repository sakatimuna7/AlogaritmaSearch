using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_search
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void linierSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Linier ln = new Linier();
            ln.MdiParent = this;
            ln.Show();
        }

        private void binnarySearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            binnsrc bn = new binnsrc();
            bn.MdiParent = this;
            bn.Show();
        }
    }
}
