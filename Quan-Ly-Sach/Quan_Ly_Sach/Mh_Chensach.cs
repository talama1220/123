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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n= int.Parse(text7.Text);
            DanhSach Book;
            Book.ma = text1.Text;
            Book.ten = text2.Text;
            Book.nxb = text3.Text;
            Book.gia = double.Parse(text4.Text);
            Book.namxb = int.Parse(text5.Text);
            Book.tl = text6.Text;
            if (n <= Program.A.Count)
            {
                Program.A.Insert(n - 1, Book);
                Th_Ghichu.Text = "Đã chèn thành công!";
            }
            else
            {
                Th_Ghichu.Text = "Không tìm thấy sách ở vị trí " + n;
            }
            
        }

        private void text7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void text6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void text5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void text4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void text3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void text2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Th_Ghichu_Click(object sender, EventArgs e)
        {

        }

        private void text1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
