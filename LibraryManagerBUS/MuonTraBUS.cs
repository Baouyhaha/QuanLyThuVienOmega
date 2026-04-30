using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagerDAL;
using LibraryManagerDTO;

namespace LibraryManagerBUS
{
    public class MuonTraBUS
    {
        private MuonTraDAL dal = new MuonTraDAL();
        public DataTable LaySachDangMuon(string maThe) => dal.LaySachDangMuon(maThe);

        // HÀM TÍNH TIỀN PHẠT (Cực kỳ quan trọng)
        public int TinhTienPhat(string hanTraStr, DateTime ngayTraThucTe)
        {
            try
            {
                // Parse ngay từ varchar(10) trong DB
                DateTime hanTra = DateTime.ParseExact(hanTraStr, "dd/MM/yyyy", null);

                if (ngayTraThucTe > hanTra)
                {
                    int soNgayTre = (ngayTraThucTe - hanTra).Days;
                    return soNgayTre * 5000; // Phạt 5.000đ/ngày trễ
                }
            }
            catch { return 0; }
            return 0;
        }
        public string ThucHienMuonSach(MuonTraDTO phieu, List<ChiTietMuonDTO> dsChiTiet)
        {
            if (dsChiTiet.Count == 0) return "Vui lòng chọn ít nhất một cuốn sách!";

            try
            {
                if (dal.LuuPhieuMuon(phieu, dsChiTiet))
                    return "SUCCESS";
                return "Không thể lưu phiếu mượn.";
            }
            catch (Exception ex)
            {
                return "Lỗi hệ thống: " + ex.Message;
            }
        }
        public bool ThuThuXacNhanGiaoSach(string maGiaoDich, string maBanSao)
        {
            // 1. Cập nhật Header thành 1 (Đang mượn)
            string sqlH = "UPDATE thongtinmuontrasach SET trangThai = 1 WHERE maThongTinhMuonTraSach = @ma";

            // 2. Cập nhật Detail thành 1 (Đang mượn)
            string sqlD = "UPDATE chitietmuonsach SET trangThai = 1 WHERE maThongTinhMuonTraSach = @ma AND maBanSao = @maBS";

            // 3. Cập nhật trạng thái Sách thành 1 (Đang mượn)
            string sqlS = "UPDATE bansaosach SET trangThai = 1 WHERE maBanSao = @maBS";

            // Thực thi trong Transaction... (thầy sẽ hướng dẫn chi tiết ở bước sau)
            return true;
        }
        public DataTable GetRegistrationHeader(string maThe) => dal.LayDonDangKy(maThe);
        public DataTable GetRegistrationDetails(string maGD) => dal.LayChiTietDon(maGD);

        public string ConfirmLending(string maGD, List<string> dsMaBanSao)
        {
            if (string.IsNullOrEmpty(maGD)) return "Không tìm thấy mã giao dịch!";
            if (dsMaBanSao.Count == 0) return "Danh sách sách giao không được trống!";

            if (dal.XacNhanGiaoSach(maGD, dsMaBanSao))
                return "SUCCESS";
            return "Lỗi khi cập nhật dữ liệu mượn sách.";
        }
        public int TinhTienPhat(string hanTraStr)
        {
            try
            {
                DateTime hanTra = DateTime.ParseExact(hanTraStr, "dd/MM/yyyy", null);
                DateTime ngayHienTai = DateTime.Now.Date; // Tự lấy ngày máy tính[cite: 2]
                if (ngayHienTai > hanTra)
                {
                    return (ngayHienTai - hanTra).Days * 2000; // Phạt 2k/ngày[cite: 2]
                }
            }
            catch { return 0; }
            return 0;
        }

        public bool ThucHienTraSach(string maP, string maBS, int tienPhat, string lyDo)
            => dal.ThucHienTraSach(maP, maBS, tienPhat, lyDo);
    }
}
