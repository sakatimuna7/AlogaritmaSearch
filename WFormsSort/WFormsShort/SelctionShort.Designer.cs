﻿namespace WFormsShort
{
    partial class SelctionShort
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.btn_input = new System.Windows.Forms.Button();
            this.lst_awal = new System.Windows.Forms.ListBox();
            this.lst_akhir = new System.Windows.Forms.ListBox();
            this.btn_hasil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INPUT";
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(63, 18);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(128, 20);
            this.txt_input.TabIndex = 1;
            // 
            // btn_input
            // 
            this.btn_input.Location = new System.Drawing.Point(197, 16);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(75, 23);
            this.btn_input.TabIndex = 2;
            this.btn_input.Text = "Simpan";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // lst_awal
            // 
            this.lst_awal.FormattingEnabled = true;
            this.lst_awal.Location = new System.Drawing.Point(20, 90);
            this.lst_awal.Name = "lst_awal";
            this.lst_awal.Size = new System.Drawing.Size(120, 199);
            this.lst_awal.TabIndex = 3;
            // 
            // lst_akhir
            // 
            this.lst_akhir.FormattingEnabled = true;
            this.lst_akhir.Location = new System.Drawing.Point(156, 90);
            this.lst_akhir.Name = "lst_akhir";
            this.lst_akhir.Size = new System.Drawing.Size(120, 199);
            this.lst_akhir.TabIndex = 4;
            // 
            // btn_hasil
            // 
            this.btn_hasil.Location = new System.Drawing.Point(105, 61);
            this.btn_hasil.Name = "btn_hasil";
            this.btn_hasil.Size = new System.Drawing.Size(75, 23);
            this.btn_hasil.TabIndex = 5;
            this.btn_hasil.Text = "Tampil";
            this.btn_hasil.UseVisualStyleBackColor = true;
            this.btn_hasil.Click += new System.EventHandler(this.btn_hasil_Click);
            // 
            // SelctionShort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(288, 315);
            this.Controls.Add(this.btn_hasil);
            this.Controls.Add(this.lst_akhir);
            this.Controls.Add(this.lst_awal);
            this.Controls.Add(this.btn_input);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.label1);
            this.Name = "SelctionShort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelctionShort";
            this.Load += new System.EventHandler(this.SelctionShort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Button btn_input;
        private System.Windows.Forms.ListBox lst_awal;
        private System.Windows.Forms.ListBox lst_akhir;
        private System.Windows.Forms.Button btn_hasil;
    }
}