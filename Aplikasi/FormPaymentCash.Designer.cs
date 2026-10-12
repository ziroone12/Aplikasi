namespace Aplikasi
{
    partial class FormPaymentCash
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
            this.lblTagihanCash = new System.Windows.Forms.Label();
            this.lblKembalian = new System.Windows.Forms.Label();
            this.txtUangMasuk = new System.Windows.Forms.TextBox();
            this.btnSelesaiCash = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Tagihan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Uang Tunai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kembalian tunai";
            // 
            // lblTagihanCash
            // 
            this.lblTagihanCash.AutoSize = true;
            this.lblTagihanCash.Location = new System.Drawing.Point(150, 30);
            this.lblTagihanCash.Name = "lblTagihanCash";
            this.lblTagihanCash.Size = new System.Drawing.Size(51, 20);
            this.lblTagihanCash.TabIndex = 3;
            this.lblTagihanCash.Text = "label4";
            // 
            // lblKembalian
            // 
            this.lblKembalian.AutoSize = true;
            this.lblKembalian.Location = new System.Drawing.Point(150, 125);
            this.lblKembalian.Name = "lblKembalian";
            this.lblKembalian.Size = new System.Drawing.Size(51, 20);
            this.lblKembalian.TabIndex = 4;
            this.lblKembalian.Text = "label5";
            // 
            // txtUangMasuk
            // 
            this.txtUangMasuk.Location = new System.Drawing.Point(154, 69);
            this.txtUangMasuk.Name = "txtUangMasuk";
            this.txtUangMasuk.Size = new System.Drawing.Size(100, 26);
            this.txtUangMasuk.TabIndex = 5;
            // 
            // btnSelesaiCash
            // 
            this.btnSelesaiCash.Location = new System.Drawing.Point(154, 182);
            this.btnSelesaiCash.Name = "btnSelesaiCash";
            this.btnSelesaiCash.Size = new System.Drawing.Size(123, 29);
            this.btnSelesaiCash.TabIndex = 6;
            this.btnSelesaiCash.Text = "Selesai";
            this.btnSelesaiCash.UseVisualStyleBackColor = true;
            this.btnSelesaiCash.Click += new System.EventHandler(this.btnSelesaiCash_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Count";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // FormPaymentCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 223);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSelesaiCash);
            this.Controls.Add(this.txtUangMasuk);
            this.Controls.Add(this.lblKembalian);
            this.Controls.Add(this.lblTagihanCash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPaymentCash";
            this.Text = "FormPaymentCash";
            this.Load += new System.EventHandler(this.FormPaymentCash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTagihanCash;
        private System.Windows.Forms.Label lblKembalian;
        private System.Windows.Forms.TextBox txtUangMasuk;
        private System.Windows.Forms.Button btnSelesaiCash;
        private System.Windows.Forms.Button button1;
    }
}