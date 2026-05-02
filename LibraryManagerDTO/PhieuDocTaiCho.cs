using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerDTO
{
    public class PhieuDocTaiCho
    {
        public string maPhieu {  get; set; }
        public string maSach {  get; set; }
        public int trangThai { get; set; }
        public string tenNguoiDoc { get; set; }
        public string Cccd { get; set; }

        public string maBanSao { get; set; } // Thay cho maSach cũ
    }
    }
