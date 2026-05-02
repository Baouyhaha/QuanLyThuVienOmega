using LibraryManagerDAL;
using LibraryManagerDTO;
using System;

namespace LibraryManagerBUS
{
    public class PhieuDocTaiChoBUS
    {
        private PhieuDocTaiChoDAL dal = new PhieuDocTaiChoDAL();

        // Đã sửa: Xử lý cắt chuỗi từ mã phiếu lớn nhất trong DB
        public string SinhMaPhieuMoi()
        {
            // Định dạng: PDC-YYMMDD-XXX
            string prefix = "PDC-" + DateTime.Now.ToString("yyMMdd") + "-";
            string maMoiNhat = dal.LayMaPhieuMoiNhatTrongNgay(DateTime.Now);

            int sttMoi = 1;

            if (!string.IsNullOrEmpty(maMoiNhat))
            {
                // Lấy 3 ký tự cuối cùng của chuỗi mã (ví dụ "002" từ "PDC-240516-002")
                string soCuoi = maMoiNhat.Substring(maMoiNhat.Length - 3);
                if (int.TryParse(soCuoi, out int count))
                {
                    sttMoi = count + 1;
                }
            }

            return prefix + sttMoi.ToString("D3"); // Đảm bảo luôn có 3 chữ số (VD: 001, 015)
        }

        public string TaoPhieu(PhieuDocTaiCho phieu)
        {
            // ĐÃ SỬA CHỖ 1: Kiểm tra rỗng trên thuộc tính maBanSao thay vì maSach
            if (string.IsNullOrWhiteSpace(phieu.Cccd) || string.IsNullOrWhiteSpace(phieu.maBanSao) || string.IsNullOrWhiteSpace(phieu.tenNguoiDoc))
            {
                return "Vui lòng điền đủ Số CCCD, Họ tên và Quét mã sách!";
            }

            SachDAL dalSach = new SachDAL();

            // ĐÃ SỬA CHỖ 2: Truyền maBanSao vào hàm kiểm tra trạng thái
            int tinhTrang = dalSach.KiemTraTrangThaiSach(phieu.maBanSao);

            if (tinhTrang == -1)
                return "Lỗi: Mã bản sao sách không tồn tại trong hệ thống!";

            if (tinhTrang == 1)
                return "Lỗi: Cuốn sách này hiện đang có người mượn, không thể đọc tại chỗ!";

            phieu.maPhieu = SinhMaPhieuMoi();
            phieu.trangThai = 1;

            if (dal.ThemPhieuMoi(phieu))
            {
                // Có thể mở comment dòng dưới nếu em đã viết hàm cập nhật trạng thái sách trong SachDAL
                // dalSach.CapNhatTrangThai(phieu.maBanSao, 1); 
                return "SUCCESS";
            }

            return "Lỗi CSDL: Không thể tạo phiếu lúc này.";
        }

        public string KiemTraKhachVangLai(string cccd)
        {
            if (string.IsNullOrWhiteSpace(cccd) || cccd.Length != 12 || !long.TryParse(cccd, out _))
            {
                return "ERROR_FORMAT";
            }

            string tenKhach = dal.LayTenKhachTheoCCCD(cccd);

            if (tenKhach != null)
            {
                return tenKhach;
            }

            return "NEW_GUEST";
        }
    }
}