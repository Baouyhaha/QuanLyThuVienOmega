using LibraryManagerDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerDAL
{
    public class NhaPhatHanhDAL
    {
            // Tạo đối tượng DbHelper
            private DbHelper dbHelper = new DbHelper();

            public DataTable LayDanhSachNXB()
            {
                // Lấy Mã và Tên từ bảng nhaphathanh
                string sql = "SELECT maNhaPhatHanh, tenNhaPhatHanh FROM nhaphathanh";
            return dbHelper.getTable(sql);
            }
    }
}
