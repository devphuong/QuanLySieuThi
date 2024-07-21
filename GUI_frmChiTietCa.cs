using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLySieuThi;

namespace GUI_QuanLySieuThi
{
    public partial class GUI_frmChiTietCa : Form
    {
        public string strNhan;
        BUS_QLTaiKhoan busTotalHD = new BUS_QLTaiKhoan();
        public GUI_frmChiTietCa()
        {
            InitializeComponent();
        }
        public GUI_frmChiTietCa(string giatrinhan) : this()
        {
            strNhan = giatrinhan;
            lblMaCa.Text = strNhan;
        }
        private void lblQuayLai_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void GUI_frmChiTietCa_Load_1(object sender, EventArgs e)
        {
            lblSoHoaDon.Text = (busTotalHD.TotalHoaDon()).ToString();
            lblTBHoaDon.Text = (busTotalHD.AvgHoaDon()).ToString();
            lblDoanhThu.Text = (busTotalHD.TotalDoanhThu()).ToString();
        }
    }
}
