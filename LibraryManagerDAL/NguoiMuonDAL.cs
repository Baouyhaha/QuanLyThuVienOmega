using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagerDAO;
using LibraryManagerDTO;

namespace LibraryManagerDAL
{
    public class NguoiMuonDAL
    {
        public DataTable LayThongTinHoSo(string tenTaiKhoan)
        {
            string query = @"SELECT nm.hoTen, nm.maDinhDanh, nm.sdt, nm.email, 
                            nm.maNguoiMuon, nm.soTienDatCoc, nm.trangThai 
                     FROM nguoimuon nm
                     WHERE nm.tenTaiKhoan = @user";

            SqlParameter[] parameters = { new SqlParameter("@user", tenTaiKhoan) };
            return DbHelper.getTable(query, parameters);
        }

        // 2. Hàm gửi yêu cầu kích hoạt
        public bool GuiYeuCauKichHoat(string tenTaiKhoan)
        {// Cập nhật trạng thái thành 2 (Đang chờ duyệt)
            string query = "UPDATE nguoimuon SET trangThai = 2 WHERE tenTaiKhoan = @TenTaiKhoan";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@TenTaiKhoan", tenTaiKhoan)
            };

            return DbHelper.executeNonQuery(query, parameters);

        }
        public DataTable LayThongTinThe(string maNguoiMuon)
        {
            // 1. Câu query chuẩn: Liên kết bảng Thẻ và bảng Người mượn qua Mã người mượn
            string query = @"SELECT t.maTheMuon, t.ngayHetHan, t.trangThai, n.hoTen 
                 FROM themuon t 
                 INNER JOIN nguoimuon n ON t.maNguoiMuon = n.maNguoiMuon 
                 WHERE t.maNguoiMuon = @ma";

            // 2. Logic chốt chặn của em (Giữ nguyên vì rất tốt)
            string giaTriTruyenVao = string.IsNullOrEmpty(maNguoiMuon) ? "KHONG_CO_MA" : maNguoiMuon;

            // 3. Khai báo Parameter (Khớp với @ma ở trên)
            SqlParameter[] pars = {
    new SqlParameter("@ma", giaTriTruyenVao)
};

            // 4. Trả về kết quả
            return DbHelper.getTable(query, pars);
        }
        public int KiemTraTinhTrangThe(string maNguoiMuon)
        {
            // Tìm thẻ mượn dựa vào mã người mượn
            string sql = "SELECT trangThai FROM themuon WHERE maNguoiMuon = @maNM";
            SqlParameter[] pr = { new SqlParameter("@maNM", maNguoiMuon) };

            DataTable dt = LibraryManagerDAO.DbHelper.getTable(sql, pr);

            // Nếu DataTable không có dòng nào -> Sinh viên này chưa từng đăng ký thẻ
            if (dt.Rows.Count == 0)
            {
                return -1;
            }

            // Nếu có thẻ, trả về trạng thái của thẻ (0: Hợp lệ, 1: Hết hạn)
            return Convert.ToInt32(dt.Rows[0]["trangThai"]);
        }
        ///code moi
        ///

        // 1. Hàm kiểm tra trùng tên tài khoản để gọi trước khi đăng ký
        public bool KiemTraTrungTenTaiKhoan(string tenTaiKhoan)
        {
            string sql = "SELECT COUNT(*) FROM taikhoan WHERE tenTaiKhoan = @TenTaiKhoan";
            SqlParameter[] parameters = {
                new SqlParameter("@TenTaiKhoan", SqlDbType.VarChar) { Value = tenTaiKhoan }
            };

            object result = DbHelper.executeScalar(sql, parameters);
            if (result != null)
            {
                return Convert.ToInt32(result) > 0; // Trả về true nếu đã tồn tại
            }
            return false;
        }
        // 2. Hàm thực hiện chèn dữ liệu vào 2 bảng (Sử dụng cấu trúc bảng chuẩn của em)
        public bool DangKyHethong(TaiKhoanDTO tk, NguoiMuonDTO nm)
        {
            using (SqlConnection conn = DbHelper.getConnection())
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // ---- THAO TÁC 1: Thêm vào bảng taikhoan ----
                        string sqlTaiKhoan = @"INSERT INTO taikhoan (tenTaiKhoan, matKhau, ten, gioiTinh, email, soDienThoai) 
                                               VALUES (@TenTaiKhoan, @MatKhau, @Ten, @GioiTinh, @Email, @SoDienThoai)";

                        SqlCommand cmdTK = new SqlCommand(sqlTaiKhoan, conn, transaction);
                        cmdTK.Parameters.AddWithValue("@TenTaiKhoan", tk.TenTaiKhoan);
                        cmdTK.Parameters.AddWithValue("@MatKhau", tk.MatKhau);
                        cmdTK.Parameters.AddWithValue("@Ten", tk.Ten);
                        cmdTK.Parameters.AddWithValue("@GioiTinh", tk.GioiTinh);
                        cmdTK.Parameters.AddWithValue("@Email", tk.Email);
                        cmdTK.Parameters.AddWithValue("@SoDienThoai", tk.SoDienThoai);

                        cmdTK.ExecuteNonQuery();

                        // ---- THAO TÁC 2: Thêm vào bảng nguoimuon ----
                        string sqlNguoiMuon = @"INSERT INTO nguoimuon (maNguoiMuon, tenTaiKhoan, hoTen, ngaySinh, sdt, email, diaChi, loaiKhach, maDinhDanh, soTienDatCoc, trangThai) 
                                                VALUES (@MaNguoiMuon, @TenTaiKhoan, @HoTen, @NgaySinh, @Sdt, @Email, @DiaChi, @LoaiKhach, @MaDinhDanh, @SoTienDatCoc, @TrangThai)";

                        SqlCommand cmdNM = new SqlCommand(sqlNguoiMuon, conn, transaction);
                        cmdNM.Parameters.AddWithValue("@MaNguoiMuon", nm.MaNguoiMuon);
                        cmdNM.Parameters.AddWithValue("@TenTaiKhoan", nm.TenTaiKhoan);
                        cmdNM.Parameters.AddWithValue("@HoTen", nm.HoTen);
                        cmdNM.Parameters.AddWithValue("@NgaySinh", nm.NgaySinh);
                        cmdNM.Parameters.AddWithValue("@Sdt", nm.Sdt);
                        cmdNM.Parameters.AddWithValue("@Email", nm.Email);
                        cmdNM.Parameters.AddWithValue("@DiaChi", nm.DiaChi);
                        cmdNM.Parameters.AddWithValue("@LoaiKhach", nm.LoaiKhach);
                        cmdNM.Parameters.AddWithValue("@MaDinhDanh", nm.MaDinhDanh);
                        cmdNM.Parameters.AddWithValue("@SoTienDatCoc", nm.SoTienDatCoc); // Mặc định truyền vào là 0
                        cmdNM.Parameters.AddWithValue("@TrangThai", nm.TrangThai);       // Mặc định truyền vào là 1 theo yêu cầu

                        cmdNM.ExecuteNonQuery();

                        // Nếu cả 2 câu lệnh đều thành công, tiến hành Commit để lưu thật vào DB
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        // Có lỗi ở bất kỳ đâu sẽ lập tức hủy bỏ toàn bộ, không để lại dữ liệu rác
                        transaction.Rollback();
                        throw new Exception("Lỗi thực thi tại tầng DAO: " + ex.Message);
                    }
                }
            }
        }
    }
}
