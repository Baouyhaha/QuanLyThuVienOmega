using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using LibraryManagerDAO;
using LibraryManagerDTO;

namespace LibraryManagerBUS
{
    public class TaiKhoanBUS
    {
        private TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();

        public void DangKy(TaiKhoanDTO tk, string xacNhanMatKhau)
        {
            // 1. Tách riêng thông báo lỗi cho từng ô trống
            if (string.IsNullOrWhiteSpace(tk.TenTaiKhoan))
                throw new Exception("Lỗi: Bạn chưa nhập Tên tài khoản!");

            if (string.IsNullOrWhiteSpace(tk.MatKhau))
                throw new Exception("Lỗi: Bạn chưa nhập Mật khẩu!");

            if (string.IsNullOrWhiteSpace(tk.Ten))
                throw new Exception("Lỗi: Bạn chưa nhập Họ và tên!");

            // 2. Kiểm tra mật khẩu khớp nhau
            if (tk.MatKhau != xacNhanMatKhau)
                throw new Exception("Lỗi: Mật khẩu xác nhận không trùng khớp!");

            // 3. Kiểm tra Số điện thoại (Chỉ nhận 10 chữ số, bắt đầu bằng số 0)
            if (!string.IsNullOrWhiteSpace(tk.SoDienThoai))
            {
                // Quy tắc Regex: Bắt đầu là 0 (^0), theo sau là 9 chữ số (\d{9}), và kết thúc ($)
                if (!Regex.IsMatch(tk.SoDienThoai, @"^0\d{9}$"))
                {
                    throw new Exception("Lỗi: Số điện thoại không hợp lệ! Vui lòng nhập đúng 10 chữ số và bắt đầu bằng số 0.");
                }
            }

            // 4. Kiểm tra định dạng Email (Bắt buộc phải có chữ/số phía trước và đuôi là @gmail.com)
            if (!string.IsNullOrWhiteSpace(tk.Email))
            {
                // ^[a-zA-Z0-9._]+ có nghĩa là tên email chỉ được chứa chữ, số, dấu chấm, dấu gạch dưới
                // @gmail\.com$ có nghĩa là bắt buộc phải kết thúc bằng @gmail.com
                if (!Regex.IsMatch(tk.Email, @"^[a-zA-Z0-9._]+@gmail\.com$"))
                {
                    throw new Exception("Lỗi: Email không hợp lệ! Vui lòng sử dụng định dạng @gmail.com (Ví dụ: nguyenvana@gmail.com).");
                }
            }
            else
            {
                throw new Exception("Lỗi: Bạn chưa nhập Email!");
            }

            // 05. Lớp phòng thủ số 2 cho Tên tài khoản (Đề phòng người dùng lách giao diện)
            if (!Regex.IsMatch(tk.TenTaiKhoan, @"^[a-zA-Z0-9]+$"))
            {
                throw new Exception("Lỗi: Tên tài khoản chỉ được chứa chữ cái và số!");
            }

            // 6. Kiểm tra trùng lặp và Đăng ký (Giữ nguyên như cũ)
            if (taiKhoanDAO.KiemTraTonTai(tk.TenTaiKhoan))
                throw new Exception("Lỗi: Tên tài khoản này đã có người sử dụng. Vui lòng chọn tên khác!");

            bool ketQua = taiKhoanDAO.DangKyTaiKhoanMoi(tk);
            if (!ketQua)
                throw new Exception("Lỗi hệ thống. Đăng ký không thành công!");
        }
        public TaiKhoanSession Login(string username, string password)
        {
            // Gọi xuống DAO
            TaiKhoanSession session = taiKhoanDAO.CheckLoginAndGetRole(username, password);

            // Nếu session bằng null nghĩa là sai pass hoặc không có tài khoản
            if (session == null)
            {
                throw new Exception("Tài khoản hoặc mật khẩu không đúng!");
            }

            // Trả session (Quyền + Mã người dùng) về cho FrmDangNhap
            return session;
        }
        public DataTable LayDanhSach(string tuKhoa = "", int locTrangThai = -1)
        {
            return taiKhoanDAO.LayDanhSachTaiKhoan(tuKhoa, locTrangThai);
        }
        public bool DuyetHoacHuyThe(string maNM, int trangThai, int tienCoc)
        {
            return taiKhoanDAO.CapNhatTrangThaiThe(maNM, trangThai, tienCoc);
        }
    }
}
