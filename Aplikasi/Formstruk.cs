using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Mengimpor pustaka Drawing untuk menggambar teks struk (Font, Warna, Koordinat)
using System.Drawing;
// Mengimpor pustaka Printing untuk mengaktifkan sistem mesin cetak dokumen printer Windows
using System.Drawing.Printing;

namespace Aplikasi
{
    public partial class Formstruk : Form
    {
        //Mendeklarasikan objek komponen mesin cetak bawaan Windows Forms
        private PrintDocument prntDoc = new PrintDocument();

        //Variabel penampung kiriman data nota dari Form Transaksi
        private string notaID;
        private string namaKasir;
        private decimal totalBiaya;
        private DataTable detailBelanja;
        // Menerima operan data transaksi dari Form Sebelah pas objek struk ini dibuat
        public Formstruk(string idNota, string kasir, decimal total, DataTable keranjang)
        {
            InitializeComponent();

            // Memindahkan data operan masuk ke variabel internal form struk
            this.notaID = idNota;
            this.namaKasir = kasir;
            this.totalBiaya = total;
            this.detailBelanja = keranjang;

            // Mengaitkan mesin cetak dengan Event Handler proses penggambaran teks struk
            prntDoc.PrintPage += new PrintPageEventHandler(GambarlayoutStruk);

            // Menyambungkan mesin cetak ke dalam komponen visual layar struk (PrintPreviewControl)
            ppcStruk.Document = prntDoc;
        }
        // FUNGSI UTAMA: Menggambar desain struk belanja nota termal secara digital baris demi baris
        private void GambarlayoutStruk(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics; // Objek g bertindak sebagai "Pena/Kuas Digital" untuk menggambar di kertas struk

            // Menyiapkan ukuran dan jenis huruf (Font) yang biasa dipakai printer struk thermal kasir
            Font fontJudul = new Font("Courier New", 12, FontStyle.Bold);
            Font fontRegular = new Font("Courier New", 9, FontStyle.Regular);
            Font fontBold = new Font("Courier New", 9, FontStyle.Bold);

            // Mengatur koordinat batas kiri pembukuan (X) dan titik awal tinggi baris atas (Y)
            float x = 10;
            float y = 10;
            float jarakBaris = 18; // Jarak lompatan spasi baris ke bawah (Line Spacing)

            // Menggambar teks judul nama toko (Koordinat X, Y)
            g.DrawString("      TOKO BUKU KITA      ", fontJudul, Brushes.Black, x, y);
            y += jarakBaris + 5; // Lompat ke baris bawahnya
            g.DrawString("==========================", fontRegular, Brushes.Black, x, y);
            y += jarakBaris;

            // Menggambar data header nota (Nomor ID Nota transaksi dan Nama Kasir bertugas)
            g.DrawString("No Nota : " + notaID, fontRegular, Brushes.Black, x, y);
            y += jarakBaris;
            g.DrawString("Kasir   : " + namaKasir, fontRegular, Brushes.Black, x, y);
            y += jarakBaris;
            g.DrawString("Tanggal : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fontRegular, Brushes.Black, x, y);
            y += jarakBaris;
            g.DrawString("--------------------------", fontRegular, Brushes.Black, x, y);
            y += jarakBaris;

            // MELAKUKAN LOOPING: Membakar seluruh baris barang yang terjual dari isi keranjang belanja
            foreach (DataRow row in detailBelanja.Rows)
            {
                string judulBuku = row["Judul"].ToString();
                // Memotong judul buku jika terlalu panjang agar tidak bablas keluar dari kertas struk kasir
                if (judulBuku.Length > 25) judulBuku = judulBuku.Substring(0, 22) + "...";

                int qty = Convert.ToInt32(row["Jumlah"]);
                decimal harga = Convert.ToDecimal(row["Harga"]);
                decimal sub = Convert.ToDecimal(row["Subtotal"]);

                // Baris A: Gambar Nama Judul Buku yang dibeli konsumen
                g.DrawString(judulBuku, fontRegular, Brushes.Black, x, y);
                y += jarakBaris;

                // Baris B: Gambar Rincian Perkalian Harga Kuantitas (Contoh: 2 x 50,000    Rp100,000)
                g.DrawString($"  {qty} x {harga:N0}", fontRegular, Brushes.Black, x, y);
                // Menggambar subtotal agak bergeser ke kanan (koordinat X ditambah 160) agar lurus rapi di ujung kertas
                g.DrawString($"Rp.{sub:N0}", fontRegular, Brushes.Black, x + 160, y);
                y += jarakBaris;
            }

            // Menggambar footer penutup total pembayaran nota belanja kasir
            g.DrawString("--------------------------", fontRegular, Brushes.Black, x, y);
            y += jarakBaris;
            g.DrawString("GRAND TOTAL :", fontBold, Brushes.Black, x, y);
            g.DrawString($"Rp.{totalBiaya:N0}", fontBold, Brushes.Black, x + 160, y);
            y += jarakBaris + 10;

            g.DrawString("   Terima Kasih Banyak   ", fontRegular, Brushes.Black, x, y);
            y += jarakBaris;
            g.DrawString(" Silakan Datang Kembali  ", fontRegular, Brushes.Black, x, y);
        }
    

        private void Formstruk_Load(object sender, EventArgs e)
        {

        }
    }
}
