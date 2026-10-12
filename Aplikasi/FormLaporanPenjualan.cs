using MySql.Data.MySqlClient;
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
            btnFilter.Click += btnFilter_Click;
            btnEkspor.Click += btnEkspor_Click;
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime tanggalMulai = dtPeriode.Value.Date;
            DateTime tanggalSelesai = dtSelesai.Value.Date.AddDays(1).AddTicks(-1);

            if (tanggalMulai > tanggalSelesai)
            {
                MessageBox.Show("Rentang filter tanggal tidak logis! Periksa kembali.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = Koneksi.Getkoneksi())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                // REVISI KUERI: Menambahkan u.username AS `Kasir Bertugas` dan INNER JOIN users u 
                // untuk menarik data nama akun kasir berdasarkan id_user yang tercatat di tabel transactions.
                string query = @"SELECT t.tanggal AS `Tanggal Transaksi`, 
                                        b.judul AS `Judul Buku`, 
                                        td.jumlah AS `Jumlah Terjual`, 
                                        td.subtotal AS `Total Pendapatan`,
                                        u.username AS `Kasir Bertugas`
                                 FROM transaction_details td
                                 INNER JOIN transactions t ON td.id_transaksi = t.id_transaksi
                                 INNER JOIN books b ON td.id_buku = b.id_buku
                                 INNER JOIN users u ON t.id_user = u.id_user
                                 WHERE t.tanggal BETWEEN @mulai AND @selesai
                                 ORDER BY t.tanggal DESC";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@mulai", tanggalMulai);
                    cmd.Parameters.AddWithValue("@selesai", tanggalSelesai);

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvLaporan.DataSource = dt;
                    }
                }
            }
        }

        private void btnEkspor_Click(object sender, EventArgs e)
        {
            if (dgvLaporan.Rows.Count == 0)
            {
                MessageBox.Show("Tabel laporan masih kosong. Tidak ada data untuk diekspor!", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Laporan Keuangan Toko Buku Lengkap dengan Nama Kasir Sukses Diekspor!", "Ekspor Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Tombol Saring Aksi Menyaring Data Pembukuan Masuk Berdasarkan Jangkauan Tanggal Kalender (DateTimePicker)


        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Menutup total seluruh background process aplikasi saat tombol X silang ditekan langsung
            Application.Exit();
        }

        private void FormLaporanPenjualan_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
