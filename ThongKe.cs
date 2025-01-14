﻿using System;
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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }


        private void btnDoanhThuDate_Click_1(object sender, EventArgs e)
        {
            DanhThuTheoBang dttb = new DanhThuTheoBang();
            this.Visible = false;
            dttb.ShowDialog();
            this.Visible = true;
        }

        private void btnDoanhThuChart_Click_1(object sender, EventArgs e)
        {
            BieuDoCot bdc = new BieuDoCot();
            this.Visible = false;
            bdc.ShowDialog();
            this.Visible = true;
        }

        private void btnTiLeBanHang_Click_1(object sender, EventArgs e)
        {
            TiLeBanHang tlbh = new TiLeBanHang();
            this.Visible = false;
            tlbh.ShowDialog();
            this.Visible = true;
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
