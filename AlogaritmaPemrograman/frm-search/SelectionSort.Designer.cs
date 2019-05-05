namespace frm_search
{
    partial class SelectionSort
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_hasil = new System.Windows.Forms.Button();
            this.lst_akhir = new System.Windows.Forms.ListBox();
            this.lst_awal = new System.Windows.Forms.ListBox();
            this.btn_input = new System.Windows.Forms.Button();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_hasil
            // 
            this.btn_hasil.Location = new System.Drawing.Point(99, 39);
            this.btn_hasil.Name = "btn_hasil";
            this.btn_hasil.Size = new System.Drawing.Size(75, 23);
            this.btn_hasil.TabIndex = 11;
            this.btn_hasil.Text = "Tampil";
            this.btn_hasil.UseVisualStyleBackColor = true;
            this.btn_hasil.Click += new System.EventHandler(this.btn_hasil_Click);
            // 
            // lst_akhir
            // 
            this.lst_akhir.FormattingEnabled = true;
            this.lst_akhir.Location = new System.Drawing.Point(154, 77);
            this.lst_akhir.Name = "lst_akhir";
            this.lst_akhir.Size = new System.Drawing.Size(120, 199);
            this.lst_akhir.TabIndex = 10;
            // 
            // lst_awal
            // 
            this.lst_awal.FormattingEnabled = true;
            this.lst_awal.Location = new System.Drawing.Point(18, 77);
            this.lst_awal.Name = "lst_awal";
            this.lst_awal.Size = new System.Drawing.Size(120, 199);
            this.lst_awal.TabIndex = 9;
            // 
            // btn_input
            // 
            this.btn_input.Location = new System.Drawing.Point(195, 11);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(75, 23);
            this.btn_input.TabIndex = 8;
            this.btn_input.Text = "Simpan";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(61, 13);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(128, 20);
            this.txt_input.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "INPUT";
            // 
            // SelectionSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 292);
            this.Controls.Add(this.btn_hasil);
            this.Controls.Add(this.lst_akhir);
            this.Controls.Add(this.lst_awal);
            this.Controls.Add(this.btn_input);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.label1);
            this.Name = "SelectionSort";
            this.Text = "SelectionSort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hasil;
        private System.Windows.Forms.ListBox lst_akhir;
        private System.Windows.Forms.ListBox lst_awal;
        private System.Windows.Forms.Button btn_input;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Label label1;
    }
}