using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagerDTO; //

namespace LibraryManagerDAO
{
    public class TaiKhoanDAO
    {
        private string connectionString = DbHelper.strConn;

        // 1. Hàm kiểm tra tên tài khoản đã tồn tại chưa
        public bool KiemTraTonTai(string tenTaiKhoan)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT COUNT(*) FROM taikhoan WHERE tenTaiKhoan = @tenTK";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@tenTK", tenTaiKhoan);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0; // Trả về true nếu đã có người dùng
                }
            }
        }
        // 2. Hàm thực hiện Transaction Đăng Ký
        public bool DangKyTaiKhoanMoi(TaiKhoanDTO tk)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // Bắt đầu giao dịch sinh tử
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    // LỆNH 1: Insert vào bảng taikhoan
                    string sqlTaiKhoan = "INSERT INTO taikhoan (tenTaiKhoan, matKhau, ten, gioiTinh, email, soDienThoai) " +
                                         "VALUES (@tenTK, @mk, @ten, @gt, @email, @sdt)";
                    using (SqlCommand cmd1 = new SqlCommand(sqlTaiKhoan, conn, trans))
                    {
                        cmd1.Parameters.AddWithValue("@tenTK", tk.TenTaiKhoan);
                        cmd1.Parameters.AddWithValue("@mk", tk.MatKhau);
                        cmd1.Parameters.AddWithValue("@ten", tk.Ten);
                        cmd1.Parameters.AddWithValue("@gt", tk.GioiTinh);
                        cmd1.Parameters.AddWithValue("@email", tk.Email);
                        cmd1.Parameters.AddWithValue("@sdt", tk.SoDienThoai);
                        cmd1.ExecuteNonQuery();
                    }

                    // LỆNH 2: Tự động sinh mã người mượn mới (NM0001, NM0002...)
                    string sqlGetMaxId = "SELECT MAX(maNguoiMuon) FROM nguoimuon";
                    string newMaNM = "NM0001"; // Mặc định nếu chưa có ai

                    using (SqlCommand cmdMax = new SqlCommand(sqlGetMaxId, conn, trans))
                    {
                        object result = cmdMax.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            string lastMa = result.ToString(); // VD: "NM0015"
                            int number = int.Parse(lastMa.Substring(2)); // Cắt lấy số 15
                            newMaNM = "NM" + (number + 1).ToString("D4"); // Tăng lên 16 -> "NM0016"
                        }
                    }

                    // LỆNH 3: Insert vào bảng nguoimuon với trạng thái 0 (Chưa Active)
                    string sqlNguoiMuon = "INSERT INTO nguoimuon (maNguoiMuon, tenTaiKhoan, trangThai) " +
                                          "VALUES (@maNM, @tenTK, 0)";
                    using (SqlCommand cmd2 = new SqlCommand(sqlNguoiMuon, conn, trans))
                    {
                        cmd2.Parameters.AddWithValue("@maNM", newMaNM);
                        cmd2.Parameters.AddWithValue("@tenTK", tk.TenTaiKhoan);
                        cmd2.ExecuteNonQuery();
                    }

                    trans.Commit(); // Hoàn tất thành công cả 2 bảng
                    return true;
                }
                catch (Exception)
                {
                    trans.Rollback(); // Có lỗi -> Hoàn tác mọi thứ
                    return false;
                }
            }
        }
        public TaiKhoanSession CheckLoginAndGetRole(string username, string password)
        {
            using (SqlConnection conn = DbHelper.getConnection()) // Sử dụng hàm kết nối của em
            {
                conn.Open();

                // 1. Kiểm tra tài khoản và mật khẩu
                string checkUserQuery = "SELECT COUNT(*) FROM taikhoan WHERE tenTaiKhoan = @user AND matKhau = @pass";
                using (SqlCommand cmd = new SqlCommand(checkUserQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);
                    int count = (int)cmd.ExecuteScalar();
                    if (count == 0) return null; // Sai tài khoản hoặc mật khẩu
                }

                // 2. Nếu đúng, kiểm tra xem có phải Thủ thư không
                string checkLibQuery = "SELECT maThuThu FROM thuthu WHERE tenTaiKhoan = @user";
                using (SqlCommand cmd = new SqlCommand(checkLibQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return new TaiKhoanSession(2, null); // Trả về Role 2 (Thủ thư)
                    }
                }

                // 3. Nếu không phải thủ thư, kiểm tra trạng thái Người mượn
                string checkReaderQuery = "SELECT maNguoiMuon, trangThai FROM nguoimuon WHERE tenTaiKhoan = @user";
                using (SqlCommand cmd = new SqlCommand(checkReaderQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string maNguoiMuon = reader["maNguoiMuon"].ToString();
                            int trangThai = Convert.ToInt32(reader["trangThai"]);

                            // trạng thái 1 là Active, 0 là Chưa Active
                            int role = (trangThai == 1) ? 1 : -1;
                            return new TaiKhoanSession(role, maNguoiMuon);
                        }
                    }
                }
                return null;
            }
        }
    }
}
