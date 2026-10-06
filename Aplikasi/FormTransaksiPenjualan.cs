using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aplikasi
{
    public partial class FormTransaksiPenjualan : Form
    {
        // Membuat wadah tabel virtual terputus koneksi (Disconnected Architecture) untuk menampung list belanjaan kasir di RAM komputer
        private DataTable keranjangTemp;
        private int currentIdBuku = 0;
        private string currentKodeBuku = "";
        private decimal currentHargaBuku = 0;
        private int currentStokGudang = 0;
        private decimal grandTotal = 0;
        public FormTransaksiPenjualan()
        {
            InitializeComponent();
            InisialisasiKeranjang(); // Membuat kolom tabel keranjang belanjaan temporer pas load awal sistem komponen
        }
        // Menyusun dan merancang struktur kepala kolom keranjang belanja temporer lokal
        private void InisialisasiKeranjang()
        {
            keranjangTemp = new DataTable();
            keranjangTemp.Columns.Add("id_buku", typeof(int));
            keranjangTemp.Columns.Add("KodeBuku", typeof(string));
            keranjangTemp.Columns.Add("Judul", typeof(string));
            keranjangTemp.Columns.Add("Harga", typeof(decimal));
            keranjangTemp.Columns.Add("Jumlah", typeof(int));
            keranjangTemp.Columns.Add("Subtotal", typeof(decimal));
            dgvKeranjang.DataSource = keranjangTemp; // Menyambungkan struktur tabel memori lokal ke DataGridView keranjang belanjaan visual
        }

        // Tombol Klik Aksi Pencarian Buku Berdasarkan Barcode / Potongan Huruf Judul
        private void btnCari_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCariBuku.Text)) return;

            // Mengambil baris hasil temuan pencarian data dari database mysql melalui Kelas Transaksi OOP
            DataTable hasil = transaksi.CariBuku(txtCariBuku.Text.Trim());
            if (hasil.Rows.Count > 0)
            {
                // Menarik indeks data baris barisan urutan pertama hasil pencarian yang sukses ditemukan
                DataRow row = hasil.Rows[0];
                currentIdBuku = Convert.ToInt32(row["id_buku"]);
                currentKodeBuku = row["kode_buku"].ToString();
                lblJudul.Text = row["judul"].ToString();
                currentHargaBuku = Convert.ToDecimal(row["harga"]);
                lblHarga.Text = currentHargaBuku.ToString("N0"); // Merender nominal dengan pemisah digit angka ribuan koma/titik manis
                currentStokGudang = Convert.ToInt32(row["stok"]);
                lblStok.Text = currentStokGudang.ToString();
            }
            else
            {
                MessageBox.Show("Data buku tidak ditemukan.", "Pencarian", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Tombol Klik Aksi Memasukkan Buku Terpilih Hasil Pencarian ke List Keranjang Belanjaan Visual dgv
        private void btnTambahKeranjang_Click(object sender, EventArgs e)
        {
            if (currentIdBuku == 0) return; // Batalkan proses jika kasir belum menentukan pencarian buku apapun

            int jumlahBeli;
            // Validasi filter penulisan menyaring kesalahan inputan huruf/karakter aneh pada kuantitas kupon beli barang
            if (!int.TryParse(txtJumlahBeli.Text, out jumlahBeli) || jumlahBeli <= 0)
            {
                MessageBox.Show("Jumlah beli harus berupa angka positif.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi krusial pengamanan menolak penjualan jika kuantitas item yang dibeli melampaui sisa pasokan stok riil gudang fisik
            if (jumlahBeli > currentStokGudang)
            {
                MessageBox.Show("Stok gudang tidak mencukupi untuk jumlah pembelian ini.", "Stok Kurang", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Melakukan perkalian matematika nominal harga buku dikalikan kuantitas unit item yang diborong pelanggan
            decimal subtotal = currentHargaBuku * jumlahBeli;
            // Menuliskan rekor ke baris tabel keranjang belanjaan temporer memori RAM lokal komputer kasir
            keranjangTemp.Rows.Add(currentIdBuku, currentKodeBuku, lblJudul.Text, currentHargaBuku, jumlahBeli, subtotal);
            HitungGrandTotal(); // Memperbarui nilai total nominal nota belanjaan kasir secara realtime otomatis
            ResetPencarianBuku(); // Kembalikan kolom pencarian buku ke kondisi semula bersih siap cari buku berikutnya
        }

        // Tombol Klik Aksi Mengeluarkan / Mengeliminasi Item Barang dari Daftar List Tabel Belanjaan Sementara dgv
        private void btnHapusItem_Click(object sender, EventArgs e)
        {
            if (dgvKeranjang.CurrentRow != null && dgvKeranjang.CurrentRow.Index >= 0)
            {
                dgvKeranjang.Rows.RemoveAt(dgvKeranjang.CurrentRow.Index); // Menghapus baris item belanja terpilih
                HitungGrandTotal(); // Kalkulasi hitung ulang total nominal nota belanjaan kasir paling baru
            }
        }

        // Menghitung akumulasi total pertambahan penggabungan nominal uang dari baris subtotal keranjang
        private void HitungGrandTotal()
        {
            grandTotal = 0; // Mengeset titik awal penjumlahan di nominal dasar angka 0
            foreach (DataRow row in keranjangTemp.Rows)
            {
                grandTotal += Convert.ToDecimal(row["Subtotal"]); // Akumulasi akumulatif penggabungan nominal subtotal
            }
            lblTotalHarga.Text = grandTotal.ToString("N0"); // Merender angka total belanja kasir ke komponen label teks UI
        }

        private void ResetPencarianBuku()
        {
            currentIdBuku = 0;
            currentKodeBuku = "";
            currentHargaBuku = 0;
            currentStokGudang = 0;
            lblJudul.Text = "-";
            lblHarga.Text = "0";
            lblStok.Text = "0";
            txtJumlahBeli.Clear();
            txtCariBuku.Clear();
        }

        // Operasi Klik Tombol Pembayaran POS Kasir (Penerapan Pola Database Kritis MySQL Transaction)
        private void btnBayar_Click(object sender, EventArgs e)
        {
            if (keranjangTemp.Rows.Count == 0) // Mencegah pemrosesan kasir jika isi tabel belanjaan masih kosong melompong
            {
                MessageBox.Show("Keranjang masih kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = Koneksi.Getkoneksi())
            {
                conn.Open();
                // 1. Memulai sesi pengamanan SQL Transaction di database untuk menangani kegagalan penyimpanan data terputus di tengah jalan
                MySqlTransaction trans = conn.BeginTransaction();

                try
                {
                    long idTransaksiBaru = 0;
                    // 2. Menulis data master rekor utama induk nota transaksi keuangan
                    string queryMaster = "INSERT INTO transactions (tanggal, total_harga, id_user) VALUES (@tgl, @total, @user)";
                    using (MySqlCommand cmdMaster = new MySqlCommand(queryMaster, conn, trans))
                    {
                        cmdMaster.Parameters.AddWithValue("@tgl", DateTime.Now);
                        cmdMaster.Parameters.AddWithValue("@total", grandTotal);
                        cmdMaster.Parameters.AddWithValue("@user", Program.IDUserAktif);
                        cmdMaster.ExecuteNonQuery();

                        // Menangkap angka Auto-Increment ID transaksi unik teranyar yang barusan dihasilkan otomatis oleh sistem tabel MySQL
                        idTransaksiBaru = cmdMaster.LastInsertedId;
                    }

                    // 3. Menjalankan proses perulangan (looping) baris daftar belanjaan di keranjang RAM lokal untuk disimpan masal ke database
                    foreach (DataRow row in keranjangTemp.Rows)
                    {
                        // Memasukkan detail pecahan item buku terjual ke tabel riwayat jembatan transaksi detail (transaction_details)
                        string queryDetail = "INSERT INTO transaction_details (id_transaksi, id_buku, jumlah, subtotal) VALUES (@idT, @idB, @jml, @sub)";
                        using (MySqlCommand cmdDetail = new MySqlCommand(queryDetail, conn, trans))
                        {
                            cmdDetail.Parameters.AddWithValue("@idT", idTransaksiBaru);
                            cmdDetail.Parameters.AddWithValue("@idB", row["id_buku"]);
                            cmdDetail.Parameters.AddWithValue("@jml", row["Jumlah"]);
                            cmdDetail.Parameters.AddWithValue("@sub", row["Subtotal"]);
                            cmdDetail.ExecuteNonQuery();
                        }

                        // Menjalankan instruksi matematika pengurangan (DEDUKSI) nilai kuantitas sisa saldo stok fisik di gudang buku asli (tabel books)
                        string queryStok = "UPDATE books SET stok = stok - @jml WHERE id_buku = @idB";
                        using (MySqlCommand cmdStok = new MySqlCommand(queryStok, conn, trans))
                        {
                            cmdStok.Parameters.AddWithValue("@jml", row["Jumlah"]);
                            cmdStok.Parameters.AddWithValue("@idB", row["id_buku"]);
                            cmdStok.ExecuteNonQuery();
                        }
                    }

                    // 4. Jika seluruh baris instruksi insert masal di atas sukses tanpa kendala, sahkan seluruh data tersimpan mutlak permanen
                    trans.Commit();

                    // 5. Membuat kerangka teks struk kasir simulasi struk kertas kasir POS thermal printer toko buku
                    string strukText = $"=== STRUK TOKO BUKU ===\nID Transaksi: {idTransaksiBaru}\nKasir: {Program.UsernameAktif}\nTotal: Rp. {grandTotal:N0}\n=====================\nTerima Kasih.";
                    MessageBox.Show(strukText, "Simulasi Cetak Struk", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Transaksi berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    keranjangTemp.Clear(); // Kosongkan total tabel keranjang belanjaan lokal RAM kasir
                    HitungGrandTotal(); // Kembalikan nilai total pembukuan nota kasir ke angka bersih nol rupiah semula
                }
                catch (Exception ex)
                {
                    // 6. Apabila terjadi pemadaman listrik atau crash sistem ditengah jalan, batalkan dan pulihkan kondisi awal database utuh semula (Rollback)
                    trans.Rollback();
                    MessageBox.Show("Gagal memproses transaksi kasir: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnKembaliDashboard_Click(object sender, EventArgs e)
        {
            // Menyembunyikan mesin POS kasir berjalan
            this.Hide();
            // Mengarahkan kembali ke dashboard utama menu milik kasir
            FormDashboardKasir kasirDash = new FormDashboardKasir();
            kasirDash.Show();
        }
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Menutup total seluruh background process aplikasi saat tombol X silang ditekan langsung
            Application.Exit();
        }

        private void FormTransaksiPenjualan_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label8.Visible = false;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            lblJudul.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            lblHarga.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            lblStok.BackColor = Color.Transparent;
        }

        private void FormTransaksiPenjualan_Load_1(object sender, EventArgs e)
        {

        }
    }
}
