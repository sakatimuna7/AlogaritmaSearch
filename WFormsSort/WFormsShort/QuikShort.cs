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
    public partial class QuikShort : Form
    {
        int[] arr = new int[5];
        int x;
        public QuikShort()
        {
            InitializeComponent();
        }

        private void QuikShort_Load(object sender, EventArgs e)
        {
            x = 0;
            txt_input.Focus();
        }


        //==============
        private static void Quick_Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort(arr, pivot + 1, right);
                }
            }

        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }

        private void btn_input_Click_1(object sender, EventArgs e)
        {
            if (x > 4)
            {
                btn_input.Enabled = false;
            }
            else
            {
                arr[x] = int.Parse(txt_input.Text);
                x++;
                txt_input.Clear();
                txt_input.Focus();
            }
        }

        private void btn_hasil_Click(object sender, EventArgs e)
        {
            foreach (var item in arr)
            {
                lst_awal.Items.Add(item);
            }
            Quick_Sort(arr, 0, arr.Length - 1);
            foreach (var item in arr)
            {
                lst_akhir.Items.Add(item);
            }
        }
        //==============

    }
}
