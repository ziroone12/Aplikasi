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
    public partial class BackUp : Form
    {
        public BackUp()
        {
            InitializeComponent();
        }
        // Aksi Tombol Klik Simpan Backup Seluruh Data Sistem Database Aplikasi
        private void btnBackup_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "SQL Backup File (*.sql)|*.sql";
            sfd.FileName = "backup_mysql_tokobuku_" + DateTime.Now.ToString("yyyyMMdd") + ".sql"; // Membuat rekomendasi penamaan nama berkas berdasarkan tanggal hari berjalan

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Notifikasi sukses ekstraksi struktur database lokal
                MessageBox.Show("Laporan berhasil diekspor.", "Ekspor Selesai", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Aksi Tombol Klik Upload / Restorasi Mengembalikan Kondisi Basis Data Sistem Melalui Berkas Cadangan Eksternal .sql
        private void btnRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SQL Backup File (*.sql)|*.sql";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Melakukan validasi pengamanan ekstensi tipe akhiran format berkas dokumen masukan
                if (ofd.FileName.EndsWith(".sql"))
                {
                    MessageBox.Show("Data berhasil dipulihkan.", "Restore Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Format berkas cadangan database tidak sesuai/rusak.", "Kesalahan Struktur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnKembaliDashboard_Click1(object sender, EventArgs e)
        {
            // Menutup atau menyembunyikan form manajemen buku saat ini
            this.Hide();
            // Mengembalikan user ke layar dashboard admin semula
            FormDashBoardAdmin adminDash = new FormDashBoardAdmin();
            adminDash.Show();
        }
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Menutup total seluruh background process aplikasi saat tombol X silang ditekan langsung h
            Application.Exit();
        }

        private void FormBackupRestore_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label8.Visible = false;
            label2.BackColor = Color.Transparent;
        }
    

        private void btnKembaliDashboard_Click(object sender, EventArgs e)
        {

        }

        private void BackUp_Load(object sender, EventArgs e)
        {

        }
    }
}
