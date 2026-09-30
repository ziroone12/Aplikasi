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
        //untuk ngekonekin ke database nyaaa
        private static string connectionString = "server=localhost;username=root;port=3306;database=db_tokobuku";

        public static MySqlConnection Getkoneksi()
        {
            //untuk menghubungkan program apk dengan server database
            return new MySqlConnection(connectionString);
        }
    }
}
