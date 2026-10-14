namespace Aplikasi
{
    partial class FormTransaksiPenjualan
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
            this.cmbCariBuku = new System.Windows.Forms.ComboBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvKeranjang = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeranjang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Buku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(596, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jumlah";
            // 
            // cmbCariBuku
            // 
            this.cmbCariBuku.FormattingEnabled = true;
            this.cmbCariBuku.Location = new System.Drawing.Point(212, 141);
            this.cmbCariBuku.Name = "cmbCariBuku";
            this.cmbCariBuku.Size = new System.Drawing.Size(121, 21);
            this.cmbCariBuku.TabIndex = 2;
            this.cmbCariBuku.TextUpdate += new System.EventHandler(this.cmbCariBuku_TextUpdate);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(658, 141);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(780, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // dgvKeranjang
            // 
            this.dgvKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeranjang.Location = new System.Drawing.Point(131, 197);
            this.dgvKeranjang.Name = "dgvKeranjang";
            this.dgvKeranjang.RowHeadersWidth = 62;
            this.dgvKeranjang.Size = new System.Drawing.Size(724, 228);
            this.dgvKeranjang.TabIndex = 5;
            this.dgvKeranjang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKeranjang_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "TOTAL BELANJA";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Location = new System.Drawing.Point(282, 453);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(40, 13);
            this.lblGrandTotal.TabIndex = 7;
            this.lblGrandTotal.Text = "Jumlah";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(780, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Bayar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // FormTransaksiPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aplikasi.Properties.Resources._5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(913, 487);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvKeranjang);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.cmbCariBuku);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTransaksiPenjualan";
            this.Text = "FormTransaksiPenjualan";
            this.Load += new System.EventHandler(this.FormTransaksiPenjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeranjang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCariBuku;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvKeranjang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Button button2;
    }
}