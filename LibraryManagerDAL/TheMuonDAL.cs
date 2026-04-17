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
        //private DbHelper dbHelper = new DbHelper();

        public bool PhatHanhTheMoi(string tenTaiKhoan, string mssv, int tienCoc, string maNguoiMuon, string maTheMuon, DateTime ngayHetHan)
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
                    string sqlNguoiMuon = @"INSERT INTO NguoiMuon (maNguoiMuon, tenTaiKhoan, mssv, soTienDatCoc, trangThai) 
                                            VALUES (@maNguoiMuon, @tenTaiKhoan, @mssv, @tienCoc, 1)";
                    using (SqlCommand cmd1 = new SqlCommand(sqlNguoiMuon, conn, transaction))
                    {
                        cmd1.Parameters.AddWithValue("@maNguoiMuon", maNguoiMuon);
                        cmd1.Parameters.AddWithValue("@tenTaiKhoan", tenTaiKhoan);
                        cmd1.Parameters.AddWithValue("@mssv", string.IsNullOrEmpty(mssv) ? (object)DBNull.Value : mssv);
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
    }

}
