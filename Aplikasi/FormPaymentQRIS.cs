using QRCoder;
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
    public partial class FormPaymentQRIS : Form
    {
        public decimal TotalTagihan { get; set; }
        public FormPaymentQRIS()
        {
            InitializeComponent();
        }
        private void FormPaymentQRIS_Load(object sender, EventArgs e)
        {
            // 1. Pengaturan Form agar rapi dan berada di tengah layar
            this.Text = "Form Pembayaran QRIS";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(350, 480); // Mengatur ukuran lebar dan tinggi form

            // 2. Pengaturan Label Tagihan di Bagian Atas Tengah
            lblTagihanQRIS.Text = "Tagihan QRIS: Rp " + TotalTagihan.ToString("N0");
            lblTagihanQRIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11, System.Drawing.FontStyle.Bold);
            lblTagihanQRIS.AutoSize = true;
            lblTagihanQRIS.Location = new System.Drawing.Point((this.ClientSize.Width - lblTagihanQRIS.Width) / 2, 20);

            // 3. Pengaturan PictureBox untuk Barcode QRIS di Tengah
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Size = new System.Drawing.Size(250, 250); // Ukuran kotak QR Code
            pictureBox1.Location = new System.Drawing.Point((this.ClientSize.Width - pictureBox1.Width) / 2, 60);

            // 4. Pengaturan Tombol Konfirmasi Pembayaran di Bawah QR Code
            btnSelesaiQRIS.Text = "Konfirmasi Pembayaran";
            btnSelesaiQRIS.Size = new System.Drawing.Size(200, 40);
            btnSelesaiQRIS.Location = new System.Drawing.Point((this.ClientSize.Width - btnSelesaiQRIS.Width) / 2, 330);

            // 5. Generate QR Code ke dalam PictureBox (Menggunakan library QRCoder)
            string qrisData = "https://example.com/pay?amount=" + TotalTagihan;
            using (QRCoder.QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator())
            {
                QRCoder.QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrisData, QRCoder.QRCodeGenerator.ECCLevel.Q);
                using (QRCoder.QRCode qrCode = new QRCoder.QRCode(qrCodeData))
                {
                    Bitmap qrCodeImage = qrCode.GetGraphic(20);
                    pictureBox1.Image = qrCodeImage;
                }
            }
        }

        private void btnSelesaiQRIS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menerima Sinyal Bank M-Banking Mandiri: Pembayaran QRIS Berhasil Disahkan!", "QRIS Lunas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lblTagihanQRIS_Click(object sender, EventArgs e)
        {

        }
    }
}

