using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerDTO
{
    public class ChiTietMuonDTO
    {
        public string MaPhieu { get; set; }
        public string BanSaoSach { get; set; }
        public int TrangThai { get; set; }    // 0: Đăng ký, 1: Đang mượn, 2: Đã trả
        public string TinhTrangSach { get; set; } // Cột ngayMuon trong ERD của em dùng để ghi chú
        public string NgayTra { get; set; }   // Thực tế trả
        public int TienPhat { get; set; }
        public string LyDoPhat { get; set; }
    }
}
