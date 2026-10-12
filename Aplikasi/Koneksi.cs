using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi
{
    public class Koneksi
    {
        private static string connectionString = "server=localhost;port=3306;username=root;password=;database=db_tokobuku;";
        public static MySqlConnection Getkoneksi()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
