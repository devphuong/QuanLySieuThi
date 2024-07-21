using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace GUI_QuanLySieuThi
{
    public partial class BieuDoCot : Form
    {
        public BieuDoCot()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-66PNN2C\SQLEXPRESS;Initial Catalog=QLSieuThiMini;Integrated Security=True;");
        KetNoiDuLieu kn = new KetNoiDuLieu();

        private void BieuDoCot_Load(object sender, EventArgs e)
        {
            kn.opendata();
            string sql = "select * from SANPHAM";
            CmbLoaiSP.DataSource = kn.taobang(sql);
            CmbLoaiSP.DisplayMember = "MASP";
        }

        private void btnLoaiSP_Click(object sender, EventArgs e)
        {
            // Số lượng
            SqlDataAdapter da = new SqlDataAdapter("select masp, sum(SOLUONG) as SL from cthd where masp='" + CmbLoaiSP.Text + "' group by masp", con);
            DataTable dt2 = new DataTable();
            da.Fill(dt2);
            chart1.DataSource = dt2;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "MÃ SẢN PHẨM";
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "TỔNG SỐ LƯỢNG";

            chart1.Series["SoLuong"].XValueMember = "masp";
            chart1.Series["SoLuong"].YValueMembers = "SL";

            // Tổng tiền

            SqlDataAdapter da1 = new SqlDataAdapter("select masp, sum(THANHTIEN) as TONGTIEN from cthd where masp='" + CmbLoaiSP.Text + "' group by masp", con);
            DataTable dt3 = new DataTable();
            da1.Fill(dt3);
            chart2.DataSource = dt3;
            chart2.ChartAreas["ChartArea1"].AxisX.Title = "MÃ SẢN PHẨM";
            chart2.ChartAreas["ChartArea1"].AxisX.Title = "TỔNG SỐ TIỀN";

            chart2.Series["VND"].XValueMember = "masp";
            chart2.Series["VND"].YValueMembers = "TONGTIEN";
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select masp, sum(SOLUONG) as SL from cthd group by masp", con);
            DataTable dt2 = new DataTable();
            da.Fill(dt2);
            chart1.DataSource = dt2;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "MÃ SẢN PHẨM";
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "TỔNG SỐ LƯỢNG";

            chart1.Series["SoLuong"].XValueMember = "masp";
            chart1.Series["SoLuong"].YValueMembers = "SL";

            SqlDataAdapter da1 = new SqlDataAdapter("select masp, sum(THANHTIEN) as TONGTIEN from cthd group by masp", con);
            DataTable dt3 = new DataTable();
            da1.Fill(dt3);
            chart2.DataSource = dt3;
            chart2.ChartAreas["ChartArea1"].AxisX.Title = "MÃ SẢN PHẨM";
            chart2.ChartAreas["ChartArea1"].AxisX.Title = "TỔNG SỐ TIỀN";

            chart2.Series["VND"].XValueMember = "masp";
            chart2.Series["VND"].YValueMembers = "TONGTIEN";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            string date = txtYear.Text + "-" + txtMonth.Text + "-" + txtDay.Text;
            if (kiemtrangay())
            {
                SqlDataAdapter da = new SqlDataAdapter("select HOADON.tensp, sum(SOLUONG) as SL, HOADON.NGLAPHD from CTHD, HOADON where CTHD.SOHD = HOADON.SOHD and HOADON.NGLAPHD='" + date + "' group by HOADON.tensp, HOADON.NGLAPHD", con);
                DataTable dt2 = new DataTable();
                da.Fill(dt2);
                chart1.DataSource = dt2;
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "MÃ SẢN PHẨM";
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "TỔNG SỐ LƯỢNG";

                chart1.Series["SoLuong"].XValueMember = "tensp";
                chart1.Series["SoLuong"].YValueMembers = "SL";

                // Tổng tiền

                SqlDataAdapter da1 = new SqlDataAdapter("select hoadon.tensp, sum(THANHTIEN) as TONGTIEN, HOADON.NGLAPHD from cthd , HOADON where CTHD.SOHD = HOADON.SOHD and HOADON.NGLAPHD='" + date + "' group by HOADON.tensp, HOADON.NGLAPHD", con);
                DataTable dt3 = new DataTable();
                da1.Fill(dt3);
                chart2.DataSource = dt3;
                chart2.ChartAreas["ChartArea1"].AxisX.Title = "MÃ SẢN PHẨM";
                chart2.ChartAreas["ChartArea1"].AxisX.Title = "TỔNG SỐ TIỀN";

                chart2.Series["VND"].XValueMember = "tensp";
                chart2.Series["VND"].YValueMembers = "TONGTIEN";
            }
        }
        private bool kiemtrangay()
        {
            string date = txtYear.Text + "-" + txtMonth.Text + "-" + txtDay.Text;
            if (int.Parse(txtDay.Text) < 1 || int.Parse(txtDay.Text) > 31 || int.Parse(txtMonth.Text) > 12 || int.Parse(txtMonth.Text) < 1 || int.Parse(txtYear.Text) < 2000)
            {
                MessageBox.Show("Ngày tháng năm không hợp lệ!", "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
