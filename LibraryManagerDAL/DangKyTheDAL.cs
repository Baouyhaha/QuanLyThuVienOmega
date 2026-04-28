using LibraryManagerDAO;
using LibraryManagerDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerDAL
{
    public class DangKyTheDAL
    {
        // Hàm lưu yêu cầu đăng ký thẻ mượn vào DB
        public bool GuiYeuCauDangKy(DangKyTheDTO khach)
        {
            // Chú ý: Cột trangThai = 0 nghĩa là "Đang chờ duyệt cấp thẻ"
            string sql = @"INSERT INTO NguoiMuon (hoTen, ngaySinh, sdt, email, diaChi, loaiKhach, maDinhDanh, trangThai) 
                           VALUES (@hoTen, @ngaySinh, @sdt, @email, @diaChi, @loaiKhach, @maDinhDanh, 0)";

            SqlParameter[] pars = {
                new SqlParameter("@hoTen", khach.HoTen),
                new SqlParameter("@ngaySinh", khach.NgaySinh),
                new SqlParameter("@sdt", khach.Sdt),
                new SqlParameter("@email", khach.Email),
                new SqlParameter("@diaChi", khach.DiaChi),
                new SqlParameter("@loaiKhach", khach.LoaiDocGia),
                new SqlParameter("@maDinhDanh", khach.MaDinhDanh)
            };

            return DbHelper.executeNonQuery(sql, pars);
        }
    }
}
