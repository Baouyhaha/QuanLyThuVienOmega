using LibraryManagerDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerBUS
{
    public class TacGiaBUS
    {
        // Khởi tạo đối tượng từ tầng DAL
        private TacGiaDAL tacGiaDAL = new TacGiaDAL();

        public DataTable LayDanhSachTacGia()
        {
            // Ở đây chức năng chỉ là lấy danh sách nên ta gọi thẳng xuống DAL
            // Sau này nếu có chức năng Thêm/Sửa/Xóa Tác giả, bạn sẽ viết thêm các hàm kiểm tra lỗi (Validation) ở đây
            return tacGiaDAL.LayDanhSachTacGia();
        }
    }
}   