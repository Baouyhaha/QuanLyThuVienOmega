using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagerDAL;

namespace LibraryManagerBUS
{
    public class ThongTinMuonTraBUS
    {
        ThongTinMuonTraDAL dal = new ThongTinMuonTraDAL();  
        public bool ChotDonMuonSach(string maNguoiMuon, DateTime hanTra, int tienDatCoc, DataTable gioHang)
        {
            // 1. Sinh mã phiếu tự động dựa vào thời gian thực 
            // Format: PM + yyMMdd + HHmmss (VD: PM2604301038)
            string maPhieuTuSinh = "PM" + DateTime.Now.ToString("yyMMddHHmmss");

            // 2. Chuyển đổi ngày tháng sang chuẩn VARCHAR(10) (dd/MM/yyyy) theo CSDL của em
            string chuoiNgayDangKi = DateTime.Now.ToString("dd/MM/yyyy");
            string chuoiHanTra = hanTra.ToString("dd/MM/yyyy");

            // 3. Gọi DAL thực thi Transaction
            return dal.TaoPhieuMuonTransaction(maPhieuTuSinh, maNguoiMuon, chuoiNgayDangKi, chuoiHanTra, tienDatCoc, gioHang);
        }
        public bool PheDuyetGiaoSach(string maPhieu)
        {
            // Gọi xuống hàm DAL em vừa thêm ở trên
            return dal.PheDuyetGiaoSach(maPhieu);
        }
        public DataTable GetDsPhieuChoDuyet()
        {
            return dal.GetDsPhieuChoDuyet();
        }
        public DataTable GetChiTietSachTrongPhieu(string maPhieu)
        {
            // Gọi xuống hàm DAL vừa viết ở trên
            return dal.GetChiTietSachTrongPhieu(maPhieu);
        }
        public bool HuyPhieuMuon(string maPhieu)
        {
            return dal.HuyPhieuMuon(maPhieu);
        }
        public DataTable LocPhieuMuon(string tuKhoa, int trangThai)
        {
            return dal.LocPhieuMuon(tuKhoa, trangThai);
        }
        public DataTable TimKiemNhanhChoThuThu(string tuKhoa)
        {
            return dal.TimKiemNhanhChoThuThu(tuKhoa);
        }
    }
}
