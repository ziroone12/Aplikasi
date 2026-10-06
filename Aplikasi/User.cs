using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace Aplikasi
{
    public class User
    {

        public string IdUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        // FUNGSI 1: VALIDASI LOGIN (SUDAH DISINKRONKAN KE TABEL 'users')
        public bool ValidasiLogin(string user, string pass, string roleterpilih)
        {
            bool status = false;

            using (MySqlConnection conn = Koneksi.Getkoneksi())
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                // PERBAIKAN: Nama tabel diubah dari 'user' menjadi 'users' sesuai dengan database MySQL Anda
                string query = "SELECT id_user, username, password, role FROM users WHERE username = @user AND password = @pass AND role = @role";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", user);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    cmd.Parameters.AddWithValue("@role", roleterpilih);

                    try
                    {
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
                }
            }
            return status;
        }

        // FUNGSI 2: CEK USERNAME KEMBAR (SUDAH DISINKRONKAN KE TABEL 'users')
        public bool CekUsernameTerdaftar(string user)
        {
            using (MySqlConnection conn = Koneksi.Getkoneksi())
            {
                // PERBAIKAN: Nama tabel diubah dari 'user' menjadi 'users' sesuai dengan database MySQL Anda
                string query = "SELECT COUNT(*) FROM users WHERE username = @user";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", user);

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        // FUNGSI 3: REGISTRASI USER BARU (SUDAH PAS KE TABEL 'users')
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

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }

}

