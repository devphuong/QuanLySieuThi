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
using System.IO;

namespace GUI_QuanLySieuThi
{
    public partial class NhapHang : Form
    {
        string strNhapHang = @"D:\Ôn Tập IT\Đồ án APP Window\Đồ án_28_6\From_Gia_Bao\WinFormsApp5\TRASUA";
        public NhapHang()
        {
            InitializeComponent();
        }
        string chuoi = @"Data Source=DESKTOP-66PNN2C\SQLEXPRESS;Initial Catalog=QLSieuThiMini;Integrated Security=True;";
        private void NhapHang_Load(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "File text|*.txt";
            if (of.ShowDialog() == DialogResult.OK)
            {

                String path = System.IO.Path.GetDirectoryName(of.FileName);

                StreamReader sr = new StreamReader(of.FileName);
                string line = " ";
                while ((line = sr.ReadLine()) != null)
                {
                    string[] strInfo = line.Split(new char[] { ',' });
                    ListViewItem item = new ListViewItem(strInfo[0]);
                    item.SubItems.Add(strInfo[1]);
                    item.SubItems.Add(strInfo[2]);
                    item.SubItems.Add(strInfo[5]);
                    item.SubItems.Add(strInfo[3]);
                    item.SubItems.Add(strInfo[4]);

                    lvNhap.Items.Add(item);


                }
            }
        }

        private void tinhtien()
        {
            int tongtien = 0;
            for (int j = 0; j < dtXuat.RowCount; j++)
            {
                int tong = int.Parse(dtXuat.Rows[j].Cells[2].Value.ToString()) * int.Parse(dtXuat.Rows[j].Cells[5].Value.ToString());
                dtXuat.Rows[j].Cells[6].Value = tong.ToString();
            }
            for (int i = 0; i < dtXuat.RowCount; i++)
            {
                tongtien += int.Parse(dtXuat.Rows[i].Cells[6].Value.ToString());

            }
            textBox1.Text = tongtien.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (lvNhap.SelectedItems.Count > 0)
            {
                String a = lvNhap.SelectedItems[0].SubItems[0].Text;
                String dg = lvNhap.SelectedItems[0].SubItems[2].Text;
                string tensp = lvNhap.SelectedItems[0].SubItems[1].Text;
                String dv = lvNhap.SelectedItems[0].SubItems[5].Text;
                String nsx = lvNhap.SelectedItems[0].SubItems[4].Text;
                String sl = lvNhap.SelectedItems[0].SubItems[3].Text;
                object[] hehe = new object[] { a, tensp, dg, nsx, dv, sl };
                dtXuat.Rows.Add(hehe);
                tinhtien();
                foreach (ListViewItem lv in lvNhap.SelectedItems)
                {

                    lvNhap.Items.Remove(lv);

                }

            }
        }

        private void dtXuat_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            tinhtien();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtXuat.Rows.Count; i++)
            {

                try
                {
                    // int rowindex = dtXuat.CurrentCell.RowIndex;

                    string masp = dtXuat.Rows[i].Cells["MASP"].Value.ToString();
                    string tensp = dtXuat.Rows[i].Cells["TENSP"].Value.ToString();
                    string dv = dtXuat.Rows[i].Cells["DVT"].Value.ToString();

                    string nsx = dtXuat.Rows[i].Cells["NSX"].Value.ToString();

                    string gja = dtXuat.Rows[i].Cells["GIA"].Value.ToString();
                    int sl = int.Parse(dtXuat.Rows[i].Cells["SOLUONG"].Value.ToString());
                    string comm = string.Format("insert into  SANPHAM(MASP,TENSP,DVT,NHASX,GIA,SOLUONG) values( MASP='{0}',TENSP=N'{1}',DVT=N'{2}',NHASX=N'{3}',GIA='{4}',SOLUONG={5}) ", masp, tensp, dv, nsx, gja, sl);
                    string commm = string.Format("insert into  SANPHAM(MASP,TENSP,DVT,NHASX,GIA,SOLUONG) values('{0}',N'{1}',N'{2}',N'{3}',{4},{5})", masp, tensp, dv, nsx, gja, sl);
                    SqlConnection conn = new SqlConnection(chuoi);
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(commm, conn);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Nhap thanh cong");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
