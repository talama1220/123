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
    public partial class Mh_Timkiem : Form
    {
        public Mh_Timkiem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var N = text1.Text;
            int kt = -1;
            for (int i = 0; i < Program.A.Count; i++)
            {
                if (string.Compare(Program.A[i].tl, N, true) == 0)
                {
                    kt = kt + 1;
                    ListViewItem chuoilon = new ListViewItem(Program.A[i].ma);
                    ListViewItem.ListViewSubItem nho1 = new
                        ListViewItem.ListViewSubItem(chuoilon, Program.A[i].ten);
                    ListViewItem.ListViewSubItem nho2 = new
                        ListViewItem.ListViewSubItem(chuoilon, Program.A[i].nxb);
                    ListViewItem.ListViewSubItem nho3 = new
                        ListViewItem.ListViewSubItem(chuoilon, $"{Program.A[i].gia}");
                    ListViewItem.ListViewSubItem nho4 = new
                        ListViewItem.ListViewSubItem(chuoilon, $"{Program.A[i].namxb}");
                    ListViewItem.ListViewSubItem nho5 = new
                        ListViewItem.ListViewSubItem(chuoilon, Program.A[i].tl);
                    chuoilon.SubItems.Add(nho1);
                    chuoilon.SubItems.Add(nho2);
                    chuoilon.SubItems.Add(nho3);
                    chuoilon.SubItems.Add(nho4);
                    chuoilon.SubItems.Add(nho5);
                    ghichu.Items.Add(chuoilon);
                }
            }
            if (kt < 0)
            {
                Th_Ghichu.Text = "Không tìm thấy sách thể loại " + N;
            }
        }

        private void text1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Th_Ghichu_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ghichu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
