using LibraryManagerDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerDAL
{
    public class TacGiaDAL
    {
        private DbHelper dbHelper = new DbHelper();

        public DataTable LayDanhSachTacGia()
        {
            string sql = "SELECT maTacGia, tenTacGia FROM tacgia";
            return DbHelper.getTable(sql);
        }
    }
}
