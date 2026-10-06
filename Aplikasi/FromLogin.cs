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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Tombol Klik Aksi Masuk Akun (Login)
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label1.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1. Validasi awal memastikan semua kolom isian teks dan pilihan Role tidak boleh kosong
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || cmbRoleDaftar.SelectedItem == null)
            {
                MessageBox.Show("Harap isi semua kolom dan pilih Role Anda sebelum masuk.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Menghentikan proses ke baris bawah jika isian belum lengkap
            }

            try
            {
                // 2. Instansiasi membuat objek baru dari kelas model User
                User objekUser = new User();

                // 3. Mengambil teks Role yang dipilih dari ComboBox Login (misal: "admin" atau "kasir")
                string roleTerpilih = cmbRoleDaftar.SelectedItem.ToString();

                // 4. PERBAIKAN: Mengirim Username, Password, DAN Role ke fungsi validasi database terbaru
                if (objekUser.ValidasiLogin(txtUsername.Text.Trim(), txtPassword.Text.Trim(), roleTerpilih))
                {
                    MessageBox.Show("Login Berhasil! Selamat Datang.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide(); // Menyembunyikan jendela Form Login dari layar

                    // 5. Mengarahkan rute dashboard sesuai dengan Role yang sudah tervalidasi benar
                    if (objekUser.Role.ToLower() == "admin")
                    {
                        FormDashBoardAdmin adminDash = new FormDashBoardAdmin();
                        adminDash.Show(); // Membuka menu kendali utama admin master data
                    }
                    else
                    {
                        FormDashBoardKasir kasirDash = new FormDashBoardKasir();
                        kasirDash.Show(); // Membuka mesin utama point of sales kasirc
                    }
                }
                else
                {
                    // 6. Notifikasi penolakan jika salah satu dari Username, Password, atau Pilihan Role tidak cocok di database
                    MessageBox.Show("Username, password, atau pilihan role Anda salah.", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Penanganan darurat pembatas jika koneksi MySQL bermasalah
                MessageBox.Show("Gagal terhubung ke sistem database: " + ex.Message, "Error Koneksi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Tombol Klik Aksi Pendaftaran Perekaman Akun Baru Lokal Sistem
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            // 1. Menyaring kelengkapan isian text field registrasi user baru
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || cmbRoleDaftar.SelectedItem == null)
            {
                MessageBox.Show("Harap isi seluruh field termasuk pilihan Role registrasi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User objekUser = new User();

            // 2. Mencegah pendaftaran nama akun yang sama/kembar di dalam database
            if (objekUser.CekUsernameTerdaftar(txtUsername.Text.Trim()))
            {
                MessageBox.Show("Username sudah digunakan, gunakan nama lain.", "Registrasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Mengisi properti data objek model berdasarkan masukan kotak teks antarmuka
            objekUser.Username = txtUsername.Text.Trim();
            objekUser.Password = txtPassword.Text.Trim();
            objekUser.Role = cmbRoleDaftar.SelectedItem.ToString();

            // 4. Menjalankan fungsi simpan rekor pendaftaran akun baru ke tabel users database mysql
            if (objekUser.Registrasiuserbaru())
            {
                MessageBox.Show("User Baru berhasil terdaftar di dalam sistem!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Menutup total seluruh background process aplikasi saat tombol X silang ditekan langsung
            Application.Exit();
        }

    }
}