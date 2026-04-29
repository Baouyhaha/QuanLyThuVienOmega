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

        public DataTable GetTopSachHot(int soLuongTop = 10)
        {
            try
            {
                if (soLuongTop <= 0)
                    throw new Exception("Số lượng thống kê phải lớn hơn 0.");

                return dal.LayTopSachMuonNhieuNhat(soLuongTop);
            }
            catch (Exception ex)
            {
                // Bắt lỗi từ DAL hoặc lỗi logic và ném lên GUI
                throw new Exception("Lỗi nghiệp vụ thống kê: " + ex.Message);
            }
        }
    }
}
