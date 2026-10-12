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
        public decimal TotalTagihan { get; set; }
        public FormPaymentCash()
        {
            InitializeComponent();
        }
        private void FormPaymentCash_Load(object sender, EventArgs e)
        {
            lblTagihanCash.Text = "Tagihan Cash: Rp " + TotalTagihan.ToString("N0");
        }

        private void txtUangMasuk_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtUangMasuk.Text, out decimal uangDiberikan))
            {
                decimal kembalian = uangDiberikan - TotalTagihan;
                lblKembalian.Text = kembalian >= 0 ? "Rp " + kembalian.ToString("N0") : "Uang Tunai Kurang!";
            }
        }

        private void btnSelesaiCash_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtUangMasuk.Text, out decimal uangDiberikan) && uangDiberikan >= TotalTagihan)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else { MessageBox.Show("Nominal pembayaran uang tunai belum valid!", "Peringatan"); }
        }
    }
}
