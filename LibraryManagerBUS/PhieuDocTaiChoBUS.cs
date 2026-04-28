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
            if (string.IsNullOrWhiteSpace(phieu.Cccd) || string.IsNullOrWhiteSpace(phieu.maSach))
            {
                return "Vui lòng điền đủ Số CCCD, Họ tên và Quét mã sách!";
            }

            // KHAI BÁO THÊM ĐỐI TƯỢNG SACH DAL Ở ĐÂY ĐỂ TRÁNH LỖI DALSACH
            SachDAL dalSach = new SachDAL();

            // 2. KIỂM TRA TRẠNG THÁI SÁCH (Sử dụng dalSach vừa khai báo)
            int tinhTrang = dalSach.KiemTraTrangThaiSach(phieu.maSach);

            if (tinhTrang == -1)
                return "Lỗi: Mã bản sao sách không tồn tại trong hệ thống!";

            if (tinhTrang == 1)
                return "Lỗi: Cuốn sách này hiện đang có người mượn, không thể đọc tại chỗ!";

            // 3. NẾU SÁCH SẴN SÀNG (tinhTrang == 0), TIẾN HÀNH TẠO PHIẾU
            phieu.maPhieu = SinhMaPhieuMoi();
            phieu.trangThai = 1;

            // Dùng biến 'dal' (đã có sẵn ở đầu class) để thêm phiếu
            if (dal.ThemPhieuMoi(phieu))
            {
                // Có thể mở comment dòng dưới nếu em đã viết hàm cập nhật trạng thái sách trong SachDAL
                // dalSach.CapNhatTrangThai(phieu.maSach, 1); 
                return "SUCCESS";
            }

            return "Lỗi CSDL: Không thể tạo phiếu lúc này.";
        }


        public string KiemTraKhachVangLai(string cccd)
        {
            // 1. Kiểm tra định dạng (phải đủ 12 số)
            if (string.IsNullOrWhiteSpace(cccd) || cccd.Length != 12 || !long.TryParse(cccd, out _))
            {
                return "ERROR_FORMAT";
            }

            // 2. Gọi DAL để tìm tên
            string tenKhach = dal.LayTenKhachTheoCCCD(cccd);

            if (tenKhach != null)
            {
                return tenKhach; // Trả về tên khách cũ
            }

            return "NEW_GUEST"; // Đánh dấu là khách mới
        }
    }
}
