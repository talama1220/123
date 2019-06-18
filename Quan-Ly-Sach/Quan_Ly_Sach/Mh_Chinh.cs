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
    public partial class Mh_Chinh : Form
    {
        public Mh_Chinh()
        {
            InitializeComponent();
        }

        private void Mh_Chinh_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Mh = new Mh_NhapSach();
            Mh.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Mh = new Form2();
            Mh.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Mh = new Mh_XoaSach();
            Mh.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var Mh = new Mh_Capnhat();
            Mh.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var Mh = new Form3();
            Mh.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var Mh = new Mh_Timkiem();
            Mh.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var Mh = new Mh_TimKiemTen();
            Mh.ShowDialog();
        }
    }
}
