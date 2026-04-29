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
    }
}
