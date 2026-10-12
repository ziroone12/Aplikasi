using MySql.Data.MySqlClient;
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
    public partial class dashkasir : Form
    {
        public dashkasir()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            // Tautkan event load ke fungsi penarik data database yang sah
            this.Load += new EventHandler(dashkasir_Load);
        }
        private void dashkasir_Load(object sender, EventArgs e)
        {
            MuatJurnalPasokanGudang();
        }

        // 3. FUNGSI LOGIKA: Menarik khusus aktivitas barang masuk, restock, dan edit buku dari tabel audit log
        public void MuatJurnalPasokanGudang()
        {
            using (MySqlConnection conn = Koneksi.Getkoneksi())
            {
                try
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    // KUERI SELEKTIF: Menyaring khusus data aktivitas gudang (RESTOCK, TAMBAH BUKU, EDIT BUKU)
                    string queryFilter = @"
                        SELECT al.tanggal AS `Tanggal Pembaruan`, 
                               al.aktivitas AS `Aktivitas Gudang`, 
                               al.detail_perubahan AS `Rincian Perubahan Data Produk Fisik`, 
                               u.username AS `Admin Pengubah`
                        FROM audit_logs al
                        INNER JOIN users u ON al.id_user = u.id_user
                        WHERE al.aktivitas IN ('RESTOCK', 'TAMBAH BUKU', 'EDIT BUKU')
                        ORDER BY al.tanggal DESC 
                        LIMIT 30"; // Membatasi maksimal 30 rekam jejak barang masuk harian

                    using (MySqlDataAdapter da = new MySqlDataAdapter(queryFilter, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Menumpahkan data dari database MySQL ke komponen visual DataGridView milik kasir
                        // Catatan: Pastikan nama DataGridView di desainer kamu bernama dgvRiwayatPasokan atau sesuaikan ID-nya
                        dgvRiwayatPasokan.DataSource = dt;

                        // Kunci Elastisitas Kolom: Mengatur lebar kolom otomatis agar teks terlihat utuh seluruhnya
                        dgvRiwayatPasokan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat jurnal riwayat pasokan barang: " + ex.Message, "Error Jaringan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
