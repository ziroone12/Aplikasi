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
        private DataTable dtKeranjang = new DataTable();
        public decimal grandtotal = 0;
        public FormTransaksiPenjualan()
        {
            InitializeComponent();
            InisialisasiKeranjang();
            BuatTombolAksiPerBaris();
            cmbCariBuku.TextUpdate += cmbCariBuku_TextUpdate;


        }
        private void InisialisasiKeranjang()
        {
            dtKeranjang.Columns.Add("id_buku", typeof(int));
            dtKeranjang.Columns.Add("Kode Buku", typeof(string));
            dtKeranjang.Columns.Add("Judul Buku", typeof(string));
            dtKeranjang.Columns.Add("Harga Satuan", typeof(decimal));
            dtKeranjang.Columns.Add("Jumlah", typeof(int));
            dtKeranjang.Columns.Add("Subtotal", typeof(decimal));
            dgvKeranjang.DataSource = dtKeranjang;
        }
        private void BuatTombolAksiPerBaris()
        {
            DataGridViewButtonColumn btnTambahCol = new DataGridViewButtonColumn() { Name = "KolomTambah", HeaderText = "Tambah", Text = "+", UseColumnTextForButtonValue = true, Width = 60 };
            dgvKeranjang.Columns.Add(btnTambahCol);
            DataGridViewButtonColumn btnKurangCol = new DataGridViewButtonColumn() { Name = "KolomKurang", HeaderText = "Kurang", Text = "-", UseColumnTextForButtonValue = true, Width = 60 };
            dgvKeranjang.Columns.Add(btnKurangCol);
        }

        private void dgvKeranjang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataRow row = dtKeranjang.Rows[e.RowIndex];
            decimal harga = Convert.ToDecimal(row["Harga Satuan"]);
            int qtySekarang = Convert.ToInt32(row["Jumlah"]);

            if (dgvKeranjang.Columns[e.ColumnIndex].Name == "KolomTambah")
            {
                row["Jumlah"] = qtySekarang + 1;
                row["Subtotal"] = (qtySekarang + 1) * harga;
            }
            else if (dgvKeranjang.Columns[e.ColumnIndex].Name == "KolomKurang")
            {
                if (qtySekarang > 1)
                {
                    row["Jumlah"] = qtySekarang - 1;
                    row["Subtotal"] = (qtySekarang - 1) * harga;
                }
                else { dtKeranjang.Rows.Remove(row); }
            }
            HitungGrandTotal();
        }

        private void cmbCariBuku_TextUpdate(object sender, EventArgs e)
        {
            string keyword = cmbCariBuku.Text.Trim();
            if (keyword.Length < 1) return;

            using (MySqlConnection conn = Koneksi.Getkoneksi())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string query = "SELECT id_buku, kode_buku, judul, harga FROM books WHERE judul LIKE @key OR kode_buku LIKE @key";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@key", "%" + keyword + "%");
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        cmbCariBuku.Items.Clear();
                        foreach (DataRow row in dt.Rows)
                        {
                            cmbCariBuku.Items.Add($"{row["id_buku"]} | {row["kode_buku"]} | {row["judul"]} | {row["harga"]}");
                        }
                        cmbCariBuku.DroppedDown = true;
                        cmbCariBuku.Select(keyword.Length, 0);
                    }
                }
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (cmbCariBuku.SelectedItem == null || string.IsNullOrWhiteSpace(txtQty.Text)) return;
            string[] pecahan = cmbCariBuku.SelectedItem.ToString().Split('|');
            int idBuku = Convert.ToInt32(pecahan[0].Trim());
            string kode = pecahan[1].Trim();
            string judul = pecahan[2].Trim();
            decimal harga = Convert.ToDecimal(pecahan[3].Trim());
            int qtyInput = Convert.ToInt32(txtQty.Text);

            bool itemSudahAda = false;
            foreach (DataRow row in dtKeranjang.Rows)
            {
                if (Convert.ToInt32(row["id_buku"]) == idBuku)
                {
                    int qtyLama = Convert.ToInt32(row["Jumlah"]);
                    row["Jumlah"] = qtyLama + qtyInput;
                    row["Subtotal"] = (qtyLama + qtyInput) * harga;
                    itemSudahAda = true;
                    break;
                }
            }

            if (!itemSudahAda)
            {
                DataRow dr = dtKeranjang.NewRow();
                dr["id_buku"] = idBuku;
                dr["Kode Buku"] = kode;
                dr["Judul Buku"] = judul;
                dr["Harga Satuan"] = harga;
                dr["Jumlah"] = qtyInput;
                dr["Subtotal"] = qtyInput * harga;
                dtKeranjang.Rows.Add(dr);
            }
            HitungGrandTotal();
        }

        private void HitungGrandTotal()
        {
            grandtotal = 0;
            foreach (DataRow row in dtKeranjang.Rows) grandtotal += Convert.ToDecimal(row["Subtotal"]);
            lblGrandTotal.Text = "Rp " + grandtotal.ToString("N0");
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            if (dtKeranjang.Rows.Count == 0) return;

            FormBilingPayment frmBilling = new FormBilingPayment() { TotalTagihanMaster = grandtotal };

            // Jendela popup payment terbuka kasir pilih metode lalu klik selesai.
            if (frmBilling.ShowDialog() == DialogResult.OK)
            {
                // Jika kasir sukses bayar, jalankan fungsi simpan database di bawah ini:
                SimpanTransaksiKeDatabase(frmBilling);
            }
        }

        private void SimpanTransaksiKeDatabase(FormBilingPayment frmBilling)
        {
            using (MySqlConnection conn = Koneksi.Getkoneksi())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                using (MySqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        string qTrans = "INSERT INTO transactions (tanggal, total_harga, id_user) VALUES (NOW(), @total, @user); SELECT LAST_INSERT_ID();";
                        int idNota = 0;
                        using (MySqlCommand cmd = new MySqlCommand(qTrans, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@total", grandtotal);
                            cmd.Parameters.AddWithValue("@user", Program.IDUserAktif);
                            idNota = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        // 2. LOOPING ISI KERANJANG UNTUK MEMASUKKAN DETAIL ITEM & MEMOTONG STOK GUDANG
                        foreach (DataRow row in dtKeranjang.Rows)
                        {
                            // Simpan ke pecahan anak nota
                            string qDetail = "INSERT INTO transaction_details (id_transaksi, id_buku, jumlah, subtotal) VALUES (@idTx, @idBuku, @qty, @sub)";
                            using (MySqlCommand cmdD = new MySqlCommand(qDetail, conn, trans))
                            {
                                cmdD.Parameters.AddWithValue("@idTx", idNota);
                                cmdD.Parameters.AddWithValue("@idBuku", row["id_buku"]);
                                cmdD.Parameters.AddWithValue("@qty", row["Jumlah"]);
                                cmdD.Parameters.AddWithValue("@sub", row["Subtotal"]);
                                cmdD.ExecuteNonQuery();
                            }

                            // Potong stok fisik buku di database
                            string qPotongStok = "UPDATE books SET stok = stok - @qty WHERE id_buku = @idBuku";
                            using (MySqlCommand cmdS = new MySqlCommand(qPotongStok, conn, trans))
                            {
                                cmdS.Parameters.AddWithValue("@qty", row["Jumlah"]);
                                cmdS.Parameters.AddWithValue("@idBuku", row["id_buku"]);
                                cmdS.ExecuteNonQuery();
                            }
                        }

                        // Nyatakan seluruh rangkaian penulisan data ke database sukses
                        trans.Commit();

   
                        string metodeBayar = frmBilling.MetodeDipilih;
                        decimal uangTunai = grandtotal; // Nilai bawaan default jika non-tunai

                        if (metodeBayar == "CASH")
                        {
                            // Mengambil nilai riil uang fisik dari properti Form Billing 
                            uangTunai = frmBilling.UangDiterima;
                        }

                        // Sekarang rumus kalkulasi matematika ini dijamin lurus dan akurat menghasilkan angka 
                        decimal kembalian = uangTunai - grandtotal;

                        // Memanggil Formstruk dengan parameter lengkap, seimbang, dan jujur
                        Formstruk frmStruk = new Formstruk(idNota.ToString(), Program.UsernameAktif, grandtotal, dtKeranjang, uangTunai, kembalian, metodeBayar);
                        frmStruk.ShowDialog();

                        // Bersihkan meja kasir untuk transaksi baru
                        dtKeranjang.Clear();
                        HitungGrandTotal();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback(); // Batalkan penulisan jika koneksi terputus di tengah jalan
                        MessageBox.Show("Gagal memproses dan menyimpan transaksi: " + ex.Message, "Error Basis Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }


        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Menutup total seluruh background process aplikasi saat tombol X silang ditekan langsung
            Application.Exit();
        }

        private void FormTransaksiPenjualan_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
