using LibraryManagerDAO;
using LibraryManagerDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerDAL
{
    public class SachDAL
    {
        //1. Khởi tạo đối tượng DbHelper 
        private DbHelper dbHelper = new DbHelper(); // dung truc tiep, khong can the nay nú

        public DataTable LayTatCaSach()
        {
            string query = @"
                SELECT 
                    s.maSach AS [Mã Sách], 
                    s.tenSach AS [Tên Sách], 
                    ISNULL(tg.DanhSachTacGia, N'Chưa có') AS [Tác Giả], 
                    s.isbn AS [Mã ISBN],
                    nph.tenNhaPhatHanh AS [Nhà Xuất Bản], 
                    s.soLuongHienCo AS [Số Lượng Có Sẵn]
                FROM sach s
                LEFT JOIN nhaphathanh nph ON s.maNhaPhatHanh = nph.maNhaPhatHanh
                LEFT JOIN (
                    SELECT cttg.maSach, 
                           STRING_AGG(t.tenTacGia, ', ') AS DanhSachTacGia
                    FROM chitiettacgia cttg
                    JOIN tacgia t ON cttg.maTacGia = t.maTacGia
                    GROUP BY cttg.maSach
                ) tg ON s.maSach = tg.maSach";

            //2. Sử dụng hàm getTable() TỪ DBHELPER 
            return dbHelper.getTable(query);
        }
        public bool ThemSach(SachDTO sach)
        {
            // 1. THÊM VÀO BẢNG SÁCH TRƯỚC
            string sqlSach = @"INSERT INTO sach (maSach, tenSach, maNhaPhatHanh, isbn, soLuongHienCo) 
                       VALUES (@maSach, @tenSach, @maNhaPhatHanh, @isbn, @soLuong)";

            SqlParameter[] prmsSach = new SqlParameter[]
            {
        new SqlParameter("@maSach", sach.maSach),
        new SqlParameter("@tenSach", sach.tenSach),
        new SqlParameter("@maNhaPhatHanh", sach.maNhaPhatHanh),
        new SqlParameter("@isbn", sach.isbn),
        new SqlParameter("@soLuong", sach.soLuongHienCo)
            };

            // Chạy lệnh thêm Sách
            bool themSachThanhCong = dbHelper.executeNonQuery(sqlSach, prmsSach);

            // 2. NẾU THÊM SÁCH THÀNH CÔNG -> THÊM TIẾP VÀO BẢNG CHI TIẾT TÁC GIẢ
            if (themSachThanhCong)
            {
                string sqlTacGia = @"INSERT INTO chitiettacgia (maSach, maTacGia) 
                             VALUES (@maSach, @maTacGia)";

                SqlParameter[] prmsTacGia = new SqlParameter[]
                {
            new SqlParameter("@maSach", sach.maSach),
            new SqlParameter("@maTacGia", sach.maTacGia) // Lấy từ DTO vừa thêm
                };

                // Chạy lệnh thêm Chi tiết tác giả
                return dbHelper.executeNonQuery(sqlTacGia, prmsTacGia);
            }

            // Nếu thêm sách thất bại thì trả về false luôn
            return false;
        }
        public bool SuaSach(SachDTO sach)
        {
            // 1. CẬP NHẬT BẢNG `sach`
            string sqlSach = @"UPDATE sach 
                       SET tenSach = @tenSach, maNhaPhatHanh = @maNhaPhatHanh, 
                           isbn = @isbn, soLuongHienCo = @soLuong 
                       WHERE maSach = @maSach";

            SqlParameter[] prmsSach = {
        new SqlParameter("@maSach", sach.maSach),
        new SqlParameter("@tenSach", sach.tenSach),
        new SqlParameter("@maNhaPhatHanh", sach.maNhaPhatHanh),
        new SqlParameter("@isbn", sach.isbn),
        new SqlParameter("@soLuong", sach.soLuongHienCo)
    };

            bool capNhatSachThanhCong = dbHelper.executeNonQuery(sqlSach, prmsSach);

            // 2. NẾU CẬP NHẬT SÁCH THÀNH CÔNG -> XỬ LÝ BẢNG `chitiettacgia`
            if (capNhatSachThanhCong)
            {
                // Thuật toán: Xóa liên kết cũ và Tạo liên kết mới (để tránh lỗi trùng lặp khóa chính)
                string sqlXoa = "DELETE FROM chitiettacgia WHERE maSach = @maSach";
                SqlParameter[] prmsXoa = { new SqlParameter("@maSach", sach.maSach) };
                dbHelper.executeNonQuery(sqlXoa, prmsXoa);

                // Thêm tác giả mới (từ ComboBox mà người dùng vừa chọn lại)
                string sqlThemMoi = "INSERT INTO chitiettacgia (maSach, maTacGia) VALUES (@maSach, @maTacGia)";
                SqlParameter[] prmsThem = {
        new SqlParameter("@maSach", sach.maSach),
        new SqlParameter("@maTacGia", sach.maTacGia)
            };

                return dbHelper.executeNonQuery(sqlThemMoi, prmsThem);
            }

            return false;
        }
        public bool XoaSach(string maSach)
        {
            // 1. Xóa trong bảng trung gian (Chi tiết tác giả) trước để gỡ bỏ ràng buộc khóa ngoại
            string sqlTacGia = "DELETE FROM chitiettacgia WHERE maSach = @ma";
            SqlParameter[] prm = { new SqlParameter("@ma", maSach) };
            dbHelper.executeNonQuery(sqlTacGia, prm);

            // 2. Sau đó mới xóa cuốn sách trong bảng chính
            string sqlSach = "DELETE FROM sach WHERE maSach = @ma";
            SqlParameter[] prm2 = { new SqlParameter("@ma", maSach) };

            return dbHelper.executeNonQuery(sqlSach, prm2);
        }
        public DataTable TimKiemSach(string keyword)
        {
            // Dùng LIKE và dấu % để tìm kiếm tương đối (chỉ cần chứa cụm từ đó là ra)
            string sql = @"SELECT 
                    sach.maSach AS [Mã Sách], 
                    sach.tenSach AS [Tên Sách], 
                    sach.isbn AS [Mã ISBN],
                    nhaphathanh.tenNhaPhatHanh AS [Nhà Xuất Bản], 
                    tacgia.tenTacGia AS [Tác Giả], 
                    sach.soLuongHienCo AS [Số Lượng Có Sẵn]
                   FROM sach
                   JOIN nhaphathanh ON sach.maNhaPhatHanh = nhaphathanh.maNhaPhatHanh
                   JOIN chitiettacgia ON sach.maSach = chitiettacgia.maSach
                   JOIN tacgia ON chitiettacgia.maTacGia = tacgia.maTacGia
                   WHERE sach.maSach LIKE @key OR sach.tenSach LIKE @key";

            SqlParameter[] prms = {
        new SqlParameter("@key", "%" + keyword + "%")
    };

            return dbHelper.getTable(sql, prms);
        }
    }
}
