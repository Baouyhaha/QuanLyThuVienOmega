using LibraryManagerDAO;
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
        // 1. HÀM TẠO PHIẾU (Dành cho Form Đăng kýx của Sinh viên)
        public bool TaoPhieuMuonTransaction(string maPhieu, string maNguoiMuon, string ngayDangKi, string hanTra, int tienDatCoc, DataTable gioHang)
        {
            using (SqlConnection conn = DbHelper.getConnection()) // Dùng DbHelper cho chuyên nghiệp
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    // LỆNH 1: Insert phiếu tổng (Trạng thái 0: Chờ duyệt)
                    string sqlPhieu = @"INSERT INTO thongtinmuontrasach (maThongTinhMuonTraSach, maNguoiMuon, ngayDangKi, hanTra, tienDatCoc, trangThai) 
                                        VALUES (@maPhieu, @maNguoiMuon, @ngayDK, @hanTra, @tienCoc, 0)";

                    using (SqlCommand cmdPhieu = new SqlCommand(sqlPhieu, conn, trans))
                    {
                        cmdPhieu.Parameters.AddWithValue("@maPhieu", maPhieu);
                        cmdPhieu.Parameters.AddWithValue("@maNguoiMuon", maNguoiMuon);
                        cmdPhieu.Parameters.AddWithValue("@ngayDK", ngayDangKi);
                        cmdPhieu.Parameters.AddWithValue("@hanTra", hanTra);
                        cmdPhieu.Parameters.AddWithValue("@tienCoc", tienDatCoc);
                        cmdPhieu.ExecuteNonQuery();
                    }

                    // LỆNH 2: Vòng lặp bốc sách và cập nhật trạng thái
                    foreach (DataRow row in gioHang.Rows)
                    {
                        // 2.1: LẤY TRỰC TIẾP MÃ BẢN SAO TỪ GIỎ HÀNG 
                        // (Bỏ luôn đoạn SQL đi tìm kiếm lằng nhằng lúc nãy)
                        string maBanSaoVatLy = row["Mã Sách"].ToString();

                        // 2.2 Insert vào bảng chi tiết (Trạng thái 0: Đã đăng ký)
                        string sqlChiTiet = @"INSERT INTO chitietmuonsach (maThongTinhMuonTraSach, maBanSao, trangThai) 
                          VALUES (@maPhieu, @maBanSao, 0)";
                        using (SqlCommand cmdCT = new SqlCommand(sqlChiTiet, conn, trans))
                        {
                            cmdCT.Parameters.AddWithValue("@maPhieu", maPhieu);
                            cmdCT.Parameters.AddWithValue("@maBanSao", maBanSaoVatLy); // Ném thẳng mã bản sao vào đây
                            cmdCT.ExecuteNonQuery();
                        }

                        // 2.3 Chuyển trạng thái bản sao sang 2 (Đã đăng ký/Giữ chỗ)
                        string sqlUpBS = "UPDATE bansaosach SET trangThai = 2 WHERE banSaoSach = @maBS";
                        using (SqlCommand cmdUp = new SqlCommand(sqlUpBS, conn, trans))
                        {
                            cmdUp.Parameters.AddWithValue("@maBS", maBanSaoVatLy);
                            cmdUp.ExecuteNonQuery();
                        }
                    }

                    trans.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw ex;
                }
            }
        }

        // 2. HÀM PHÊ DUYỆT & GIAO SÁCH (Dành cho Form Quản lý của Thủ thư)
        public bool PheDuyetGiaoSach(string maPhieu)
        {
            using (SqlConnection conn = DbHelper.getConnection())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    // 1. Cập nhật trạng thái phiếu mượn tổng quát (Trạng thái 1: Đã giao sách)
                    string sqlPhieu = "UPDATE thongtinmuontrasach SET trangThai = 1 WHERE maThongTinhMuonTraSach = @mp";
                    using (SqlCommand cmd1 = new SqlCommand(sqlPhieu, conn, trans))
                    {
                        cmd1.Parameters.AddWithValue("@mp", maPhieu);
                        cmd1.ExecuteNonQuery();
                    }

                    // 2. Cập nhật trạng thái từng cuốn sách trong phiếu (Chuyển từ 2 - Đã đăng ký sang 1 - Đang mượn)
                    // Đồng thời cập nhật ngày mượn thực tế vào bảng chi tiết
                    string sqlUpdateSach = @"
                UPDATE bansaosach SET trangThai = 1 
                WHERE banSaoSach IN (SELECT maBanSao FROM chitietmuonsach WHERE maThongTinhMuonTraSach = @mp);
                
                UPDATE chitietmuonsach SET trangThai = 1, ngayMuon = GETDATE() 
                WHERE maThongTinhMuonTraSach = @mp;";

                    using (SqlCommand cmd2 = new SqlCommand(sqlUpdateSach, conn, trans))
                    {
                        cmd2.Parameters.AddWithValue("@mp", maPhieu);
                        cmd2.ExecuteNonQuery();
                    }

                    trans.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw ex;
                }

            }
        }
        public DataTable GetDsPhieuChoDuyet()
        {
            // SQL bổ sung thêm cột trangThaiThe và dùng sub-query để đếm số lượng sách trong phiếu
            string sql = @"SELECT p.maThongTinhMuonTraSach, n.hoTen, p.ngayDangKi, p.tienDatCoc, 
                          t.trangThai AS trangThaiThe,
                          (SELECT COUNT(*) FROM chitietmuonsach ct 
                           WHERE ct.maThongTinhMuonTraSach = p.maThongTinhMuonTraSach) AS soLuong
                   FROM thongtinmuontrasach p
                   JOIN nguoimuon n ON p.maNguoiMuon = n.maNguoiMuon
                   JOIN themuon t ON n.maNguoiMuon = t.maNguoiMuon
                   WHERE p.trangThai = 0";

            return DbHelper.getTable(sql);
        }
        public DataTable GetChiTietSachTrongPhieu(string maPhieu)
        {
            // Thầy dùng đúng tên cột maThongTinhMuonTraSach có chữ 'h' như code trước của em
            string sql = @"SELECT s.maSach, s.tenSach, bs.banSaoSach, bs.gia
                   FROM chitietmuonsach ct
                   JOIN bansaosach bs ON ct.maBanSao = bs.banSaoSach
                   JOIN sach s ON bs.maSach = s.maSach
                   WHERE ct.maThongTinhMuonTraSach = @mp";

            SqlParameter[] pr = { new SqlParameter("@mp", maPhieu) };
            return DbHelper.getTable(sql, pr);
        }
        public bool HuyPhieuMuon(string maPhieu)
        {
            using (SqlConnection conn = DbHelper.getConnection()) // Dùng DbHelper cho chuẩn
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    // Lệnh 1: Update trạng thái phiếu thành -1
                    string sqlPhieu = "UPDATE thongtinmuontrasach SET trangThai = -1 WHERE maThongTinhMuonTraSach = @mp";
                    using (SqlCommand cmd1 = new SqlCommand(sqlPhieu, conn, trans))
                    {
                        cmd1.Parameters.AddWithValue("@mp", maPhieu);
                        cmd1.ExecuteNonQuery();
                    }

                    // Lệnh 2: Giải phóng sách (đưa về trạng thái 0)
                    string sqlSach = "UPDATE bansaosach SET trangThai = 0 WHERE banSaoSach IN (SELECT maBanSao FROM chitietmuonsach WHERE maThongTinhMuonTraSach = @mp)";
                    using (SqlCommand cmd2 = new SqlCommand(sqlSach, conn, trans))
                    {
                        cmd2.Parameters.AddWithValue("@mp", maPhieu);
                        cmd2.ExecuteNonQuery();
                    }

                    trans.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw ex;
                }
            }
        }
        public DataTable LocPhieuMuon(string tuKhoa, int trangThai)
        {
            // Bổ sung: t.trangThai (trạng thái thẻ) và Sub-query để đếm số lượng sách
            string sql = @"SELECT p.maThongTinhMuonTraSach, n.hoTen, p.ngayDangKi, p.tienDatCoc, p.trangThai,
                           t.trangThai AS trangThaiThe,
                           (SELECT COUNT(*) FROM chitietmuonsach ct 
                            WHERE ct.maThongTinhMuonTraSach = p.maThongTinhMuonTraSach) AS soLuong
                   FROM thongtinmuontrasach p 
                   JOIN nguoimuon n ON p.maNguoiMuon = n.maNguoiMuon
                   JOIN themuon t ON n.maNguoiMuon = t.maNguoiMuon
                   WHERE (p.maThongTinhMuonTraSach LIKE @tk OR n.hoTen LIKE @tk OR p.maNguoiMuon LIKE @tk)";

            // Nếu không phải chọn "Tất cả" (-2)
            if (trangThai != -2)
            {
                sql += " AND p.trangThai = @tt";
            }

            SqlParameter[] pr = {
        new SqlParameter("@tk", "%" + tuKhoa + "%"),
        new SqlParameter("@tt", trangThai)
    };

            // Thực thi và trả về DataTable cho BUS
            return DbHelper.getTable(sql, pr);
        }
        public DataTable TimKiemNhanhChoThuThu(string tuKhoa)
        {
            // Tìm kiếm "3 trong 1": Mã phiếu, Mã SV hoặc Tên SV
            string sql = @"SELECT p.maThongTinhMuonTraSach, n.hoTen, p.ngayDangKi, p.tienDatCoc, p.trangThai 
                   FROM thongtinmuontrasach p 
                   JOIN nguoimuon n ON p.maNguoiMuon = n.maNguoiMuon 
                   WHERE p.maThongTinhMuonTraSach LIKE @tk 
                      OR p.maNguoiMuon LIKE @tk 
                      OR n.hoTen LIKE @tk";

            // Thêm dấu % vào hai đầu để tìm kiếm chứa (contains)
            SqlParameter[] pr = {
        new SqlParameter("@tk", "%" + tuKhoa + "%")
    };

            return DbHelper.getTable(sql, pr);
        }
    }
}
