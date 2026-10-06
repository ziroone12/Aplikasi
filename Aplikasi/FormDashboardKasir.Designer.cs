namespace Aplikasi
{
    partial class FormDashboardKasir
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
            this.btnLogout.Location = new System.Drawing.Point(25, 411);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(99, 34);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnMenuTransaksi
            // 
            this.btnMenuTransaksi.Location = new System.Drawing.Point(25, 226);
            this.btnMenuTransaksi.Name = "btnMenuTransaksi";
            this.btnMenuTransaksi.Size = new System.Drawing.Size(202, 57);
            this.btnMenuTransaksi.TabIndex = 6;
            this.btnMenuTransaksi.Text = "Transaksi";
            this.btnMenuTransaksi.UseVisualStyleBackColor = true;
            // 
            // lblSelamatDatang
            // 
            this.lblSelamatDatang.AutoSize = true;
            this.lblSelamatDatang.Location = new System.Drawing.Point(134, 93);
            this.lblSelamatDatang.Name = "lblSelamatDatang";
            this.lblSelamatDatang.Size = new System.Drawing.Size(143, 20);
            this.lblSelamatDatang.TabIndex = 5;
            this.lblSelamatDatang.Text = "DashBoard KASIR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(278, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "DashBoard KASIR";
            // 
            // FormDashboardKasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aplikasi.Properties.Resources._3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(607, 472);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMenuTransaksi);
            this.Controls.Add(this.lblSelamatDatang);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDashboardKasir";
            this.Text = "FormDashboardKasir";
            this.Load += new System.EventHandler(this.FormDashboardKasir_Load_1);
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