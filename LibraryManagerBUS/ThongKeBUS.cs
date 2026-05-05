using LibraryManagerDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerBUS
{
    public class ThongKeBUS
    {
        private ThongKeDAL dal = new ThongKeDAL();

        

        public DataTable ThongKeTop10Sach()
        {
            return dal.ThongKeTop10Sach();
        }
    }
}
