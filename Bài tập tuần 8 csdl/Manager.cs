using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_tập_tuần_8_csdl
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void chứcNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            sinhvien sss = new sinhvien();
            sss.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            Khoa k = new Khoa();
            k.Show();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            Monhoc mh = new Monhoc();
            mh.Show();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            Nhapdiem n = new Nhapdiem();
            n.Show();
        }

        private void toolStripLabel6_Click(object sender, EventArgs e)
        {
            xemdiem xd = new xemdiem();
            xd.Show();
        }

        private void toolStripLabel7_Click(object sender, EventArgs e)
        {
            xemsvtheokhoa sdd = new xemsvtheokhoa();
            sdd.Show();
        }

        private void toolStripLabel8_Click(object sender, EventArgs e)
        {
           Close();
        }
    }
}
