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
    public partial class FormManajemenStok : Form
    {
        
        public FormManajemenStok()
        {
            InitializeComponent();
        }

        private void FormManajemenStok_Load(object sender, EventArgs e)
        {
            
        }
        
        
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Menutup total seluruh background process aplikasi saat tombol X silang ditekan langsung
            Application.Exit();
        }
    }
}



