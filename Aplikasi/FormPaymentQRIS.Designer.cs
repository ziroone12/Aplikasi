namespace Aplikasi
{
    partial class FormPaymentQRIS
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
            this.lblTagihanQRIS = new System.Windows.Forms.Label();
            this.btnSelesaiQRIS = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // lblTagihanQRIS
            // 
            this.lblTagihanQRIS.AutoSize = true;
            this.lblTagihanQRIS.Location = new System.Drawing.Point(119, 16);
            this.lblTagihanQRIS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTagihanQRIS.Name = "lblTagihanQRIS";
            this.lblTagihanQRIS.Size = new System.Drawing.Size(35, 13);
            this.lblTagihanQRIS.TabIndex = 1;
            this.lblTagihanQRIS.Text = "label2";
            this.lblTagihanQRIS.Click += new System.EventHandler(this.lblTagihanQRIS_Click);
            // 
            // btnSelesaiQRIS
            // 
            this.btnSelesaiQRIS.Location = new System.Drawing.Point(36, 175);
            this.btnSelesaiQRIS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelesaiQRIS.Name = "btnSelesaiQRIS";
            this.btnSelesaiQRIS.Size = new System.Drawing.Size(127, 19);
            this.btnSelesaiQRIS.TabIndex = 3;
            this.btnSelesaiQRIS.Text = "Konfirmasi Pembayaran";
            this.btnSelesaiQRIS.UseVisualStyleBackColor = true;
            this.btnSelesaiQRIS.Click += new System.EventHandler(this.btnSelesaiQRIS_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormPaymentQRIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 215);
            this.Controls.Add(this.btnSelesaiQRIS);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTagihanQRIS);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPaymentQRIS";
            this.Text = "FormPaymentQRIS";
            this.Load += new System.EventHandler(this.FormPaymentQRIS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTagihanQRIS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSelesaiQRIS;
    }
}