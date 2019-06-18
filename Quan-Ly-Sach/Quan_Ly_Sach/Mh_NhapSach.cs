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
    public partial class Mh_NhapSach : Form
    {
        public Mh_NhapSach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DanhSach Book;
            Book.ma = Text1.Text;
            Book.ten = Text2.Text;
            Book.nxb = Text3.Text;
            Book.gia = double.Parse(Text4.Text);
            Book.namxb = int.Parse(Text5.Text);
            Book.tl = Text6.Text;
            Program.A.Add(Book);
            Th_Ghichu.Text = "Đã lưu thành công!";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Th_Ghichu_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
