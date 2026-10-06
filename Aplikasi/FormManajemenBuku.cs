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
    public partial class FormManajemenBuku : Form
    {
        // Variabel penanda penampung angka ID baris data buku yang sedang disorot/diklik oleh user
        private int selectedIdBuku = 0;
        public FormManajemenBuku()
        {
            InitializeComponent();
        }
        private void FormManajemenBuku_Load(object sender, EventArgs e)
        {
            RefreshDataGrid(); // Mengisi tabel data grid view otomatis saat form di-load awal
            label8.Visible = false;
            label1.Visible = false;
            label2.BackColor = Color.Transparent; label3.BackColor = Color.Transparent; label4.BackColor = Color.Transparent; label5.BackColor = Color.Transparent; label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
        }

        // Fungsi penyegar data grid view agar selaras dengan tabel database paling aktual
        private void RefreshDataGrid()
        {
            try
            {
                // Menyambungkan DataTable memori lokal hasil tarikan kelas Buku ke properti DataSource tabel visual dgv
                dgvBuku.DataSource = Buku.TampilkanSemua();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data grid: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Aksi ketika salah satu kotak baris di dalam tabel dgv diklik oleh tetikus mouse user
        private void dgvBuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Menghindari terjadinya eror jika yang diklik baris header judul kolom tabel
            {
                DataGridViewRow row = dgvBuku.Rows[e.RowIndex];

                // Mengambil nilai ID baris penanda dan memindahkan teks tabel ke kotak form isian input teks box
                selectedIdBuku = Convert.ToInt32(row.Cells["id_buku"].Value);
                txtKodeBuku.Text = row.Cells["kode_buku"].Value.ToString();
                txtJudul.Text = row.Cells["judul"].Value.ToString();
                txtPengarang.Text = row.Cells["pengarang"].Value.ToString();
                txtPenerbit.Text = row.Cells["penerbit"].Value.ToString();
                txtHarga.Text = row.Cells["harga"].Value.ToString();
                txtStok.Text = row.Cells["stok"].Value.ToString();
            }
        }

        // Operasi Klik Tombol Tambah Buku Baru
        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (CheckEmptyInputs()) return; // Batalkan proses jika terdeteksi ada isian kolom box yang kosong

            // Membuat objek model buku dan memindahkan nilai teks dari kontrol UI form ke atribut kelas objek buku
            Buku objekBuku = new Buku
            {
                KodeBuku = txtKodeBuku.Text.Trim(),
                Judul = txtJudul.Text.Trim(),
                Pengarang = txtPengarang.Text.Trim(),
                Penerbit = txtPenerbit.Text.Trim(),
                Harga = Convert.ToDecimal(txtHarga.Text),
                Stok = Convert.ToInt32(txtStok.Text)
            };

            // Menjalankan method kirim perintah tulis data baru ke sistem database mysql
            if (objekBuku.SimpanBaru())
            {
                MessageBox.Show("Buku berhasil ditambahkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDataGrid(); // Segarkan visual dgv tabel
                BersihForm(); // Bersihkan kotak inputan form
            }
        }

        // Operasi Klik Tombol Perbarui / Edit Rincian Informasi Buku Lama
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedIdBuku == 0) // Validasi pencegahan jika belum ada sel baris dgv tabel diklik sorot oleh user
            {
                MessageBox.Show("Pilih data buku terlebih dahulu dari tabel.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CheckEmptyInputs()) return;

            Buku objekBuku = new Buku
            {
                IdBuku = selectedIdBuku, // Menyertakan angka kunci ID parameter utama target modifikasi rekor
                KodeBuku = txtKodeBuku.Text.Trim(),
                Judul = txtJudul.Text.Trim(),
                Pengarang = txtPengarang.Text.Trim(),
                Penerbit = txtPenerbit.Text.Trim(),
                Harga = Convert.ToDecimal(txtHarga.Text),
                Stok = Convert.ToInt32(txtStok.Text)
            };

            if (objekBuku.UbahData())
            {
                MessageBox.Show("Buku berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDataGrid();
                BersihForm();
            }
        }

        // Operasi Klik Tombol Hapus Buku Selamanya dari Sistem Gudang Buku
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedIdBuku == 0)
            {
                MessageBox.Show("Pilih buku terlebih dahulu dari daftar.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Memunculkan kotak konfirmasi pilihan ganda Yes/No untuk meminimalkan salah klik tidak sengaja
            DialogResult res = MessageBox.Show("Apakah Anda yakin ingin menghapus buku ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                // Menjalankan perintah eksekusi hapus berdasarkan masukan nilai ID penanda terpilih
                if (Buku.HapusData(selectedIdBuku))
                {
                    MessageBox.Show("Buku berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataGrid();
                    BersihForm();
                }
            }
        }

        // Tombol aksi membatalkan pilihan klik baris data komponen
        private void btnBersih_Click(object sender, EventArgs e)
        {
            BersihForm();
        }

        // Fungsi pembantu mengecek validasi kelengkapan isian string kosong komponen text box form
        private bool CheckEmptyInputs()
        {
            if (string.IsNullOrWhiteSpace(txtKodeBuku.Text) || string.IsNullOrWhiteSpace(txtJudul.Text) ||
                string.IsNullOrWhiteSpace(txtPengarang.Text) || string.IsNullOrWhiteSpace(txtPenerbit.Text) ||
                string.IsNullOrWhiteSpace(txtHarga.Text) || string.IsNullOrWhiteSpace(txtStok.Text))
            {
                MessageBox.Show("Data tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }

        // Mengembalikan form inputan teks box ke keadaan kosong bersih mula-mula semula
        private void BersihForm()
        {
            selectedIdBuku = 0;
            txtKodeBuku.Clear();
            txtJudul.Clear();
            txtPengarang.Clear();
            txtPenerbit.Clear();
            txtHarga.Clear();
            txtStok.Clear();
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

