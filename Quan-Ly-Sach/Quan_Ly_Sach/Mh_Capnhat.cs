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
    public partial class Mh_Capnhat : Form
    {
        public Mh_Capnhat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(text7.Text);
            DanhSach Book;
            Book.ma = text1.Text;
            Book.ten = text2.Text;
            Book.nxb = text3.Text;
            Book.gia = double.Parse(text4.Text);
            Book.namxb = int.Parse(text5.Text);
            Book.tl = text6.Text;
            if (n <= Program.A.Count)
            {
                Program.A.Remove(Program.A[n - 1]);
                
                Program.A.Insert(n - 1, Book);
                Th_Ghichu.Text = "Đã cập nhật thành công!";
            }
            else
            {
                Th_Ghichu.Text = "Không tìm thấy sách ở vị trí " + n;
            }

            
        }
    }
}
