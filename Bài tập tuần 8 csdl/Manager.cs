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
            IsMdiContainer = true;
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
            foreach (var item in this.MdiChildren)
            {
                if(item.Name == "sinhvien")
                {
                    item.Activate();
                    return;
                }
            }
            var formSinhVien =  new sinhvien();
            formSinhVien.MdiParent = this;
            formSinhVien.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                if (item.Name == "Khoa")
                {
                    item.Activate();
                    return;
                }
            }
            var form = new Khoa();
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                if (item.Name.ToLower() == "monhoc")
                {
                    item.Activate();
                    return;
                }
            }
            var form = new Monhoc();
            form.MdiParent = this;
            form.Show();
           
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                if (item.Name.ToLower() == "nhapdiem")
                {
                    item.Activate();
                    return;
                }
            }
            var form = new Nhapdiem();
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripLabel6_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                if (item.Name.ToLower() == "xemdiem")
                {
                    item.Activate();
                    return;
                }
            }
            var form = new xemdiem();
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripLabel7_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                if (item.Name.ToLower() == "xemsvtheokhoa")
                {
                    item.Activate();
                    return;
                }
            }
            var form = new xemsvtheokhoa();
            form.MdiParent = this;
            form.Show();
        }

        private void toolStripLabel8_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
