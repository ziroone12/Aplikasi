using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aplikasi
{
    public partial class FormDashboardKasir : Form
    {
        public FormDashboardKasir()
        {
            InitializeComponent();

        }
        private void FormDashboardKasir_Load(object sender, EventArgs e)
        {
            // Menampilkan nama kasir yang sedang aktif bertugas pada StatusStrip bagian bawah
            lblStatusKasir.Text = "Kasir Aktif: " + Program.UsernameAktif;

            ////Langsung meluncurkan jendela kecil form notifikasi update gudang admin
            //FormNotifikasiGudang frmNotif = new FormNotifikasiGudang();
            //frmNotif.MdiParent = this; // Kunci posisi agar form anak mengambang rapi di dalam dashboard
            //frmNotif.Show();
        }


        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Menutup total seluruh background process aplikasi saat tombol X silang ditekan langsung
            Application.Exit();
        }

        private void FormDashboardKasir_Load_1(object sender, EventArgs e)
        {

        }
        private void menuTransaksiPOS_Click(object sender, EventArgs e)
        {
            // PROSES CEK DUPLIKASI: Jika meja transaksi POS sudah terbuka, cukup fokuskan ke depan layar
            foreach (Form child in this.MdiChildren)
            {
                if (child is FormTransaksiPenjualan)
                {
                    child.Activate();
                    return;
                }
            }

            // Jika belum terbuka, buat instansiasi jendela transaksi anak yang baru
            FormTransaksiPenjualan frmPOS = new FormTransaksiPenjualan();
            frmPOS.MdiParent = this; // KUNCI UTAMA: Mengunci form anak di dalam bingkai kontainer kasir
            frmPOS.Show(); // Tampilkan meja POS kasir penuh
        }

        // Event untuk memproses keluar sesi kasir secara aman (Secure Logout)
        private void menuLogout_Click(object sender, EventArgs e)
        {
            // Reset total seluruh sisa variabel memori sesi RAM global agar steril
            Program.IDUserAktif = 0;
            Program.UsernameAktif = "";
            Program.RoleAktif = "";

            this.Hide(); // Sembunyikan jendela dashboard kasir operasional harian

            // Panggil kembali jendela FormLogin independen di luar kontainer MDI
            Form1 frmLogin = new Form1();

            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                // JIKA LOGIN ULANG BERHASIL: Restart jalannya instansiasi berkas exe proyek untuk membaca role baru
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                Application.Exit();
            }
            else
            {
                // Jika kasir/admin menyunting klik silang batal login ulang, hancurkan total seluruh proses background RAM
                Application.Exit();
            }


        }
    }
}

