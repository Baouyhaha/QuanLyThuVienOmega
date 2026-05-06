using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagerDAO;
using LibraryManagerDTO;

namespace LibraryManagerDAL
{
    public class TacGiaDAL
    {
        public DataTable GetAll()
        {
            string sql = "SELECT * FROM tacgia";
            return DbHelper.getTable(sql);
        }
        // 1. Lấy toàn bộ danh sách tác giả để hiển thị lên DataGridView
        public DataTable LyeToanBoTacGia()
        {
            string sql = "SELECT maTacGia AS [Mã Tác Giả], tenTacGia AS [Tên Tác Giả] FROM tacgia";
            return DbHelper.getTable(sql);
        }

        // 2. Thêm tác giả mới
        public bool ThemTacGia(TacGiaDTO tg)
        {
            string sql = "INSERT INTO tacgia (maTacGia, tenTacGia) VALUES (@Ma, @Ten)";
            SqlParameter[] parameters = {
                new SqlParameter("@Ma", SqlDbType.Int) { Value = tg.MaTacGia },
                new SqlParameter("@Ten", SqlDbType.NVarChar) { Value = tg.TenTacGia }
            };
            return DbHelper.executeNonQuery(sql, parameters);
        }

        // 3. Sửa thông tin tác giả
        public bool SuaTacGia(TacGiaDTO tg)
        {
            string sql = "UPDATE tacgia SET tenTacGia = @Ten WHERE maTacGia = @Ma";
            SqlParameter[] parameters = {
                new SqlParameter("@Ma", SqlDbType.Int) { Value = tg.MaTacGia },
                new SqlParameter("@Ten", SqlDbType.NVarChar) { Value = tg.TenTacGia }
            };
            return DbHelper.executeNonQuery(sql, parameters);
        }

        // 4. Xóa tác giả
        public bool XoaTacGia(int maTacGia)
        {
            string sql = "DELETE FROM tacgia WHERE maTacGia = @Ma";
            SqlParameter[] parameters = {
                new SqlParameter("@Ma", SqlDbType.Int) { Value = maTacGia }
            };
            return DbHelper.executeNonQuery(sql, parameters);
        }

        // 5. Kiểm tra xem tác giả có đang viết cuốn sách nào không (Kiểm tra trong bảng chitiettacgia)
        public bool KiemTraTacGiaCoSach(int maTacGia)
        {
            string sql = "SELECT COUNT(*) FROM chitiettacgia WHERE maTacGia = @Ma";
            SqlParameter[] parameters = {
                new SqlParameter("@Ma", SqlDbType.Int) { Value = maTacGia }
            };
            object res = DbHelper.executeScalar(sql, parameters);
            return res != null && Convert.ToInt32(res) > 0;
        }

        // 6. Kiểm tra trùng Mã tác giả khi thêm mới
        public bool KiemTraTrungMa(int maTacGia)
        {
            string sql = "SELECT COUNT(*) FROM tacgia WHERE maTacGia = @Ma";
            SqlParameter[] parameters = {
                new SqlParameter("@Ma", SqlDbType.Int) { Value = maTacGia }
            };
            object res = DbHelper.executeScalar(sql, parameters);
            return res != null && Convert.ToInt32(res) > 0;
        }
    }
}
