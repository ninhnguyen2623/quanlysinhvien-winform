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
    public partial class xemdiem : Form
    {
        public xemdiem()
        {
            InitializeComponent();
        }

        private void xemdiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLySinhVienDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.quanLySinhVienDataSet.SinhVien);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // lấy chuỗi connectionstring từ app.config
                string conn = global::Bài_tập_tuần_8_csdl.Properties.Settings.Default.QuanLySinhVienConnectionString;
                string str;
                // truy vấn lấy điểm các môn học của SV có mã số được chọn
                str = string.Format("Select TenMH, Diem From KetQua,Mon where [KetQua].MaMH = [Mon].MaH AND MaSo = {0}", comboBox1.Text);
                SqlDataAdapter da = new SqlDataAdapter(str, conn);
                DataSet ds = new DataSet();
                // đổ vào dataset
                da.Fill(ds);
                // hiển thị ra DataGridView
                dataGridView1.DataSource = ds.Tables[0];
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
