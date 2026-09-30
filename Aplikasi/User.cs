using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using MySql.Data.MySqlClient;


namespace Aplikasi
{
    public class User
    {

        public string IdUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }


        public bool ValidasiLogin(string user, string pass, string roleterpilih)
        {
            bool status = false;
            //membuat variabel baru bernama status yang hanya bisa menyimpan nilai kebenaran (boolean) dan menginisialisasi nilai awalnya sebagai false (salah)

            using (MySqlConnection conn = Koneksi.Getkoneksi())
            {
                conn.Open();
                string query = "SELECT id_user, username, password, role FROM user WHERE username = @user AND password = @pass AND role = @role";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", user);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    cmd.Parameters.AddWithValue("@role", roleterpilih);

                    try
                    {
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Program.IDUserAktif = Convert.ToInt32(reader["id_user"]);
                                Program.UsernameAktif = reader["username"].ToString();
                                this.Role = reader["role"].ToString();
                                status = true;
                            }
                        }

                    }
                    catch (Exception) { throw; } 
                    // fungsi throw untuk memicu terjadinya pengecualian (exception) secara sengaja ketika ada kesalahan atau kondisi tak terduga dalam kode
                }
            }
            return status;
        }
        //memeriksa apakah sebuah nama pengguna (username) sudah ada atau sudah terdaftar di dalam sistem
        public bool CekUsernameTerdaftar(string user)
        {
            using (MySqlConnection conn = Koneksi.Getkoneksi())
            {
                // membuka koneksi ke database menggunakan objek MySqlConnection yang diperoleh dari metode Koneksi.Getkoneksi()
                conn.Open();
                string query = "SELECT COUNT(*) FROM user WHERE username = @user";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", user);
                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    // executescalar perintah yang digunakan untuk menjalankan query SQL dan hanya mengambil satu nilai saja pada baris pertama dan kolom pertama dari hasil query.

                    return count > 0;
                }
            }
        }

        public bool Registrasiuserbaru()
        {
            using (MySqlConnection conn = Koneksi.Getkoneksi())
            {
                string query = "INSERT INTO users (username, password, role) VALUES (@user, @pass, @role)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", this.Username);
                    cmd.Parameters.AddWithValue("@pass", this.Password);
                    cmd.Parameters.AddWithValue("@role", this.Role);
                    conn.Open();

                    return cmd.ExecuteNonQuery() > 0;
                }

            }

        }
    }
}
