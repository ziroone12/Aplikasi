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
    public partial class FormBilingPayment : Form
    {
        public decimal TotalTagihanMaster { get; set; }
        public FormBilingPayment()
        {
            InitializeComponent();
        }
        private void FormBillingPayment_Load(object sender, EventArgs e)
        {
            lblTotalMaster.Text = "Rp " + TotalTagihanMaster.ToString("N0");
        }

        private void btnLanjut_Click(object sender, EventArgs e)
        {
            if (cmbMetode.SelectedItem == null) return;
            string metode = cmbMetode.SelectedItem.ToString().ToUpper();

            if (metode == "CASH")
            {
                FormPaymentCash frmCash = new FormPaymentCash() { TotalTagihan = TotalTagihanMaster };
                if (frmCash.ShowDialog() == DialogResult.OK) { this.DialogResult = DialogResult.OK; this.Close(); }
            }
            else if (metode == "QRIS")
            {
                FormPaymentQRIS frmQRIS = new FormPaymentQRIS() { TotalTagihan = TotalTagihanMaster };
                if (frmQRIS.ShowDialog() == DialogResult.OK) { this.DialogResult = DialogResult.OK; this.Close(); }
            }
            else
            {
                FormPaymentTransfer frmTransfer = new FormPaymentTransfer();
                if (frmTransfer.ShowDialog() == DialogResult.OK) { this.DialogResult = DialogResult.OK; this.Close(); }
            }
        }
    }
}
