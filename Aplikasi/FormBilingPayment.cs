using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aplikasi
{
    public partial class FormBilingPayment : Form
    {
        public decimal TotalTagihanMaster { get; set; }
        
        public string MetodeDipilih { get; set; } = "CASH";
        
        public decimal UangDiterima { get; set; }
        public decimal NominalUangMasuk { get; set; }
        private bool sudahDihitung = false;



        public FormBilingPayment()
        {
            InitializeComponent();
        }
        private void FormBillingPayment_Load(object sender, EventArgs e)
        {
            lblTotalMaster.Text = "Rp " + TotalTagihanMaster.ToString("N0");
            cmbMetode.Items.Clear();
            cmbMetode.Items.Add("CASH");
            cmbMetode.Items.Add("QRIS");
            cmbMetode.Items.Add("TRANSFER");
            cmbMetode.SelectedIndex = 0;
        }

        private void btnLanjut_Click(object sender, EventArgs e)
        {
            if (cmbMetode.SelectedItem == null) return;
            // Simpan teks metode yang dipilih kasir (CASH/QRIS/TRANSFER) ke variabel global
            MetodeDipilih = cmbMetode.SelectedItem.ToString().ToUpper();

            if (MetodeDipilih == "CASH")
            {
                FormPaymentCash frmCash = new FormPaymentCash() { TotalTagihan = TotalTagihanMaster };
                if (frmCash.ShowDialog() == DialogResult.OK)
                {
                    // AMBIL NILAI RIIL DARI TEXTBOX FORM CASH SEBELUM CLOSE
                    this.UangDiterima = frmCash.NominalUangMasuk; // Garis merah sembuh total!
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }

            else if (MetodeDipilih == "QRIS")
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
