using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagerBUS;
using LibraryManagerDTO;

namespace LibraryManagerGUI
{
    public partial class FrmDangKy : Form
    {
        private TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        private bool isMatKhauHidden = true;
        private bool isXacNhanMKHidden = true;

        public FrmDangKy()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // 1. Bật hộp thoại hỏi người dùng xác nhận
            DialogResult xacNhan = MessageBox.Show("Bạn có chắc chắn muốn đăng ký tài khoản với các thông tin này không?",
                                                   "Xác nhận đăng ký",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);

            // Nếu người dùng chọn No thì dừng hàm luôn
            if (xacNhan == DialogResult.No)
            {
                return;
            }

            // 2. Nếu chọn Yes, tiến hành đóng gói dữ liệu và gọi tầng BUS
            try
            {
                // Đóng gói thông tin cho bảng taikhoan
                TaiKhoanDTO tkMoi = new TaiKhoanDTO
                {
                    TenTaiKhoan = txtTenTaiKhoan.Text.Trim(),
                    MatKhau = txtMatKhau.Text.Trim(),
                    Ten = txtHoTen.Text.Trim(),
                    GioiTinh = cboGioiTinh.Text,
                    Email = txtEmail.Text.Trim(),
                    SoDienThoai = txtSDT.Text.Trim()
                };

                // Đóng gói thông tin đặc thù cho bảng nguoimuon
                // LƯU Ý: Em cần đảm bảo các Control như dtpNgaySinh, txtDiaChi, cboLoaiKhach, txtMaDinhDanh đã được đặt tên đúng trong Designer
                NguoiMuonDTO nmMoi = new NguoiMuonDTO
                {
                    NgaySinh = dtpNgaySinh.Value, // Lấy giá trị từ DateTimePicker
                    DiaChi = txtDiaChi.Text.Trim(),
                    LoaiKhach = cboLoaiKhach.Text, // ComboBox chọn: Sinh viên / Khách ngoài
                    MaDinhDanh = txtMaDinhDanh.Text.Trim() // Nhập MSSV hoặc CCCD vào đây
                };

                string xacNhanMK = txtXacNhanMatKhau.Text.Trim();

                // Gọi tầng BUS xử lý nghiệp vụ kiểm tra và lưu vào CSDL
                bool ketQua = taiKhoanBUS.DangKy(tkMoi, nmMoi, xacNhanMK);

                if (ketQua)
                {
                    MessageBox.Show("Đăng ký thành công! Tài khoản của bạn đã được chuyển sang trạng thái chờ cấp thẻ.",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form đăng ký sau khi thành công
                }
            }
            catch (Exception ex)
            {
                // Nhận chính xác thông báo lỗi từ tầng BUS hoặc lỗi chi tiết từ tầng DAO gửi lên và hiển thị
                MessageBox.Show(ex.Message, "Lỗi Đăng Ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTenTaiKhoan_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Chặn khoảng trắng và ký tự đặc biệt ngay khi gõ tên tài khoản
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Tên tài khoản không được chứa khoảng trắng hoặc ký tự đặc biệt!",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtMatKhau_IconRightClick(object sender, EventArgs e)
        {
            isMatKhauHidden = !isMatKhauHidden; // Đảo ngược trạng thái

            if (isMatKhauHidden)
            {
                txtMatKhau.PasswordChar = '*'; // Ẩn chữ
                txtMatKhau.IconRight = Properties.Resources.close_eye; // Mắt nhắm
            }
            else
            {
                txtMatKhau.PasswordChar = '\0'; // Hiện chữ
                txtMatKhau.IconRight = Properties.Resources.show; // Mắt mở
            }
        }

        private void txtXacNhanMatKhau_IconRightClick(object sender, EventArgs e)
        {
            isXacNhanMKHidden = !isXacNhanMKHidden; // Đảo ngược trạng thái

            // ĐÃ SỬA: Gom cấu trúc ngoặc nhọn chuẩn chỉnh để không bị lỗi luôn hiện chữ như bản cũ
            if (isXacNhanMKHidden)
            {
                txtXacNhanMatKhau.PasswordChar = '*';
                txtXacNhanMatKhau.IconRight = Properties.Resources.close_eye;
            }
            else
            {
                txtXacNhanMatKhau.PasswordChar = '\0';
                txtXacNhanMatKhau.IconRight = Properties.Resources.show;
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKhach_Click(object sender, EventArgs e)
        {
            // 1. Tìm FrmDangNhap đang chìm ở dưới và bắt nó ẩn đi
            foreach (Form form in Application.OpenForms)
            {
                if (form is FrmDangNhap)
                {
                    form.Hide();
                    break;
                }
            }

            // 2. Khởi tạo FrmMain với Role = 0 (Khách), tham số mã người dùng = null
            FrmMain mainForm = new FrmMain(0, null);
            mainForm.Show();

            // 3. Đóng Form Đăng ký lại
            this.Close();
        }
    }
}
