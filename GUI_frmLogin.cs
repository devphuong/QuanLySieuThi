using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLySieuThi;
using BUS_QuanLySieuThi;

namespace GUI_QuanLySieuThi
{
    public partial class GUI_frmLogin : Form
    {
        BUS_QLTaiKhoan busTK = new BUS_QLTaiKhoan();
        public GUI_frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_QLTaiKhoan tk = new DTO_QLTaiKhoan(txtTaiKhoan.Text, txtMatKhau.Text);
                busTK.getQLTaiKhoan();
                if (busTK.loginTaiKhoan(tk))
                {
                    GUI_frmCashier cs = new GUI_frmCashier(txtTaiKhoan.Text);
                    this.Hide();
                    cs.Show();
                    cs.DangXuat += Cs_DangXuat;
                }
                else
                    MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu! Hãy đăng nhập lại", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void Cs_DangXuat(object sender, EventArgs e)
        {
            (sender as GUI_frmCashier).isThoat = false;
            (sender as GUI_frmCashier).Close();
            this.Show();
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
