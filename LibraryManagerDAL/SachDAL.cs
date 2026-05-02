using LibraryManagerDAO;
using LibraryManagerDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace LibraryManagerDAL
{
    public class SachDAL
    {

        // Lấy mã sách lớn nhất hiện có (Ví dụ: "S001")
        public string GetMaxMaSach()
        {
            string sql = "SELECT MAX(maSach) FROM sach";
            object result = DbHelper.executeScalar(sql);
            return result?.ToString();
        }

        // Lấy số thứ tự lớn nhất của bản sao thuộc một mã sách
        public object GetMaxSoThuTu(string maSach)
        {
            string sql = "SELECT MAX(soThuTu) FROM bansaosach WHERE maSach = '" + maSach + "'";
            return DbHelper.executeScalar(sql);
        }

        public DataTable GetAllSachFullInfo()
        {
            // Lấy thông tin sách và tên nhà xuất bản bằng INNER JOIN
            string sql = @"SELECT s.maSach, s.tenSach, n.tenNhaPhatHanh, s.isbn, s.soLuongHienCo 
                   FROM sach s 
                   INNER JOIN nhaphathanh n ON s.maNhaPhatHanh = n.maNhaPhatHanh";
            return DbHelper.getTable(sql);
        }

        public DataTable SearchSach(string keyword)
        {
            // Tìm kiếm theo tên sách hoặc mã sách
            string sql = @"SELECT s.maSach, s.tenSach, n.tenNhaPhatHanh, s.isbn, s.soLuongHienCo 
                   FROM sach s 
                   INNER JOIN nhaphathanh n ON s.maNhaPhatHanh = n.maNhaPhatHanh
                   WHERE s.tenSach LIKE @key OR s.maSach LIKE @key";
            SqlParameter[] pr = { new SqlParameter("@key", "%" + keyword + "%") };
            return DbHelper.getTable(sql, pr);
        }

        // Kiểm tra xem đầu sách có cuốn nào đang được mượn không
        public bool KiemTraSachDangMuon(string maSach)
        {
            // trangThai = 1 là đang mượn
            string sql = "SELECT COUNT(*) FROM bansaosach WHERE maSach = @ma AND trangThai = 1";
            SqlParameter[] pr = { new SqlParameter("@ma", maSach) };
            return Convert.ToInt32(DbHelper.executeScalar(sql, pr)) > 0;
        }

        // Hàm xóa tổng thể dùng Transaction
        public bool XoaSach(string maSach)
        {
            using (SqlConnection conn = DbHelper.getConnection())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    // 1. Xóa bản sao sách trước
                    string sqlBS = "DELETE FROM bansaosach WHERE maSach = @ma";
                    SqlCommand cmdBS = new SqlCommand(sqlBS, conn, trans);
                    cmdBS.Parameters.AddWithValue("@ma", maSach);
                    cmdBS.ExecuteNonQuery();

                    // 2. Xóa chi tiết tác giả
                    string sqlTG = "DELETE FROM chitiettacgia WHERE maSach = @ma";
                    SqlCommand cmdTG = new SqlCommand(sqlTG, conn, trans);
                    cmdTG.Parameters.AddWithValue("@ma", maSach);
                    cmdTG.ExecuteNonQuery();

                    // 3. Cuối cùng mới xóa Sách
                    string sqlS = "DELETE FROM sach WHERE maSach = @ma";
                    SqlCommand cmdS = new SqlCommand(sqlS, conn, trans);
                    cmdS.Parameters.AddWithValue("@ma", maSach);
                    cmdS.ExecuteNonQuery();

                    trans.Commit();
                    return true;
                }
                catch
                {
                    trans.Rollback();
                    return false;
                }
            }
        }
        public bool CapNhatToanBoSach(SachDTO sach, List<int> dsMaTG, List<BanSaoSachDTO> dsBS)
        {
            using (SqlConnection conn = DbHelper.getConnection())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    // 1. Cập nhật thông tin Sách
                    string sqlS = "UPDATE sach SET tenSach=@t, maNhaPhatHanh=@n, isbn=@i, soLuongHienCo=@sl WHERE maSach=@m";
                    SqlCommand cmdS = new SqlCommand(sqlS, conn, trans);
                    cmdS.Parameters.AddWithValue("@m", sach.maSach);
                    cmdS.Parameters.AddWithValue("@t", sach.tenSach);
                    cmdS.Parameters.AddWithValue("@n", sach.maNhaPhatHanh);
                    cmdS.Parameters.AddWithValue("@i", sach.isbn);
                    cmdS.Parameters.AddWithValue("@sl", sach.soLuongHienCo);
                    cmdS.ExecuteNonQuery();

                    // 2. Cập nhật Tác giả (Xóa hết cũ của sách này - Thêm lại danh sách mới)
                    new SqlCommand($"DELETE FROM chitiettacgia WHERE maSach='{sach.maSach}'", conn, trans).ExecuteNonQuery();
                    foreach (int maTG in dsMaTG)
                    {
                        SqlCommand cmdTG = new SqlCommand("INSERT INTO chitiettacgia VALUES(@ms, @mtg)", conn, trans);
                        cmdTG.Parameters.AddWithValue("@ms", sach.maSach);
                        cmdTG.Parameters.AddWithValue("@mtg", maTG);
                        cmdTG.ExecuteNonQuery();
                    }

                    // 3. Cập nhật Bản sao (UPSERT: Nếu tồn tại thì Update giá/loại, nếu chưa có thì Insert)
                    foreach (var bs in dsBS)
                    {
                        string sqlBS = @"IF EXISTS (SELECT 1 FROM bansaosach WHERE banSaoSach = @mabs)
                                 UPDATE bansaosach SET loaiBanSao=@l, gia=@g WHERE banSaoSach=@mabs
                                 ELSE
                                 INSERT INTO bansaosach VALUES(@mabs, @ms, @st, @l, @g, 0, 0)";
                        SqlCommand cmdBS = new SqlCommand(sqlBS, conn, trans);
                        cmdBS.Parameters.AddWithValue("@mabs", bs.banSaoSach);
                        cmdBS.Parameters.AddWithValue("@ms", sach.maSach);
                        cmdBS.Parameters.AddWithValue("@st", bs.soThuTu);
                        cmdBS.Parameters.AddWithValue("@l", bs.loaiBanSao);
                        cmdBS.Parameters.AddWithValue("@g", bs.gia);
                        cmdBS.ExecuteNonQuery();
                    }

                    trans.Commit(); return true;
                }
                catch { trans.Rollback(); return false; }
            }
        }
        // 1. Lấy thông tin cơ bản của 1 cuốn sách
        public DataTable LayThongTinChiTiet(string maSach)
        {
            string sql = "SELECT * FROM sach WHERE maSach = @ma";
            SqlParameter[] pr = { new SqlParameter("@ma", maSach) };
            return DbHelper.getTable(sql, pr);
        }

        // 2. Lấy danh sách tác giả của cuốn sách đó (Dùng JOIN)
        public DataTable LayDSTacGiaCuaSach(string maSach)
        {
            string sql = @"SELECT tg.maTacGia, tg.tenTacGia 
                   FROM tacgia tg 
                   JOIN chitiettacgia ct ON tg.maTacGia = ct.maTacGia 
                   WHERE ct.maSach = @ma";
            SqlParameter[] pr = { new SqlParameter("@ma", maSach) };
            return DbHelper.getTable(sql, pr);
        }

        // 3. Lấy danh sách các bản sao của cuốn sách đó
        public DataTable LayDSBanSaoCuaSach(string maSach)
        {
            string sql = "SELECT * FROM bansaosach WHERE maSach = @ma";
            SqlParameter[] pr = { new SqlParameter("@ma", maSach) };
            return DbHelper.getTable(sql, pr);
        }
        

        //Chua chac dung
        public int KiemTraTrangThaiSach(string maBanSao)
        {
            // Truy vấn cột trangThai của bản sao cụ thể
            string sql = "SELECT trangThai FROM bansaosach WHERE banSaoSach = @ma";
            SqlParameter[] pr = { new SqlParameter("@ma", maBanSao) };

            object res = DbHelper.executeScalar(sql, pr);

            // Nếu tìm thấy thì trả về giá trị (0, 1, 2...), nếu không thấy trả về -1
            return res != null ? Convert.ToInt32(res) : -1;
        }
        // 1. Lấy toàn bộ danh sách sách cho Form Tìm Kiếm
        public DataTable GetDanhSachSachFrmTimKiem()
        {
            // Thầy thêm JOIN với bảng tác giả và đặt bí danh (Alias) cho cột để em dễ gọi trong C#
            string sql = @"SELECT s.maSach, s.tenSach, 
               nph.tenNhaPhatHanh AS NhaXuatBan, 
               tg.tenTacGia AS TacGia, 
               s.isbn
        FROM sach s 
        LEFT JOIN nhaphatHanh nph ON s.maNhaPhatHanh = nph.maNhaPhatHanh
        LEFT JOIN chitiettacgia cttg ON s.maSach = cttg.maSach
        LEFT JOIN tacgia tg ON cttg.maTacGia = tg.maTacGia"; 
            return DbHelper.getTable(sql);
        }

        // 2. Hàm tìm kiếm thông minh (Tìm theo tên hoặc ISBN)
        public DataTable TimKiemSachThongMinh(string tuKhoa)
        {
            // Thầy thêm JOIN nhaphathanh để lấy được cột tenNhaPhatHanh
            string sql = @"SELECT s.maSach, s.tenSach, nph.tenNhaPhatHanh, b.gia, b.loaiBanSao, b.trangThai 
                   FROM sach s 
                   JOIN bansaosach b ON s.maSach = b.maSach 
                   JOIN nhaphathanh nph ON s.maNhaPhatHanh = nph.maNhaPhatHanh
                   WHERE (s.maSach LIKE @tk 
                          OR s.tenSach LIKE @tk 
                          OR nph.tenNhaPhatHanh LIKE @tk) 
                   AND b.xoa = 0";

            SqlParameter[] pr = { new SqlParameter("@tk", "%" + tuKhoa + "%") };
            return DbHelper.getTable(sql, pr);
        }
        public int KiemTraSoLuongCoTheMuon(string maSach)
        {
            // Đếm số lượng bản sao thỏa mãn 3 điều kiện vàng
            string query = @"SELECT COUNT(*) 
                     FROM bansaosach 
                     WHERE maSach = @maSach 
                       AND loaiBanSao = 2 
                       AND trangThai = 0 
                       AND xoa = 0";

            SqlParameter[] pars = { new SqlParameter("@maSach", maSach) };

            // ExecuteScalar dùng để lấy một giá trị duy nhất (ở đây là kết quả của COUNT)
            object result = DbHelper.executeScalar(query, pars);

            return result != null ? Convert.ToInt32(result) : 0;
        }
        public int LaySoLuongKhaDung(string maSach)
        {
            // Chỉ đếm những bản sao: Đúng mã sách, Cho mượn về (2), Sẵn có (0) và Chưa thanh lý (0)
            string query = @"SELECT COUNT(*) 
                     FROM bansaosach 
                     WHERE maSach = @ma 
                       AND loaiBanSao = 2 
                       AND trangThai = 0 
                       AND xoa = 0";

            SqlParameter[] pars = { new SqlParameter("@ma", maSach) };

            // Trả về số lượng kiểu số nguyên
            object result = DbHelper.executeScalar(query, pars);
            return result != null ? Convert.ToInt32(result) : 0;
        }
        public string LayMaBanSaoKhaDung(string maSach)
        {
            // Tìm 1 bản sao: Đúng mã sách, Cho mượn (2), Sẵn có (0), Chưa xóa (0)
            // Theo đúng cấu trúc bảng bansaosach của Danh
            string sql = @"SELECT TOP 1 banSaoSach 
                   FROM bansaosach 
                   WHERE maSach = @ma 
                     AND loaiBanSao = 2 
                     AND trangThai = 0 
                     AND xoa = 0";

            SqlParameter[] pr = { new SqlParameter("@ma", maSach) };
            object res = DbHelper.executeScalar(sql, pr);

            return res != null ? res.ToString() : null;
        }
        public DataTable TimKiemSachThongMinh2(string tuKhoa)
        {
            // Chỉ giữ lại đoạn này
            string sql = "EXEC sp_TimKiemSachNangCao @TuKhoa";
            SqlParameter[] pars = {
        new SqlParameter("@TuKhoa", string.IsNullOrWhiteSpace(tuKhoa) ? (object)DBNull.Value : tuKhoa.Trim())
    };
            return DbHelper.getTable(sql, pars);
        }

    }
}
