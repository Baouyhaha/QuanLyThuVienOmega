using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerDTO
{
    public class UserSessionDTO
    {
        public static string tenTaiKhoan { get; set; }
        public static string vaiTro { get; set; } // "Admin", "User", "Guest"
        public static int trangThai { get; set; } // 0: Chưa kích hoạt, 1: Đã kích hoạt
    }
}
