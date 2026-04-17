using LibraryManagerDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerBUS
{
    public class NhaPhatHanhBUS
    {
        private NhaPhatHanhDAL nxbDAL = new NhaPhatHanhDAL();

        public DataTable LayDanhSachNXB()
        {
            return nxbDAL.LayDanhSachNXB();
        }
    }
}
