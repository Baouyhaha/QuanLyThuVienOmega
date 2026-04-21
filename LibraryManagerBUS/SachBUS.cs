using LibraryManagerDAL;
using LibraryManagerDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerBUS
{
    public class SachBUS
    {
        private SachDAL sachDAL = new SachDAL();

        public DataTable GetDanhSachSach()
        {
            // Gọi hàm LayTatCaSach() từ DAL
            return sachDAL.LayTatCaSach();
        }
        public bool ThemSachMoi(SachDTO sach)
        {
            // BẮT LỖI (Validation): Đảm bảo dữ liệu hợp lệ trước khi chạm tới Database
            if (string.IsNullOrWhiteSpace(sach.maSach) || string.IsNullOrWhiteSpace(sach.tenSach))
            {
                throw new Exception("Mã sách và Tên sách không được để trống!");
            }

            if (sach.maSach.Length > 6)
            {
                throw new Exception("Mã sách không được vượt quá 6 ký tự!");
            }

            if (sach.soLuongHienCo < 0)
            {
                throw new Exception("Số lượng sách không thể là số âm!");
            }

            // Nếu qua được hết các cửa ải trên, gọi DAL để lưu xuống DB
            return sachDAL.ThemSach(sach);
        }
        public bool SuaSachInfo(SachDTO sach)
        {
            // 1. Kiểm tra ràng buộc dữ liệu (Validation) trước khi lưu

            // Tên sách không được phép để trống hoặc chỉ chứa khoảng trắng
            if (string.IsNullOrWhiteSpace(sach.tenSach))
            {
                throw new Exception("Tên sách không được để trống!");
            }

            // Số lượng sách không thể là số âm
            if (sach.soLuongHienCo < 0)
            {
                throw new Exception("Số lượng sách không hợp lệ (không được là số âm)!");
            }

            // (Bạn có thể thêm các luật khác ở đây nếu muốn. VD: Bắt lỗi độ dài ISBN...)

            // 2. Nếu dữ liệu đã an toàn và hợp lệ, đẩy xuống tầng DAL để lưu vào SQL Server
            return sachDAL.SuaSach(sach);
        }
        public bool XoaSachInfo(string maSach)
        {
            // Bạn có thể thêm kiểm tra ở đây, ví dụ: Sách đang được mượn thì không cho xóa
            return sachDAL.XoaSach(maSach);
        }
        public DataTable TimKiemSach(string keyword)
        {
            return sachDAL.TimKiemSach(keyword);
        }
        public DataTable GetDanhSachSachFrmTimKiem()
        {
            // Gọi hàm GetDanhSachSachtimKiem() từ DAL
            return sachDAL.GetDanhSachSachtimKiem();
        }
        public DataTable TimKiemSachThongMinh(string tuKhoa)
        {
            // Gọi hàm từ lớp DAL (Giả sử em đã khởi tạo sachDAL ở trên)
            return sachDAL.TimKiemSachThongMinh(tuKhoa);
        }
    }
}
