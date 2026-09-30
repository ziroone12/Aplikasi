using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aplikasi
{
    internal class Buku
    {
        public class buku
        {
            public string Id { get; set; }
            public string kodebuku { get; set; }
            public string Judul { get; set; }
            public string Pengarang { get; set; }
            public int Penerbit { get; set; }
            public string Harga { get; set; }
            public string Stok { get; set; }

            public static DataTable TampilaknSemua()
            {
                DataTable dt = new DataTable();
                //fungsi datatable untuk menampung data dari database

                using (MySqlConnection conn = Koneksi.Getkoneksi())
                {
                    string query = "SELECT id_buku, kode_buku, judul, pengarang, penerbit, harga, stok FROM buku";

                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, conn))
                    //fungsi mysqldataadapter adalah komponen yang bertindak sebagai jembatan otomatis antara aplikasi Anda dan database MySQL.

                    {
                        da.Fill(dt);
                    }
                }
                return dt;
            }

            public bool SimpanBaru()
            {
                using (MySqlConnection conn = Koneksi.Getkoneksi())
                {
                    string query = "INSERT INTO books (kode_buku, judul, pengarang, penerbit, harga, stok) VALUES (@kode, @judul, @pengarang, @penerbit, @harga, @stok)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@kode", this.kodebuku);
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

            public bool UbahData()
            {
                using (MySqlConnection coonn = Koneksi.Getkoneksi())
                {
                    string query = "UPDATE books SET kode_buku = @kode, judul = @judul, pengarang = @pengarang, penerbit = @penerbit, harga = @harga, stok = @stok WHERE id_buku = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, coonn))
                    {
                        cmd.Parameters.AddWithValue("@kode", this.kodebuku);
                        cmd.Parameters.AddWithValue("@judul", this.Judul);
                        cmd.Parameters.AddWithValue("@pengarang", this.Pengarang);
                        cmd.Parameters.AddWithValue("@penerbit", this.Penerbit);
                        cmd.Parameters.AddWithValue("@harga", this.Harga);
                        cmd.Parameters.AddWithValue("@stok", this.Stok);
                        cmd.Parameters.AddWithValue("@id", this.Id);
                        coonn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }

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

            public static bool UpdateTambahStok(int id, int jumlahtambahan)
            {
                using (MySqlConnection conn = Koneksi.Getkoneksi())
                {
                    string query = "UPDATE books SET stok = stok + @tambahan WHERE id_buku = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@tambahan", jumlahtambahan);
                        cmd.Parameters.AddWithValue("@id", id);
                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            })
        }
    }
}
