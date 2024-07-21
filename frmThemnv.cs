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
namespace GUI_QuanLySieuThi
{
    public partial class frmThemnv : Form
    {
        public frmThemnv()
        {
            InitializeComponent();
        }
        string link = @"Data Source = DESKTOP-66PNN2C\SQLEXPRESS; Initial Catalog = QLSieuThiMini; Integrated Security = true";
        private void frmThemnv_Load(object sender, EventArgs e)
        {

        }
        private bool kiemtra()
        {
            SqlConnection conn = new SqlConnection(link);
            string sql ="select count(*) from NHANVIEN where MANV='"+txtmnv.Text+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            int count = 0;
            count = (int)cmd.ExecuteScalar();
                if (count >0)
                    {    
                     MessageBox.Show("Mã nhân viên đã có trong danh sách", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     txtmnv.Focus();
                    return false;
                    }
            
           
                if (txtmnv.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);   
                    txtmnv.Focus();
                    return false;
                }
                if (txthoten.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập họ tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txthoten.Focus();
                    return false;
                }
                
                return true;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            { 

                DateTime a = Convert.ToDateTime(dtpnsinh.Value.ToString());
                DateTime b = Convert.ToDateTime(dtpngvl.Value.ToString());
                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                
                SqlConnection conn = new SqlConnection(link);
                try
                 {

                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "themnv";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MNV", SqlDbType.Char).Value = txtmnv.Text;
                    cmd.Parameters.Add("@HTEN", SqlDbType.NVarChar).Value = txthoten.Text;
                    cmd.Parameters.Add("@Gtinh", SqlDbType.Char).Value = txtgt.Text;
                    cmd.Parameters.Add("@Nsinh", SqlDbType.DateTime).Value = a;
                    cmd.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = txtsdt.Text;
                    cmd.Parameters.Add("@NGVL", SqlDbType.DateTime).Value = b;
                    cmd.Parameters.Add("@Cvu", SqlDbType.NVarChar).Value = txtcv.Text;
                    cmd.Parameters.Add("@Dchi", SqlDbType.NVarChar).Value = txtdchi.Text;
                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                //da.Fill(dt);
                    conn.Close();
                    MessageBox.Show(" them thanh cong");
                    this.Close();
                    QLNV f = new QLNV();


                 }
                 catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

            }
        }
    }
}
