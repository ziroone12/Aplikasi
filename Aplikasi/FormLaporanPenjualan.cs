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
    public partial class FormLaporanPenjualan : Form
    {
        public FormLaporanPenjualan()
        {
            InitializeComponent();
        }
        // Tombol Saring Aksi Menyaring Data Pembukuan Masuk Berdasarkan Jangkauan Tanggal Kalender (DateTimePicker)
        
        
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Menutup total seluruh background process aplikasi saat tombol X silang ditekan langsung
            Application.Exit();
        }

        private void FormLaporanPenjualan_Load(object sender, EventArgs e)
        {
            
        }
    }
}
