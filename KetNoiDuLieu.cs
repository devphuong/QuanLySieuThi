using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GUI_QuanLySieuThi
{
    internal class KetNoiDuLieu
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-66PNN2C\SQLEXPRESS;Initial Catalog=QLSieuThiMini;Integrated Security=True;");

        public void opendata()
        {
            con.Open();
        }
        public void closedata()
        {
            con.Close();
        }
        public DataTable taobang(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter ds = new SqlDataAdapter(sql, con);
            ds.Fill(dt);
            return (dt);
        }
    }
}
