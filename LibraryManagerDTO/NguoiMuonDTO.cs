using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerDTO
{
    public class NguoiMuonDTO
    {
        public string MaNguoiMuon { get; set; }
        public string TenTaiKhoan { get; set; }
        public string MSSV { get; set; }
        public int SoTienDatCoc { get; set; }
        public string GiaiDoanHoc { get; set; }
        public int TrangThai { get; set; } // 0: Chưa Active, 1: Đã Active
    }
}
