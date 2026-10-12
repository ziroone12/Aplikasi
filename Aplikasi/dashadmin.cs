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
    public partial class dashadmin : Form
    {
        public dashadmin()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormLogAudit_Load);

        }
        private void FormLogAudit_Load(object sender, EventArgs e)
        {
            MuatSeluruhRiwayatSistemToko();
        }

        // FUNGSI LOGIKA: Menggabungkan riwayat penjualan & log audit menggunakan teknik SQL UNION ALL
        public void MuatSeluruhRiwayatSistemToko()
        {
            using (MySqlConnection conn = Koneksi.Getkoneksi())
            {
                try
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    // KUERI TINGKAT TINGGI: Menyatukan data operasional dari tabel transactions dan audit_logs
                    string queryPusat = @"
                        SELECT t.tanggal AS `Waktu Operasional`, 
                               'PENJUALAN NOTA' AS `Jenis Aktivitas`, 
                               CONCAT('Transaksi Berhasil, Total Belanja: Rp ', FORMAT(t.total_harga, 0)) AS `Keterangan Detail`, 
                               u.username AS `Aktor Pelaksana`
                        FROM transactions t
                        INNER JOIN users u ON t.id_user = u.id_user
                        
                        UNION ALL
                        
                        SELECT al.tanggal AS `Waktu Operasional`, 
                               al.aktivitas AS `Jenis Aktivitas`, 
                               al.detail_perubahan AS `Keterangan Detail`, 
                               u.username AS `Aktor Pelaksana`
                        FROM audit_logs al
                        INNER JOIN users u ON al.id_user = u.id_user
                        
                        ORDER BY `Waktu Operasional` DESC 
                        LIMIT 30"; // Menampilkan hingga 30 rekor aktivitas digital terbaru toko buku

                    using (MySqlDataAdapter da = new MySqlDataAdapter(queryPusat, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Menumpahkan hasil gabungan database ke DataGridView raksasa
                        dgvRiwayatSistem.DataSource = dt;
                        dgvRiwayatSistem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat papan monitor audit harian: " + ex.Message, "Error Jaringan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
