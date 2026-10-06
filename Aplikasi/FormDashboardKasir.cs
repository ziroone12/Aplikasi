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
            // Merender teks nama kasir yang berhasil login dari memori program global statis
            lblSelamatDatang.Text = "Selamat Datang, " + Program.UsernameAktif + "!";
            lblSelamatDatang.BackColor = Color.Transparent;
            label1.Visible = false;
        }

        private void btnMenuTransaksi_Click(object sender, EventArgs e)
        {
            // 1. Sembunyikan dashboard kasir saat ini agar tidak kelihatan di latar belakang
            this.Hide();

            // 2. Instansiasi membuat objek dari Form Transaksi Penjualan
            FormTransaksiPenjualan frm = new FormTransaksiPenjualan();

            // 3. WAJIB menggunakan .Show() biasa (jangan pakai .ShowDialog()) 
            // agar form ini berdiri mandiri dan form sebelumnya bisa disembunyikan
            frm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Menutup total seluruh background process aplikasi saat tombol X silang ditekan langsung
            Application.Exit();
        }

        private void FormDashboardKasir_Load_1(object sender, EventArgs e)
        {

        }
    }
}

