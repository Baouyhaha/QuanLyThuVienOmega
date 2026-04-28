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
    }
}
