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
    public partial class QLNV : Form
    {
        string link = @"Data Source = DESKTOP-66PNN2C\SQLEXPRESS; Initial Catalog = QLSieuThiMini; Integrated Security = true";
        public QLNV()
        {
            InitializeComponent();
        }

        

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            frmThemnv f = new frmThemnv();
            f.Show();
        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            loadnv();
            dtgdsnv.Columns["TThai"].Visible = false;
        }
        public void loadnv()
        {
           
            SqlConnection conn = new SqlConnection(link);
            conn.Open();
            //SqlCommand selectall = new SqlCommand("select * from NhanVien", connect);
            //selectall.BeginExecuteNonQuery
            //SqlDataReader datareader = selectall.ExecuteReader();
            //while (datareader.Read())
            //{

            //}
            //connect.Close();
            string sqlcm = "select * from NHANVIEN where TThai = 1";
            SqlCommand cmd = new SqlCommand(sqlcm, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            dtgdsnv.DataSource = dt;
        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            loadnv();
        }

        private void btnxoanv_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(link);

                conn.Open();
                for (int i = 0; i < dtgdsnv.SelectedRows.Count; i++)
                {
                    //if (row.Cells["check"].Value.ToString() == 1)


                    string id = dtgdsnv.SelectedRows[i].Cells["MANV"].Value.ToString();


                    string sqlcm = "update NHANVIEN set TThai = 0 where MANV='" + id + "'";


                    // cmd.CommandText = "xoanvien";
                    // cmd.CommandType = CommandType.StoredProcedure;
                    // cmd.Parameters.Add("@manv", SqlDbType.Char).Value = "'"+id+"'";
                    //cmd.Connection = conn;
                    SqlCommand cmd = new SqlCommand(sqlcm, conn);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Đã xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loadnv();


                }


                conn.Close();


                //Reset();

            }

            catch (Exception ex)
            //var s = dataGridView1.SelectedRows[0].Cells["MANV"].Value.ToString();
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnsuattnv_Click(object sender, EventArgs e)
        {

        }

        private void dtgdsnv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgdsnv.SelectedRows.Count > 0)
            {

                int rowindex = dtgdsnv.CurrentCell.RowIndex;
                string manv = dtgdsnv.Rows[rowindex].Cells["MANV"].Value.ToString();
                string hoten = dtgdsnv.Rows[rowindex].Cells["HOTEN"].Value.ToString();
                string gioitinh = dtgdsnv.Rows[rowindex].Cells["GTINH"].Value.ToString();
                DateTime ngaysinh = DateTime.Parse(dtgdsnv.Rows[rowindex].Cells["NGSINH"].Value.ToString());
                string sodt = dtgdsnv.Rows[rowindex].Cells["SODT"].Value.ToString();
                DateTime ngvaolam = DateTime.Parse(dtgdsnv.Rows[rowindex].Cells["NGVL"].Value.ToString());
                string cvu = dtgdsnv.Rows[rowindex].Cells["CHUCVU"].Value.ToString();
                string dchi = dtgdsnv.Rows[rowindex].Cells["DCHI"].Value.ToString();
                string comm = string.Format("update NHANVIEN set  HOTEN=N'{0}',GTINH='{1}',NGSINH= '{2}',SODT=N'{3}',NGVL='{4}',CHUCVU=N'{5}',DCHI=N'{6}' where MANV = '{7}'", hoten, gioitinh, ngaysinh.ToString("yyyy-MM-dd HH:mm:ss:fff"), sodt, ngvaolam.ToString("yyyy-MM-dd HH:mm:ss:fff"), cvu, dchi, manv);
                SqlConnection conn = new SqlConnection(link);
                conn.Open();
                SqlCommand cmd = new SqlCommand(comm, conn);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Sua thanh cong");
                conn.Close();

            }
        }

        private void btnexportexcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Microsoft Excel|*.xls";
            // sv.AddExtension = true;
            // sv.RestoreDirectory = true;

            if (sv.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                export(dtgdsnv, sv.FileName);
            }
        }
        private void export(DataGridView dataGridView1, string fileName)
        {

            {

                //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
                Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

                Microsoft.Office.Interop.Excel.Application excel;
                Microsoft.Office.Interop.Excel.Workbook workbook;
                Microsoft.Office.Interop.Excel.Worksheet worksheet;
                try
                {
                    //Tạo đối tượng COM.
                    excel = new Microsoft.Office.Interop.Excel.Application();
                    excel.Visible = false;
                    excel.DisplayAlerts = false;
                    //tạo mới một Workbooks bằng phương thức add()
                    workbook = excel.Workbooks.Add(Type.Missing);
                    worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                    //đặt tên cho sheet
                    worksheet.Name = "Danh sách sinh viên";

                    // export header trong DataGridView
                    for (int i = 0; i < dataGridView1.ColumnCount - 1; i++)
                    {
                        worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                    }
                    // export nội dung trong DataGridView
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        for (int j = 0; j < dataGridView1.ColumnCount - 1; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    worksheet.Columns.AutoFit();
                    // sử dụng phương thức SaveAs() để lưu workbook với filename
                    workbook.SaveAs(fileName);
                    //đóng workbook
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string sqlcmall ="";
            //SqlCommand selectall = new SqlCommand("select * from NhanVien", connect);
            //selectall.BeginExecuteNonQuery
            //SqlDataReader datareader = selectall.ExecuteReader();
            //while (datareader.Read())
            //{
            if (textBox1.Text == "")
            {
                sqlcmall = "select * from NHANVIEN where TThai = 1";
            }    
            //}
            //connect.Close();
            else
                sqlcmall = "select * from NHANVIEN where MANV like '"+textBox1.Text+ "%' and TThai = 1 ";
            SqlConnection conn = new SqlConnection(link);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlcmall, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            dtgdsnv.DataSource = dt;
        }
    }
   
   

}
