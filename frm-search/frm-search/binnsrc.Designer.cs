﻿namespace frm_search
{
    partial class binnsrc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(binnsrc));
            this.btn_clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_tampil = new System.Windows.Forms.Label();
            this.btn_cari = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lst_arr = new System.Windows.Forms.ListBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.lst_sort = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.AutoSize = true;
            this.btn_clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_clear.BackgroundImage")));
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_clear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_clear.Location = new System.Drawing.Point(388, 0);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(63, 264);
            this.btn_clear.TabIndex = 15;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(117, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Binnary Search";
            // 
            // lbl_tampil
            // 
            this.lbl_tampil.AutoSize = true;
            this.lbl_tampil.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_tampil.Location = new System.Drawing.Point(12, 233);
            this.lbl_tampil.Name = "lbl_tampil";
            this.lbl_tampil.Size = new System.Drawing.Size(0, 13);
            this.lbl_tampil.TabIndex = 13;
            // 
            // btn_cari
            // 
            this.btn_cari.BackColor = System.Drawing.Color.IndianRed;
            this.btn_cari.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cari.BackgroundImage")));
            this.btn_cari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cari.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_cari.Location = new System.Drawing.Point(346, 184);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.Size = new System.Drawing.Size(47, 41);
            this.btn_cari.TabIndex = 12;
            this.btn_cari.UseVisualStyleBackColor = false;
            this.btn_cari.Click += new System.EventHandler(this.btn_cari_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(296, 39);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "Tambah";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lst_arr
            // 
            this.lst_arr.FormattingEnabled = true;
            this.lst_arr.Location = new System.Drawing.Point(12, 81);
            this.lst_arr.Name = "lst_arr";
            this.lst_arr.Size = new System.Drawing.Size(183, 95);
            this.lst_arr.TabIndex = 10;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(111, 194);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(223, 20);
            this.txt_search.TabIndex = 9;
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_keypress);
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(30, 42);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(260, 20);
            this.txt_input.TabIndex = 8;
            this.txt_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_input_KeyPress);
            // 
            // lst_sort
            // 
            this.lst_sort.FormattingEnabled = true;
            this.lst_sort.Location = new System.Drawing.Point(212, 81);
            this.lst_sort.Name = "lst_sort";
            this.lst_sort.Size = new System.Drawing.Size(176, 95);
            this.lst_sort.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(8, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cari Angka";
            // 
            // binnsrc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(451, 264);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lst_sort);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_tampil);
            this.Controls.Add(this.btn_cari);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lst_arr);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.txt_input);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "binnsrc";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Binnary Seacrh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tampil;
        private System.Windows.Forms.Button btn_cari;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ListBox lst_arr;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.ListBox lst_sort;
        private System.Windows.Forms.Label label2;
    }
}