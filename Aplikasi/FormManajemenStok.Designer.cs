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
            this.dgvBukuGudang.Location = new System.Drawing.Point(134, 237);
            this.dgvBukuGudang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBukuGudang.Name = "dgvBukuGudang";
            this.dgvBukuGudang.RowHeadersWidth = 62;
            this.dgvBukuGudang.Size = new System.Drawing.Size(1058, 237);
            this.dgvBukuGudang.TabIndex = 0;
            this.dgvBukuGudang.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBukuGudang_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 495);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jumlah Buku Masuk Baru :";
            // 
            // textSimpanStok
            // 
            this.textSimpanStok.Location = new System.Drawing.Point(354, 495);
            this.textSimpanStok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textSimpanStok.Name = "textSimpanStok";
            this.textSimpanStok.Size = new System.Drawing.Size(148, 26);
            this.textSimpanStok.TabIndex = 2;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(990, 492);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(201, 35);
            this.btnSimpan.TabIndex = 3;
            this.btnSimpan.Text = "SIMPAN STOK";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpanStok_Click);
            // 
            // FormManajemenStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aplikasi.Properties.Resources._6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.textSimpanStok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBukuGudang);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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