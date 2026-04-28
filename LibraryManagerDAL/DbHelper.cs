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
        public static DataTable getTable(string sql, SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = getConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    // Nếu có tham số (dùng cho tìm kiếm LIKE) thì add vào đây
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                // Bạn có thể dùng MessageBox ở đây để soi lỗi nếu cần
                throw new Exception("Lỗi chi tiết từ SQL: " + ex.Message);
            }
            return dt;
        }


        // Hàm thực thi lệnh (Dành cho INSERT, UPDATE, DELETE)
        public static bool executeNonQuery(string sql) // Dùng cho các câu lệnh không có tham số
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
        public static bool executeNonQuery(string sql, SqlParameter[] parameters)// Dùng cho các câu lệnh có tham số
        {
            try
            {
                using (SqlConnection conn = getConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    // Nếu có truyền tham số vào thì add nó vào Command
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

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
