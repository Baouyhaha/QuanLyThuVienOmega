using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagerDAL;
using LibraryManagerDTO;

namespace LibraryManagerBUS
{
    public class TacGiaBUS
    {
        private TacGiaDAL tgDAL = new TacGiaDAL();
        public DataTable LayDanhSachTacGia()
        {
            return tgDAL.GetAll();
        }
        //code cu
        public DataTable LayDanhSach()
        {
            return tgDAL.LyeToanBoTacGia();
        }

        public bool Them(TacGiaDTO tg)
        {
            if (tg.MaTacGia <= 0)
                throw new Exception("Mã tác giả phải là số nguyên dương lớn hơn 0!");

            if (string.IsNullOrEmpty(tg.TenTacGia))
                throw new Exception("Tên tác giả không được để trống!");

            if (tgDAL.KiemTraTrungMa(tg.MaTacGia))
                throw new Exception("Mã tác giả này đã tồn tại! Vui lòng nhập mã khác.");

            return tgDAL.ThemTacGia(tg);
        }

        public bool Sua(TacGiaDTO tg)
        {
            if (string.IsNullOrEmpty(tg.TenTacGia))
                throw new Exception("Tên tác giả không được để trống!");

            return tgDAL.SuaTacGia(tg);
        }

        public bool Xoa(int maTacGia)
        {
            // Kiểm tra nghiệp vụ ràng buộc khóa ngoại với bảng chitiettacgia
            if (tgDAL.KiemTraTacGiaCoSach(maTacGia))
            {
                throw new Exception("Không thể xóa tác giả này vì thông tin của họ đang được liên kết với các đầu sách trong thư viện!");
            }

            return tgDAL.XoaTacGia(maTacGia);
        }
    }
}