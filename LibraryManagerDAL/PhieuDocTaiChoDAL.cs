using LibraryManagerDAO;
using LibraryManagerDTO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagerDAL
{
    public class PhieuDocTaiChoDAL
    {
        // Đã sửa: Lấy mã phiếu mới nhất thay vì đếm số lượng
        public string LayMaPhieuMoiNhatTrongNgay(DateTime ngay)
        {
            string query = "SELECT TOP 1 MaPhieu FROM PhieuDocTaiCho WHERE CAST(ngayDoc AS DATE) = CAST(@Ngay AS DATE) ORDER BY MaPhieu DESC";
            SqlParameter[] parameters = {
                new SqlParameter("@Ngay", ngay.Date)
            };

            object result = DbHelper.executeScalar(query, parameters);
            return result != null ? result.ToString() : null;
        }

        // Hàm thêm phiếu mới giữ nguyên vì cấu trúc DB đã được mở rộng MaPhieu lên VARCHAR(20)
        public bool ThemPhieuMoi(PhieuDocTaiCho phieu)
        {
            string query = @"INSERT INTO PhieuDocTaiCho (MaPhieu, CCCD, tenNguoiDoc, maBanSao, TrangThai, ngayDoc) 
                     VALUES (@MaPhieu, @Cccd, @TenNguoiDoc, @MaBanSao, @TrangThai, GETDATE())";

            SqlParameter[] parameters = {
                new SqlParameter("@MaPhieu", phieu.maPhieu),
                new SqlParameter("@Cccd", phieu.Cccd),
                new SqlParameter("@TenNguoiDoc", phieu.tenNguoiDoc),
                new SqlParameter("@MaBanSao", phieu.maBanSao), // Đã cập nhật
                new SqlParameter("@TrangThai", phieu.trangThai)
            };

            return DbHelper.executeNonQuery(query, parameters);
        }

        public string LayTenKhachTheoCCCD(string cccd)
        {
            string sql = "SELECT TOP 1 tenNguoiDoc FROM PhieuDocTaiCho WHERE Cccd = @cccd ORDER BY ngayDoc DESC";
            SqlParameter[] pars = {
                new SqlParameter("@cccd", cccd)
            };

            object result = DbHelper.executeScalar(sql, pars);

            if (result != null)
            {
                return result.ToString();
            }
            return null;
        }

        public DataTable LayDanhSachHienTai()
        {
            string sql = "EXEC sp_LayDanhSachDocTaiCho";
            return DbHelper.getTable(sql);
        }

        public int LayTrangThaiBanSaoSach(string maBanSao)
        {
            try
            {
                string sql = "SELECT trangThai FROM BanSaoSach WHERE maBanSao = @maBanSao";
                SqlParameter[] pars = {
            new SqlParameter("@maBanSao", maBanSao)
        };

                // Giả sử DbHelper.executeScalar trả về object chứa giá trị của cột đầu tiên
                object result = DbHelper.executeScalar(sql, pars);

                if (result != null)
                {
                    return Convert.ToInt32(result); // Trả về 0, 1 hoặc 2
                }
                return -1; // Báo hiệu mã sách này nhập sai, không tồn tại
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi kiểm tra trạng thái sách: " + ex.Message);
            }
        }
        public bool HoanTatNhanTraSach(string maPhieu, string maBanSao)
        {
            using (SqlConnection conn = DbHelper.getConnection())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    // 1. Cập nhật phiếu đọc tại chỗ (Chuyển trạng thái từ Đang đọc -> Đã trả/Hoàn tất)
                    // Giả sử 0 là trạng thái hoàn tất
                    string sqlPhieu = "UPDATE PhieuDocTaiCho SET trangThai = 0 WHERE maPhieu = @maPhieu";
                    SqlCommand cmdPhieu = new SqlCommand(sqlPhieu, conn, trans);
                    cmdPhieu.Parameters.AddWithValue("@maPhieu", maPhieu);
                    cmdPhieu.ExecuteNonQuery();

                    // 2. Cập nhật trạng thái bản sao sách về 0 (Sẵn sàng mượn)
                    string sqlSach = "UPDATE BanSaoSach SET trangThai = 0 WHERE banSaoSach = @maBanSao";
                    SqlCommand cmdSach = new SqlCommand(sqlSach, conn, trans);
                    cmdSach.Parameters.AddWithValue("@maBanSao", maBanSao);
                    cmdSach.ExecuteNonQuery();

                    // Nếu cả 2 lệnh trên đều chạy lọt, ta Commit (Lưu vĩnh viễn vào DB)
                    trans.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    // Nếu có bất kỳ lỗi nào, Rollback (Hoàn tác lại như chưa có chuyện gì xảy ra)
                    trans.Rollback();
                    throw new Exception("Lỗi khi nhận trả sách: " + ex.Message);
                }
            }
        }
    }
}