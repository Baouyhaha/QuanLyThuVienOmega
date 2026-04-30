using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerDAL
{
    public class ThongTinMuonTraDAL
    {
        // Nhớ thay bằng chuỗi kết nối của em (hoặc gọi từ DbHelper của em ra)
        private string connectionString = "Data Source=.;Initial Catalog=QuanLyThuVien;Integrated Security=True";

        // Hàm Transaction xử lý chốt đơn
        public bool TaoPhieuMuonTransaction(string maPhieu, string maNguoiMuon, string ngayDangKi, string hanTra, int tienDatCoc, DataTable gioHang)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // BẮT ĐẦU GIAO DỊCH (TRANSACTION)
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    // LỆNH 1: Insert vào bảng thông tin tổng (thongtinmuontrasach)
                    string sqlPhieu = @"INSERT INTO thongtinmuontrasach (maThongTinhMuonTraSach, maNguoiMuon, ngayDangKi, hanTra, tienDatCoc, trangThai) 
                                        VALUES (@maPhieu, @maNguoiMuon, @ngayDK, @hanTra, @tienCoc, 0)"; // 0: Đã đăng ký

                    using (SqlCommand cmdPhieu = new SqlCommand(sqlPhieu, conn, trans))
                    {
                        cmdPhieu.Parameters.AddWithValue("@maPhieu", maPhieu);
                        cmdPhieu.Parameters.AddWithValue("@maNguoiMuon", maNguoiMuon);
                        cmdPhieu.Parameters.AddWithValue("@ngayDK", ngayDangKi);
                        cmdPhieu.Parameters.AddWithValue("@hanTra", hanTra);
                        cmdPhieu.Parameters.AddWithValue("@tienCoc", tienDatCoc);
                        cmdPhieu.ExecuteNonQuery();
                    }

                    // LỆNH 2: Vòng lặp bốc sách vật lý và Insert chi tiết
                    foreach (DataRow row in gioHang.Rows)
                    {
                        string maSach = row["Mã Sách"].ToString();

                        // 2.1 Rút ra đích danh 1 mã bản sao vật lý đang rảnh
                        string sqlTimBanSao = @"SELECT TOP 1 banSaoSach FROM bansaosach 
                                                WHERE maSach = @maSach AND loaiBanSao = 2 AND trangThai = 0 AND xoa = 0";
                        string maBanSaoVatLy = "";

                        using (SqlCommand cmdTim = new SqlCommand(sqlTimBanSao, conn, trans))
                        {
                            cmdTim.Parameters.AddWithValue("@maSach", maSach);
                            object result = cmdTim.ExecuteScalar();

                            if (result == null)
                            {
                                // Nếu không tìm thấy (do người khác vừa mượn mất), quăng lỗi để Rollback ngay
                                throw new Exception($"Rất tiếc! Cuốn sách '{row["Tên Sách"]}' vừa bị người khác đăng ký mất. Vui lòng xóa khỏi giỏ và chọn sách khác.");
                            }
                            maBanSaoVatLy = result.ToString();
                        }

                        // 2.2 Insert vào bảng chi tiết (chitietmuonsach)
                        string sqlChiTiet = @"INSERT INTO chitietmuonsach (maThongTinhMuonTraSach, maBanSao, trangThai, ngayMuon, ngayTra, tienPhat, lyDoPhat) 
                                              VALUES (@maPhieu, @maBanSao, 0, '', '', 0, '')"; // 0: Đã đăng ký
                        using (SqlCommand cmdChiTiet = new SqlCommand(sqlChiTiet, conn, trans))
                        {
                            cmdChiTiet.Parameters.AddWithValue("@maPhieu", maPhieu);
                            cmdChiTiet.Parameters.AddWithValue("@maBanSao", maBanSaoVatLy);
                            cmdChiTiet.ExecuteNonQuery();
                        }

                        // 2.3 Cập nhật trạng thái cuốn sách vật lý đó thành 2 (Đã đăng ký / Giữ chỗ)
                        string sqlUpdateBanSao = "UPDATE bansaosach SET trangThai = 2 WHERE banSaoSach = @maBanSao";
                        using (SqlCommand cmdUpdate = new SqlCommand(sqlUpdateBanSao, conn, trans))
                        {
                            cmdUpdate.Parameters.AddWithValue("@maBanSao", maBanSaoVatLy);
                            cmdUpdate.ExecuteNonQuery();
                        }
                    }

                    // NẾU CHẠY ĐẾN ĐÂY MÀ KHÔNG LỖI -> LƯU CHÍNH THỨC
                    trans.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    // NẾU CÓ BẤT KỲ LỖI NÀO -> HỦY BỎ TOÀN BỘ CÁC LỆNH ĐÃ CHẠY BÊN TRÊN
                    trans.Rollback();
                    throw new Exception(ex.Message); // Ném lỗi lên BUS để báo cho người dùng
                }
            }
        }
    }
}
