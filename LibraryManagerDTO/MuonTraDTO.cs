using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerDTO
{
    public class MuonTraDTO
    {
        public string MaPhieu { get; set; } // maThongTinhMuonTraSach
        public string MaNguoiMuon { get; set; }
        public string NgayDangKi { get; set; } // varchar(10)
        public string HanTra { get; set; }     // varchar(10)
        public int TienDatCoc { get; set; }
        public int TrangThai { get; set; }     // 0: Đăng ký, 1: Đang mượn, 2: Đã trả
    }
}
