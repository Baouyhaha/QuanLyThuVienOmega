using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerDAO
{
    public class DbHelper
    {
        public static string strConn = @"Data Source=.;Initial Catalog=QuanLyThuVien;Integrated Security=True;";

        // Hàm mở kết nối
        public static SqlConnection getConnection()
        {
            return new SqlConnection(strConn);
        }

        // Hàm lấy dữ liệu (Dành cho câu lệnh SELECT)
        public static DataTable getTable(string sql)
        {
            using (SqlConnection conn = getConnection())
            {
                SqlDataAdapter adp = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                return dt;
            }
        }

        // Hàm thực thi lệnh (Dành cho INSERT, UPDATE, DELETE)
        public static bool executeNonQuery(string sql)
        {
            try
            {
                using (SqlConnection conn = getConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    int check = cmd.ExecuteNonQuery();
                    return check > 0;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
