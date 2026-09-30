using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi
{
    public class User
    {
       
        public string IdUser { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        
        public bool ValidasiLogin(string user,string pass, string roleterpilih)
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
                            Program.IDUserAktif

                    }
                }
            }
        }
    }
}
