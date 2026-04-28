using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagerDAO;

namespace LibraryManagerDAL
{
    public class NhaPhatHanhDAL
    {
        // Lấy toàn bộ danh sách để nạp vào ComboBox
        public DataTable GetAll()
        {
            string sql = "SELECT * FROM nhaphathanh";
            return DbHelper.getTable(sql);
        }

        // Tìm ID dựa trên tên (dùng để kiểm tra xem NXB đã tồn tại chưa)
        public object GetIdByName(string tenNXB)
        {
            string sql = "SELECT maNhaPhatHanh FROM nhaphathanh WHERE tenNhaPhatHanh = @ten";
            SqlParameter[] pr = { new SqlParameter("@ten", tenNXB) };
            return DbHelper.executeScalar(sql, pr);
        }

        // Thêm mới NXB và trả về ID vừa tạo
        public int InsertAndGetId(string tenNXB)
        {
            string sql = "INSERT INTO nhaphathanh(tenNhaPhatHanh) VALUES(@ten); SELECT SCOPE_IDENTITY();";
            SqlParameter[] pr = { new SqlParameter("@ten", tenNXB) };
            return System.Convert.ToInt32(DbHelper.executeScalar(sql, pr));
        }
    }
}
