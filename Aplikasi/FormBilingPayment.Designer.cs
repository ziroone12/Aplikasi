namespace Aplikasi
{
    partial class FormBilingPayment
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
            this.lblTotalMaster = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMetode = new System.Windows.Forms.ComboBox();
            this.btnLanjut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL TAGIHAN MASTER";
            // 
            // lblTotalMaster
            // 
            this.lblTotalMaster.AutoSize = true;
            this.lblTotalMaster.Location = new System.Drawing.Point(330, 54);
            this.lblTotalMaster.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalMaster.Name = "lblTotalMaster";
            this.lblTotalMaster.Size = new System.Drawing.Size(18, 20);
            this.lblTotalMaster.TabIndex = 1;
            this.lblTotalMaster.Text = "T";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pilih Metode Pembayaran";
            // 
            // cmbMetode
            // 
            this.cmbMetode.FormattingEnabled = true;
            this.cmbMetode.Location = new System.Drawing.Point(312, 123);
            this.cmbMetode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMetode.Name = "cmbMetode";
            this.cmbMetode.Size = new System.Drawing.Size(180, 28);
            this.cmbMetode.TabIndex = 3;
            // 
            // btnLanjut
            // 
            this.btnLanjut.Location = new System.Drawing.Point(62, 194);
            this.btnLanjut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLanjut.Name = "btnLanjut";
            this.btnLanjut.Size = new System.Drawing.Size(112, 35);
            this.btnLanjut.TabIndex = 4;
            this.btnLanjut.Text = "Lanjut";
            this.btnLanjut.UseVisualStyleBackColor = true;
            this.btnLanjut.Click += new System.EventHandler(this.btnLanjut_Click);
            // 
            // FormBilingPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 288);
            this.Controls.Add(this.btnLanjut);
            this.Controls.Add(this.cmbMetode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalMaster);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormBilingPayment";
            this.Text = "FormBilingPayment";
            this.Load += new System.EventHandler(this.FormBillingPayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalMaster;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMetode;
        private System.Windows.Forms.Button btnLanjut;
    }
}