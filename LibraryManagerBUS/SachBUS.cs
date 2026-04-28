using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagerDAL;
using LibraryManagerDAO;
using LibraryManagerDTO;

namespace LibraryManagerBUS
{
    public class SachBUS
    {
        private SachDAL sachDAL = new SachDAL();

        public string SinhMaSachTuDong()
        {
            string maxID = sachDAL.GetMaxMaSach();
            if (string.IsNullOrEmpty(maxID))
            {
                return "S001"; // Nếu chưa có sách nào, bắt đầu từ S001
            }

            // Tách chữ 'S' ra, lấy phần số đằng sau
            // Ví dụ: "S001" -> "001"
            string numericPart = maxID.Substring(1);
            int nextNumber = int.Parse(numericPart) + 1;

            // Ghép lại thành mã mới, định dạng 3 chữ số (D3)
            // Ví dụ: 2 -> "S002", 10 -> "S010"
            return "S" + nextNumber.ToString("D3");
        }

        public string SinhMaBanSao(string maSach)
        {
            object maxSTT = sachDAL.GetMaxSoThuTu(maSach);
            int nextSTT = 1;

            if (maxSTT != null && maxSTT != DBNull.Value)
            {
                nextSTT = Convert.ToInt32(maxSTT) + 1;
            }

            // Quy luật: [MaSach]-[STT] (Ví dụ: S001-01)
            return maSach + "-" + nextSTT.ToString("D2");
        }
        public int LaySoThuTuLonNhat(string maSach)
        {
            // Gọi DAL lấy kết quả thô (object)
            object result = sachDAL.GetMaxSoThuTu(maSach);

            // Nếu chưa có cuốn nào (null) thì trả về 0, ngược lại convert sang int
            if (result == null || result == DBNull.Value) return 0;
            return Convert.ToInt32(result);
        }
        public bool LuuPhieuNhapSach(SachDTO sach, List<int> dsMaTacGia, List<BanSaoSachDTO> dsBanSao)
        {
            using (SqlConnection conn = DbHelper.getConnection())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction(); // Bắt đầu giao dịch

                try
                {
                    // 1. Lưu vào bảng sach
                    string sqlSach = "INSERT INTO sach VALUES (@ma, @ten, @nxb, @isbn, @sl)";
                    SqlParameter[] p1 = {
                new SqlParameter("@ma", sach.maSach),
                new SqlParameter("@ten", sach.tenSach),
                new SqlParameter("@nxb", sach.maNhaPhatHanh),
                new SqlParameter("@isbn", sach.isbn),
                new SqlParameter("@sl", sach.soLuongHienCo)
            };
                    ExecuteWithTrans(sqlSach, p1, conn, trans);

                    // 2. Lưu vào bảng chitiettacgia (vòng lặp)
                    foreach (int maTG in dsMaTacGia)
                    {
                        string sqlTG = "INSERT INTO chitiettacgia VALUES (@maS, @maTG)";
                        SqlParameter[] p2 = {
                    new SqlParameter("@maS", sach.maSach),
                    new SqlParameter("@maTG", maTG)
                };
                        ExecuteWithTrans(sqlTG, p2, conn, trans);
                    }

                    // 3. Lưu vào bảng bansaosach (vòng lặp từ Grid)
                    foreach (var bs in dsBanSao)
                    {
                        string sqlBS = "INSERT INTO bansaosach VALUES (@maBS, @maS, @stt, @loai, @gia, @tt, 0)";
                        SqlParameter[] p3 = {
                    new SqlParameter("@maBS", bs.banSaoSach),
                    new SqlParameter("@maS", bs.maSach),
                    new SqlParameter("@stt", bs.soThuTu),
                    new SqlParameter("@loai", bs.loaiBanSao),
                    new SqlParameter("@gia", bs.gia),
                    new SqlParameter("@tt", bs.trangThai)
                };
                        ExecuteWithTrans(sqlBS, p3, conn, trans);
                    }

                    trans.Commit(); // Nếu mọi thứ ổn, lưu vĩnh viễn vào DB
                    return true;
                }
                catch (Exception ex)
                {
                    trans.Rollback(); // Nếu có bất kỳ lỗi nào, hủy bỏ toàn bộ (Data sạch)
                    return false;
                }
            }
        }

        // Hàm phụ hỗ trợ chạy lệnh SQL kèm Transaction
        private void ExecuteWithTrans(string sql, SqlParameter[] pr, SqlConnection conn, SqlTransaction trans)
        {
            SqlCommand cmd = new SqlCommand(sql, conn, trans);
            cmd.Parameters.AddRange(pr);
            cmd.ExecuteNonQuery();
        }
        public DataTable LayDanhSachSach()
        {
            return sachDAL.GetAllSachFullInfo();
        }

        public DataTable TimKiemSach(string keyword)
        {
            return sachDAL.SearchSach(keyword);
        }
        public string XoaSachNghiepVu(string maSach)
        {
            // 1. Kiểm tra xem sách có đang bị mượn không
            if (sachDAL.KiemTraSachDangMuon(maSach))
            {
                return "Không thể xóa vì có bản sao của sách này đang được mượn!";
            }

            // 2. Thực hiện xóa
            if (sachDAL.XoaSach(maSach))
            {
                return "Thành công";
            }
            return "Lỗi hệ thống khi xóa sách.";
        }
        public bool CapNhatToanBoSach(SachDTO sach, List<int> dsMaTG, List<BanSaoSachDTO> dsBS)
        {
            // Gọi xuống hàm tương ứng ở lớp DAL
            return sachDAL.CapNhatToanBoSach(sach, dsMaTG, dsBS);
        }
        // 1. Gọi DAL lấy thông tin sách
        public DataTable LayThongTinChiTiet(string maSach)
        {
            return sachDAL.LayThongTinChiTiet(maSach);
        }

        // 2. Gọi DAL lấy danh sách tác giả
        public DataTable LayDSTacGiaCuaSach(string maSach)
        {
            return sachDAL.LayDSTacGiaCuaSach(maSach);
        }

        // 3. Gọi DAL lấy danh sách bản sao
        public DataTable LayDSBanSaoCuaSach(string maSach)
        {
            return sachDAL.LayDSBanSaoCuaSach(maSach);
        }
        // Gọi hàm lấy danh sách từ DAL
        public DataTable GetDanhSachSachFrmTimKiem()
        {
            return sachDAL.GetDanhSachSachFrmTimKiem();
        }

        // Gọi hàm tìm kiếm từ DAL
        public DataTable TimKiemSachThongMinh(string tuKhoa)
        {
            return sachDAL.TimKiemSachThongMinh(tuKhoa);
        }
    }
}
