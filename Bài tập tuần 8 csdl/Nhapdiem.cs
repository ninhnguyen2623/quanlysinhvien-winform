using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_tập_tuần_8_csdl
{
    public partial class Nhapdiem : Form
    {
        public Nhapdiem()
        {
            InitializeComponent();
        }

        private void Nhapdiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLySinhVienDataSet.Mon' table. You can move, or remove it, as needed.
            this.monTableAdapter.Fill(this.quanLySinhVienDataSet.Mon);
            // TODO: This line of code loads data into the 'quanLySinhVienDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.quanLySinhVienDataSet.SinhVien);


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Focus();
                return;
            }
            try
            {
                var diem = Convert.ToDecimal(textBox1.Text);
                if(diem > 10)
                {
                    MessageBox.Show("Điểm phải nhỏ hơn hoặc bằng 10", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                    textBox1.Text = "";
                    return;
                }
                string conn = global::Bài_tập_tuần_8_csdl.Properties.Settings.Default.QuanLySinhVienConnectionString;

                string str = string.Format("INSERT INTO \"QuanLySinhVien\".\"dbo\".\"KetQua\" (\"MaSo\", \"MaMH\", \"Diem\") VALUES ({0}, N'{1}', {2});", comboBox1.Text, comboBox3.Text, diem);
           
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                SqlCommand sqlCommand = new SqlCommand(str, con);


                if(sqlCommand.ExecuteNonQuery() != 0 )
                {
                    MessageBox.Show("Thêm Điểm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "";
                }
                con.Close();
            
            
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
