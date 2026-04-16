using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerDTO
{
    public class ThongTinMuonTraSach
    {
        public string maThongTinhMuonTraSach { get; set; }
        public string maNguoiMuon { get; set; }
        public DateTime ngayDangKi { get; set; }
        
        public DateTime hanTra { get; set; }
        public int tienDatCoc { get; set; }
    }
}
