using LibraryManagerDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerDAL
{
    public class ThongKeDAL
    {
        public DataTable LayTopSachMuonNhieuNhat(int soLuongTop)
        {
            try
            {
                // Truy vấn đếm số lần mượn của từng cuốn sách, sắp xếp giảm dần
                string sql = @"
                    SELECT TOP (@Top) s.tenSach, COUNT(ct.maBanSao) AS SoLuotMuon
                    FROM chitietmuonsach ct
                    JOIN bansaosach bs ON ct.maBanSao = bs.banSaoSach
                    JOIN sach s ON bs.maSach = s.maSach
                    GROUP BY s.tenSach
                    ORDER BY SoLuotMuon DESC";

                SqlParameter[] pars = {
                    new SqlParameter("@Top", soLuongTop)
                };

                return DbHelper.getTable(sql, pars);
            }
            catch (Exception ex)
            {
                // Ném lỗi lên tầng BUS xử lý
                throw new Exception("Lỗi khi truy xuất dữ liệu thống kê: " + ex.Message);
            }
        }
    }
}
