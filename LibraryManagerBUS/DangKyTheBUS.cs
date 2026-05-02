using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagerDAL;
using LibraryManagerDAO;
using LibraryManagerDTO;

namespace LibraryManagerBUS
{
    public class DangKyTheBUS
    {
        private DangKyTheDAL dal = new DangKyTheDAL();

        public string XuLyDangKy(DangKyTheDTO khachMoi)
        {
            if (string.IsNullOrEmpty(khachMoi.TenTaiKhoan))
            {
                return "Lỗi: Phiên đăng nhập không hợp lệ.";
            }

            string maNM = "NM" + DateTime.Now.ToString("yyyyMMddHHmmss");
            string maThe = "T" + DateTime.Now.ToString("HHmmss");
            string ngayHan = DateTime.Now.AddYears(1).ToString("yyyy-MM-dd");

            string sql = @"
                BEGIN TRANSACTION;
                BEGIN TRY
                    INSERT INTO nguoimuon (maNguoiMuon, tenTaiKhoan, hoTen, ngaySinh, sdt, email, diaChi, loaiKhach, maDinhDanh, trangThai)
                    VALUES (@MaNM, @TenTK, @Ten, @NS, @SDT, @Email, @DC, @Loai, @ID, 1);

                    INSERT INTO themuon (maTheMuon, ngayHetHan, trangThai, maKichHoat, maNguoiMuon)
                    VALUES (@MaThe, @Han, 0, @MaKH, @MaNM);

                    COMMIT TRANSACTION;
                END TRY
                BEGIN CATCH
                    ROLLBACK TRANSACTION;
                    THROW;
                END CATCH";

            SqlParameter[] sqlParams = {
                new SqlParameter("@MaNM", maNM),
                new SqlParameter("@TenTK", khachMoi.TenTaiKhoan),
                new SqlParameter("@Ten", khachMoi.HoTen),
                new SqlParameter("@NS", khachMoi.NgaySinh),
                new SqlParameter("@SDT", khachMoi.Sdt),
                new SqlParameter("@Email", khachMoi.Email),
                new SqlParameter("@DC", khachMoi.DiaChi),
                new SqlParameter("@Loai", khachMoi.LoaiDocGia),
                new SqlParameter("@ID", khachMoi.MaDinhDanh),
                new SqlParameter("@MaThe", maThe),
                new SqlParameter("@Han", ngayHan),
                new SqlParameter("@MaKH", "ACT" + DateTime.Now.Second)
            };

            try
            {
                if (DbHelper.executeNonQuery(sql, sqlParams))
                {
                    return "SUCCESS";
                }
                return "Lỗi: Không thể thực thi yêu cầu.";
            }
            catch (Exception ex)
            {
                return "Lỗi hệ thống: " + ex.Message;
            }
        }
    }
}
