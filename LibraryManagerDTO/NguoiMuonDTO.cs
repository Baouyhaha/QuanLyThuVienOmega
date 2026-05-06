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
        public string TenTaiKhoan { get; set; } // Khóa ngoại kết nối sang bảng taikhoan
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string LoaiKhach { get; set; }     // Sinh viên / Khách ngoài
        public string MaDinhDanh { get; set; }    // Lưu MSSV hoặc CCCD
        public int SoTienDatCoc { get; set; }     // Mặc định = 0
        public int TrangThai { get; set; }        // Đặt bằng 1 khi đăng ký theo yêu cầu của em
    }
}
