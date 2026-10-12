using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi
{
    public static class Program
    {
        public static int IDUserAktif = 0;
        public static string UsernameAktif = "";
        public static string RoleAktif = "";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 frmLogin = new Form1();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                if (Program.RoleAktif == "admin")
                {
                    Application.Run(new FormDashBoardAdmin());
                }
                else
                {
                    Application.Run(new FormDashboardKasir());
                }
            }
        }
    }
}
