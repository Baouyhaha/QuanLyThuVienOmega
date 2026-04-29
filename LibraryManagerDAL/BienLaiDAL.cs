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
    public class BienLaiDAL
    {
        public DataTable LayThongTinBienLai(string maPhieu, string maBanSao)
        {
            try
            {
                string sql = @"
                    SELECT 
                        nm.hoTen AS TenDocGia,
                        nm.maDinhDanh AS MaDinhDanh,
                        s.tenSach AS TenSach,
                        tt.hanTra AS HanTra,
                        ct.ngayTra AS NgayTra,
                        ct.tienPhat AS TienPhat,
                        ct.lyDoPhat AS LyDoPhat
                    FROM chitietmuonsach ct
                    JOIN thongtinmuontrasach tt ON ct.maThongTinhMuonTraSach = tt.maThongTinhMuonTraSach
                    JOIN nguoimuon nm ON tt.maNguoiMuon = nm.maNguoiMuon
                    JOIN bansaosach bs ON ct.maBanSao = bs.banSaoSach
                    JOIN sach s ON bs.maSach = s.maSach
                    WHERE ct.maThongTinhMuonTraSach = @maPhieu AND ct.maBanSao = @maBanSao";

                SqlParameter[] pars = {
                    new SqlParameter("@maPhieu", maPhieu),
                    new SqlParameter("@maBanSao", maBanSao)
                };

                return DbHelper.getTable(sql, pars);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi truy xuất dữ liệu in biên lai: " + ex.Message);
            }
        }
    }
}
