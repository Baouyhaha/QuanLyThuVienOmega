using LibraryManagerDAL;
using LibraryManagerDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerBUS
{
    public class NguoiMuonBUS
    {
        private NguoiMuonDAL dal = new NguoiMuonDAL();

        public DataTable LayThongTinHoSo(string tenTaiKhoan)
        {
            return dal.LayThongTinHoSo(tenTaiKhoan);
        }

        // Hàm cầu nối lấy thông tin thẻ
        public DataTable LayThongTinThe(string maNguoiMuon)
        {
            // Chuyền bóng từ DAL lên GUI
            return dal.LayThongTinThe(maNguoiMuon);
        }
        public bool GuiYeuCauKichHoat(string tenTaiKhoan)
        {
            return dal.GuiYeuCauKichHoat(tenTaiKhoan);
        }
    }
}
