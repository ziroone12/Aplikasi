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
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TOTAL TAGIHAN MASTER";
            // 
            // lblTotalMaster
            // 
            this.lblTotalMaster.AutoSize = true;
            this.lblTotalMaster.Location = new System.Drawing.Point(220, 35);
            this.lblTotalMaster.Name = "lblTotalMaster";
            this.lblTotalMaster.Size = new System.Drawing.Size(14, 13);
            this.lblTotalMaster.TabIndex = 1;
            this.lblTotalMaster.Text = "T";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pilih Metode Pembayaran";
            // 
            // cmbMetode
            // 
            this.cmbMetode.FormattingEnabled = true;
            this.cmbMetode.Location = new System.Drawing.Point(208, 80);
            this.cmbMetode.Name = "cmbMetode";
            this.cmbMetode.Size = new System.Drawing.Size(121, 21);
            this.cmbMetode.TabIndex = 3;
            // 
            // btnLanjut
            // 
            this.btnLanjut.Location = new System.Drawing.Point(179, 169);
            this.btnLanjut.Name = "btnLanjut";
            this.btnLanjut.Size = new System.Drawing.Size(75, 23);
            this.btnLanjut.TabIndex = 4;
            this.btnLanjut.Text = "Lanjut";
            this.btnLanjut.UseVisualStyleBackColor = true;
            // 
            // FormBilingPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 331);
            this.Controls.Add(this.btnLanjut);
            this.Controls.Add(this.cmbMetode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalMaster);
            this.Controls.Add(this.label1);
            this.Name = "FormBilingPayment";
            this.Text = "FormBilingPayment";
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