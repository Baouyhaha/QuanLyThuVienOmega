using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerDTO
{
    public class ChiTietMuonSachDTO
    {
        public string maThongTinhMuonTraSach { get; set; }
        public string maBanSao {  get; set; }
        public int trangThai {  get; set; } 
        public DateTime ngayMuon { get; set; }
        public DateTime ngayTra { get; set; }
        public int tienPhat { get; set; }
        public string lyDoPhat { get; set; }
    }
}
