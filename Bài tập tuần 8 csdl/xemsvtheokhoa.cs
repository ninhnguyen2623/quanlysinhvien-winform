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
    public partial class xemsvtheokhoa : Form
    {
        public xemsvtheokhoa()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xemsvtheokhoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLySinhVienDataSet.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.quanLySinhVienDataSet.Khoa);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // lấy chuỗi connectionstring từ app.config
                string conn = global::Bài_tập_tuần_8_csdl.Properties.Settings.Default.QuanLySinhVienConnectionString;
                string str;
                // truy vấn lấy điểm các môn học của SV có mã số được chọn
                str = string.Format("SELECT T2.* From Khoa T1 JOIN SinhVien T2 ON T1.MaKhoa = T2.MaKhoa WHERE  T1.MaKhoa = '{0}';", comboBox1.Text.Trim());
                SqlDataAdapter da = new SqlDataAdapter(str, conn);
                DataSet ds = new DataSet();
                // đổ vào dataset
                da.Fill(ds);
                // hiển thị ra DataGridView
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
