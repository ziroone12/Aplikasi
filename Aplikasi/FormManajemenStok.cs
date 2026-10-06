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
    public partial class FormManajemenStok : Form
    {
        private int selectedIdBukuStok = 0; // Mencatat penanda ID buku target pasokan restock baru masuk
        public FormManajemenStok()
        {
            InitializeComponent();
        }

        private void FormManajemenStok_Load(object sender, EventArgs e)
        {
            RefreshStokGrid(); // Memanggil daftar sisa kuantitas persediaan barang buku terkini kala modul form dibuka pertama kali
            label1.Visible = false;
            label8.Visible = false;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            lblBukuTerpilih.BackColor = Color.Transparent;
        }
        private void RefreshStokGrid()
        {
            try
            {
                // Menampilkan tabel visual rak buku terkini dari database ke komponen dgv pasokan stok gudang
                dgvStokGudang.DataSource = Buku.TampilkanSemua();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat daftar stok: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStokGudang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //fdsfsd
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStokGudang.Rows[e.RowIndex];
                // Mencatat ID buku target penanda pasokan beserta penulisan teks penunjuk rincian nama buku di label informasi UI fguydsjsdvg
                selectedIdBukuStok = Convert.ToInt32(row.Cells["id_buku"].Value);
                lblBukuTerpilih.Text = row.Cells["kode_buku"].Value.ToString() + " - " + row.Cells["judul"].Value.ToString();
            }
        }
        // Aksi klik eksekusi simpan restock kiriman pasokan barang baru

        private void btnSimpanStok_Click(object sender, EventArgs e)
        {
            if (selectedIdBukuStok == 0)
            {
                MessageBox.Show("Pilih item buku pada tabel terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int tambahanStok;
            // Validasi filter penyaringan teks box, menolak isian kuantitas pasokan baru yang dilarang keras bernilai huruf/minus negatif
            if (string.IsNullOrWhiteSpace(txtJumlahStokBaru.Text) ||
                !int.TryParse(txtJumlahStokBaru.Text, out tambahanStok) ||
                tambahanStok <= 0)
            {
                MessageBox.Show("Jumlah buku baru harus valid untuk semua buku.", "Validasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Mengeksekusi penambahan pertambahan nilai stok ke tabel books database mysql melalui perantara Kelas Buku OOP
            if (Buku.UpdateTambahStok(selectedIdBukuStok, tambahanStok))
            {
                MessageBox.Show("Stok berhasil diperbarui untuk semua buku.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshStokGrid(); // Segarkan visual tabel komponen dgv biar angka sisa stok otomatis ter-update naik bertambah
                txtJumlahStokBaru.Clear();
                lblBukuTerpilih.Text = "-";
                selectedIdBukuStok = 0; // Kembalikan nilai angka pointer ke setelan awal 0 kosong bersih kembali
            }
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
    }
}



