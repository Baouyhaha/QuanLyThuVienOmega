using LibraryManagerDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerBUS
{
    public class TheMuonBUS
    {
        private TheMuonDAL theMuonDAL = new TheMuonDAL();

        public string PhatHanhThe(string tenTaiKhoan, bool laSinhVien, string mssv, string tienCocStr)
        {
            // 1. Validation (Bắt lỗi cơ bản)
            if (string.IsNullOrWhiteSpace(tenTaiKhoan))
                return "Vui lòng nhập Tên tài khoản!";

            int tienCoc = 0;
            if (laSinhVien)
            {
                if (string.IsNullOrWhiteSpace(mssv))
                    return "Vui lòng nhập MSSV cho sinh viên!";

                // ĐÂY CHÍNH LÀ ĐOẠN CODE BẮT LỖI CHIỀU DÀI ĐỂ KHÔNG BỊ VĂNG DATABASE
                if (mssv.Length > 8)
                    return "Lỗi: Mã số sinh viên không được vượt quá 8 ký tự!";
            }
            else
            {
                if (!int.TryParse(tienCocStr, out tienCoc) || tienCoc < 0)
                    return "Tiền cọc không hợp lệ (phải là số nguyên dương)!";
            }

            // 2. Tự động sinh mã (Mã Người Mượn và Mã Thẻ)
            // Cách sinh mã nhanh dùng thời gian thực 
            // Chỉ lấy Ngày(2) + Giờ(2) + Phút(2) + Giây(2) = 8 ký tự
            string timeStamp = DateTime.Now.ToString("ddHHmmss");
            string maNguoiMuon = "NM" + timeStamp;
            string maTheMuon = "TH" + timeStamp;

            // 3. Tính ngày hết hạn (Ví dụ: Thẻ mặc định có hạn 1 năm kể từ ngày cấp)
            DateTime ngayHetHan = DateTime.Now.AddYears(1);

            // 4. Gọi xuống DAL để thực thi
            try
            {
                bool result = theMuonDAL.PhatHanhTheMoi(tenTaiKhoan, mssv, tienCoc, maNguoiMuon, maTheMuon, ngayHetHan);
                if (result)
                    return "SUCCESS";
                return "Cấp thẻ thất bại do lỗi cơ sở dữ liệu.";
            }
            catch (Exception ex)
            {
                return ex.Message; // Bắt và hiển thị lỗi thay vì làm văng (crash) phần mềm
            }
        }

        public DataTable TimKiemThongTinThe(string maThe)
        {
            if (string.IsNullOrWhiteSpace(maThe))
                return null;
            return theMuonDAL.LayThongTinThe(maThe);
        }

        public string GiaHanThe(string maThe, DateTime ngayHetHanMoi)
        {
            if (string.IsNullOrWhiteSpace(maThe))
                return "Vui lòng tìm kiếm thẻ trước khi gia hạn!";

            if (ngayHetHanMoi <= DateTime.Now)
                return "Ngày gia hạn mới phải lớn hơn ngày hiện tại!";

            // Chuyển DateTime về chuỗi chuẩn MM/dd/yyyy (hoặc dd/MM/yyyy tùy CSDL của em)
            string ngayMoiStr = ngayHetHanMoi.ToString("MM/dd/yyyy");

            try
            {
                bool result = theMuonDAL.CapNhatNgayHetHan(maThe, ngayMoiStr);
                if (result) return "SUCCESS";
                return "Không tìm thấy thẻ để cập nhật!";
            }
            catch (Exception ex)
            {
                return "Lỗi CSDL: " + ex.Message;
            }
        }

        public string CapNhatThongTin(string maThe, string hoTen, string sdt, DateTime ngaySinh)
        {
            if (string.IsNullOrWhiteSpace(hoTen)) return "Họ tên không được để trống!";

            try
            {
                if (theMuonDAL.CapNhatThongTinChiTiet(maThe, hoTen, sdt, ngaySinh))
                {
                    return "SUCCESS";
                }
                return "Không tìm thấy dữ liệu phù hợp để cập nhật (Sai mã thẻ).";
            }
            catch (Exception ex)
            {
                // Trả về lỗi chi tiết của SQL để em dễ sửa
                return "Lỗi SQL: " + ex.Message;
            }
        }

        private TheMuonDAL dal = new TheMuonDAL();

        public DataTable GetAll() => dal.LayTatCaThe();

        public DataTable Search(string keyword) => dal.TimKiemThe(keyword);

        public bool DeleteCard(string maThe) => dal.XoaThe(maThe);

        // Hàm chuyển đổi số trạng thái sang chữ để hiển thị trên Grid
        public string ConvertTrangThai(int status, DateTime expiry)
        {
            if (expiry < DateTime.Now) return "Hết hạn";
            if (status == 1) return "Đang bị khóa";
            return "Đang hoạt động";
        }
        public string ThayDoiTrangThaiThe(string maThe, int trangThaiMoi)
        {
            if (dal.UpdateCardStatus(maThe, trangThaiMoi))
                return "SUCCESS";
            return "Lỗi khi cập nhật trạng thái thẻ!";
        }
        public string KichHoatTaiKhoan(string tenTaiKhoan, string maKichHoat)
        {
            // Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(tenTaiKhoan) || string.IsNullOrWhiteSpace(maKichHoat))
            {
                return "Vui lòng nhập đầy đủ Tên tài khoản và Mã kích hoạt!";
            }

            TheMuonDAL dal = new TheMuonDAL();

            // Gọi DAL xử lý
            if (dal.KichHoatThe(tenTaiKhoan, maKichHoat))
            {
                return "SUCCESS";
            }

            return "Tên tài khoản hoặc Mã kích hoạt không chính xác!";
        }

    }
}
