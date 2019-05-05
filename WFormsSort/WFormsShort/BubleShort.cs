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
    public partial class BubleShort : Form
    {
        int[] data = new int[5];
        int x;
        int wadah;
        public BubleShort()
        {
            InitializeComponent();
        }

        private void btn_input_Click(object sender, EventArgs e)
        {
            if (x > 4)
            {
                btn_input.Enabled = false;
            }
            else
            {
                data[x] = int.Parse(txt_input.Text);
                x++;
                txt_input.Clear();
                txt_input.Focus();
            }
        }

        private void btn_hasil_Click(object sender, EventArgs e)
        {
            foreach (int p in data)
            {
                lst_awal.Items.Add(p);
            }
            for (int i = 0; i <= data.Length - 2; i++)
            {
                for (int j = 0; j <= data.Length - 2; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        wadah = data[j + 1];
                        data[j+1] = data[j];
                        data[j] = wadah;
                    }
                }
            }
            foreach (int p in data)
            {
                lst_akhir.Items.Add(p);
            }
        }

        private void BubleShort_Load(object sender, EventArgs e)
        {
            x = 0;
            txt_input.Focus();
        }

        private void txt_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false
                && (int)e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
            }
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btn_input_Click(sender, e);
            }
        }
    }
}
