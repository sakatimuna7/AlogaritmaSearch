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
    public partial class MargeSort : Form
    {  
        public int nA, nL, nR ;
            
        public MargeSort()
        {
            InitializeComponent();
        }

        private void txt_inputangka_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false          // -- jika bukan digit
                && (int)e.KeyChar != (int)Keys.Back)     // -- dan bukan backspace
            {
                e.Handled = true;                         // -- membatalkan event keypress         
            }
            if ((int)e.KeyChar ==(int)Keys.Enter)
            {
                btn_add_Click(sender,e);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nA = 0; nL = 0; nR = 0;
            lbl_array.Text = "nA = 0";
            lbl_array_left.Text = "nL = 0";
            lbl_array_right.Text = "nR = 0";

            lst_hasil.Items.Clear();
            lst_Data.Items.Clear();
        }

       

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_inputangka.Text != "")
            {
                lst_Data.Items.Add(txt_inputangka.Text);
                txt_inputangka.Text = "";
                txt_inputangka.Focus();
            }
        }

        private void btn_hitungpjdata_Click(object sender, EventArgs e)
        {
            nA = lst_Data.Items.Count;
            lbl_array.Text = "nA = " +  nA.ToString();

           if(nA % 2 == 1)
                nL = (nA / 2)+1;
           else
               nL = (nA / 2);

           lbl_array_left.Text = "nL = " + nL.ToString();

           nR = nA - nL;           
           lbl_array_right.Text = "nR = " + nR.ToString();
            
        }



        private void btn_margesort_Click(object sender, EventArgs e)
        {
            int[] arr_A = new int[nA];
            int[] arr_L = new int[nL];
            int[] arr_R = new int[nR];
            int left=0;
            int right=0;

            for (int i = 0; i < nA; i++)
            {
                string value= lst_Data.Items[i].ToString();
                arr_A[i] =int.Parse(value);
                lbl_arr_A.Text = lbl_arr_A.Text + " " + value;
                if(i<nL)
                {    
                    arr_L[left] = int.Parse(value);
                    left ++;
                    lbl_arr_L.Text = lbl_arr_L.Text + "  " + value;                    
                }
                else
                {
                    arr_R[right] = int.Parse(value);
                    right ++;
                    lbl_arr_R.Text = lbl_arr_R.Text + "  " + value;  
                }
            }
            sort(arr_A, 0, arr_A.Length - 1);
            Print(arr_A);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lst_hasil.Items.Clear();
            lbl_arr_A.Text = "Arr_A =";
            lbl_arr_L.Text = "Arr_L =";
            lbl_arr_R.Text = "Arr_R =";
        }
        ///////////////
    private void Print(int[] arr)
    {
        foreach (int i in arr)
        {
            lst_hasil.Items.Add(i);
        }
    }
    private static void merge(int[] arr, int l, int m, int r) 
    { 
        // Find sizes of two subarrays to be merged 
        int n1 = m - l + 1; 
        int n2 = r - m; 
  
        /* Create temp arrays */
        int[] L = new int[n1]; 
        int[] R = new int[n2]; 
  
        /*Copy data to temp arrays*/
        for (int i=0; i<n1; ++i)
        {
            L[i] = arr[l + i]; 
        }
        for (int j=0; j<n2; ++j)
        {
            R[j] = arr[m + 1+ j]; 
        }
  
        /* Merge the temp arrays */
  
        // Initial indexes of first and second subarrays 
        int o = 0;
        int p = 0; 
  
        // Initial index of merged subarry array 
        int k = l; 
        while (o < n1 && p < n2) 
        { 
            if (L[o] <= R[p]) 
            { 
                arr[k] = L[o]; 
                o++; 
            } 
            else
            { 
                arr[k] = R[p]; 
                p++; 
            } 
            k++; 
        } 
  
        /* Copy remaining elements of L[] if any */
        while (o < n1) 
        { 
            arr[k] = L[o]; 
            o++; 
            k++; 
        } 
  
        /* Copy remaining elements of R[] if any */
        while (p < n2) 
        { 
            arr[k] = R[p]; 
            p++; 
            k++; 
        } 
    } 
  
    // Main function that sorts arr[l..r] using 
    // merge() 
    private static void sort(int[] arr, int l, int r) 
    { 
        if (l < r) 
        { 
            // Find the middle point 
            int m = (l+r)/2; 
  
            // Sort first and second halves 
            sort(arr, l, m); 
            sort(arr , m+1, r); 
  
            // Merge the sorted halves 
            merge(arr, l, m, r);
            
        }
    }
     ////////
    }
}
