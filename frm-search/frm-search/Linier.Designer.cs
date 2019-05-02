namespace frm_search
{
    partial class Linier
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
            this.txt_input = new System.Windows.Forms.TextBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lst_arr = new System.Windows.Forms.ListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cari = new System.Windows.Forms.Button();
            this.lbl_tampil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(12, 16);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(179, 20);
            this.txt_input.TabIndex = 0;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(12, 165);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(179, 20);
            this.txt_search.TabIndex = 1;
            // 
            // lst_arr
            // 
            this.lst_arr.FormattingEnabled = true;
            this.lst_arr.Location = new System.Drawing.Point(12, 54);
            this.lst_arr.Name = "lst_arr";
            this.lst_arr.Size = new System.Drawing.Size(260, 95);
            this.lst_arr.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(197, 16);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Tambah";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cari
            // 
            this.btn_cari.Location = new System.Drawing.Point(197, 162);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.Size = new System.Drawing.Size(75, 23);
            this.btn_cari.TabIndex = 4;
            this.btn_cari.Text = "Cari";
            this.btn_cari.UseVisualStyleBackColor = true;
            this.btn_cari.Click += new System.EventHandler(this.btn_cari_Click);
            // 
            // lbl_tampil
            // 
            this.lbl_tampil.AutoSize = true;
            this.lbl_tampil.Location = new System.Drawing.Point(12, 206);
            this.lbl_tampil.Name = "lbl_tampil";
            this.lbl_tampil.Size = new System.Drawing.Size(0, 13);
            this.lbl_tampil.TabIndex = 5;
            // 
            // Linier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 236);
            this.Controls.Add(this.lbl_tampil);
            this.Controls.Add(this.btn_cari);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lst_arr);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.txt_input);
            this.Name = "Linier";
            this.Text = "Linier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ListBox lst_arr;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cari;
        private System.Windows.Forms.Label lbl_tampil;
    }
}