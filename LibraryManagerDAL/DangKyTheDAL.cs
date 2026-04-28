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
            // 1. TỰ SINH MÃ NGƯỜI MƯỢN (Ví dụ: NM28103015)
            string maNguoiMuonMoi = "NM" + DateTime.Now.ToString("ddHHmmss");

            // 2. ĐÃ BỔ SUNG CỘT maNguoiMuon VÀO CÂU LỆNH INSERT
            string sql = @"INSERT INTO NguoiMuon (maNguoiMuon, hoTen, ngaySinh, sdt, email, diaChi, loaiKhach, maDinhDanh, trangThai) 
                           VALUES (@maNM, @hoTen, @ngaySinh, @sdt, @email, @diaChi, @loaiKhach, @maDinhDanh, 0)";

            SqlParameter[] pars = {
                new SqlParameter("@maNM", maNguoiMuonMoi), // Truyền mã vừa sinh vào đây
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
