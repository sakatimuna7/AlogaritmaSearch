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
    public partial class binnsrc : Form
    {
        int[] data;
        int leng;
        int cari;

        public binnsrc()
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
            _default();
            if (lst_sort.Text == "") arr();
            if (txt_search.Text == "")return ;
            cari = int.Parse(txt_search.Text);
            int hasil = binarySearch(data, 0, leng - 1, cari);
            print(hasil);
            txt_search.Clear();
            txt_search.Focus();
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            _default();
            lst_arr.Items.Clear();
            lst_sort.Items.Clear();
            txt_input.Focus();
        }
                            //fungction 
    // Returns index of x if it is present in 
    // arr[l..r], else return -1 
        static int binarySearch(int[] arr, int l,int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                // If the element is present at the 
                // middle itself 
                if (arr[mid] == x)
                    return mid;

                // If element is smaller than mid, then 
                // it can only be present in left subarray 
                if (arr[mid] > x)
                    return binarySearch(arr, l, mid - 1, x);

                // Else the element can only be present 
                // in right subarray 
                return binarySearch(arr, mid + 1, r, x);
            }

            // We reach here when element is not present 
            // in array 
            return -1;
        }
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
            lst_sort.Items.Clear();
            foreach (var i in data)
            {
                lst_sort.Items.Add(i);
            }
        }
        void _default()
        {
            lbl_count.Text = "Result : ";
            lbl_index.Text = "Index : ";
            lbl_count.Text = "Count : ";
        }
        void print(int hasil)
        {
            int[] index = new int[leng];
            int count = 0;
            for (int i = 0; i < leng; i++)
            {
                if (data[i] == cari)
                {
                    index[count] = i;
                    count++;
                }
            }

            if (hasil == -1)
            {
                lbl_tampil.Text = "Nilai Yang Anda Cari(" + cari + ") Tidak Ditemukan";
            }
            else
            {
                lbl_tampil.Text = "Nilai Yang Anda Cari (" + cari + ") Ditemukan";
                lbl_count.Text = lbl_count.Text + count;
                for (int x = 0; x < count; x++)
                {
                    lbl_index.Text += index[x] + ", ";
                }
            }
        }
    }
}
