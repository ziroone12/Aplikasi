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
            this.lblSelamatDatang = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manegemenBukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menagemenStokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanPenjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.riwayatLaporanPenjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refundTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelamatDatang
            // 
            this.lblSelamatDatang.AutoSize = true;
            this.lblSelamatDatang.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelamatDatang.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.lblSelamatDatang.Location = new System.Drawing.Point(204, 63);
            this.lblSelamatDatang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelamatDatang.Name = "lblSelamatDatang";
            this.lblSelamatDatang.Size = new System.Drawing.Size(232, 27);
            this.lblSelamatDatang.TabIndex = 8;
            this.lblSelamatDatang.Text = "lblSelamatDatang";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manegemenBukuToolStripMenuItem,
            this.menagemenStokToolStripMenuItem,
            this.laporanPenjualanToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manegemenBukuToolStripMenuItem
            // 
            this.manegemenBukuToolStripMenuItem.Name = "manegemenBukuToolStripMenuItem";
            this.manegemenBukuToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.manegemenBukuToolStripMenuItem.Text = "Manegemen Buku";
            // 
            // menagemenStokToolStripMenuItem
            // 
            this.menagemenStokToolStripMenuItem.Name = "menagemenStokToolStripMenuItem";
            this.menagemenStokToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.menagemenStokToolStripMenuItem.Text = "Menagemen Stok";
            // 
            // laporanPenjualanToolStripMenuItem
            // 
            this.laporanPenjualanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.riwayatLaporanPenjualanToolStripMenuItem,
            this.refundTransaksiToolStripMenuItem});
            this.laporanPenjualanToolStripMenuItem.Name = "laporanPenjualanToolStripMenuItem";
            this.laporanPenjualanToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.laporanPenjualanToolStripMenuItem.Text = "Laporan Penjualan";
            // 
            // riwayatLaporanPenjualanToolStripMenuItem
            // 
            this.riwayatLaporanPenjualanToolStripMenuItem.Name = "riwayatLaporanPenjualanToolStripMenuItem";
            this.riwayatLaporanPenjualanToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.riwayatLaporanPenjualanToolStripMenuItem.Text = "Riwayat Laporan Penjualan";
            // 
            // refundTransaksiToolStripMenuItem
            // 
            this.refundTransaksiToolStripMenuItem.Name = "refundTransaksiToolStripMenuItem";
            this.refundTransaksiToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.refundTransaksiToolStripMenuItem.Text = "Refund Transaksi";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.logOutToolStripMenuItem.Text = "Log out";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Status Aktif";
            // 
            // FormDashBoardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aplikasi.Properties.Resources.Screenshot_2026_09_27_143314;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 432);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSelamatDatang);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormDashBoardAdmin";
            this.Text = "FormDashBoardAdmin";
            this.Load += new System.EventHandler(this.FormDashboardAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSelamatDatang;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manegemenBukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menagemenStokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanPenjualanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem riwayatLaporanPenjualanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refundTransaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}