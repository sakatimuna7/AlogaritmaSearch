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
    public partial class jumpsrc : Form
    {
        int[] data;
        int leng;
        int cari;

        public jumpsrc()
        {
            InitializeComponent();
        }
        private void txt_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false          // -- jika bukan digit
                && (int)e.KeyChar != (int)Keys.Back)     // -- dan bukan backspace
            {
                e.Handled = true;                         // -- membatalkan event keypress         
            }

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btn_add_Click(sender, e);
            }
        }
        private void txt_search_keypress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false          // -- jika bukan digit
                && (int)e.KeyChar != (int)Keys.Back)     // -- dan bukan backspace
            {
                e.Handled = true;                         // -- membatalkan event keypress         
            }

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btn_cari_Click(sender, e);
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_input.Text == "") return;
            lst_arr.Items.Add(txt_input.Text);
            txt_input.Clear();
            txt_input.Focus();
        }
        private void btn_cari_Click(object sender, EventArgs e)
        {
            if (lst_sort.Text == "") arr();
            if (txt_search.Text == "") return;
            cari = int.Parse(txt_search.Text);
            int hasil = jumpSearch(data, cari);
            if (hasil == -1)
            {
                lbl_tampil.Text = "Nilai Yang Anda Cari Tidak Ada Error Code ";
            }
            else
            {
                lbl_tampil.Text = "Nilai Yang Anda Cari Ada Di Index " + hasil + ", " + (hasil+1);
            }
            txt_search.Clear();
            txt_search.Focus();
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            lst_arr.Items.Clear();
            lst_sort.Items.Clear();
            txt_input.Focus();
        }
        //Fungctin
        void arr()
        {
            leng = lst_arr.Items.Count;
            data = new int[leng];
            for (int i = 0; i < leng; i++)
            {
                data[i] = int.Parse(lst_arr.Items[i].ToString());
            }
            //sorting array data
            Array.Sort(data);
            foreach (var i in data)
            {
                lst_sort.Items.Add(i);
            }
        }
        public static int jumpSearch(int[] arr, int x)
        {
            int n = arr.Length;

            // Finding block size to be jumped 
            int step = (int)Math.Floor(Math.Sqrt(n));

            // Finding the block where element is 
            // present (if it is present) 
            int prev = 0;
            while (arr[Math.Min(step, n) - 1] < x)
            {
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(n));
                if (prev >= n)
                    return -1;
            }

            // Doing a linear search for x in block 
            // beginning with prev. 
            while (arr[prev] < x)
            {
                prev++;

                // If we reached next block or end of 
                // array, element is not present. 
                if (prev == Math.Min(step, n))
                    return -1;
            }

            // If element is found 
            if (arr[prev] == x)
                return prev;

            return -1;
        }
    }
}
