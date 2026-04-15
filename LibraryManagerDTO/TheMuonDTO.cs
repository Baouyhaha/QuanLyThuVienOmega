using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerDTO
{
    public class TheMuonDTO
    {
        public string maTheMuon { get; set; }
        public DateTime ngayHetHan { get; set; }
        public int trangThai { get; set; }//0: chưa hết hạn, 1: đã hết hạn
        public string maKichHoat { get; set; }

    }
}
