using LibraryManagerDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerBUS
{
    public class BienLaiBUS
    {
        private BienLaiDAL dal = new BienLaiDAL();

        public DataTable GetDuLieuBienLai(string maPhieu, string maBanSao)
        {
            try
            {
                if (string.IsNullOrEmpty(maPhieu) || string.IsNullOrEmpty(maBanSao))
                    throw new Exception("Mã phiếu hoặc mã sách không hợp lệ để in biên lai.");

                return dal.LayThongTinBienLai(maPhieu, maBanSao);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi nghiệp vụ in biên lai: " + ex.Message);
            }
        }
    }
}
