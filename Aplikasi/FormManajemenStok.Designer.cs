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
            this.label8 = new System.Windows.Forms.Label();
            this.btnKembaliDashboard = new System.Windows.Forms.Button();
            this.dgvStokGudang = new System.Windows.Forms.DataGridView();
            this.btnSimpanStok = new System.Windows.Forms.Button();
            this.txtJumlahStokBaru = new System.Windows.Forms.TextBox();
            this.lblBukuTerpilih = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokGudang)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Agency FB", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-36, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(695, 14);
            this.label8.TabIndex = 29;
            this.label8.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "___________";
            // 
            // btnKembaliDashboard
            // 
            this.btnKembaliDashboard.Location = new System.Drawing.Point(16, 60);
            this.btnKembaliDashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btnKembaliDashboard.Name = "btnKembaliDashboard";
            this.btnKembaliDashboard.Size = new System.Drawing.Size(67, 23);
            this.btnKembaliDashboard.TabIndex = 28;
            this.btnKembaliDashboard.Text = "Dashboard";
            this.btnKembaliDashboard.UseVisualStyleBackColor = true;
            // 
            // dgvStokGudang
            // 
            this.dgvStokGudang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStokGudang.Location = new System.Drawing.Point(16, 180);
            this.dgvStokGudang.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStokGudang.Name = "dgvStokGudang";
            this.dgvStokGudang.RowHeadersWidth = 62;
            this.dgvStokGudang.RowTemplate.Height = 28;
            this.dgvStokGudang.Size = new System.Drawing.Size(1140, 244);
            this.dgvStokGudang.TabIndex = 27;
            // 
            // btnSimpanStok
            // 
            this.btnSimpanStok.Location = new System.Drawing.Point(16, 148);
            this.btnSimpanStok.Margin = new System.Windows.Forms.Padding(2);
            this.btnSimpanStok.Name = "btnSimpanStok";
            this.btnSimpanStok.Size = new System.Drawing.Size(90, 29);
            this.btnSimpanStok.TabIndex = 26;
            this.btnSimpanStok.Text = "Simpan";
            this.btnSimpanStok.UseVisualStyleBackColor = true;
            // 
            // txtJumlahStokBaru
            // 
            this.txtJumlahStokBaru.Location = new System.Drawing.Point(112, 128);
            this.txtJumlahStokBaru.Margin = new System.Windows.Forms.Padding(2);
            this.txtJumlahStokBaru.Name = "txtJumlahStokBaru";
            this.txtJumlahStokBaru.Size = new System.Drawing.Size(68, 20);
            this.txtJumlahStokBaru.TabIndex = 25;
            // 
            // lblBukuTerpilih
            // 
            this.lblBukuTerpilih.AutoSize = true;
            this.lblBukuTerpilih.Location = new System.Drawing.Point(90, 113);
            this.lblBukuTerpilih.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBukuTerpilih.Name = "lblBukuTerpilih";
            this.lblBukuTerpilih.Size = new System.Drawing.Size(72, 13);
            this.lblBukuTerpilih.TabIndex = 24;
            this.lblBukuTerpilih.Text = "Buku Terpilih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Jumlah Stok Baru:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Buku Terpilih:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(129, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "MANAGEMENT STOK";
            // 
            // FormManajemenStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnKembaliDashboard);
            this.Controls.Add(this.dgvStokGudang);
            this.Controls.Add(this.btnSimpanStok);
            this.Controls.Add(this.txtJumlahStokBaru);
            this.Controls.Add(this.lblBukuTerpilih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormManajemenStok";
            this.Text = "FormManajemenStok";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokGudang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnKembaliDashboard;
        private System.Windows.Forms.DataGridView dgvStokGudang;
        private System.Windows.Forms.Button btnSimpanStok;
        private System.Windows.Forms.TextBox txtJumlahStokBaru;
        private System.Windows.Forms.Label lblBukuTerpilih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}