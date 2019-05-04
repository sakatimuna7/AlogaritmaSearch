using System;
using System.Windows.Forms;

namespace frm_search
{
    public partial class Linier : Form
    {
        int[] data;
        int leng;
        int cari;
        int count = 0;

        public Linier()
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
            int hasil;
            arr();
            if (txt_search.Text == "") return;
            cari = int.Parse(txt_search.Text);
            hasil = linearSearch(data, cari);
            int[] index = new int[leng];
            count = 0;
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
                lbl_tampil.Text ="Nilai Yang Anda Cari(" + cari + ") Tidak Ditemukan";
            }
            else
            {
                lbl_tampil.Text ="Nilai Yang Anda Cari (" + cari + ") Ditemukan";
                lbl_count.Text = lbl_count.Text + count;
                for (int x = 0; x < count; x++)
                {
                    lbl_index.Text += index[x] + ", ";
                }
            }
            txt_search.Clear();
            txt_search.Focus();
        }

        //fungction
        static int linearSearch(int[] values, int target)
        {
            int n = values.Length;
            for (int i = 0; i < n; i++)
            {
                if (values[i] == target)
                {
                    return i;
                }
            }
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
            lst_arr.Items.Clear();
            Array.Sort(data);
            foreach (var i in data)
            {
                lst_arr.Items.Add(i);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lst_arr.Items.Clear();
            txt_input.Focus();
        }

        private void Linier_Load(object sender, EventArgs e)
        {
        }
        void _default()
        {
            lbl_count.Text = "Result : ";
            lbl_index.Text = "Index : ";
            lbl_count.Text = "Count : ";
        }
    }

}
