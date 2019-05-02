using System;
using System.Windows.Forms;

namespace frm_search
{
    public partial class Linier : Form
    {
        int[] data;
        int leng;
        int cari;

        public Linier()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            lst_arr.Items.Add(txt_input.Text);
            txt_input.Clear();
            txt_input.Focus();
        }

        private void btn_cari_Click(object sender, EventArgs e)
        {
            arr();
            cari = int.Parse(txt_search.Text);
            int hasil = linearSearch(data, cari);

            if (hasil == -1)
            {
                lbl_tampil.Text = "Nilai Yang Anda Cari Tidak Ada Error Code ";
            }
            else
            {
                lbl_tampil.Text = "Nilai Yang Anda Cari Ada Di Index " + hasil;
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
        }
    }

}
