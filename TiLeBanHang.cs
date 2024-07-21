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
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI_QuanLySieuThi
{
    public partial class TiLeBanHang : Form
    {
        public TiLeBanHang()
        {
            InitializeComponent();
        }

        private void TiLeBanHang_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-66PNN2C\SQLEXPRESS;Initial Catalog=QLSieuThiMini;Integrated Security=True;");
            SqlDataAdapter adapter = new SqlDataAdapter("select tensp,sum(soluong) as SL from cthd group by tensp", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            chart1.DataSource = dt;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tên Sản Phẩm";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Tổng Số Lượng";

            chart1.Series["Series1"].XValueMember = "TENSP";
            chart1.Series["Series1"].YValueMembers = "SL";
            chart1.Series["Series1"].ChartType = SeriesChartType.Pie;
        }
    }
}
