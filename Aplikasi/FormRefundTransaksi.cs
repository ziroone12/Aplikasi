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
    public partial class FormRefundTransaksi : Form
    {
        public FormRefundTransaksi()
        {
            InitializeComponent();
            btnCariNota.Click += btnCariNota_Click;
            btnProsesRefund.Click += btnProsesRefund_Click;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnCariNota_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDtransaksi.Text))
            {
                MessageBox.Show("Harap masukkan ID Nota Transaksi terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtIDtransaksi.Text, out int idNota))
            {
                MessageBox.Show("ID Nota harus berupa angka bulat valid!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection conn = Koneksi.Getkoneksi())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                // Kueri untuk melihat item apa saja yang dibeli pada nota tersebut
                string queryCari = @"SELECT b.judul AS `Judul Buku Terbeli`, 
                                            td.jumlah AS `Jumlah Beli Unit`, 
                                            td.subtotal AS `Subtotal Biaya Belanja`
                                     FROM transaction_details td
                                     INNER JOIN books b ON td.id_buku = b.id_buku
                                     WHERE td.id_transaksi = @idTx";

                using (MySqlCommand cmd = new MySqlCommand(queryCari, conn))
                {
                    cmd.Parameters.AddWithValue("@idTx", idNota);

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("Nomor ID Nota Transaksi tidak ditemukan di database!", "Data Kosong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dt.Clear();
                        }

                        dgvRincian.DataSource = dt; // Ikat data ke DataGridView preview
                    }
                }
            }
        }

        // FUNGSI 2: EKSEKUSI UTAMA PEMBATALAN NOTA & PENGEMBALIAN STOK (TRANSAKSI ACID SAFETY)
        private void btnProsesRefund_Click(object sender, EventArgs e)
        {
            if (dgvRincian.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada rincian data transaksi yang valid untuk diproses refund!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idNota = Convert.ToInt32(txtIDtransaksi.Text);

            // Konfirmasi ulang kebijakan admin sebelum data dihapus permanen
            DialogResult konfirmasi = MessageBox.Show($"Apakah Anda yakin ingin menyetujui REFUND dan membatalkan nota transaksi ID: {idNota}?\nTindakan ini akan mengembalikan semua produk ke stok fisik gudang.", "Kebijakan Otorisasi Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (konfirmasi != DialogResult.Yes) return;

            using (MySqlConnection conn = Koneksi.Getkoneksi())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                // Membuka jaring pengaman Database Transaction agar pembalikan data seimbang (Anti-Korupsi Data)
                using (MySqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Ambil ID Buku dan Jumlah asli dari database (bukan dari DataGridView agar datanya akurat)
                        DataTable dtItems = new DataTable();
                        string qGet = "SELECT id_buku, jumlah FROM transaction_details WHERE id_transaksi = @id";
                        using (MySqlCommand cmdG = new MySqlCommand(qGet, conn, trans))
                        {
                            cmdG.Parameters.AddWithValue("@id", idNota);
                            using (MySqlDataAdapter da = new MySqlDataAdapter(cmdG)) { da.Fill(dtItems); }
                        }

                        // 2. LOOPING PEMBALIKAN STOK: Kembalikan dan naikkan kuota sisa stok produk fisik ke database asal
                        foreach (DataRow row in dtItems.Rows)
                        {
                            string qReturn = "UPDATE books SET stok = stok + @qty WHERE id_buku = @idB";
                            using (MySqlCommand cmdR = new MySqlCommand(qReturn, conn, trans))
                            {
                                cmdR.Parameters.AddWithValue("@qty", Convert.ToInt32(row["jumlah"]));
                                cmdR.Parameters.AddWithValue("@idB", Convert.ToInt32(row["id_buku"]));
                                cmdR.ExecuteNonQuery();
                            }
                        }

                        // 3. Hapus rekor rincian pecahan pecahan nota anak (transaction_details) terlebih dahulu
                        using (MySqlCommand cmdD = new MySqlCommand("DELETE FROM transaction_details WHERE id_transaksi = @id", conn, trans))
                        {
                            cmdD.Parameters.AddWithValue("@id", idNota);
                            cmdD.ExecuteNonQuery();
                        }

                        // 4. Hapus rekor induk transaksi utama (transactions)
                        using (MySqlCommand cmdT = new MySqlCommand("DELETE FROM transactions WHERE id_transaksi = @id", conn, trans))
                        {
                            cmdT.Parameters.AddWithValue("@id", idNota);
                            cmdT.ExecuteNonQuery();
                        }

                        // 5. JEJAK AUDIT ADMIN: Catat tindakan pembatalan darurat ini ke tabel log audit bersama ID Admin pengubah
                        string qLog = "INSERT INTO audit_logs (tanggal, aktivitas, detail_perubahan, id_user) VALUES (NOW(), 'REFUND TRANSAKSI', @detail, @user)";
                        using (MySqlCommand cmdL = new MySqlCommand(qLog, conn, trans))
                        {
                            cmdL.Parameters.AddWithValue("@detail", $"Kebijakan Admin [{Program.UsernameAktif}] menyetujui REFUND total pembatalan nomor nota ID: {idNota}. Stok buku dikembalikan utuh.");
                            cmdL.Parameters.AddWithValue("@user", Program.IDUserAktif); // Kunci identitas admin pengubah
                            cmdL.ExecuteNonQuery();
                        }

                        trans.Commit(); // Nyatakan seluruh rantai pembalikan data sukses permanen
                        MessageBox.Show("Sesi Refund Transaksi Berhasil! Seluruh Pasokan Stok Buku Dikembalikan Utuh ke Gudang.", "Refund Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Bersihkan sisa tampilan visual
                        txtIDtransaksi.Clear();
                        ((DataTable)dgvRincian.DataSource).Clear();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback(); // Batalkan semua kueri jika ada salah satu yang crash/mati lampu di tengah jalan
                        MessageBox.Show("Proses Pembatalan Refund Gagal Dieksekusi: " + ex.Message, "Error Database Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

