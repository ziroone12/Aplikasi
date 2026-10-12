namespace Aplikasi
{
    partial class FormManajemenBuku
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.txtJudul = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtPenerbit = new System.Windows.Forms.TextBox();
            this.txtPengarang = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvMasterBuku = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterBuku)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 217);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barcode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Judul";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(987, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 300);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pengarang";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 311);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Penerbit";
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(196, 212);
            this.txtKode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(148, 26);
            this.txtKode.TabIndex = 5;
            // 
            // txtJudul
            // 
            this.txtJudul.Location = new System.Drawing.Point(597, 218);
            this.txtJudul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(148, 26);
            this.txtJudul.TabIndex = 6;
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(1070, 212);
            this.txtHarga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(148, 26);
            this.txtHarga.TabIndex = 7;
            // 
            // txtPenerbit
            // 
            this.txtPenerbit.Location = new System.Drawing.Point(597, 306);
            this.txtPenerbit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPenerbit.Name = "txtPenerbit";
            this.txtPenerbit.Size = new System.Drawing.Size(148, 26);
            this.txtPenerbit.TabIndex = 8;
            // 
            // txtPengarang
            // 
            this.txtPengarang.Location = new System.Drawing.Point(196, 300);
            this.txtPengarang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPengarang.Name = "txtPengarang";
            this.txtPengarang.Size = new System.Drawing.Size(148, 26);
            this.txtPengarang.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 442);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 52);
            this.button1.TabIndex = 9;
            this.button1.Text = "SIMPAN BUKU";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(615, 442);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 52);
            this.button2.TabIndex = 10;
            this.button2.Text = "EDIT BUKU";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1070, 442);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 52);
            this.button3.TabIndex = 11;
            this.button3.Text = "HAPUS BUKU";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // dgvMasterBuku
            // 
            this.dgvMasterBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasterBuku.Location = new System.Drawing.Point(94, 546);
            this.dgvMasterBuku.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMasterBuku.Name = "dgvMasterBuku";
            this.dgvMasterBuku.RowHeadersWidth = 62;
            this.dgvMasterBuku.Size = new System.Drawing.Size(1125, 138);
            this.dgvMasterBuku.TabIndex = 12;
            this.dgvMasterBuku.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMasterBuku_CellClick);
            // 
            // FormManajemenBuku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aplikasi.Properties.Resources._4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1735, 695);
            this.Controls.Add(this.dgvMasterBuku);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPengarang);
            this.Controls.Add(this.txtPenerbit);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtJudul);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormManajemenBuku";
            this.Text = "FormManajemenBuku";
            this.Load += new System.EventHandler(this.FormManajemenBuku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasterBuku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.TextBox txtJudul;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtPenerbit;
        private System.Windows.Forms.TextBox txtPengarang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvMasterBuku;
    }
}