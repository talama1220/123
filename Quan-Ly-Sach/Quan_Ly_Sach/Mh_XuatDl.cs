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
    public partial class Form3 : Form
    {
        static void Xuatlabel(String X)
        {
           
        }

        public Form3()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            for (int i = 0; i < Program.A.Count; i++)
            {
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

