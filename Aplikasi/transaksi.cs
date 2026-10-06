using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Aplikasi
{
    public class transaksi
    {
        //Di bawah ini adalah pembuatan Method (Fungsi) pencarian pintar tersebut
        public static DataTable CariBuku(string keyword)
        {
            DataTable dt = new DataTable();// Menyiapkan wadah tabel virtual di RAM lokal komputer
            using (MySqlConnection conn = Koneksi.Getkoneksi())
            {
                // keylike fungsinya : buat  nyari data yang mirip
                string query = "SELECT id_buku, kode_buku, judul, harga,stok FROM books where kode_buku = @key OR judul LIKE @keyLike";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@key", keyword);
                    cmd.Parameters.AddWithValue("@keyLike", "%" + keyword + "%");
                    // Menggunakan DataAdapter sebagai jembatan penarik data massal dari database ke DataTable lokal
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }

            }
            return dt;
        }


        public static DataTable AmbilLaporan(DateTime dari, DateTime sampai)
        {
            //sebagai mesin penarik laporan keuangan 
            DataTable dt = new DataTable();
            using (MySqlConnection conn = Koneksi.Getkoneksi())
            {
                string query = @"SELECT t, tanggal AS Tanggal Transaksi, b.judul AS judul Buku, td.jumlah AS `Jumlah Terjual`, td.subtotal AS `Total Pendapatan` 
                                 FROM transaction_details td
                                 INNER JOIN transactions t ON td.id_transaksi = t.id_transaksi
                                 INNER JOIN books b ON td.id_buku = b.id_buku
                                 WHERE t.tanggal BETWEEN @mulai AND @selesai";
                //untuk mengangkut teks rumus mesin penarik laporan k
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    //parameters fungsinya : sebagai kamar kosong  atau biasa di sebut sebagai saringan keamanan
                    cmd.Parameters.AddWithValue("@mulai", dari);
                    cmd.Parameters.AddWithValue("@selesai", sampai);
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

    }
}
