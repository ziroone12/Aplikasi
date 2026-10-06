using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aplikasi
{
    public class Buku
    {
        // 1. Deklarasi Properti Data sesuai pemetaan struktur kolom tabel master buku
        public int IdBuku { get; set; }
        public string KodeBuku { get; set; }
        public string Judul { get; set; }
        public string Pengarang { get; set; }
        public string Penerbit { get; set; }
        public decimal Harga { get; set; }
        public int Stok { get; set; }

        // 2. Method statis mengambil data massal isi rak buku untuk disambungkan ke komponen DataGridView
        public static DataTable TampilkanSemua()
        {
            DataTable dt = new DataTable(); // Menyiapkan wadah tabel virtual di RAM lokal komputer
            using (MySqlConnection conn = Koneksi.Getkoneksi())
            {
                string query = "SELECT id_buku, kode_buku, judul, pengarang, penerbit, harga, stok FROM books";
                // Menggunakan DataAdapter sebagai jembatan penarik data massal dari database ke DataTable lokal
                using (MySqlDataAdapter da = new MySqlDataAdapter(query, conn))
                {
                    da.Fill(dt); // Memasukkan baris data fisik database ke dalam tabel memori lokal
                }
            }
            return dt; // Mengembalikan hasil olahan tabel memori lokal
        }

        // 3. Method simpan entitas rekor pendaftaran buku baru dari form admin gudang
        public bool SimpanBaru()
        {
            using (MySqlConnection conn = Koneksi.Getkoneksi())
            {
                string query = "INSERT INTO books (kode_buku, judul, pengarang, penerbit, harga, stok) VALUES (@kode, @judul, @pengarang, @penerbit, @harga, @stok)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@kode", this.KodeBuku);
                    cmd.Parameters.AddWithValue("@judul", this.Judul);
                    cmd.Parameters.AddWithValue("@pengarang", this.Pengarang);
                    cmd.Parameters.AddWithValue("@penerbit", this.Penerbit);
                    cmd.Parameters.AddWithValue("@harga", this.Harga);
                    cmd.Parameters.AddWithValue("@stok", this.Stok);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0; // Mengembalikan true jika rekor berhasil ditulis
                }
            }
        }

        // 4. Method memperbarui rincian informasi detail data buku lama
        public bool UbahData()
        {
            using (MySqlConnection conn = Koneksi.Getkoneksi())
            {
                string query = "UPDATE books SET kode_buku=@kode, judul=@judul, pengarang=@pengarang, penerbit=@penerbit, harga=@harga, stok=@stok WHERE id_buku=@id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", this.IdBuku);
                    cmd.Parameters.AddWithValue("@kode", this.KodeBuku);
                    cmd.Parameters.AddWithValue("@judul", this.Judul);
                    cmd.Parameters.AddWithValue("@pengarang", this.Pengarang);
                    cmd.Parameters.AddWithValue("@penerbit", this.Penerbit);
                    cmd.Parameters.AddWithValue("@harga", this.Harga);
                    cmd.Parameters.AddWithValue("@stok", this.Stok);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // 5. Method menghapus rekor buku dari database berdasarkan kecocokan ID primer
        public static bool HapusData(int id)
        {
            using (MySqlConnection conn = Koneksi.Getkoneksi())
            {
                string query = "DELETE FROM books WHERE id_buku = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // 6. Method operasi penambahan kalkulasi kuantitas stok barang masuk gudang
        public static bool UpdateTambahStok(int id, int jumlahTambahan)
        {
            using (MySqlConnection conn = Koneksi.Getkoneksi())
            {
                // Menambahkan angka pasokan stok lama database digabung dengan jumlah kiriman stok baru
                string query = "UPDATE books SET stok = stok + @tambahan WHERE id_buku = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tambahan", jumlahTambahan);
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }


    }
}
