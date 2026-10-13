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
    public partial class FormManajemenBuku : Form
    {
        
        public FormManajemenBuku()
        {
            InitializeComponent();
            MuatTabelBuku();
            dgvMasterBuku.CellClick += dgvMasterBuku_CellClick;

        }

        private void MuatTabelBuku()
        {
            using (MySqlConnection conn = Koneksi.Getkoneksi())
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT id_buku, kode_buku, judul, pengarang, penerbit, harga, stok FROM books", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMasterBuku.DataSource = dt;
            }
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // 1. Validasi Kode Buku tidak boleh kosong
            if (string.IsNullOrWhiteSpace(txtKode.Text))
            {
                MessageBox.Show("Kode Buku tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKode.Focus();
                return;
            }

            // 2. Validasi Judul Buku tidak boleh kosong
            if (string.IsNullOrWhiteSpace(txtJudul.Text))
            {
                MessageBox.Show("Judul Buku tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtJudul.Focus();
                return;
            }

            // 3. Validasi Harga Buku tidak boleh kosong (Optional, silakan pakai jika perlu)
            if (string.IsNullOrWhiteSpace(txtHarga.Text))
            {
                MessageBox.Show("Harga Buku tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHarga.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPenerbit.Text))
            {
                MessageBox.Show("Penerbit tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHarga.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPengarang.Text))
            {
                MessageBox.Show("Pengarang tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHarga.Focus();
                return;
            }


            using (MySqlConnection conn = Koneksi.Getkoneksi())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                // Kriteria 1: Kolom input stok dihilangkan, kueri dipaksa langsung bernilai 0 di database
                string query = "INSERT INTO books (kode_buku, judul, pengarang, penerbit, harga, stok) VALUES (@kode, @judul, @peng, @pene, @harga, 0)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@kode", txtKode.Text.Trim());
                    cmd.Parameters.AddWithValue("@judul", txtJudul.Text.Trim());
                    cmd.Parameters.AddWithValue("@peng", txtPengarang.Text.Trim());
                    cmd.Parameters.AddWithValue("@pene", txtPenerbit.Text.Trim());
                    cmd.Parameters.AddWithValue("@harga", Convert.ToDecimal(txtHarga.Text));
                    cmd.ExecuteNonQuery();
                }

                string qLog = "INSERT INTO audit_logs (tanggal, aktivitas, detail_perubahan, id_user) VALUES (NOW(), 'TAMBAH BUKU', @detail, @user)";
                using (MySqlCommand cmdL = new MySqlCommand(qLog, conn))
                {
                    cmdL.Parameters.AddWithValue("@detail", $"Admin menambahkan rekor buku baru '{txtJudul.Text.Trim()}' dengan otomatisasi Stok Awal = 0");
                    cmdL.Parameters.AddWithValue("@user", Program.IDUserAktif);
                    cmdL.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Buku Baru Berhasil Didaftarkan dengan Stok Awal = 0!", "Sukses");
            MuatTabelBuku();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMasterBuku.CurrentRow == null) return;
            int idBuku = Convert.ToInt32(dgvMasterBuku.CurrentRow.Cells["id_buku"].Value);

            using (MySqlConnection conn = Koneksi.Getkoneksi())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                // Kriteria 1: Nilai stok DIKUNCI RAPAT, kueri UPDATE tidak boleh menyentuh atau memodifikasi kolom stok!
                string query = "UPDATE books SET kode_buku=@kode, judul=@judul, pengarang=@peng, penerbit=@pene, harga=@harga WHERE id_buku=@id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@kode", txtKode.Text.Trim());
                    cmd.Parameters.AddWithValue("@judul", txtJudul.Text.Trim());
                    cmd.Parameters.AddWithValue("@peng", txtPengarang.Text.Trim());
                    cmd.Parameters.AddWithValue("@pene", txtPenerbit.Text.Trim());
                    cmd.Parameters.AddWithValue("@harga", Convert.ToDecimal(txtHarga.Text));
                    cmd.Parameters.AddWithValue("@id", idBuku);
                    cmd.ExecuteNonQuery();
                }

                string qLog = "INSERT INTO audit_logs (tanggal, aktivitas, detail_perubahan, id_user) VALUES (NOW(), 'EDIT BUKU', @detail, @user)";
                using (MySqlCommand cmdL = new MySqlCommand(qLog, conn))
                {
                    cmdL.Parameters.AddWithValue("@detail", $"Admin mengubah informasi rincian detail buku '{txtJudul.Text.Trim()}' (Nilai Stok Terkunci Aman)");
                    cmdL.Parameters.AddWithValue("@user", Program.IDUserAktif);
                    cmdL.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Detail Informasi Buku Berhasil Diperbarui!", "Sukses");
            MuatTabelBuku();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvMasterBuku.CurrentRow == null) return;
            int idBuku = Convert.ToInt32(dgvMasterBuku.CurrentRow.Cells["id_buku"].Value);
            string judul = dgvMasterBuku.CurrentRow.Cells["judul"].Value.ToString();

            if (MessageBox.Show($"Hapus data buku {judul}?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MySqlConnection conn = Koneksi.Getkoneksi())
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("DELETE FROM books WHERE id_buku=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idBuku);
                        cmd.ExecuteNonQuery();
                    }
                }
                MuatTabelBuku();
            }
        }

        private void dgvMasterBuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgvMasterBuku.Rows[e.RowIndex];
            txtKode.Text = row.Cells["kode_buku"].Value.ToString();
            txtJudul.Text = row.Cells["judul"].Value.ToString();
            txtPengarang.Text = row.Cells["pengarang"].Value.ToString();
            txtPenerbit.Text = row.Cells["penerbit"].Value.ToString();
            txtHarga.Text = row.Cells["harga"].Value.ToString();
        }


        private void FormManajemenBuku_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

