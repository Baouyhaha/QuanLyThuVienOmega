using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagerDAO;

namespace LibraryManagerDAL
{
    public class TheMuonDAL
    {
        // Khởi tạo đối tượng DbHelper của em
        private DbHelper dbHelper = new DbHelper();

        public bool PhatHanhTheMoi(string tenTaiKhoan, string maDinhDanh, int tienCoc, string maNguoiMuon, string maTheMuon, DateTime ngayHetHan)
        {
            // Sử dụng hàm getConnection() từ DbHelper của em thay vì dùng chuỗi kết nối
            using (SqlConnection conn = DbHelper.getConnection())
            {
                conn.Open();
                // Bắt đầu một giao dịch (Transaction)
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. Thêm vào bảng NguoiMuon
                    string sqlNguoiMuon = @"INSERT INTO NguoiMuon (maNguoiMuon, tenTaiKhoan, maDinhDanh, soTienDatCoc, trangThai) 
                                            VALUES (@maNguoiMuon, @tenTaiKhoan, @maDinhDanh, @tienCoc, 1)";
                    using (SqlCommand cmd1 = new SqlCommand(sqlNguoiMuon, conn, transaction))
                    {
                        cmd1.Parameters.AddWithValue("@maNguoiMuon", maNguoiMuon);
                        cmd1.Parameters.AddWithValue("@tenTaiKhoan", tenTaiKhoan);
                        cmd1.Parameters.AddWithValue("@maDinhDanh", string.IsNullOrEmpty(maDinhDanh) ? (object)DBNull.Value : maDinhDanh);
                        cmd1.Parameters.AddWithValue("@tienCoc", tienCoc);
                        cmd1.ExecuteNonQuery();
                    }

                    // 2. Thêm vào bảng TheMuon
                    string sqlTheMuon = @"INSERT INTO TheMuon (maTheMuon, maNguoiMuon, ngayHetHan, trangThai) 
                                          VALUES (@maTheMuon, @maNguoiMuon, @ngayHetHan, 1)";
                    using (SqlCommand cmd2 = new SqlCommand(sqlTheMuon, conn, transaction))
                    {
                        cmd2.Parameters.AddWithValue("@maTheMuon", maTheMuon);
                        cmd2.Parameters.AddWithValue("@maNguoiMuon", maNguoiMuon);
                        cmd2.Parameters.AddWithValue("@ngayHetHan", ngayHetHan.ToString("MM/dd/yyyy")); // Định dạng ngày tháng cho SQL
                        cmd2.ExecuteNonQuery();
                    }

                    // Nếu cả 2 lệnh trên đều chạy lọt, ta Commit (chốt lưu) dữ liệu
                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    // Nếu có bất kỳ lỗi nào, Rollback (quay xe), hủy bỏ mọi thay đổi
                    transaction.Rollback();
                    throw new Exception("Lỗi khi cấp thẻ DAL: " + ex.Message);
                }
            }
        }
        //  Hàm lấy thông tin chi tiết của thẻ dựa vào Mã Thẻ
        public DataTable LayThongTinThe(string maTheMuon)
        {
            // Kết nối 3 bảng: TheMuon, NguoiMuon, TaiKhoan để lấy đủ thông tin
            string sql = @"SELECT tm.maTheMuon, tm.ngayHetHan, tk.tenTaiKhoan, tk.ten, tk.soDienThoai
                   FROM TheMuon tm
                   INNER JOIN NguoiMuon nm ON tm.maNguoiMuon = nm.maNguoiMuon
                   INNER JOIN TaiKhoan tk ON nm.tenTaiKhoan = tk.tenTaiKhoan
                   WHERE tm.maTheMuon = @maTheMuon";

            DataTable dt = new DataTable();
            using (SqlConnection conn = DbHelper.getConnection())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@maTheMuon", maTheMuon);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

        //  Hàm cập nhật Ngày hết hạn mới xuống Database
        public bool CapNhatNgayHetHan(string maTheMuon, string ngayHetHanMoi)
        {
            string sql = "UPDATE TheMuon SET ngayHetHan = @ngayMoi WHERE maTheMuon = @maTheMuon";
            using (SqlConnection conn = DbHelper.getConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    // Trong DB của em ngayHetHan đang là VARCHAR, nên ta truyền chuỗi vào
                    cmd.Parameters.AddWithValue("@ngayMoi", ngayHetHanMoi);
                    cmd.Parameters.AddWithValue("@maTheMuon", maTheMuon);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool CapNhatThongTinChiTiet(string maThe, string hoTen, string sdt, DateTime ngaySinh)
        {
            // Chúng ta sẽ cập nhật bảng taikhoan dựa trên mã thẻ mượn
            // Lưu ý: Nếu DB của em thực sự không có cột ngaySinh, hãy xóa dòng ngaySinh = @ns đi nhé!
            string sql = @"UPDATE taikhoan 
                   SET ten = @ht, 
                       soDienThoai = @sdt
                       -- , ngaySinh = @ns  <-- Bỏ comment nếu DB có cột này
                   WHERE tenTaiKhoan = (
                       SELECT TOP 1 nm.tenTaiKhoan 
                       FROM nguoimuon nm 
                       JOIN themuon tm ON nm.maNguoiMuon = tm.maNguoiMuon 
                       WHERE RTRIM(tm.maTheMuon) = RTRIM(@maThe)
                   )";

            SqlParameter[] pr = {
        new SqlParameter("@maThe", maThe),
        new SqlParameter("@ht", hoTen),
        new SqlParameter("@sdt", sdt)
        // , new SqlParameter("@ns", ngaySinh) <-- Bỏ comment nếu dùng ngaySinh
    };

            return DbHelper.executeNonQuery(sql, pr);
        }

        // Lấy toàn bộ danh sách thẻ (Join 3 bảng)
        public DataTable LayTatCaThe()
        {
            string sql = @"SELECT tm.maTheMuon, tk.ten as HoTen, tm.ngayHetHan, 
                              tm.trangThai
                       FROM themuon tm
                       JOIN nguoimuon nm ON tm.maNguoiMuon = nm.maNguoiMuon
                       JOIN taikhoan tk ON nm.tenTaiKhoan = tk.tenTaiKhoan";
            return DbHelper.getTable(sql);
        }

        // Tìm kiếm thẻ theo Tên hoặc Mã thẻ
        public DataTable TimKiemThe(string keyword)
        {
            string sql = @"SELECT tm.maTheMuon, tk.ten as HoTen, tm.ngayHetHan, tm.trangThai
                       FROM themuon tm
                       JOIN nguoimuon nm ON tm.maNguoiMuon = nm.maNguoiMuon
                       JOIN taikhoan tk ON nm.tenTaiKhoan = tk.tenTaiKhoan
                       WHERE tm.maTheMuon LIKE @k OR tk.ten LIKE @k";
            SqlParameter[] pr = { new SqlParameter("@k", "%" + keyword + "%") };
            return DbHelper.getTable(sql, pr);
        }

        // Xóa thẻ (Hoặc cập nhật trạng thái thành 'Đã xóa' tùy nghiệp vụ)
        public bool XoaThe(string maThe)
        {
            string sql = "DELETE FROM themuon WHERE maTheMuon = @ma";
            SqlParameter[] pr = { new SqlParameter("@ma", maThe) };
            return DbHelper.executeNonQuery(sql, pr);
        }

        // Hàm cập nhật trạng thái thẻ mượn
        public bool UpdateCardStatus(string maThe, int trangThai)
        {
            string sql = "UPDATE themuon SET trangThai = @tt WHERE maTheMuon = @ma";
            SqlParameter[] pr = {
        new SqlParameter("@tt", trangThai),
        new SqlParameter("@ma", maThe)
    };

            // Sử dụng Convert.ToInt32 thay vì (int) để tránh lỗi CS0030
            return Convert.ToInt32(DbHelper.executeNonQuery(sql, pr)) > 0;
        }
        public DataTable TimKiemThongTinThe(string maThe)
        {
            // Đảm bảo có t.trangThai trong danh sách SELECT
            string sql = @"SELECT t.maTheMuon, t.ngayHetHan, t.trangThai, n.tenTaiKhoan, tk.ten, tk.soDienThoai
                   FROM themuon t
                   INNER JOIN nguoimuon n ON t.maNguoiMuon = n.maNguoiMuon
                   INNER JOIN taikhoan tk ON n.tenTaiKhoan = tk.tenTaiKhoan
                   WHERE RTRIM(t.maTheMuon) = RTRIM(@ma)";

            SqlParameter[] pr = { new SqlParameter("@ma", maThe) };
            return DbHelper.getTable(sql, pr); // Trả về bảng chứa đầy đủ các cột bao gồm trangThai
        }

        // Hàm kiểm tra mã kích hoạt và cập nhật trạng thái
        public bool KichHoatThe(string tenTaiKhoan, string maKichHoat)
        {
            // 1. Kiểm tra mã kích hoạt có khớp với tên tài khoản không
            string queryCheck = @"SELECT nm.maNguoiMuon 
                                  FROM themuon tm 
                                  INNER JOIN nguoimuon nm ON tm.maNguoiMuon = nm.maNguoiMuon 
                                  WHERE nm.tenTaiKhoan = @tk AND tm.maKichHoat = @mkh";
            SqlParameter[] parsCheck = {
                new SqlParameter("@tk", tenTaiKhoan),
                new SqlParameter("@mkh", maKichHoat)
            };

            object result = DbHelper.executeScalar(queryCheck, parsCheck);

            if (result != null)
            {
                // Nếu tìm thấy, lấy mã người mượn và Update trạng thái
                string maNguoiMuon = result.ToString();
                string queryUpdate = "UPDATE nguoimuon SET trangThai = 1 WHERE maNguoiMuon = @ma";
                SqlParameter[] parsUpdate = { new SqlParameter("@ma", maNguoiMuon) };

                return DbHelper.executeNonQuery(queryUpdate, parsUpdate);
            }

            // Trả về false nếu sai mã kích hoạt hoặc sai tên tài khoản
            return false;
        }
    }


}
