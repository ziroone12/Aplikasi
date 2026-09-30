using System;
using System.Collections.Generic;
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


        public bool ValidasiLogin(string user, string pass, string roleterpilih)
        {
            bool status = false;

            using (MySqlConnection conn = koneksi.Getkoneksi())
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
                            Program.IDUserAktif = Convert.ToInt32(reader["id_user"]);
                        Program.UsernameAktif = reader["username"].ToString();
                        this.Role = reader["role"].ToString();

                        status = true;

                    }
                    catch (Exception) { throw; } // fungsi throw untuk memicu terjadinya pengecualian (exception) secara sengaja ketika ada kesalahan atau kondisi tak terduga dalam kode
                }
            }
            return status;
        }
        public bool CekUsernameTerdaftar(string user)
        {
            using (MySqlConnection conn = koneksi.Getkoneksi())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM user WHERE username = @user";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", user);
                    conn.open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public bool Registrasiuserbaru()
        {
            using (MySqlConnection conn = koneksi.Getkoneksi())
            {
                string query = "INSERT INTO users (username, password, role) VALUES (@user, @pass, @role)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.addWithValue("@user", this.Username);
                    cmd.Parameters.addWithValue("@pass", this.Password);
                    cmd.Parameters.addWithValue("@role", this.Role);
                    conn.open();

                    return cmd.executeNonQuery() > 0;
                }

            }

        }
    }
}
