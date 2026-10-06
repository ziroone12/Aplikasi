using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi
{
    public partial class FormLaporanPenjualan : Form
    {
        public FormLaporanPenjualan()
        {
            InitializeComponent();
        }
        // Tombol Saring Aksi Menyaring Data Pembukuan Masuk Berdasarkan Jangkauan Tanggal Kalender (DateTimePicker)
        private void btnFilter_Click(object sender, EventArgs e)
        {
            // Menangkap tanggal awal pencarian batas waktu kalender harian laporan
            DateTime dariDate = dtpMulai.Value.Date;
            // Mengeset jam tanggal penutupan filter akhir laporan ke jam 23:59:59 agar rangkuman rekap transaksi di hari berjalan ikut terbaca penuh
            DateTime sampaiDate = dtpSelesai.Value.Date.AddDays(1).AddSeconds(-1);

            try
            {
                // Mengirim jangkauan filter kalender ke dalam query Kelas Transaksi OOP untuk dirender langsung ke DataGridView laporan
                dgvLaporan.DataSource = transaksi.AmbilLaporan(dariDate, sampaiDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyaring laporan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Simulasi Klik Aksi Mengunduh / Pengeksporan Berkas Dokumen Laba Pembukuan Laporan Penjualan Toko Buku
        private void btnEkspor_Click(object sender, EventArgs e)
        {
            if (dgvLaporan.Rows.Count == 0) // Validasi penolakan sistem jika tabel laporan masih kosong / belum di-filter saring
            {
                MessageBox.Show("Tidak ada data laporan untuk diekspor.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Memunculkan kotak dialog sukses simulasi pembuatan berkas dokumen pembukuan laporan eksternal berformat dokumen excel/pdf
            MessageBox.Show("Laporan berhasil diekspor.", "Ekspor Selesai", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKembaliDashboard_Click(object sender, EventArgs e)
        {
            // Menutup atau menyembunyikan form manajemen buku saat ini
            this.Hide();
            // Mengembalikan user ke layar dashboard admin semula
            FormDashBoardAdmin adminDash = new FormDashBoardAdmin();
            adminDash.Show();
        }
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Menutup total seluruh background process aplikasi saat tombol X silang ditekan langsung
            Application.Exit();
        }

        private void FormLaporanPenjualan_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label8.Visible = false;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
        }

        private void FormLaporanPenjualan_Load_1(object sender, EventArgs e)
        {

        }
    }
}
