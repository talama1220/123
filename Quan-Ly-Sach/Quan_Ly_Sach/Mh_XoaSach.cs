using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Sach
{
    public partial class Mh_XoaSach : Form
    {
        public Mh_XoaSach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(text1.Text);
            if (n <= Program.A.Count)
            {
                Program.A.Remove(Program.A[n - 1]);
                Th_Ghichu.Text = "Đã xóa thành công!";
            }
            else
            {
                Th_Ghichu.Text = "Không tìm thấy sách ở vị trí " + n;
            }
        }

        private void text1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Th_Ghichu_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
