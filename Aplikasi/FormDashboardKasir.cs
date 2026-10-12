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
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;

            // Menautkan Event secara terprogram agar sinkron bebas eror cache
            this.Load += new EventHandler(FormDashboardKasir_Load);
            this.FormClosing += new FormClosingEventHandler(Form_FormClosing);

        }
        private void SembunyikanSemuaFormAnak()
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Hide(); // Sembunyikan (Hide) secara halus dari monitor
            }
        }
        private void FormDashboardKasir_Load(object sender, EventArgs e)
        {
            dashkasir frmPasokan = new dashkasir();
            frmPasokan.MdiParent = this; // Memaksa form riwayat mengunci di dalam kontainer MDI kasir
            frmPasokan.FormBorderStyle = FormBorderStyle.None; // Mencopot bilah kontrol abu-abu atas
            frmPasokan.WindowState = FormWindowState.Maximized; // Memaksa melar penuh satu monitor desktop
            frmPasokan.Show();
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
            SembunyikanSemuaFormAnak();

            // 2. Cek duplikasi form anak agar tidak melahirkan double memori RAM
            foreach (Form child in this.MdiChildren)
            {
                if (child is FormTransaksiPenjualan)
                {
                    child.WindowState = FormWindowState.Maximized; // Paksa melar 100%
                    child.Show(); // Munculkan kembali ke monitor
                    child.Activate();
                    return;
                }
            }

            // Jika benar-benar belum terbuka, buat instansiasi jendela transaksi anak yang baru
            FormTransaksiPenjualan frmPOS = new FormTransaksiPenjualan();
            frmPOS.MdiParent = this; // KUNCI UTAMA: Mengunci form anak di dalam bingkai kontainer kasir
            frmPOS.FormBorderStyle = FormBorderStyle.None; // Hilangkan baris judul/tombol silang
            frmPOS.WindowState = FormWindowState.Maximized; // Paksa melar penuh satu monitor
            frmPOS.Show();
        }
        private void menuRiwayatPasokan_Click(object sender, EventArgs e)
        {
            // 1. Bersihkan layar dari form anak yang terbuka sebelumnya (Auto-Hide)
            SembunyikanSemuaFormAnak();

            // 2. Cek apakah form riwayat pasokan sudah pernah dibuat di memori RAM
            foreach (Form child in this.MdiChildren)
            {
                if (child is dashkasir)
                {
                    child.WindowState = FormWindowState.Maximized; // Paksa melar 100% penuh
                    ((dashkasir)child).MuatJurnalPasokanGudang(); // Segarkan pasokan paling update
                    child.Show(); // Munculkan kembali ke monitor
                    child.Activate();
                    return;
                }
            }

            // Jika belum ada di memori RAM, lahirkan jendela anak riwayat pasokan baru tertanam paten
            dashkasir frmPasokan = new dashkasir();
            frmPasokan.MdiParent = this; // Kunci ke dalam bingkai kontainer dashboard kasir harian
            frmPasokan.FormBorderStyle = FormBorderStyle.None; // Hancurkan baris judul & tombol silang Windows
            frmPasokan.WindowState = FormWindowState.Maximized; // Paksa melar 100% penuh mengisi satu monitor
            frmPasokan.Show();
        }
        // Event untuk memproses keluar sesi kasir secara aman (Secure Logout)
        private void menuLogout_Click(object sender, EventArgs e)
        {
            Program.IDUserAktif = 0;
            Program.UsernameAktif = "";
            Program.RoleAktif = "";

            this.Hide(); // Sembunyikan dashboard kasir harian
            Form1 frmLogin = new Form1(); // Panggil gerbang FormLogin awal luar MDI

            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                Application.Exit();
            }
            else
            {
                Application.Exit();
            }


        }
       
    }
}

