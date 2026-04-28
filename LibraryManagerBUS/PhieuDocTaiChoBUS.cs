using LibraryManagerDAL;
using LibraryManagerDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerBUS
{
    public class PhieuDocTaiChoBUS
    {
        private PhieuDocTaiChoDAL dal = new PhieuDocTaiChoDAL();

        // Logic sinh mã thông minh reset theo ngày của em
        public string SinhMaPhieuMoi()
        {
            // Định dạng: PDC-YYMMDD-XXX
            string prefix = "PDC-" + DateTime.Now.ToString("yyMMdd") + "-";
            int count = dal.LaySoPhieuTrongNgay(DateTime.Now); // Đếm số phiếu của ngày hôm nay

            int sttMoi = count + 1;
            return prefix + sttMoi.ToString("D3"); // VD: PDC-240516-001
        }

        public string TaoPhieu(PhieuDocTaiCho phieu)
        {
            // 1. Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(phieu.Cccd) ||
                string.IsNullOrWhiteSpace(phieu.tenNguoiDoc) ||
                string.IsNullOrWhiteSpace(phieu.maSach))
            {
                return "Vui lòng điền đủ Số CCCD, Họ tên và Quét mã sách!";
            }

            // 2. Gán các thông tin tự động
            phieu.maPhieu = SinhMaPhieuMoi();
            phieu.trangThai = 1; // 1: Đang mượn đọc tại chỗ

            // 3. Đẩy xuống DAL
            if (dal.ThemPhieuMoi(phieu))
            {
                return "SUCCESS";
            }
            return "Lỗi CSDL: Không thể tạo phiếu lúc này.";
        }
    }
}
