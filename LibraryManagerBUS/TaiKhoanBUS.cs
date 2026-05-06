using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using LibraryManagerDAL;
using LibraryManagerDAO;
using LibraryManagerDTO;

namespace LibraryManagerBUS
{
    public class TaiKhoanBUS
    {
        private TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
        private NguoiMuonDAL nguoiMuonDAL = new NguoiMuonDAL();

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

        //code moi
        public bool DangKy(TaiKhoanDTO tk, NguoiMuonDTO nm, string xacNhanMK)
        {
            // 1. Ràng buộc dữ liệu: Không được để trống các trường bắt buộc
            if (string.IsNullOrEmpty(tk.TenTaiKhoan) || string.IsNullOrEmpty(tk.MatKhau) || string.IsNullOrEmpty(tk.Ten))
            {
                throw new Exception("Tên tài khoản, mật khẩu và họ tên không được để trống!");
            }

            if (string.IsNullOrEmpty(nm.LoaiKhach) || string.IsNullOrEmpty(nm.MaDinhDanh))
            {
                throw new Exception("Vui lòng chọn loại khách và nhập mã định danh (MSSV/CCCD)!");
            }

            // 2. Kiểm tra trùng khớp mật khẩu nhập lại
            if (tk.MatKhau != xacNhanMK)
            {
                throw new Exception("Mật khẩu và xác nhận mật khẩu không trùng khớp!");
            }

            // 3. Kiểm tra độ an toàn mật khẩu (Ví dụ: tối thiểu 6 ký tự)
            if (tk.MatKhau.Length < 6)
            {
                throw new Exception("Mật khẩu phải có độ dài từ 6 ký tự trở lên để đảm bảo bảo mật!");
            }

            // 4. Kiểm tra trùng tên tài khoản (Gọi DAO kiểm tra dưới Database)
            // Đây chính là bước giải quyết tận gốc lỗi "giới hạn tài khoản" (trùng khóa chính) 
            if (nguoiMuonDAL.KiemTraTrungTenTaiKhoan(tk.TenTaiKhoan))
            {
                throw new Exception("Tên tài khoản này đã tồn tại trong hệ thống! Vui lòng chọn tên đăng nhập khác.");
            }

            // 5. Tự động đồng bộ và thiết lập các thông số hệ thống
            nm.TenTaiKhoan = tk.TenTaiKhoan; // Gắn khóa ngoại liên kết 2 bảng
            nm.HoTen = tk.Ten;               // Đồng bộ Họ tên sang bảng người mượn
            nm.Sdt = tk.SoDienThoai;         // Đồng bộ Số điện thoại
            nm.Email = tk.Email;             // Đồng bộ Email

            nm.SoTienDatCoc = 0;             // Đăng ký online mặc định tiền ký quỹ bằng 0
            nm.TrangThai = 2;                // Đặt trạng thái mặc định bằng 1 (Chờ cấp thẻ)

            // 6. Thuật toán tự động sinh Mã Người Mượn (Không bắt người dùng nhập)
            // Định dạng: NM + Chuỗi thời gian hiện tại (NămThángNgàyGiờPhútGiây) 
            // Đảm bảo tính duy nhất tuyệt đối và độ dài vừa vặn trong khoảng VARCHAR(20)
            nm.MaNguoiMuon = "NM" + DateTime.Now.ToString("yyMMddHHmmss");

            // 7. Sau khi tất cả điều kiện đã hợp lệ -> Đẩy xuống DAO để thực thi ghi vào DB
            return nguoiMuonDAL.DangKyHethong(tk, nm);
        }
    }
}
