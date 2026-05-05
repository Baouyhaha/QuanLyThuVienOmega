using LibraryManagerDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerDAL
{
    public class NguoiMuonDAL
    {
        public DataTable LayThongTinHoSo(string tenTaiKhoan)
        {
            string query = @"SELECT nm.hoTen, nm.maDinhDanh, nm.sdt, nm.email, 
                            nm.maNguoiMuon, nm.soTienDatCoc, nm.trangThai 
                     FROM nguoimuon nm
                     WHERE nm.tenTaiKhoan = @user";

            SqlParameter[] parameters = { new SqlParameter("@user", tenTaiKhoan) };
            return DbHelper.getTable(query, parameters);
        }

        // 2. Hàm gửi yêu cầu kích hoạt
        public bool GuiYeuCauKichHoat(string tenTaiKhoan)
        {// Cập nhật trạng thái thành 2 (Đang chờ duyệt)
            string query = "UPDATE nguoimuon SET trangThai = 2 WHERE tenTaiKhoan = @TenTaiKhoan";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@TenTaiKhoan", tenTaiKhoan)
            };

            return DbHelper.executeNonQuery(query, parameters);

        }
        public DataTable LayThongTinThe(string maNguoiMuon)
        {
            // 1. Câu query chuẩn: Liên kết bảng Thẻ và bảng Người mượn qua Mã người mượn
            string query = @"SELECT t.maTheMuon, t.ngayHetHan, t.trangThai, n.hoTen 
                 FROM themuon t 
                 INNER JOIN nguoimuon n ON t.maNguoiMuon = n.maNguoiMuon 
                 WHERE t.maNguoiMuon = @ma";

            // 2. Logic chốt chặn của em (Giữ nguyên vì rất tốt)
            string giaTriTruyenVao = string.IsNullOrEmpty(maNguoiMuon) ? "KHONG_CO_MA" : maNguoiMuon;

            // 3. Khai báo Parameter (Khớp với @ma ở trên)
            SqlParameter[] pars = {
    new SqlParameter("@ma", giaTriTruyenVao)
};

            // 4. Trả về kết quả
            return DbHelper.getTable(query, pars);
        }
        public int KiemTraTinhTrangThe(string maNguoiMuon)
        {
            // Tìm thẻ mượn dựa vào mã người mượn
            string sql = "SELECT trangThai FROM themuon WHERE maNguoiMuon = @maNM";
            SqlParameter[] pr = { new SqlParameter("@maNM", maNguoiMuon) };

            DataTable dt = LibraryManagerDAO.DbHelper.getTable(sql, pr);

            // Nếu DataTable không có dòng nào -> Sinh viên này chưa từng đăng ký thẻ
            if (dt.Rows.Count == 0)
            {
                return -1;
            }

            // Nếu có thẻ, trả về trạng thái của thẻ (0: Hợp lệ, 1: Hết hạn)
            return Convert.ToInt32(dt.Rows[0]["trangThai"]);
        }
    }
}
