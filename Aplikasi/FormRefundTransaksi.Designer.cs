namespace Aplikasi
{
    partial class FormRefundTransaksi
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
            this.txtIDtransaksi = new System.Windows.Forms.TextBox();
            this.btnCariNota = new System.Windows.Forms.Button();
            this.btnProsesRefund = new System.Windows.Forms.Button();
            this.dgvRincian = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRincian)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "No id Nota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.label2.Location = new System.Drawing.Point(12, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(825, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Refund akan menghapus total rekor nota keuangan dan mengembalikan sisa kuantitas " +
    "stok fisik kembali ke gudang";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtIDtransaksi
            // 
            this.txtIDtransaksi.Location = new System.Drawing.Point(113, 30);
            this.txtIDtransaksi.Name = "txtIDtransaksi";
            this.txtIDtransaksi.Size = new System.Drawing.Size(100, 26);
            this.txtIDtransaksi.TabIndex = 2;
            // 
            // btnCariNota
            // 
            this.btnCariNota.Location = new System.Drawing.Point(239, 22);
            this.btnCariNota.Name = "btnCariNota";
            this.btnCariNota.Size = new System.Drawing.Size(89, 42);
            this.btnCariNota.TabIndex = 3;
            this.btnCariNota.Text = "cari nota";
            this.btnCariNota.UseVisualStyleBackColor = true;
            this.btnCariNota.Click += new System.EventHandler(this.btnCariNota_Click);
            // 
            // btnProsesRefund
            // 
            this.btnProsesRefund.Location = new System.Drawing.Point(239, 338);
            this.btnProsesRefund.Name = "btnProsesRefund";
            this.btnProsesRefund.Size = new System.Drawing.Size(273, 29);
            this.btnProsesRefund.TabIndex = 4;
            this.btnProsesRefund.Text = "Refund";
            this.btnProsesRefund.UseVisualStyleBackColor = true;
            this.btnProsesRefund.Click += new System.EventHandler(this.btnProsesRefund_Click);
            // 
            // dgvRincian
            // 
            this.dgvRincian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRincian.Location = new System.Drawing.Point(12, 87);
            this.dgvRincian.Name = "dgvRincian";
            this.dgvRincian.RowHeadersWidth = 62;
            this.dgvRincian.RowTemplate.Height = 28;
            this.dgvRincian.Size = new System.Drawing.Size(776, 150);
            this.dgvRincian.TabIndex = 5;
            // 
            // FormRefundTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1735, 695);
            this.Controls.Add(this.dgvRincian);
            this.Controls.Add(this.btnProsesRefund);
            this.Controls.Add(this.btnCariNota);
            this.Controls.Add(this.txtIDtransaksi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRefundTransaksi";
            this.Text = "FormRefundTransaksi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRincian)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDtransaksi;
        private System.Windows.Forms.Button btnCariNota;
        private System.Windows.Forms.Button btnProsesRefund;
        private System.Windows.Forms.DataGridView dgvRincian;
    }
}