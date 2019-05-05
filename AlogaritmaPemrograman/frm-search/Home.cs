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

        private void aboutmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Hamdan Habibi : Source Code/Repo Upload In My GitHub => https://github.com/sakatimuna7/AlogaritmaSearch ", "About Me", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void jumpSeacrhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jumpsrc jm = new jumpsrc();
            jm.MdiParent = this;
            jm.Show();
        }

        private void linierSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectionSort ss = new SelectionSort();
            ss.MdiParent = this;
            ss.Show();
        }

        private void bubleSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BubleSort bs = new BubleSort();
            bs.MdiParent = this;
            bs.Show();
        }

        private void margeSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MargeSort ms = new MargeSort();
            ms.MdiParent = this;
            ms.Show();
        }

        private void quickSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuickSort qs = new QuickSort();
            qs.MdiParent = this;
            qs.Show();
        }

        /*
         jika aplikasi ini di unggah mahasiswa untuk pengumpulan tugas terkecuali saya secara full tanpa =>
         * mengambil Code tertentu saja, saya harap bapak dosen dapat memberi sangsi terhadap =>
         * Mahasiswa Tersebut. Tujuan saya mengupload ini untuk memberikan contoh ke teman-teman saya yang sedikit =>
         * kesulitan dalam pembuatan program berbasis from.
         * Saya merasa program ini tidak sepenuhnya sempurna, jadi karna itu saya mohon maaf atas kekurangan =>
         * atas program yang saya buat
         */
    }
}
