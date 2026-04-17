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
using LibraryManagerDAO;
using LibraryManagerDTO;

namespace LibraryManagerGUI
{

    public partial class FrmDangNhap : Form
    {
        private bool isMatKhauHidden = true;
        private TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        public FrmDangNhap()
        {
            InitializeComponent();
            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTenTaiKhoan.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            // 1. Kiểm tra rỗng ngay trên Giao diện cho nhanh
            if (string.IsNullOrWhiteSpace(taiKhoan) || string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tài khoản và Mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTaiKhoan.Focus(); // Nháy con trỏ chuột vào ô tài khoản
                return;
            }

            try
            {
                // 2. Gọi BUS xử lý đăng nhập (Hàm này ta đã viết ở các bài đầu tiên)
                TaiKhoanSession session = taiKhoanBUS.Login(taiKhoan, matKhau);

                // 3. Khởi tạo Form Main với quyền hạn tương ứng
                FrmMain mainForm = new FrmMain(session.Role, session.MaNguoiMuon);

                // 4. Ẩn Form Đăng Nhập đi
                this.Hide();

                // 5. Mở Form Main lên và BẮT BUỘC CHỜ ở đây cho đến khi Form Main bị đóng
                mainForm.ShowDialog();

                // 6. Khi Form Main bị đóng (người dùng tắt app hoặc Đăng xuất), code sẽ chạy tiếp xuống đây:
                // Ta xóa trắng các ô nhập liệu và hiện lại Form Đăng nhập
                txtTenTaiKhoan.Clear();
                txtMatKhau.Clear();
                txtTenTaiKhoan.Focus();
                this.Show();
            }
            catch (Exception ex)
            {
                // Bắt lỗi sai tài khoản / mật khẩu từ BUS văng ra
                MessageBox.Show(ex.Message, "Lỗi Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FrmDangKy frm = new FrmDangKy();
            frm.ShowDialog();
        }
        private void txtMatKhau_IconRightClick(object sender, EventArgs e)
        {
            isMatKhauHidden = !isMatKhauHidden; // Đảo ngược trạng thái

            if (isMatKhauHidden)
            {
                // Ẩn mật khẩu
                txtMatKhau.UseSystemPasswordChar = true;
                txtMatKhau.IconRight = Properties.Resources.close_eye;
            }
            else
            {
                // Hiện mật khẩu
                txtMatKhau.UseSystemPasswordChar = false;
                txtMatKhau.PasswordChar = '\0';
                txtMatKhau.IconRight = Properties.Resources.show;
            }
        }
    }
}
