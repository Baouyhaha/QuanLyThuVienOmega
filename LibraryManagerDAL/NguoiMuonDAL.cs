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
            // CÂU LỆNH SQL ĐÃ FIX THEO ẢNH THỰC TẾ CỦA EM
            string query = @"SELECT tk.ten as hoTen, nm.mssv, tk.soDienThoai, tk.email, 
                            nm.maNguoiMuon, nm.soTienDatCoc, nm.giaiDoanHoc, nm.trangThai 
                     FROM nguoimuon nm 
                     INNER JOIN taikhoan tk ON nm.tenTaiKhoan = tk.tenTaiKhoan 
                     WHERE tk.tenTaiKhoan = @TenTaiKhoan";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@TenTaiKhoan", tenTaiKhoan)
            };

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
