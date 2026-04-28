using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagerGUI
{
    public partial class FrmMain : Form
    {
        // Biến lưu trạng thái menu đang đóng hay mở (Mặc định là đang đóng / Height = 0)
        private bool isMenuCollapsed = true;

        // Biến lưu chiều cao vừa đủ, không dư thừa
        private int chieuCaoMucTieu = 0;


        // 1. Khai báo 2 biến toàn cục để lưu trữ thông tin người dùng truyền sang
        private int currentRole;
        private string currentMaNguoiMuon;


        // 2. SỬA LẠI CONSTRUCTOR: Ép nó phải nhận vào 2 tham số
        public FrmMain(int role, string maNguoiMuon)
        {
            InitializeComponent();

            // 3. Gán giá trị nhận được vào biến toàn cục để lát nữa phân quyền
            this.currentRole = role;
            this.currentMaNguoiMuon = maNguoiMuon;
        }

        // Sự kiện Form Load (Sẽ code phân quyền ẩn/hiện menu ở đây sau)
        // Khai báo biến trạng thái
        bool isSachCollapsed = true;
        bool sidebarExpand = true; // Ban đầu là mở rộng

        private Form activeForm = null; // Biến để lưu trữ Form đang hiển thị
        private void openChildForm(Form childForm)
        {
            // 1. Nếu đã có một Form đang mở, hãy đóng nó lại để giải phóng bộ nhớ
            if (activeForm != null)
                activeForm.Close();

            // 2. Gán Form mới vào biến activeForm
            activeForm = childForm;

            // 3. Thiết lập để Form con không bị hiểu là một cửa sổ độc lập
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None; // Bỏ viền
            childForm.Dock = DockStyle.Fill; // Lấp đầy Panel

            // 4. Nhét Form con vào Panel và hiển thị
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void timerMenuChucNang_Tick(object sender, EventArgs e)
        {
            int tocDoTruot = 15; // Em có thể chỉnh số này to lên để trượt nhanh hơn

            if (isMenuCollapsed) // TRƯỜNG HỢP: Đang đóng -> Cần MỞ RA
            {
                panelSubMenu_ChucNang.Height += tocDoTruot;

                // Nếu đã trượt tới vạch đích (chiều cao vừa đủ)
                if (panelSubMenu_ChucNang.Height >= chieuCaoMucTieu)
                {
                    panelSubMenu_ChucNang.Height = chieuCaoMucTieu; // Chốt sổ cho chẵn số, tránh bị lệch vài pixel
                    timerMenuChucNang.Stop();              // Dừng hoạt hình
                    isMenuCollapsed = false;               // Cập nhật trạng thái là đã mở
                }
            }
            else // TRƯỜNG HỢP: Đang mở -> Cần ĐÓNG LẠI
            {
                panelSubMenu_ChucNang.Height -= tocDoTruot;

                // Nếu đã thu về 0
                if (panelSubMenu_ChucNang.Height <= 66)
                {
                    panelSubMenu_ChucNang.Height = 66;
                    timerMenuChucNang.Stop();
                    isMenuCollapsed = true; // Cập nhật trạng thái là đã đóng
                }
            }
        }
        // Sự kiện Click vào nút chính
        private void btnChucNang_Click(object sender, EventArgs e)
        {
            // Nếu menu đang đóng và chuẩn bị trượt mở ra
            if (isMenuCollapsed == true)
            {
                TinhChieuCaoVuaDu(); // Đo đạc ngay lập tức!
            }

            // Khởi động Timer
            timerMenuChucNang.Start();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLySach());
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmCapNhatThongTinThe());
        }
        private void timerSidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                // Nếu đang mở -> Thu hẹp lại
                panelSidebar.Width -= 10;
                if (panelSidebar.Width <= 50) // Khi chạm mốc thu gọn
                {
                    sidebarExpand = false;
                    timerSidebar.Stop();
                }
            }
            else
            {
                // Nếu đang thu gọn -> Mở rộng ra
                panelSidebar.Width += 10;
                if (panelSidebar.Width >= 200) // Khi chạm mốc mở rộng
                {
                    sidebarExpand = true;
                    timerSidebar.Stop();
                }
            }
        }
        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {
            timerSidebar.Start();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Sử dụng biến currentRole đã được truyền vào từ Constructor ở bài trước
            switch (currentRole)
            {
                case 2: // ================== QUYỀN THỦ THƯ ==================
                        // 1. Cập nhật lời chào
                    lblXinChao.Text = "Tài khoản: THỦ THƯ";
                    MessageBox.Show("Chào mừng Thủ thư đã quay lại hệ thống!", "Đăng nhập thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 2. Ẩn/Hiện Menu
                    btnQuanLySach.Visible = true;
                    btnQuanLyThe.Visible = true;
                    btnQuayMuonTra.Visible = true;

                    //btnGioSach.Visible = false; // Thủ thư không xài giỏ sách cá nhân
                    //btnLichSuMuon.Visible = false;
                    break;

                case 1: // ================== QUYỀN ĐỘC GIẢ (ĐÃ KÍCH HOẠT) ==================
                    lblXinChao.Text = "Tài khoản: ĐỘC GIẢ (Active)";
                    MessageBox.Show("Đăng nhập thành công! Bạn có thể đặt mượn sách ngay bây giờ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Ẩn menu quản lý của thủ thư
                    btnQuanLySach.Visible = false;
                    btnQuanLyThe.Visible = false;
                    btnQuayMuonTra.Visible = false;

                    //// Hiện chức năng cá nhân
                    btnGioSach.Visible = true;
                    btnLichSuMuon.Visible = true;
                    break;

                case -1: // ================== QUYỀN ĐỘC GIẢ (CHƯA KÍCH HOẠT) ==================
                    lblXinChao.Text = "Tài khoản: ĐỘC GIẢ (Chưa kích hoạt)";
                    MessageBox.Show("Tài khoản của bạn chưa được kích hoạt. Bạn chỉ có thể tra cứu sách nhưng chưa thể mượn. Vui lòng gặp thủ thư để đóng cọc/kích hoạt!", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    btnQuanLySach.Visible = false;
                    btnQuanLyThe.Visible = false;
                    btnQuayMuonTra.Visible = false;

                    btnGioSach.Visible = false; // Chưa kích hoạt thì không cho mượn
                    btnLichSuMuon.Visible = false;
                    break;

                case 0: // ================== QUYỀN KHÁCH VÃNG LAI ==================
                    lblXinChao.Text = "Tài khoản: KHÁCH";

                    // Khách thì ẩn gần hết, chỉ chừa lại nút Tìm Kiếm Sách
                    btnQuanLySach.Visible = false;
                    btnQuanLyThe.Visible = false;
                    btnQuayMuonTra.Visible = false;
                    btnGioSach.Visible = false;
                    btnLichSuMuon.Visible = false;
                    break;
            }
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            // Bật hộp thoại hỏi người dùng cho lịch sự
            DialogResult xacNhan = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất khỏi hệ thống?",
                                                   "Xác nhận",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);

            if (xacNhan == DialogResult.Yes)
            {
                // Xóa thông tin phiên làm việc hiện tại (nếu cần thiết)
                this.currentRole = 0;
                this.currentMaNguoiMuon = null;

                // Đóng FrmMain lại. 
                // Nhờ lệnh này, FrmDangNhap ở dưới sẽ thoát trạng thái chờ và tự hiện lên!
                this.Close();
            }
        }
        private void TinhChieuCaoVuaDu()
        {
            chieuCaoMucTieu = 0; // Reset về 0 trước khi đếm

            // Duyệt qua từng control (nút bấm) nằm trong panelSubMenu
            foreach (Control ctrl in panelSubMenu_ChucNang.Controls)
            {
                // QUAN TRỌNG: Chỉ cộng chiều cao của những nút đang được phân quyền cho phép hiện
                if (ctrl.Visible == true)
                {
                    chieuCaoMucTieu += ctrl.Height;
                }
            }

            //chieuCaoMucTieu += 5; 
        }

        private void btnDangKyMuonSach_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmProfileNguoiDung());
        }

        private void btnTimKiemSach_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmTimKiemSach());
        }

        private void btnQuanLyDocTaiCho_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmPhieuDocTaiCho());
        }

        private void btnDangKyMuonSachDTC_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmKhachMuonSachDocTaiCho());
        }

        private void btnDangKyTheMuon_NguoiDung_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmDangKyTheMuon_NguoiDung());
        }

        private void btnGioSach_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLyTaiKhoan());
        }
    }
}
