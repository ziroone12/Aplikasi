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
        }
        private void FormDashboardAdmin_Load1(object sender, EventArgs e)
        {
            // Menampilkan informasi nama akun admin yang sedang login pada StatusStrip bawah
            lblStatusAdmin.Text = "Sesi Aktif: Admin - " + Program.UsernameAktif;
        }

        // Event untuk membuka menu Management Master Buku
        private void menuManagementBuku_Click(object sender, EventArgs e)
        {
            // PROSES CEK DUPLIKASI: Jika form manajemen buku sudah terbuka, fokuskan saja ke depan layar
            foreach (Form child in this.MdiChildren)
            {
                if (child is FormManajemenBuku)
                {
                    child.Activate();
                    return;
                }
            }

            // Jika belum terbuka, buat instansiasi form anak baru
            FormManajemenBuku frmBuku = new FormManajemenBuku();
            frmBuku.MdiParent = this; // KUNCI UTAMA: Mengunci form anak di dalam bingkai MDI Admin
            frmBuku.Show(); // Tampilkan form di dalam area kerja abu-abu admin
        }

        // Event untuk membuka menu Management Stok Gudang (Restock)
        private void menuManagementStok_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is FormManajemenStok)
                {
                    child.Activate();
                    return;
                }
            }

            FormManajemenStok frmStok = new FormManajemenStok();
            frmStok.MdiParent = this; // KUNCI UTAMA: Mengunci form anak di dalam bingkai MDI Admin
            frmStok.Show();
        }

        // Event untuk membuka Sub-Menu Drop-down: Riwayat Laporan Penjualan
        private void subMenuLaporan_Click(object sender, EventArgs e)
        {
            // SINKRONISASI BARU: Membuka FormLaporanPenjualan yang baru ditambahkan secara rapi
            foreach (Form child in this.MdiChildren)
            {
                if (child is FormLaporanPenjualan)
                {
                    child.Activate();
                    return;
                }
            }

            FormLaporanPenjualan frmLaporan = new FormLaporanPenjualan();
            frmLaporan.MdiParent = this; // KUNCI UTAMA: Mengunci form laporan di dalam MDI Admin
            frmLaporan.Show();
        }

        // Event untuk membuka Sub-Menu Drop-down: Refund Transaksi / Pembatalan Nota
        private void subMenuRefund_Click(object sender, EventArgs e)
        {
            // REVISI MODULAR: Modul refund sukses menyatu di dalam satu rumpun administrasi laporan admin
            foreach (Form child in this.MdiChildren)
            {
                if (child is FormRefundTransaksi)
                {
                    child.Activate();
                    return;
                }
            }

            FormRefundTransaksi frmRefund = new FormRefundTransaksi();
            frmRefund.MdiParent = this; // KUNCI UTAMA: Mengunci form refund di dalam MDI Admin
            frmRefund.Show();
        }

        // Event untuk membuka menu Backup & Pemulihan Basis Data
        private void menuBackup_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is BackUp)
                {
                    child.Activate();
                    return;
                }
            }

            BackUp frmBackup = new BackUp();
            frmBackup.MdiParent = this; // KUNCI UTAMA: Mengunci form backup di dalam MDI Admin
            frmBackup.Show();
        }

        // Event untuk memproses pengeluaran akun secara aman (Secure Logout)
        private void menuLogout_Click(object sender, EventArgs e)
        {
            // Membersihkan sisa variabel sesi RAM global agar steril
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
            // Mengubah kalimat sambutan teks label dengan mengambil variabel sesi nama user aktif global
            lblSelamatDatang.Text = "Selamat Datang, " + Program.UsernameAktif + "!";
            lblSelamatDatang.BackColor = Color.Transparent;
        }

        // Aksi tombol logout keluar aman sistem aplikasi kasir toko buku
        
        
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Menutup total seluruh background process aplikasi saat tombol X silang ditekan langsung
            Application.Exit();
        }
    }
}
