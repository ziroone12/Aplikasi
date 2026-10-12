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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manegemenBukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menagemenStokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanPenjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.riwayatLaporanPenjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refundTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manegemenBukuToolStripMenuItem,
            this.menagemenStokToolStripMenuItem,
            this.laporanPenjualanToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.logOutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1735, 33);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manegemenBukuToolStripMenuItem
            // 
            this.manegemenBukuToolStripMenuItem.Name = "manegemenBukuToolStripMenuItem";
            this.manegemenBukuToolStripMenuItem.Size = new System.Drawing.Size(171, 29);
            this.manegemenBukuToolStripMenuItem.Text = "Manegemen Buku";
            this.manegemenBukuToolStripMenuItem.Click += new System.EventHandler(this.menuManagementBuku_Click);
            // 
            // menagemenStokToolStripMenuItem
            // 
            this.menagemenStokToolStripMenuItem.Name = "menagemenStokToolStripMenuItem";
            this.menagemenStokToolStripMenuItem.Size = new System.Drawing.Size(167, 29);
            this.menagemenStokToolStripMenuItem.Text = "Menagemen Stok";
            this.menagemenStokToolStripMenuItem.Click += new System.EventHandler(this.menuManagementStok_Click);
            // 
            // laporanPenjualanToolStripMenuItem
            // 
            this.laporanPenjualanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.riwayatLaporanPenjualanToolStripMenuItem,
            this.refundTransaksiToolStripMenuItem});
            this.laporanPenjualanToolStripMenuItem.Name = "laporanPenjualanToolStripMenuItem";
            this.laporanPenjualanToolStripMenuItem.Size = new System.Drawing.Size(171, 29);
            this.laporanPenjualanToolStripMenuItem.Text = "Laporan Penjualan";
            // 
            // riwayatLaporanPenjualanToolStripMenuItem
            // 
            this.riwayatLaporanPenjualanToolStripMenuItem.Name = "riwayatLaporanPenjualanToolStripMenuItem";
            this.riwayatLaporanPenjualanToolStripMenuItem.Size = new System.Drawing.Size(323, 34);
            this.riwayatLaporanPenjualanToolStripMenuItem.Text = "Riwayat Laporan Penjualan";
            this.riwayatLaporanPenjualanToolStripMenuItem.Click += new System.EventHandler(this.subMenuLaporan_Click);
            // 
            // refundTransaksiToolStripMenuItem
            // 
            this.refundTransaksiToolStripMenuItem.Name = "refundTransaksiToolStripMenuItem";
            this.refundTransaksiToolStripMenuItem.Size = new System.Drawing.Size(323, 34);
            this.refundTransaksiToolStripMenuItem.Text = "Refund Transaksi";
            this.refundTransaksiToolStripMenuItem.Click += new System.EventHandler(this.subMenuRefund_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.logOutToolStripMenuItem.Text = "Dashboard";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.menuLogAudit_Click);
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(88, 29);
            this.logOutToolStripMenuItem1.Text = "LogOut";
            this.logOutToolStripMenuItem1.Click += new System.EventHandler(this.menuLogout_Click);
            // 
            // FormDashBoardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aplikasi.Properties.Resources.Screenshot_2026_09_27_143314;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1735, 695);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDashBoardAdmin";
            this.Text = "FormDashBoardAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDashboardAdmin_Load1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manegemenBukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menagemenStokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laporanPenjualanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem riwayatLaporanPenjualanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refundTransaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem1;
    }
}