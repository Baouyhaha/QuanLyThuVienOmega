using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerDTO
{
    public class DangKyTheDTO
    {
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string LoaiDocGia { get; set; } // "Sinh Viên" hoặc "Khách Ngoài"
        public string MaDinhDanh { get; set; } // Lưu MSSV (nếu là SV) hoặc CCCD (nếu là Khách)
    }
}
