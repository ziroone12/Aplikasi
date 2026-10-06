namespace Aplikasi
{
    partial class FormDashBoardAdmin
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
            this.btnMenuBackup = new System.Windows.Forms.Button();
            this.btnMenuLaporan = new System.Windows.Forms.Button();
            this.btnMenuStok = new System.Windows.Forms.Button();
            this.btnMenuBuku = new System.Windows.Forms.Button();
            this.lblSelamatDatang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(457, 292);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(63, 23);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnMenuBackup
            // 
            this.btnMenuBackup.Location = new System.Drawing.Point(32, 262);
            this.btnMenuBackup.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuBackup.Name = "btnMenuBackup";
            this.btnMenuBackup.Size = new System.Drawing.Size(178, 45);
            this.btnMenuBackup.TabIndex = 12;
            this.btnMenuBackup.Text = "Backup";
            this.btnMenuBackup.UseVisualStyleBackColor = true;
            // 
            // btnMenuLaporan
            // 
            this.btnMenuLaporan.Location = new System.Drawing.Point(32, 215);
            this.btnMenuLaporan.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuLaporan.Name = "btnMenuLaporan";
            this.btnMenuLaporan.Size = new System.Drawing.Size(178, 44);
            this.btnMenuLaporan.TabIndex = 11;
            this.btnMenuLaporan.Text = "Laporan Penjualan";
            this.btnMenuLaporan.UseVisualStyleBackColor = true;
            // 
            // btnMenuStok
            // 
            this.btnMenuStok.Location = new System.Drawing.Point(32, 164);
            this.btnMenuStok.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuStok.Name = "btnMenuStok";
            this.btnMenuStok.Size = new System.Drawing.Size(178, 47);
            this.btnMenuStok.TabIndex = 10;
            this.btnMenuStok.Text = "Management stok";
            this.btnMenuStok.UseVisualStyleBackColor = true;
            // 
            // btnMenuBuku
            // 
            this.btnMenuBuku.Location = new System.Drawing.Point(32, 116);
            this.btnMenuBuku.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenuBuku.Name = "btnMenuBuku";
            this.btnMenuBuku.Size = new System.Drawing.Size(178, 44);
            this.btnMenuBuku.TabIndex = 9;
            this.btnMenuBuku.Text = "Management Buku";
            this.btnMenuBuku.UseVisualStyleBackColor = true;
            // 
            // lblSelamatDatang
            // 
            this.lblSelamatDatang.AutoSize = true;
            this.lblSelamatDatang.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelamatDatang.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.lblSelamatDatang.Location = new System.Drawing.Point(169, 37);
            this.lblSelamatDatang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelamatDatang.Name = "lblSelamatDatang";
            this.lblSelamatDatang.Size = new System.Drawing.Size(232, 27);
            this.lblSelamatDatang.TabIndex = 8;
            this.lblSelamatDatang.Text = "lblSelamatDatang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(157, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dashboard ADMIN";
            // 
            // FormDashBoardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMenuBackup);
            this.Controls.Add(this.btnMenuLaporan);
            this.Controls.Add(this.btnMenuStok);
            this.Controls.Add(this.btnMenuBuku);
            this.Controls.Add(this.lblSelamatDatang);
            this.Controls.Add(this.label1);
            this.Name = "FormDashBoardAdmin";
            this.Text = "FormDashBoardAdmin";
            this.Load += new System.EventHandler(this.FormDashBoardAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMenuBackup;
        private System.Windows.Forms.Button btnMenuLaporan;
        private System.Windows.Forms.Button btnMenuStok;
        private System.Windows.Forms.Button btnMenuBuku;
        private System.Windows.Forms.Label lblSelamatDatang;
        private System.Windows.Forms.Label label1;
    }
}