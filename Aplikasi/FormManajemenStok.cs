using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aplikasi
{
    public partial class FormManajemenStok : Form
    {
        
        public FormManajemenStok()
        {
            InitializeComponent();
            MuatTabelBuku();
            dgvBukuGudang.CellFormatting += dgvBukuGudang_CellFormatting;
        }

        private void MuatTabelBuku()
        {
            using (MySqlConnection conn = Koneksi.Getkoneksi())
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT id_buku, kode_buku, judul, stok FROM books", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBukuGudang.DataSource = dt;
            }
        }

        private void dgvBukuGudang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvBukuGudang.Columns[e.ColumnIndex].Name.ToLower() == "stok" && e.Value != null)
            {
                int kuantitas = Convert.ToInt32(e.Value);
                if (kuantitas <= 5) // Low Stock Alert
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                }
            }
        }

        private void btnSimpanStok_Click(object sender, EventArgs e)
        {
            // 1. Validasi apakah ada baris data yang dipilih di DataGridView
            if (dgvBukuGudang.CurrentRow == null)
            {
                MessageBox.Show("Silakan pilih buku yang akan ditambah stoknya terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validasi apakah input jumlah stok masih kosong atau hanya spasi
            if (string.IsNullOrWhiteSpace(textSimpanStok.Text))
            {
                MessageBox.Show("Jumlah stok tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textSimpanStok.Focus(); // Mengarahkan kursor kembali ke text box
                return;
            }
            int idBuku = Convert.ToInt32(dgvBukuGudang.CurrentRow.Cells["id_buku"].Value);
            string judulBuku = dgvBukuGudang.CurrentRow.Cells["judul"].Value.ToString();
            int kuantitasTambahan = Convert.ToInt32(textSimpanStok.Text);

            using (MySqlConnection conn = Koneksi.Getkoneksi())
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string qUpdate = "UPDATE books SET stok = stok + @tambah WHERE id_buku = @id";
                using (MySqlCommand cmd = new MySqlCommand(qUpdate, conn))
                {
                    cmd.Parameters.AddWithValue("@tambah", kuantitasTambahan);
                    cmd.Parameters.AddWithValue("@id", idBuku);
                    cmd.ExecuteNonQuery();
                }

                string qLog = "INSERT INTO audit_logs (tanggal, aktivitas, detail_perubahan, id_user) VALUES (NOW(), 'RESTOCK', @detail, @user)";
                using (MySqlCommand cmdL = new MySqlCommand(qLog, conn))
                {
                    cmdL.Parameters.AddWithValue("@detail", $"Admin [{Program.UsernameAktif}] menambahkan pasokan stok {kuantitasTambahan} pcs pada buku: {judulBuku}");
                    cmdL.Parameters.AddWithValue("@user", Program.IDUserAktif);
                    cmdL.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Stok Gudang Berhasil Ditambahkan!", "Informasi");
            MuatTabelBuku();
        }

        private void FormManajemenStok_Load(object sender, EventArgs e)
        {
            
        }
        
        
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Menutup total seluruh background process aplikasi saat tombol X silang ditekan langsung
            Application.Exit();
        }
    }
}



