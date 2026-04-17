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
            // Bật hộp thoại hỏi người dùng (Yes/No)
            DialogResult xacNhan = MessageBox.Show("Bạn có chắc chắn muốn đăng ký tài khoản với các thông tin này không?",
                                                   "Xác nhận đăng ký",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);

            // Nếu người dùng chọn No thì kết thúc hàm luôn, không làm gì cả
            if (xacNhan == DialogResult.No)
            {
                return;
            }

            // Nếu chọn Yes thì bắt đầu chạy try-catch
            try
            {
                TaiKhoanDTO tkMoi = new TaiKhoanDTO
                {
                    TenTaiKhoan = txtTenTaiKhoan.Text.Trim(),
                    MatKhau = txtMatKhau.Text.Trim(),
                    Ten = txtHoTen.Text.Trim(),
                    GioiTinh = cboGioiTinh.Text,
                    Email = txtEmail.Text.Trim(),
                    SoDienThoai = txtSDT.Text.Trim()
                };

                string xacNhanMK = txtXacNhanMatKhau.Text.Trim();

                taiKhoanBUS.DangKy(tkMoi, xacNhanMK);

                MessageBox.Show("Đăng ký thành công! Vui lòng liên hệ thủ thư để kích hoạt tài khoản.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                // Bắt chính xác từng câu báo lỗi từ lớp BUS và in ra
                MessageBox.Show(ex.Message, "Lỗi Nhập Liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTenTaiKhoan_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Cho phép phím điều khiển (như Backspace) và phím chữ, số.
            // Nếu gõ ký tự đặc biệt (!@#$...) hoặc khoảng trắng thì chặn lại ngay lập tức.
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true; // Lệnh này giúp "hủy" phím vừa gõ
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
                                               // Thay hình bằng mắt nhắm (lấy từ Resources)
                txtMatKhau.IconRight = Properties.Resources.close_eye;
            }
            else
            {
                txtMatKhau.PasswordChar = '\0'; // Hiện chữ
                                                // Thay hình bằng mắt mở
                txtMatKhau.IconRight = Properties.Resources.show;
            }
        }

        private void txtXacNhanMatKhau_IconRightClick(object sender, EventArgs e)
        {
            isXacNhanMKHidden = !isXacNhanMKHidden; // Đảo ngược trạng thái

            if (isXacNhanMKHidden)
            {
                txtXacNhanMatKhau.PasswordChar = '*';
                txtXacNhanMatKhau.IconRight = Properties.Resources.close_eye;
            }
            else
            {

            }
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
