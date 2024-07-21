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
    public partial class GUI_frmCashier : Form
    {
        public string strNhan;
        BUS_QLTaiKhoan busData = new BUS_QLTaiKhoan();
        public GUI_frmCashier()
        {
            InitializeComponent();
        }
        //Đăng xuất
        public bool isThoat = true;
        public event EventHandler DangXuat;
        private void btnDongCa_Click_1(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn đóng ca?", "Thông báo", MessageBoxButtons.YesNo);
            if (tb == DialogResult.Yes)
                DangXuat(this, new EventArgs()); 
        }

        public GUI_frmCashier(string giatrinhan) : this()
        {
            strNhan = giatrinhan;
            lblNhanVien.Text = strNhan;
            if (strNhan.StartsWith("quanly"))
                lblTenTK.Text = "QUẢN LÝ - Quản lý";
            else
            {
                string tk = strNhan.Replace("@gmail.com", "");
                string tk2 = tk.Replace("thungan", "");
                lblTenTK.Text = "THU NGÂN " + tk2 + " - Thu ngân";
            }
            //Mã Ca
            Random rand = new Random();
            int i = rand.Next();
            lblMaCa.Text = i + RandomString(10, false);
            string maca = lblMaCa.Text;
            //Giờ mở ca
            lblGioMoCa.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            if (lblTenTK.Text == "QUẢN LÝ - Quản lý")
            {
                lbldsnv.Visible = true;
            }    
            else
                lbldsnv.Visible = false;
        }
        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder sb = new StringBuilder();
            char c;
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                c = Convert.ToChar(Convert.ToInt32(rand.Next(65, 87)));
                sb.Append(c);
            }
            if (lowerCase)
            {
                return sb.ToString().ToLower();
            }
            return sb.ToString();
        }

        private void lblChiTietCa_Click(object sender, EventArgs e)
        {
            GUI_frmChiTietCa ctc = new GUI_frmChiTietCa(lblMaCa.Text);
            ctc.ShowDialog();
        }

        private void lblDoiMatKhau_Click(object sender, EventArgs e)
        {
            GUI_frmDoiMK dmk = new GUI_frmDoiMK();
            dmk.ShowDialog();
        }

        private void GUI_frmCashier_Load(object sender, EventArgs e)
        {
            //get data vào listview
            DataTable dt = new DataTable();
            dt = busData.GetData();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem item = new ListViewItem(dr[0].ToString());
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, dt.Rows[i][0].ToString());
                item.SubItems.Add(dr[1].ToString());
                item.SubItems.Add(dr[2].ToString());
                item.SubItems.Add(dr[3].ToString());
                item.SubItems.Add(dr[4].ToString());
                item.SubItems.Add(dr[5].ToString());
                item.SubItems.Add(subitem);
                lsvHoaDon.Items.Add(item);
            }
            lsvHoaDon.View = View.Details;
            lsvHoaDon.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsvHoaDon.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void lbldsnv_Click(object sender, EventArgs e)
        {
            QLNV f = new QLNV();
            f.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ThongKe tk = new ThongKe();
            this.Visible = false;
            tk.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_BanHang bh = new frm_BanHang();
            this.Visible = false;
            bh.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NhapHang nh = new NhapHang();
            this.Visible = false;
            nh.ShowDialog();
            this.Visible = true;
        }
    }
}
