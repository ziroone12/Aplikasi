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
            lblTagihanQRIS.Text = "Tagihan QRIS: Rp " + TotalTagihan.ToString("N0");
        }

        private void btnSelesaiQRIS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menerima Sinyal Bank M-Banking Mandiri: Pembayaran QRIS Berhasil Disahkan!", "QRIS Lunas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

