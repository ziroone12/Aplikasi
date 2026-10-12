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
            this.lblSelamatDatang = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manegemenBukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStatusKasir = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manegemenBukuToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.dashboardToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(607, 36);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manegemenBukuToolStripMenuItem
            // 
            this.manegemenBukuToolStripMenuItem.Name = "manegemenBukuToolStripMenuItem";
            this.manegemenBukuToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.manegemenBukuToolStripMenuItem.Text = "Transaksi";
            this.manegemenBukuToolStripMenuItem.Click += new System.EventHandler(this.menuTransaksiPOS_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.menuLogout_Click);
            // 
            // lblStatusKasir
            // 
            this.lblStatusKasir.AutoSize = true;
            this.lblStatusKasir.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusKasir.Location = new System.Drawing.Point(127, 443);
            this.lblStatusKasir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusKasir.Name = "lblStatusKasir";
            this.lblStatusKasir.Size = new System.Drawing.Size(92, 20);
            this.lblStatusKasir.TabIndex = 13;
            this.lblStatusKasir.Text = "Status Aktif";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 443);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Status Aktif";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.menuRiwayatPasokan_Click);
            // 
            // FormDashboardKasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aplikasi.Properties.Resources._3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(607, 472);
            this.Controls.Add(this.lblStatusKasir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblSelamatDatang);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDashboardKasir";
            this.Text = "FormDashboardKasir";
            this.Load += new System.EventHandler(this.FormDashboardKasir_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSelamatDatang;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manegemenBukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label lblStatusKasir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
    }
}