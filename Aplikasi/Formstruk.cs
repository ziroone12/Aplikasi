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
        private PrintDocument prntDoc = new PrintDocument();
        private string notaID, namaKasir, jenisMetode;
        private decimal totalBiaya, tunaiDibayar, uangKembalian;
        private DataTable detailBelanja;
        public Formstruk(string idnota, string kasir, decimal total, DataTable keranjang, decimal tunai, decimal kembali, string metode)
        {
            InitializeComponent();
            this.notaID = idnota;
            this.namaKasir = kasir;
            this.totalBiaya = total;
            this.detailBelanja = keranjang;
            this.tunaiDibayar = tunai;
            this.uangKembalian = kembali;
            this.jenisMetode = metode; // Menyimpan info metode (CASH/QRIS/TRANSFER)

            // Kunci ukuran kertas melar ramping thermal standar kasir 58mm
            PaperSize ukuranKertasStruk = new PaperSize("StrukThermal58mm", 250, 600);
            prntDoc.DefaultPageSettings.PaperSize = ukuranKertasStruk;

            prntDoc.PrintPage += new PrintPageEventHandler(GambarlayoutStruk);
            ppcStruk.Document = prntDoc;

            ppcStruk.AutoZoom = false;
            ppcStruk.Zoom = 1.0;

        }
        //// FUNGSI UTAMA: Menggambar desain struk belanja nota termal secara digital baris demi baris
        private void GambarlayoutStruk(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fontJudul = new Font("Courier New", 11, FontStyle.Bold);
            Font fontRegular = new Font("Courier New", 8, FontStyle.Regular);
            float x = 10; float y = 10; float jrk = 14;

            // 1. Bagian Header Struk
            g.DrawString("      TOKO BUKU KITA      ", fontJudul, Brushes.Black, x, y); y += jrk + 5;
            g.DrawString("==========================", fontRegular, Brushes.Black, x, y); y += jrk;
            g.DrawString("No Nota : " + notaID, fontRegular, Brushes.Black, x, y); y += jrk;
            g.DrawString("Kasir   : " + namaKasir, fontRegular, Brushes.Black, x, y); y += jrk;
            g.DrawString("Tanggal : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fontRegular, Brushes.Black, x, y); y += jrk;
            g.DrawString("--------------------------", fontRegular, Brushes.Black, x, y); y += jrk;

            // 2. Looping Rincian Barang Belanjaan dari DataTable POS
            foreach (DataRow row in detailBelanja.Rows)
            {
                string judul = row["Judul Buku"].ToString();
                if (judul.Length > 20) judul = judul.Substring(0, 18) + "..";
                int qty = Convert.ToInt32(row["Jumlah"]);
                decimal sub = Convert.ToDecimal(row["Subtotal"]);

                g.DrawString(judul, fontRegular, Brushes.Black, x, y); y += jrk;
                g.DrawString($"  {qty} x Rp.{Convert.ToDecimal(row["Harga Satuan"]):N0}", fontRegular, Brushes.Black, x, y);
                g.DrawString($"Rp.{sub:N0}", fontRegular, Brushes.Black, x + 160, y); y += jrk;
            }

            // 3. Bagian Footer Struk, Total Belanja, & Informasi Pembayaran Lengkap
            g.DrawString("--------------------------", fontRegular, Brushes.Black, x, y); y += jrk;

            g.DrawString("GRAND TOTAL :", fontJudul, Brushes.Black, x, y);
            g.DrawString($"Rp.{totalBiaya:N0}", fontJudul, Brushes.Black, x + 140, y); y += jrk + 5;
            g.DrawString("--------------------------", fontRegular, Brushes.Black, x, y); y += jrk;

            // REVISI PENAMBAHAN TULISAN METODE BAYAR RIIL PROFESIONAL:
            g.DrawString("METODE BAYAR:", fontRegular, Brushes.Black, x, y);
            g.DrawString(jenisMetode, fontRegular, Brushes.Black, x + 160, y); y += jrk;

            g.DrawString("TUNAI       :", fontRegular, Brushes.Black, x, y);
            g.DrawString($"Rp.{tunaiDibayar:N0}", fontRegular, Brushes.Black, x + 160, y); y += jrk;

            g.DrawString("KEMBALIAN   :", fontRegular, Brushes.Black, x, y);
            g.DrawString($"Rp.{uangKembalian:N0}", fontRegular, Brushes.Black, x + 160, y); y += jrk + 15;

            g.DrawString("   Terima Kasih Banyak   ", fontRegular, Brushes.Black, x, y); y += jrk;
            g.DrawString(" Buku yang Dibeli Tidak  ", fontRegular, Brushes.Black, x, y); y += jrk;
            g.DrawString("  Dapat Ditukar/Dikembalikan ", fontRegular, Brushes.Black, x, y);
        
        }
    

        private void Formstruk_Load(object sender, EventArgs e)
        {

        }
    }
}
