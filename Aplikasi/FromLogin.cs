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
            label5.BackColor = Color.Transparent;
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
                        FormDashboardKasir kasirDash = new FormDashboardKasir();
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
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtKodeRegistrasi.Text) ||
                cmbRoleDaftar.SelectedItem == null)
            {
                // MessageBox.Show = Fungsi bawaan untuk memunculkan kotak pesan pop-up dialog tanda seru kuning (.Warning) di layar monitor.
                MessageBox.Show("Harap isi seluruh field termasuk pilihan Role dan Kode Rahasia Registrasi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // return = Perintah untuk menghentikan paksa jalannya kode di bawah agar user mengisi ulang form.
            }

            // 2. VALIDASI KODE RAHASIA PENDAFTARAN (FITUR PENGAMANAN BARU)
            // Teks.Trim() = Fungsi bawaan untuk membuang spasi kosong tidak sengaja di ujung depan/belakang kata ketikan user.
            // Operator logika tidak sama dengan '!=' artinya jika kata yang diketik kasir/admin bukan "1111", maka akses diblokir.
            if (txtKodeRegistrasi.Text.Trim() != "1111")
            {
                // Menampilkan pesan error penolakan keras bertanda ikon silang merah (.Error) karena kode salah.
                MessageBox.Show("Kode Rahasia Pendaftaran Salah! Anda tidak diizinkan membuat akun di sistem ini.", "Akses Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Hentikan paksa proses, data pendaftaran tidak akan pernah dikirim ke database MySQL.
            }

            // 3. PROSES INSTANSIASI OOP
            // Membuat cetakan objek baru bernama 'objekUser' berdasarkan blueprint Kelas Cetakan data 'User.cs'.
            User objekUser = new User();

            // 4. MENCEGAH DUPLIKASI NAMA AKUN KEMBAR
            // Memanggil fungsi verifikasi dari kelas User untuk memastikan nama username belum pernah diklaim orang lain di database.
            if (objekUser.CekUsernameTerdaftar(txtUsername.Text.Trim()))
            {
                MessageBox.Show("Username sudah digunakan, gunakan nama lain.", "Registrasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 5. MENYALIN DATA KE ATRIBUT PROPERTI OBJEK KELAS
            // Memindahkan teks bersih dari form ke dalam variabel penampung sementara di memori RAM milik objek user.
            objekUser.Username = txtUsername.Text.Trim();
            objekUser.Password = txtPassword.Text.Trim();
            objekUser.Role = cmbRoleDaftar.SelectedItem.ToString(); // Mengubah pilihan ComboBox menjadi string teks murni (.ToString).

            // 6. MENJALANKAN KUERI SQL TULIS DATA BARU
            // Menembakkan kueri INSERT 'RegistrasiUserBaru()' agar akun kasir/admin tersimpan mutlak permanen di database MySQL XAMPP.
            if (objekUser.Registrasiuserbaru())
            {
                // Tampilkan kotak sukses bertanda centang biru (.Information) jika data berhasil masuk tabel database.
                MessageBox.Show("User Baru berhasil terdaftar di dalam sistem!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Membersihkan isi kotak teks kode rahasia agar kosong kembali setelah pendaftaran selesai
                txtKodeRegistrasi.Clear();
            }
        }
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Menutup total seluruh background process aplikasi saat tombol X silang ditekan langsung
            Application.Exit();
        }

    }
}