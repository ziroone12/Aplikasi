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
    public partial class FormPaymentCash : Form
    {
        public decimal NominalUangMasuk { get; set; }
        public decimal TotalTagihan { get; set; }
        private bool sudahDihitung = false;
        public FormPaymentCash()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }
        private void FormPaymentCash_Load(object sender, EventArgs e)
        {
            lblTagihanCash.Text = "Rp " + TotalTagihan.ToString("N0");
            lblKembalian.Text = "Rp 0";
            sudahDihitung = false;
        }

        private void txtUangMasuk_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtUangMasuk.Text, out decimal uangDiberikan))
            {
                decimal kembalian = uangDiberikan - TotalTagihan;
                lblKembalian.Text = kembalian >= 0 ? "Rp " + kembalian.ToString("N0") : "Uang Tunai Kurang!";
            }
        }
        private void btnHitung_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUangMasuk.Text))
            {
                MessageBox.Show("Harap masukkan nominal uang tunai yang diberikan pembeli!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi inputan wajib berupa angka desimal
            if (decimal.TryParse(txtUangMasuk.Text, out decimal uangDiberikan))
            {
                decimal kembalian = uangDiberikan - TotalTagihan;

                if (kembalian >= 0)
                {
                    // Tampilkan nominal kembalian riil ke monitor kasir
                    lblKembalian.Text = "Rp " + kembalian.ToString("N0");
                    sudahDihitung = true; // Buka kunci pengaman gerbang struk
                }
                else
                {
                    lblKembalian.Text = "Uang Tunai Kurang!";
                    sudahDihitung = false; // Kunci kembali gerbang struk
                    MessageBox.Show("Nominal uang tunai yang dimasukkan kurang dari total tagihan!", "Transaksi Ditolak", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Harap masukkan inputan nominal uang berupa angka bulat valid saja!", "Error Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSelesaiCash_Click(object sender, EventArgs e)
        {
            if (!sudahDihitung)
            {
                MessageBox.Show("Harap klik tombol 'HITUNG KEMBALIAN' terlebih dahulu sebelum memproses cetak nota!", "Otorisasi Dicekal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.NominalUangMasuk = Convert.ToDecimal(txtUangMasuk.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
