using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagerDAO;
using LibraryManagerDTO;

namespace LibraryManagerDAL
{
    internal class BanSaoSachDAL
    {
        public bool Insert(BanSaoSachDTO bs)
        {
            string sql = "INSERT INTO bansaosach (banSaoSach, maSach, soThuTu, loaiBanSao, gia, trangThai, xoa) " +
                         "VALUES (@maBS, @maS, @stt, @loai, @gia, @tt, @xoa)";

            SqlParameter[] pr = {
        new SqlParameter("@maBS", bs.banSaoSach),
        new SqlParameter("@maS", bs.maSach),
        new SqlParameter("@stt", bs.soThuTu),
        new SqlParameter("@loai", bs.loaiBanSao),
        new SqlParameter("@gia", bs.gia),
        new SqlParameter("@tt", bs.trangThai),
        new SqlParameter("@xoa", bs.xoa)
    };

            return DbHelper.executeNonQuery(sql, pr);
        }
    }
}
