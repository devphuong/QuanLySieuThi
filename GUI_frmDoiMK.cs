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
    public partial class GUI_frmDoiMK : Form
    {
        BUS_QLTaiKhoan busTK = new BUS_QLTaiKhoan();
        public GUI_frmDoiMK()
        {
            InitializeComponent();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            DTO_QLTaiKhoan mkcu = new DTO_QLTaiKhoan(txtTenTK.Text, txtNhapMKCu.Text);
            busTK.getQLTaiKhoan();
            if (busTK.loginTaiKhoan(mkcu))
            {
                DTO_QLTaiKhoan mkmoi = new DTO_QLTaiKhoan(txtTenTK.Text, txtNhapMKMoi.Text);
                busTK.getQLTaiKhoan();
                if (busTK.suaTaiKhoan(mkmoi))
                {
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại!", "Thông báo");
                    ClearTextBox();
                }

            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai mật khẩu hoặc tên tài khoản! Hãy nhập lại.", "Thông báo");
                ClearTextBox();
            }
        }

        private void ClearTextBox()
        {
            txtTenTK.Clear();
            txtNhapMKCu.Clear();
            txtNhapMKMoi.Clear();
            txtNhapLaiMKMoi.Clear();
        }
    }
}
