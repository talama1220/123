using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Sach
{
    public struct DanhSach
        {
            public string ma;
            public string ten;
            public string nxb;
            public double gia;
            public int namxb;
            public string tl;
        }
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static List<DanhSach> A = new List<DanhSach>();
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Mh_Chinh());
            
        }
    }
}
