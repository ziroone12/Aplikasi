using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi
{
    public partial class FormDashBoardAdmin : Form
    {
        public FormDashBoardAdmin()
        {
            InitializeComponent();
        }
        private void FormDashboardAdmin_Load(object sender, EventArgs e)
        {
            // Mengubah kalimat sambutan teks label dengan mengambil variabel sesi nama user aktif global
            lblSelamatDatang.Text = "Selamat Datang, " + Program.UsernameAktif + "!";
            lblSelamatDatang.BackColor = Color.Transparent;
        }

        // Aksi tombol logout keluar aman sistem aplikasi kasir toko buku
        
        
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Menutup total seluruh background process aplikasi saat tombol X silang ditekan langsung
            Application.Exit();
        }
    }
}
