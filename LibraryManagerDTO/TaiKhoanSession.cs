using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerDTO
{
    public class TaiKhoanSession
    {
        public int Role { get; set; }
        // 2: Thủ thư, 1: Đã kích hoạt, -1: Chưa kích hoạt, 0: Khách

        public string MaNguoiMuon { get; set; }
        // Sẽ chứa mã người mượn (VD: NM0001), nếu là thủ thư thì để null

        public TaiKhoanSession(int role, string maNguoiMuon)
        {
            this.Role = role;
            this.MaNguoiMuon = maNguoiMuon;
        }
        public static string TaiKhoanHienTai;
        public static string MaNguoiMuonHienTai;
    }
}
