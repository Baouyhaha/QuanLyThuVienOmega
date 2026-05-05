using LibraryManagerDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerDAL
{
    public class ThongKeDAL
    {
        public DataTable ThongKeTop10Sach()
        {
            // Chỉ cần gọi tên Stored Procedure, cực kỳ an toàn và bảo mật
            string sql = "EXEC sp_ThongKeTop10SachMuon";
            return DbHelper.getTable(sql);
        }
    }
}
