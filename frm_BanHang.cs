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
    public partial class frm_BanHang : Form
    {
        string strDuongDan = @"D:\Ôn Tập IT\Đồ án APP Window\Đồ án_28_6\From_Gia_Bao\WinFormsApp5\TRASUA";
        string _chuoiKetNoi = @"Data Source=DESKTOP-66PNN2C\SQLEXPRESS;Initial Catalog=QLSieuThiMini;Integrated Security=true;";

        int _dem = 0;
        string _maHD;
        string _maNV = "NV01";
        string _maKH = "KH01";
        string _maSP;
        string _tenSP;
        string _soLuong;
        string _Gia;
        float _tongTien = 0;
        string _ngaylapHD;
        private float _tongtien;
        public frm_BanHang()
        {
            InitializeComponent();
        }

        private void dgvDSSP2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _maSP = dgvDSSP2.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (e.ColumnIndex == 0 && !string.IsNullOrEmpty(_maSP))
            {
                _tenSP = dgvDSSP2.Rows[e.RowIndex].Cells[2].Value.ToString();
                _Gia = dgvDSSP2.Rows[e.RowIndex].Cells[5].Value.ToString();
                MessageBox.Show("Đã chọn " + dgvDSSP2.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lvwDSSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThemSP1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_maSP))
            {
                _soLuong = numericUpDownSL1.Value.ToString();
                ListViewItem item = new ListViewItem(_maSP);
                item.SubItems.Add(_tenSP);
                item.SubItems.Add(_soLuong);
                item.SubItems.Add(_Gia);
                lvwDSSP2.Items.Add(item);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            _tongTien += float.Parse(_Gia) * float.Parse(_soLuong);
            lblTongTien.Text = _tongTien.ToString();
        }

        private void frm_BanHang_Load(object sender, EventArgs e)
        {
            dgvHDSP.DataSource = GetData("select * from HOADON");
            dgvDSSP2.DataSource = GetData("select masp, tensp, dvt, nhasx, gia from SANPHAM");
            _maHD = DateTime.Now.ToString("dMyyyy");
            _dem = CountQuery("select count(*) from HOADON where mahd like '" + _maHD + "%'");

            _dem++;

            _maHD += "00" + _dem;
            lblMaHoaDon.Text = _maHD;
            lblNgayLap.Text = DateTime.Now.ToString();
            lblNhanVienLapHD.Text = _maNV;
            lblTongTien.Text = _tongTien.ToString();
            _ngaylapHD = DateTime.Now.ToString();

            LoadDanhSachRau();
        }
        private DataTable GetData(string query)
        {
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            SqlConnection conn = new SqlConnection(_chuoiKetNoi);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            adapter.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
            return dt;
        }

        private int CountQuery(string query)
        {
            SqlConnection conn = new SqlConnection(_chuoiKetNoi);
            conn.Open();
            SqlCommand comm = new SqlCommand(query, conn);
            int countQuery = (int)comm.ExecuteScalar();
            conn.Close();
            return countQuery;
        }

        private void LoadDanhSachRau()
        {
            StreamReader sr = new StreamReader(strDuongDan + "\\DSRauCu.txt");
            String line;
            String[] splitter;
            while ((line = sr.ReadLine()) != null)
            {
                splitter = line.Split(',');
                ListViewItem lvi = new ListViewItem();
                //colimg + colmasp
                lvi.Text = splitter[0];               
                lvi.ImageKey = lvi.Text + ".png";
                //coltensp
                lvi.SubItems.Add(splitter[1]);
                

                lvwDSSP.Items.Add(lvi);
            }
            sr.Close();
        }

        private void btnLapHD_Click(object sender, EventArgs e)
        {
            string insertHD = string.Format("insert into HOADON values({0},getdate(),N'{2}','{3}',{4},N'{5}')", _maHD, _ngaylapHD, _maNV, _maKH, _tongTien, richTextBoxGhiChuHD.Text);
            SqlConnection sqlConnection = new SqlConnection(_chuoiKetNoi);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(insertHD, sqlConnection);
            int dem = cmd.ExecuteNonQuery();
            if (dem > 0)
            {
                MessageBox.Show("Thành công !");
            }
            sqlConnection.Close();

            dgvHDSP.DataSource = GetData("select * from HOADON");           
            dgvDSSP2.DataSource = GetData("select masp, tensp, dvt, nhasx, gia from SANPHAM");
            _maHD = DateTime.Now.ToString("dMyyyy");
            _dem = CountQuery("select count(*) from HOADON where mahd like '" + _maHD + "%'");

            _dem++;


            _maHD += "00" + _dem;
            lblMaHoaDon.Text = _maHD;
            lblNgayLap.Text = DateTime.Now.ToString();
            lblNhanVienLapHD.Text = _maNV;
            lblTongTien.Text = _tongTien.ToString();
            _ngaylapHD = DateTime.Now.ToString();



            _tongtien = 0;
            LoadDanhSachRau();
        }

        private void richTextBoxGhiChu_TextChanged(object sender, EventArgs e)
        {
            richTextBoxGhiChuHD.Text = richTextBoxGhiChu.Text;
        }
        private void tongtien()
        {
            for (int i = 0; i < lvwDSSP2.Items.Count; i++)
            {
                if (!string.IsNullOrEmpty(_Gia))
                {
                    _tongTien += float.Parse(_Gia) * float.Parse(_soLuong);
                    lblTongTien.Text = _tongTien.ToString();
                }
            }

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Microsoft Excel|*.xls";
           

            if (sv.ShowDialog() == DialogResult.OK)
            {
               
                export(dgvHDSP, sv.FileName);
            }
        }
        private void export(DataGridView dataGridView1, string fileName)
        {

            {

               
                Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

                Microsoft.Office.Interop.Excel.Application excel;
                Microsoft.Office.Interop.Excel.Workbook workbook;
                Microsoft.Office.Interop.Excel.Worksheet worksheet;
                try
                {
                    
                    excel = new Microsoft.Office.Interop.Excel.Application();
                    excel.Visible = false;
                    excel.DisplayAlerts = false;
                    
                    workbook = excel.Workbooks.Add(Type.Missing);
                    worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                    
                    worksheet.Name = "Danh sách sinh viên";

                   
                    for (int i = 0; i < dataGridView1.ColumnCount - 1; i++)
                    {
                        worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                    }
                    
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        for (int j = 0; j < dataGridView1.ColumnCount - 1; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    worksheet.Columns.AutoFit();
                    
                    workbook.SaveAs(fileName);
                    
                    workbook.Close();
                    excel.Quit();
                    MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    workbook = null;
                    worksheet = null;
                }
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvwDSSP2.Items.Count; i++)
            {
                if (lvwDSSP2.Items[i].Selected)
                {
                    lvwDSSP2.Items.RemoveAt(i);
                    _tongTien -= float.Parse(_Gia) * float.Parse(_soLuong);
                    lblTongTien.Text = _tongTien.ToString();
                }
            }

           
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
