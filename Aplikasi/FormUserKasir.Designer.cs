namespace Aplikasi
{
    partial class FormUserKasir
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMenuTransaksi = new System.Windows.Forms.Button();
            this.lblSelamatDatang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(11, 242);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(66, 22);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnMenuTransaksi
            // 
            this.btnMenuTransaksi.Location = new System.Drawing.Point(11, 122);
            this.btnMenuTransaksi.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuTransaksi.Name = "btnMenuTransaksi";
            this.btnMenuTransaksi.Size = new System.Drawing.Size(135, 37);
            this.btnMenuTransaksi.TabIndex = 6;
            this.btnMenuTransaksi.Text = "Transaksi";
            this.btnMenuTransaksi.UseVisualStyleBackColor = true;
            // 
            // lblSelamatDatang
            // 
            this.lblSelamatDatang.AutoSize = true;
            this.lblSelamatDatang.Location = new System.Drawing.Point(159, 42);
            this.lblSelamatDatang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelamatDatang.Name = "lblSelamatDatang";
            this.lblSelamatDatang.Size = new System.Drawing.Size(95, 13);
            this.lblSelamatDatang.TabIndex = 5;
            this.lblSelamatDatang.Text = "DashBoard KASIR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(180, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "DashBoard KASIR";
            // 
            // FormUserKasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMenuTransaksi);
            this.Controls.Add(this.lblSelamatDatang);
            this.Controls.Add(this.label1);
            this.Name = "FormUserKasir";
            this.Text = "FormUserKasir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMenuTransaksi;
        private System.Windows.Forms.Label lblSelamatDatang;
        private System.Windows.Forms.Label label1;
    }
}