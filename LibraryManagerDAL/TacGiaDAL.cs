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
        public DataTable GetAll()
        {
            string sql = "SELECT * FROM tacgia";
            return DbHelper.getTable(sql);
        }

    }
}
