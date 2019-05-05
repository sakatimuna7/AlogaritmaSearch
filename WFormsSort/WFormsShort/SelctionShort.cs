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
    public partial class SelctionShort : Form
    {
        int[] data = new int[5];
        int x;
        int wadah;
        public SelctionShort()
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

        private void SelctionShort_Load(object sender, EventArgs e)
        {
            x = 0;
            txt_input.Focus();
        }

        private void btn_hasil_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < x; i++)
            {
                lst_awal.Items.Add(data[i]);
            }
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (data[i] < data[j])
                    {
                        wadah = data[i];
                        data[i] = data[j];
                        data[j] = wadah;
                    }
                }
            }
            for (int i = 0; i < x; i++)
            {
                lst_akhir.Items.Add(data[i]);
            }
        }
    }
}
