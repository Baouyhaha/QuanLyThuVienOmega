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
    public class PhieuDocTaiChoDAL
    {
        // Hàm đếm số phiếu trong ngày
        public int LaySoPhieuTrongNgay(DateTime ngay)
        {
            
            string query = "SELECT COUNT(*) FROM PhieuDocTaiCho WHERE CAST(ngayDoc AS DATE) = CAST(@Ngay AS DATE)";
            SqlParameter[] parameters = {
                new SqlParameter("@Ngay", ngay.Date)
            };

            object result = DbHelper.executeScalar(query, parameters);
            return result != null ? Convert.ToInt32(result) : 0;
        }

        // Hàm thêm phiếu mới vào DB
        public bool ThemPhieuMoi(PhieuDocTaiCho phieu)
        {
            
            string query = @"INSERT INTO PhieuDocTaiCho (MaPhieu, CCCD, tenNguoiDoc, MaSach, TrangThai, ngayDoc) 
                             VALUES (@MaPhieu, @Cccd, @TenNguoiDoc, @MaSach, @TrangThai, GETDATE())";

            SqlParameter[] parameters = {
                new SqlParameter("@MaPhieu", phieu.maPhieu),
                new SqlParameter("@Cccd", phieu.Cccd),
                new SqlParameter("@TenNguoiDoc", phieu.tenNguoiDoc),
                new SqlParameter("@MaSach", phieu.maSach),
                new SqlParameter("@TrangThai", phieu.trangThai)
            };

            return DbHelper.executeNonQuery(query, parameters);
        }

        
        public string LayTenKhachTheoCCCD(string cccd)
        {
            // Tìm tên người đọc gần đây nhất có cùng số CCCD
            string sql = "SELECT TOP 1 tenNguoiDoc FROM PhieuDocTaiCho WHERE Cccd = @cccd ORDER BY ngayDoc DESC";
            SqlParameter[] pars = {
        new SqlParameter("@cccd", cccd)
    };

            // Gọi hàm executeScalar đã viết ở DbHelper
            object result = DbHelper.executeScalar(sql, pars);

            if (result != null)
            {
                return result.ToString(); // Trả về tên nếu tìm thấy
            }
            return null; // Trả về null nếu là khách hoàn toàn mới
        }

        
    }
}
