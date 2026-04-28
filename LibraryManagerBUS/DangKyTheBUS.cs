using LibraryManagerDAL;
using LibraryManagerDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerBUS
{
    public class DangKyTheBUS
    {
        private DangKyTheDAL dal = new DangKyTheDAL();

        public string XuLyDangKy(DangKyTheDTO khach)
        {
            // 1. Kiểm tra không được để trống thông tin bắt buộc
            if (string.IsNullOrWhiteSpace(khach.HoTen) ||
                string.IsNullOrWhiteSpace(khach.Sdt) ||
                string.IsNullOrWhiteSpace(khach.MaDinhDanh))
            {
                return "Vui lòng nhập đầy đủ Họ tên, Số điện thoại và MSSV/CCCD!";
            }

            // 2. Kiểm tra Số điện thoại (chỉ nhận số, khoảng 10 số)
            if (khach.Sdt.Length < 10 || !long.TryParse(khach.Sdt, out _))
            {
                return "Số điện thoại không hợp lệ!";
            }

            // 3. Đẩy xuống DAL để lưu vào Database
            if (dal.GuiYeuCauDangKy(khach))
            {
                return "SUCCESS";
            }
            return "Hệ thống đang bận, không thể gửi yêu cầu đăng ký lúc này.";
        }
    }
}
