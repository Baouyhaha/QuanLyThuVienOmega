using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagerDAL;
using LibraryManagerDAO;

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

        //public DataTable GetAll() => dal.LayTatCaThe();

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
        // 1. Lấy tất cả thẻ mượn kèm tên người mượn (Dùng JOIN)
        public DataTable GetAll()
        {
            string sql = @"SELECT t.maTheMuon, n.hoTen, t.ngayHetHan, 
                           CASE WHEN t.trangThai = 0 THEN N'Còn hạn' ELSE N'Hết hạn' END AS TinhTrang
                           FROM themuon t 
                           JOIN nguoimuon n ON t.maNguoiMuon = n.maNguoiMuon";
            return DbHelper.getTable(sql);
        }

        // 2. Lấy danh sách người mượn ĐANG CHỜ DUYỆT (trangThai = 0)
        public DataTable GetDanhSachChoDuyet()
        {
            string sql = "SELECT maNguoiMuon, hoTen, sdt, loaiKhach, maDinhDanh FROM nguoimuon WHERE trangThai = 0";
            return DbHelper.getTable(sql);
        }

        // 3. Duyệt cấp thẻ cho người đã đăng ký online
        public bool DuyetCapThe(string maNM)
        {
            string maThe = "THE" + DateTime.Now.ToString("ssmm"); // Tự sinh mã thẻ đơn giản
            string ngayHetHan = DateTime.Now.AddYears(1).ToString("dd/MM/yyyy");

            string sql = $@"
                BEGIN TRANSACTION;
                BEGIN TRY
                    UPDATE nguoimuon SET trangThai = 1 WHERE maNguoiMuon = '{maNM}';
                    INSERT INTO themuon (maTheMuon, ngayHetHan, trangThai, maKichHoat, maNguoiMuon)
                    VALUES ('{maThe}', '{ngayHetHan}', 0, 'ACT1', '{maNM}');
                    COMMIT TRANSACTION;
                END TRY
                BEGIN CATCH
                    ROLLBACK TRANSACTION;
                    THROW;
                END CATCH";
            return DbHelper.executeNonQuery(sql);
        }

        // 4. Thêm mới hoàn toàn (Đăng ký trực tiếp tại quầy)
        public bool ThemTaiQuay(string hoTen, string sdt, string email, string diaChi, string loai, string cccd)
        {
            string maNM = "NM" + DateTime.Now.ToString("yyyyMMddHHmmss");
            string maThe = "T" + DateTime.Now.ToString("HHmmss");
            string ngayHetHan = DateTime.Now.AddYears(1).ToString("dd/MM/yyyy");

            string sql = $@"
                BEGIN TRANSACTION;
                BEGIN TRY
                    INSERT INTO nguoimuon (maNguoiMuon, hoTen, sdt, email, diaChi, loaiKhach, maDinhDanh, trangThai)
                    VALUES ('{maNM}', N'{hoTen}', '{sdt}', '{email}', N'{diaChi}', N'{loai}', '{cccd}', 1);
                    INSERT INTO themuon (maTheMuon, ngayHetHan, trangThai, maKichHoat, maNguoiMuon)
                    VALUES ('{maThe}', '{ngayHetHan}', 0, 'ACT2', '{maNM}');
                    COMMIT TRANSACTION;
                END TRY
                BEGIN CATCH
                    ROLLBACK TRANSACTION;
                    THROW;
                END CATCH";
            return DbHelper.executeNonQuery(sql);
        }
    }
}
