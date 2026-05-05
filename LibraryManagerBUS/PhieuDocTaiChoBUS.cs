using LibraryManagerDAL;
using LibraryManagerDTO;
using System;
using System.Data;

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
            // 1. Kiểm tra rỗng đầu vào
            if (string.IsNullOrWhiteSpace(phieu.Cccd) || string.IsNullOrWhiteSpace(phieu.maBanSao) || string.IsNullOrWhiteSpace(phieu.tenNguoiDoc))
            {
                return "Vui lòng điền đủ Số CCCD, Họ tên và Quét mã sách!";
            }

            SachDAL dalSach = new SachDAL();

            // 2. Kiểm tra trạng thái sách từ DAL
            int tinhTrang = dalSach.KiemTraTrangThaiSach(phieu.maBanSao);

            if (tinhTrang == -1)
                return "Lỗi: Mã bản sao sách không tồn tại trong hệ thống!";

            // ĐÃ FIX: Chặn cả trạng thái 1 (Đang mượn) và 2 (Đã đăng ký)[cite: 1]
            if (tinhTrang == 1)
                return "Lỗi: Cuốn sách này hiện đang có người mượn, không thể đọc tại chỗ!";

            if (tinhTrang == 2)
                return "Lỗi: Cuốn sách này đã được độc giả khác đăng ký giữ chỗ!";

            // 3. Khởi tạo dữ liệu phiếu
            phieu.maPhieu = SinhMaPhieuMoi();
            phieu.trangThai = 1;

            // 4. Lưu xuống CSDL
            if (dal.ThemPhieuMoi(phieu))
            {
                // ĐÃ MỞ COMMENT: Bắt buộc phải cập nhật trạng thái sách thành 1 (Đang mượn)[cite: 1]
                // để hệ thống biết cuốn này đang được khách đọc tại chỗ, không cho người khác mượn nữa.
                dalSach.CapNhatTrangThai(phieu.maBanSao, 1);
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
        public DataTable LayDanhSachHienTai()
        {
            // BUS chỉ đóng vai trò gọi DAL và trả dữ liệu về cho GUI
            return dal.LayDanhSachHienTai();
        }
    }
}