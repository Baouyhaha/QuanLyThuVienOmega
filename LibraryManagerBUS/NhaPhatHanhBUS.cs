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
        NhaPhatHanhDAL nphDAL = new NhaPhatHanhDAL();

        public DataTable LayDanhSachNXB() => nphDAL.GetAll();

        public int LayHoacTaoMaNXB(string tenNXB)
        {
            object id = nphDAL.GetIdByName(tenNXB);
            if (id != null) 
            {
                return System.Convert.ToInt32(id); // Đã có thì trả về mã
            }
            return nphDAL.InsertAndGetId(tenNXB); // Chưa có thì tạo mới và trả về mã vừa tạo
        }
    }
}
