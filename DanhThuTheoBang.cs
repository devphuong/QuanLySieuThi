using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QuanLySieuThi
{
    public partial class DanhThuTheoBang : Form
    {
        public DanhThuTheoBang()
        {
            InitializeComponent();
        }
        KetNoiDuLieu kn = new KetNoiDuLieu();
        private void DanhThuTheoBang_Load(object sender, EventArgs e)
        {
            kn.opendata();
            string sql = "select * from SANPHAM";
            cmbMaSP.DataSource = kn.taobang(sql);
            cmbMaSP.DisplayMember = "MASP";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            kn.closedata();
        }

        private void cmbMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = "select * from SANPHAM where MASP='" + cmbMaSP.Text + "'";
            DataTable d = kn.taobang(s);
            foreach (DataRow hang in d.Rows)
            {
                txtTenSP.Text = hang["TENSP"].ToString();
            }

            string s1 = "select masp as 'Mã Sản Phẩm',tensp as 'Tên Sản Phẩm',dongia as 'Đơn Giá',soluong as 'Số Lượng', thanhtien as 'Thành Tiền' from cthd where masp='" + cmbMaSP.Text + "'";
            dtSP.DataSource = kn.taobang(s1);

            txtTongDon.Text = (dtSP.Rows.Count - 1).ToString();
            tongtien();
        }
        private void tongtien()
        {
            txtThanhTien.Text = "";
            float thanhtien = 0;

            for (int j = 0; j < dtSP.RowCount - 1; j++)
            {
                thanhtien += float.Parse(dtSP.Rows[j].Cells["Thành Tiền"].Value.ToString());
            }

            txtThanhTien.Text = thanhtien.ToString();
        }
    }
}
