namespace Aplikasi
{
    partial class FormLaporanPenjualan
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
            this.dtPeriode = new System.Windows.Forms.DateTimePicker();
            this.dtSelesai = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnEkspor = new System.Windows.Forms.Button();
            this.dgvLaporan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Periode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "s/d";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtPeriode
            // 
            this.dtPeriode.Location = new System.Drawing.Point(192, 98);
            this.dtPeriode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtPeriode.Name = "dtPeriode";
            this.dtPeriode.Size = new System.Drawing.Size(298, 26);
            this.dtPeriode.TabIndex = 2;
            this.dtPeriode.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtSelesai
            // 
            this.dtSelesai.Location = new System.Drawing.Point(582, 98);
            this.dtSelesai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtSelesai.Name = "dtSelesai";
            this.dtSelesai.Size = new System.Drawing.Size(298, 26);
            this.dtSelesai.TabIndex = 3;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(974, 100);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(126, 35);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "FILTER";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // btnEkspor
            // 
            this.btnEkspor.Location = new System.Drawing.Point(1168, 100);
            this.btnEkspor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEkspor.Name = "btnEkspor";
            this.btnEkspor.Size = new System.Drawing.Size(140, 35);
            this.btnEkspor.TabIndex = 5;
            this.btnEkspor.Text = "EKSPOR PDF";
            this.btnEkspor.UseVisualStyleBackColor = true;
            // 
            // dgvLaporan
            // 
            this.dgvLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaporan.Location = new System.Drawing.Point(123, 282);
            this.dgvLaporan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvLaporan.Name = "dgvLaporan";
            this.dgvLaporan.RowHeadersWidth = 62;
            this.dgvLaporan.Size = new System.Drawing.Size(1185, 326);
            this.dgvLaporan.TabIndex = 6;
            // 
            // FormLaporanPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1735, 695);
            this.Controls.Add(this.dgvLaporan);
            this.Controls.Add(this.btnEkspor);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dtSelesai);
            this.Controls.Add(this.dtPeriode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormLaporanPenjualan";
            this.Text = "FormLaporanPenjualan";
            this.Load += new System.EventHandler(this.FormLaporanPenjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtPeriode;
        private System.Windows.Forms.DateTimePicker dtSelesai;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnEkspor;
        private System.Windows.Forms.DataGridView dgvLaporan;
    }
}