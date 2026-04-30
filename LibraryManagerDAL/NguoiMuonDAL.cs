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
            // Sử dụng JOIN để lấy hoTen từ bảng nguoimuon dựa vào mã người mượn
            string query = @"SELECT t.maTheMuon, t.ngayHetHan, t.trangThai, n.hoTen 
                     FROM themuon t
                     INNER JOIN nguoimuon n ON t.maNguoiMuon = n.maNguoiMuon
                     WHERE t.maNguoiMuon = @ma";

            SqlParameter[] pars = new SqlParameter[1];
            pars[0] = new SqlParameter("@ma", SqlDbType.VarChar);
            pars[0].Value = maNguoiMuon;

            return DbHelper.getTable(query, pars);
        }
    }
}
