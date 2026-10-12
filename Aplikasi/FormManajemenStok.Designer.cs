namespace Aplikasi
{
    partial class FormManajemenStok
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
            this.dgvBukuGudang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textSimpanStok = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBukuGudang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBukuGudang
            // 
            this.dgvBukuGudang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBukuGudang.Location = new System.Drawing.Point(89, 154);
            this.dgvBukuGudang.Name = "dgvBukuGudang";
            this.dgvBukuGudang.Size = new System.Drawing.Size(705, 154);
            this.dgvBukuGudang.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jumlah Buku Masuk Baru :";
            // 
            // textSimpanStok
            // 
            this.textSimpanStok.Location = new System.Drawing.Point(236, 322);
            this.textSimpanStok.Name = "textSimpanStok";
            this.textSimpanStok.Size = new System.Drawing.Size(100, 20);
            this.textSimpanStok.TabIndex = 2;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(660, 320);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(134, 23);
            this.btnSimpan.TabIndex = 3;
            this.btnSimpan.Text = "SIMPAN STOK";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // 
            // FormManajemenStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aplikasi.Properties.Resources._6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(913, 487);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.textSimpanStok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBukuGudang);
            this.Name = "FormManajemenStok";
            this.Text = "FormManajemenStok";
            this.Load += new System.EventHandler(this.FormManajemenStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBukuGudang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBukuGudang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSimpanStok;
        private System.Windows.Forms.Button btnSimpan;
    }
}