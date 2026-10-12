using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aplikasi
{
    public partial class FormDashBoardAdmin : Form
    {
        public FormDashBoardAdmin()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.FormClosing += new FormClosingEventHandler(Form_FormClosing);

        }
        private void SembunyikanSemuaFormAnak()
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Hide(); // Sembunyikan (Hide) secara halus dari monitor
            }
        }
        private void FormDashboardAdmin_Load1(object sender, EventArgs e)
        {
            dashadmin frmAudit = new dashadmin();
            frmAudit.MdiParent = this; // Kunci ke dalam bingkai kontainer dashboard admin harian
            frmAudit.FormBorderStyle = FormBorderStyle.None; // Hancurkan baris judul & tombol silang Windows
            frmAudit.WindowState = FormWindowState.Maximized; // Paksa melar 100% penuh satu layar monitor
            frmAudit.Show();
        }

        // Event untuk membuka menu Management Master Buku
        private void menuManagementBuku_Click(object sender, EventArgs e)
        {
            SembunyikanSemuaFormAnak();

            foreach (Form child in this.MdiChildren)
            {
                if (child is FormManajemenBuku)
                {
                    child.WindowState = FormWindowState.Maximized; // Paksa melar penuh
                    child.Show(); // Munculkan kembali ke monitor
                    child.Activate();
                    return;
                }
            }

            // Jika belum ada, buat instansiasi form anak baru
            FormManajemenBuku frmBuku = new FormManajemenBuku();
            frmBuku.MdiParent = this;
            frmBuku.FormBorderStyle = FormBorderStyle.None; // Hilangkan baris judul/tombol silang
            frmBuku.WindowState = FormWindowState.Maximized; // Paksa melar penuh
            frmBuku.Show();
        }

        // Event untuk membuka menu Management Stok Gudang (Restock)
        private void menuManagementStok_Click(object sender, EventArgs e)
        {
            SembunyikanSemuaFormAnak();

            foreach (Form child in this.MdiChildren)
            {
                if (child is FormManajemenStok)
                {
                    child.WindowState = FormWindowState.Maximized; // Paksa melar penuh
                    child.Show(); // Munculkan kembali ke monitor
                    child.Activate();
                    return;
                }
            }

            FormManajemenStok frmStok = new FormManajemenStok();
            frmStok.MdiParent = this;
            frmStok.FormBorderStyle = FormBorderStyle.None; // Hilangkan baris judul/tombol silang
            frmStok.WindowState = FormWindowState.Maximized; // Paksa melar penuh
            frmStok.Show();
        }
        private void subMenuLaporan_Click(object sender, EventArgs e)
        {
            SembunyikanSemuaFormAnak();

            foreach (Form child in this.MdiChildren)
            {
                if (child is FormLaporanPenjualan)
                {
                    child.WindowState = FormWindowState.Maximized; // Paksa melar penuh
                    child.Show(); // Munculkan kembali ke monitor
                    child.Activate();
                    return;
                }
            }

            FormLaporanPenjualan frmLaporan = new FormLaporanPenjualan();
            frmLaporan.MdiParent = this;
            frmLaporan.FormBorderStyle = FormBorderStyle.None; // Hilangkan baris judul/tombol silang
            frmLaporan.WindowState = FormWindowState.Maximized; // Paksa melar penuh
            frmLaporan.Show();
        }

        // Event untuk membuka Sub-Menu Drop-down: Refund Transaksi / Pembatalan Nota
        private void subMenuRefund_Click(object sender, EventArgs e)
        {
            SembunyikanSemuaFormAnak();

            foreach (Form child in this.MdiChildren)
            {
                if (child is FormRefundTransaksi)
                {
                    child.WindowState = FormWindowState.Maximized; // Paksa melar penuh
                    child.Show(); // Munculkan kembali ke monitor
                    child.Activate();
                    return;
                }
            }

            FormRefundTransaksi frmRefund = new FormRefundTransaksi();
            frmRefund.MdiParent = this;
            frmRefund.FormBorderStyle = FormBorderStyle.None; // Hilangkan baris judul/tombol silang
            frmRefund.WindowState = FormWindowState.Maximized; // Paksa melar penuh
            frmRefund.Show();
        }

        // Event untuk membuka menu Backup & Pemulihan Basis Data
        private void menuBackup_Click(object sender, EventArgs e)
        {
            SembunyikanSemuaFormAnak();

            foreach (Form child in this.MdiChildren)
            {
                if (child is BackUp)
                {
                    child.WindowState = FormWindowState.Maximized; // Paksa melar penuh
                    child.Show(); // Munculkan kembali ke monitor
                    child.Activate();
                    return;
                }
            }

            BackUp frmBackup = new BackUp();
            frmBackup.MdiParent = this;
            frmBackup.FormBorderStyle = FormBorderStyle.None; // Hilangkan baris judul/tombol silang
            frmBackup.WindowState = FormWindowState.Maximized; // Paksa melar penuh
            frmBackup.Show();
        }
        private void menuLogAudit_Click(object sender, EventArgs e)
        {
            // 1. Bersihkan layar dari form anak yang terbuka sebelumnya (Auto-Hide)
            SembunyikanSemuaFormAnak();

            // 2. Cek apakah form log audit sudah pernah dibuat di memori RAM
            foreach (Form child in this.MdiChildren)
            {
                if (child is dashadmin)
                {
                    child.WindowState = FormWindowState.Maximized; // Paksa melar penuh
                    ((dashadmin)child).MuatSeluruhRiwayatSistemToko(); // Segarkan data terbaru
                    child.Show(); // Munculkan kembali ke monitor
                    child.Activate();
                    return;
                }
            }

            // Jika belum ada, lahirkan form anak audit baru tertanam paten seutuhnya
            dashadmin frmAudit = new dashadmin();
            frmAudit.MdiParent = this; // Kunci ke dalam bingkai kontainer dashboard admin harian
            frmAudit.FormBorderStyle = FormBorderStyle.None; // Hancurkan baris judul & tombol silang Windows
            frmAudit.WindowState = FormWindowState.Maximized; // Paksa melar 100% penuh satu layar monitor
            frmAudit.Show();
        }

        // Event untuk memproses pengeluaran akun secara aman (Secure Logout)
        private void menuLogout_Click(object sender, EventArgs e)
        {
            Program.IDUserAktif = 0;
            Program.UsernameAktif = "";
            Program.RoleAktif = "";

            this.Hide(); // Sembunyikan jendela dashboard admin harian

            // Munculkan kembali gerbang FormLogin independen di luar kontainer MDI
            Form1 frmLogin = new Form1();

            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                // JIKA LOGIN ULANG BERHASIL: Restart instansiasi aplikasi untuk membaca rute role baru
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                Application.Exit();
            }
            else
            {
                // Jika kasir/admin membatalkan login ulang, matikan seluruh proses background RAM laptop
                Application.Exit();
            }
        }
    
        private void FormDashboardAdmin_Load(object sender, EventArgs e)
        {
           
        }

        // Aksi tombol logout keluar aman sistem aplikasi kasir toko buku
        
        
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Menutup total seluruh background process aplikasi saat tombol X silang ditekan langsung
            Application.Exit();
        }

        
    }
}
