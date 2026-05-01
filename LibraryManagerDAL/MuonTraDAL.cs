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
    public class MuonTraDAL
    {
        public DataTable KiemTraDieuKienMuon(string maNM)
        {
            // Kiểm tra: Người mượn đã Active (1) và Thẻ mượn chưa hết hạn (0)
            string sql = @"SELECT nm.maNguoiMuon, tm.maTheMuon 
                   FROM nguoimuon nm
                   JOIN themuon tm ON nm.maNguoiMuon = tm.maNguoiMuon
                   WHERE nm.maNguoiMuon = @ma AND nm.trangThai = 1 AND tm.trangThai = 0";

            SqlParameter[] pr = { new SqlParameter("@ma", maNM) };
            return DbHelper.getTable(sql, pr);
        }
        public string SinhMaPhieuMuonTra()
        {
            string prefix = "MT" + DateTime.Now.ToString("yyyyMMdd");
            string sql = "SELECT TOP 1 thongtinmuontrasach FROM thongtinmuontrasach WHERE maThongTinhMuonTraSach LIKE @pre ORDER BY maThongTinhMuonTraSach DESC";
            SqlParameter[] pr = { new SqlParameter("@pre", prefix + "%") };

            object result = DbHelper.executeScalar(sql, pr);
            if (result == null) return prefix + "001";

            // Nếu đã có MT20260429001 -> Tăng lên MT20260429002
            string lastID = result.ToString();
            int nextNum = int.Parse(lastID.Substring(10)) + 1;
            return prefix + nextNum.ToString("D3");
        }
        // 2. Hàm lưu thông tin mượn sách (Transaction)
        public bool LuuPhieuMuon(MuonTraDTO phieu, List<ChiTietMuonDTO> dsChiTiet)
        {
            using (SqlConnection conn = DbHelper.getConnection())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    // Lưu Header
                    string sqlH = "INSERT INTO thongtinmuontrasach VALUES (@maP, @maNM, @nDK, @hT, @tC, 1)";
                    // ... (Phần add parameters giữ nguyên như các bài trước)

                    foreach (var item in dsChiTiet)
                    {
                        // 1. Lưu Detail: bảng chitietmuonsach dùng maBanSao làm khóa ngoại
                        string sqlD = "INSERT INTO chitietmuonsach (maThongTinhMuonTraSach, maBanSao, trangThai, ngayMuon, tienPhat) " +
                                      "VALUES (@maP, @maBS, 1, @ghiChu, 0)";
                        SqlCommand cmdD = new SqlCommand(sqlD, conn, trans);
                        cmdD.Parameters.AddWithValue("@maP", phieu.MaPhieu);
                        cmdD.Parameters.AddWithValue("@maBS", item.BanSaoSach);
                        cmdD.Parameters.AddWithValue("@ghiChu", item.TinhTrangSach);
                        cmdD.ExecuteNonQuery();

                        // 2. Cập nhật bansaosach: Tên cột PK đúng là banSaoSach
                        string sqlUpBS = "UPDATE bansaosach SET trangThai = 1 WHERE banSaoSach = @maBS";
                        SqlCommand cmdUpBS = new SqlCommand(sqlUpBS, conn, trans);
                        cmdUpBS.Parameters.AddWithValue("@maBS", item.BanSaoSach);
                        cmdUpBS.ExecuteNonQuery();
                    }
                    trans.Commit(); return true;
                }
                catch { trans.Rollback(); return false; }
            }
        }        // Lấy mã người mượn và đơn đăng ký mới nhất (trạng thái = 0) từ mã thẻ
        // Lấy mã người mượn và đơn đăng ký mới nhất (trạng thái = 0) từ mã thẻ
        public DataTable LayDonDangKyQuaMaThe(string maThe)
        {
            string sql = @"SELECT TOP 1 h.maThongTinhMuonTraSach, h.maNguoiMuon, h.tienDatCoc, h.hanTra, tk.ten
                   FROM themuon t
                   JOIN nguoimuon n ON t.maNguoiMuon = n.maNguoiMuon
                   JOIN taikhoan tk ON n.tenTaiKhoan = tk.tenTaiKhoan
                   JOIN thongtinmuontrasach h ON n.maNguoiMuon = h.maNguoiMuon
                   WHERE RTRIM(t.maTheMuon) = RTRIM(@maThe) AND h.trangThai = 0
                   ORDER BY h.maThongTinhMuonTraSach DESC";

            SqlParameter[] pr = { new SqlParameter("@maThe", maThe) };
            return DbHelper.getTable(sql, pr);
        }
        // 1. Lấy thông tin đơn đăng ký (Trạng thái = 0) qua Mã thẻ
        public DataTable LayDonDangKy(string maThe)
        {
            // Lấy thông tin Header và Tên độc giả
            string sql = @"SELECT TOP 1 h.maThongTinhMuonTraSach, h.maNguoiMuon, tk.ten, h.tienDatCoc, h.hanTra
                       FROM themuon t
                       JOIN nguoimuon n ON t.maNguoiMuon = n.maNguoiMuon
                       JOIN taikhoan tk ON n.tenTaiKhoan = tk.tenTaiKhoan
                       JOIN thongtinmuontrasach h ON n.maNguoiMuon = h.maNguoiMuon
                       WHERE RTRIM(t.maTheMuon) = RTRIM(@ma) AND h.trangThai = 0
                       ORDER BY h.maThongTinhMuonTraSach DESC";

            SqlParameter[] pr = { new SqlParameter("@ma", maThe) };
            return DbHelper.getTable(sql, pr);
        }
        // 2. Lấy danh sách sách chi tiết của đơn đó
        public DataTable LayChiTietDon(string maGD)
        {
            string sql = @"SELECT ct.maBanSao, s.tenSach, s.maSach
               FROM chitietmuonsach ct
               JOIN bansaosach bs ON ct.maBanSao = bs.banSaoSach
               JOIN sach s ON bs.maSach = s.maSach
               WHERE ct.maThongTinhMuonTraSach = @ma";
            SqlParameter[] pr = { new SqlParameter("@ma", maGD) };
            return DbHelper.getTable(sql, pr);
        }
        // 3. TRANSACTION: Xác nhận giao sách (Chuyển trạng thái 0 -> 1 cho cả 3 bảng)
        public bool XacNhanGiaoSach(string maGD, List<string> dsMaBanSao)
        {
            using (SqlConnection conn = DbHelper.getConnection())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    // Cập nhật Header thành 1 (Đang mượn)
                    SqlCommand cmdH = new SqlCommand("UPDATE thongtinmuontrasach SET trangThai = 1 WHERE maThongTinhMuonTraSach = @ma", conn, trans);
                    cmdH.Parameters.AddWithValue("@ma", maGD);
                    cmdH.ExecuteNonQuery();

                    foreach (string maBS in dsMaBanSao)
                    {
                        // Cập nhật Detail thành 1 (Đang mượn)
                        SqlCommand cmdD = new SqlCommand("UPDATE chitietmuonsach SET trangThai = 1 WHERE maThongTinhMuonTraSach = @ma AND maBanSao = @bs", conn, trans);
                        cmdD.Parameters.AddWithValue("@ma", maGD);
                        cmdD.Parameters.AddWithValue("@bs", maBS);
                        cmdD.ExecuteNonQuery();

                        // Cập nhật trạng thái Bản sao sách thành 1
                        SqlCommand cmdS = new SqlCommand("UPDATE bansaosach SET trangThai = 1 WHERE banSaoSach = @bs", conn, trans);
                        cmdS.Parameters.AddWithValue("@bs", maBS);
                        cmdS.ExecuteNonQuery();
                    }

                    trans.Commit();
                    return true;
                }
                catch { trans.Rollback(); return false; }
            }
        }
        public DataTable LayDanhSachSachDangMuon(string maThe)
        {
            string sql = @"SELECT ct.maThongTinhMuonTraSach, ct.maBanSao, s.tenSach,  
                          h.ngayMuon, h.hanTra, ct.ngayMuon as TinhTrangLucMuon
                   FROM chitietmuonsach ct
                   JOIN thongtinmuontrasach h ON ct.maThongTinhMuonTraSach = h.maThongTinhMuonTraSach
                   JOIN nguoimuon n ON h.maNguoiMuon = n.maNguoiMuon
                   JOIN themuon t ON n.maNguoiMuon = t.maNguoiMuon
                   JOIN bansaosach bs ON ct.maBanSao = bs.banSaoSach
                   JOIN sach s ON bs.maSach = s.maSach
                   WHERE RTRIM(t.maTheMuon) = RTRIM(@ma) AND ct.trangThai = 1";

            SqlParameter[] pr = { new SqlParameter("@ma", maThe) };
            return DbHelper.getTable(sql, pr);
        }
        public bool LuuTraSach(string maPhieu, string maBS, int tienPhat, string lyDo)
        {
            using (SqlConnection conn = DbHelper.getConnection())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    // 1. Cập nhật chi tiết mượn
                    string sqlCT = @"UPDATE chitietmuonsach 
                             SET ngayTra = @ngayTra, tienPhat = @tp, lyDoPhat = @ld, trangThai = 2 
                             WHERE maThongTinhMuonTraSach = @maP AND maBanSao = @maBS";
                    SqlCommand cmdCT = new SqlCommand(sqlCT, conn, trans);
                    cmdCT.Parameters.AddWithValue("@ngayTra", DateTime.Now.ToString("dd/MM/yyyy"));
                    cmdCT.Parameters.AddWithValue("@tp", tienPhat);
                    cmdCT.Parameters.AddWithValue("@ld", lyDo);
                    cmdCT.Parameters.AddWithValue("@maP", maPhieu);
                    cmdCT.Parameters.AddWithValue("@maBS", maBS);
                    cmdCT.ExecuteNonQuery();

                    // 2. Trả lại trạng thái cho bản sao sách
                    string sqlBS = "UPDATE bansaosach SET trangThai = 0 WHERE maBanSao = @maBS";
                    SqlCommand cmdBS = new SqlCommand(sqlBS, conn, trans);
                    cmdBS.Parameters.AddWithValue("@maBS", maBS);
                    cmdBS.ExecuteNonQuery();

                    trans.Commit();
                    return true;
                }
                catch { trans.Rollback(); return false; }
            }
        }
        // Lấy danh sách sách đang mượn (trangThai = 1) dựa trên Mã thẻ
        public DataTable LaySachDangMuon(string maThe)
        {
            // Chú ý: bảng ct (chitietmuonsach) dùng maBanSao
            // bảng bs (bansaosach) dùng banSaoSach
            string sql = @"SELECT ct.maThongTinhMuonTraSach, ct.maBanSao, s.tenSach, 
                          h.hanTra, ct.ngayMuon as GhiChuLucMuon
                   FROM chitietmuonsach ct
                   INNER JOIN thongtinmuontrasach h ON ct.maThongTinhMuonTraSach = h.maThongTinhMuonTraSach
                   INNER JOIN nguoimuon n ON h.maNguoiMuon = n.maNguoiMuon
                   INNER JOIN themuon t ON n.maNguoiMuon = t.maNguoiMuon
                   INNER JOIN bansaosach bs ON ct.maBanSao = bs.banSaoSach 
                   INNER JOIN sach s ON bs.maSach = s.maSach
                   WHERE RTRIM(t.maTheMuon) = RTRIM(@ma) AND ct.trangThai = 1";

            SqlParameter[] pr = { new SqlParameter("@ma", maThe) };
            return DbHelper.getTable(sql, pr);
        }

        // Hàm trả sách dùng Transaction để đảm bảo an toàn dữ liệu
        public bool ThucHienTraSach(string maPhieu, string maBS, int tienPhat, string lyDo)
        {
            using (SqlConnection conn = DbHelper.getConnection())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    // Cập nhật bảng chitietmuonsach: dùng tên cột 'maBanSao'
                    string sqlCT = @"UPDATE chitietmuonsach 
                             SET ngayTra = @nT, tienPhat = @tP, lyDoPhat = @ld, trangThai = 2 
                             WHERE maThongTinhMuonTraSach = @mP AND maBanSao = @mB";
                    SqlCommand cmdCT = new SqlCommand(sqlCT, conn, trans);
                    cmdCT.Parameters.AddWithValue("@nT", DateTime.Now.ToString("dd/MM/yyyy"));
                    cmdCT.Parameters.AddWithValue("@tP", tienPhat);
                    cmdCT.Parameters.AddWithValue("@ld", lyDo);
                    cmdCT.Parameters.AddWithValue("@mP", maPhieu);
                    cmdCT.Parameters.AddWithValue("@mB", maBS);
                    cmdCT.ExecuteNonQuery();

                    // Cập nhật bảng bansaosach: dùng tên cột 'banSaoSach'
                    string sqlBS = "UPDATE bansaosach SET trangThai = 0 WHERE banSaoSach = @mB";
                    SqlCommand cmdBS = new SqlCommand(sqlBS, conn, trans);
                    cmdBS.Parameters.AddWithValue("@mB", maBS);
                    cmdBS.ExecuteNonQuery();

                    trans.Commit(); return true;
                }
                catch { trans.Rollback(); return false; }
            }
        }

    }
}
