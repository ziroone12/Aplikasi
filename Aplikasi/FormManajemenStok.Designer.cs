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
            this.label8.Location = new System.Drawing.Point(-54, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1041, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "___________";
            // 
            // btnKembaliDashboard
            // 
            this.btnKembaliDashboard.Location = new System.Drawing.Point(24, 92);
            this.btnKembaliDashboard.Name = "btnKembaliDashboard";
            this.btnKembaliDashboard.Size = new System.Drawing.Size(100, 35);
            this.btnKembaliDashboard.TabIndex = 28;
            this.btnKembaliDashboard.Text = "Dashboard";
            this.btnKembaliDashboard.UseVisualStyleBackColor = true;
            this.btnKembaliDashboard.Click += new System.EventHandler(this.btnKembaliDashboard_Click);
            // 
            // dgvStokGudang
            // 
            this.dgvStokGudang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStokGudang.Location = new System.Drawing.Point(24, 277);
            this.dgvStokGudang.Name = "dgvStokGudang";
            this.dgvStokGudang.RowHeadersWidth = 62;
            this.dgvStokGudang.RowTemplate.Height = 28;
            this.dgvStokGudang.Size = new System.Drawing.Size(1743, 484);
            this.dgvStokGudang.TabIndex = 27;
            this.dgvStokGudang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStokGudang_CellContentClick);
            this.dgvStokGudang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStokGudang_CellContentClick);
            // 
            // btnSimpanStok
            // 
            this.btnSimpanStok.Location = new System.Drawing.Point(24, 228);
            this.btnSimpanStok.Name = "btnSimpanStok";
            this.btnSimpanStok.Size = new System.Drawing.Size(135, 45);
            this.btnSimpanStok.TabIndex = 26;
            this.btnSimpanStok.Text = "Simpan";
            this.btnSimpanStok.UseVisualStyleBackColor = true;
            this.btnSimpanStok.Click += new System.EventHandler(this.btnSimpanStok_Click);
            // 
            // txtJumlahStokBaru
            // 
            this.txtJumlahStokBaru.Location = new System.Drawing.Point(168, 197);
            this.txtJumlahStokBaru.Name = "txtJumlahStokBaru";
            this.txtJumlahStokBaru.Size = new System.Drawing.Size(100, 26);
            this.txtJumlahStokBaru.TabIndex = 25;
            // 
            // lblBukuTerpilih
            // 
            this.lblBukuTerpilih.AutoSize = true;
            this.lblBukuTerpilih.Location = new System.Drawing.Point(135, 174);
            this.lblBukuTerpilih.Name = "lblBukuTerpilih";
            this.lblBukuTerpilih.Size = new System.Drawing.Size(104, 20);
            this.lblBukuTerpilih.TabIndex = 24;
            this.lblBukuTerpilih.Text = "Buku Terpilih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Jumlah Stok Baru:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Buku Terpilih:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(194, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 54);
            this.label1.TabIndex = 21;
            this.label1.Text = "MANAGEMENT STOK";
            // 
            // FormManajemenStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aplikasi.Properties.Resources._6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1779, 773);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnKembaliDashboard);
            this.Controls.Add(this.dgvStokGudang);
            this.Controls.Add(this.btnSimpanStok);
            this.Controls.Add(this.txtJumlahStokBaru);
            this.Controls.Add(this.lblBukuTerpilih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormManajemenStok";
            this.Text = "FormManajemenStok";
            this.Load += new System.EventHandler(this.FormManajemenStok_Load);
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