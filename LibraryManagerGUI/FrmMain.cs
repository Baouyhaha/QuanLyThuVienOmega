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
            this.WindowState = FormWindowState.Maximized; // Luôn mở to hết màn hình khi chạy
            // Sử dụng biến currentRole đã được truyền vào từ Constructor ở bài trước
            switch (currentRole)
            {
                case 2: // ================== QUYỀN THỦ THƯ ==================
                        // 1. Cập nhật lời chào
                    lblXinChao.Text = "Tài khoản: THỦ THƯ";
                    MessageBox.Show("Chào mừng Thủ thư đã quay lại hệ thống!", "Đăng nhập thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnXemThongTinSach.Visible = false;
                    btnDangKyDocTaiCho.Visible = false;
                    btnDKMuonSach.Visible = false;
                    btnDKTheMuon.Visible = false;
                    btnThongTinNguoiDung.Visible = false;
                    btnTTNhanTraSach.Visible = true;
                    btnTTQuanLySach.Visible = true;
                    btnQuanLyDKSach.Visible = true;
                    btnTTQuanLyTaiKhoan.Visible = true;
                    btnTTQuanLyTacGIa.Visible = true;
                    btnTTQuanLyBanSaoSach.Visible = true;
                    btnTTQuanLyPhieuDocTaiCho.Visible = true;
                    btnThongKeTopSach.Visible = true;
                    btnQuanLyTheMuon.Visible = true;
                    break;

                case 1: // ================== QUYỀN ĐỘC GIẢ (ĐÃ KÍCH HOẠT) ==================
                    lblXinChao.Text = "Tài khoản: ĐỘC GIẢ (Active)";
                    MessageBox.Show("Đăng nhập thành công! Bạn có thể đặt mượn sách ngay bây giờ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnXemThongTinSach.Visible = true;
                    btnDangKyDocTaiCho.Visible = true;
                    btnDKMuonSach.Visible = true;
                    btnDKTheMuon.Visible = true;
                    btnThongTinNguoiDung.Visible = true;
                    btnTTNhanTraSach.Visible = false;
                    btnTTQuanLySach.Visible = false;
                    btnQuanLyDKSach.Visible = false;
                    btnTTQuanLyTaiKhoan.Visible = false;
                    btnTTQuanLyTacGIa.Visible = false;
                    btnTTQuanLyBanSaoSach.Visible = false;
                    btnTTQuanLyPhieuDocTaiCho.Visible = false;
                    btnThongKeTopSach.Visible = false;
                    btnQuanLyTheMuon.Visible = false;
                    break;

                case -1: // ================== QUYỀN ĐỘC GIẢ (CHƯA KÍCH HOẠT) ==================
                    lblXinChao.Text = "Tài khoản: ĐỘC GIẢ (Chưa kích hoạt)";
                    MessageBox.Show("Tài khoản của bạn chưa được kích hoạt. Bạn chỉ có thể tra cứu sách nhưng chưa thể mượn. Vui lòng gặp thủ thư để đóng cọc/kích hoạt!", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnXemThongTinSach.Visible = true;
                    btnDangKyDocTaiCho.Visible = true;
                    btnDKMuonSach.Visible = false;
                    btnDKTheMuon.Visible = false;
                    btnThongTinNguoiDung.Visible = false;
                    btnTTNhanTraSach.Visible = false;
                    btnTTQuanLySach.Visible = false;
                    btnQuanLyDKSach.Visible = false;
                    btnTTQuanLyTaiKhoan.Visible = false;
                    btnTTQuanLyTacGIa.Visible = false;
                    btnTTQuanLyBanSaoSach.Visible = false;
                    btnTTQuanLyPhieuDocTaiCho.Visible = false;
                    btnThongKeTopSach.Visible = false;
                    btnQuanLyTheMuon.Visible = false;
                    break;

                case 0: // ================== QUYỀN KHÁCH VÃNG LAI ==================
                    lblXinChao.Text = "Tài khoản: KHÁCH";

                    btnXemThongTinSach.Visible = true;
                    btnDangKyDocTaiCho.Visible = true;
                    btnDKMuonSach.Visible = false;
                    btnDKTheMuon.Visible = false;
                    btnThongTinNguoiDung.Visible = false;
                    btnTTNhanTraSach.Visible = false;
                    btnTTQuanLySach.Visible = false;
                    btnQuanLyDKSach.Visible=false;
                    btnTTQuanLyTaiKhoan.Visible = false;
                    btnTTQuanLyTacGIa.Visible = false;
                    btnTTQuanLyBanSaoSach.Visible = false;
                    btnTTQuanLyPhieuDocTaiCho.Visible=false;
                    btnThongKeTopSach.Visible = false;
                    btnQuanLyTheMuon.Visible = false;
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
            int chieuCaoBanDau = panelSubMenu_ChucNang.Height;

            panelSubMenu_ChucNang.Height = 2000;

            panelSubMenu_ChucNang.PerformLayout();
            int tongChieuCao = 0;
            foreach (Control con in panelSubMenu_ChucNang.Controls)
            {
                if (con.Visible)
                {
                    tongChieuCao += con.Height;
                }
            }
            chieuCaoMucTieu = tongChieuCao + 10;

            panelSubMenu_ChucNang.Height = chieuCaoBanDau;
        }

        private void btnXemThongTinSach_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmTimKiemSach());
        }

        private void btnDangKyDocTaiCho_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmKhachMuonSachDocTaiCho());
        }

        private void btnDKMuonSach_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmDangKyMuonSach());
        }

        private void btnDangKyTheMuon_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmDangKyTheMuon_NguoiDung());
        }

        private void btnTTNhanTraSach_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmNhanTraSach());
        }

        private void btnTTQuanLySach_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLySach());
        }

        private void btnQuanLyTheMuon_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLyTheMuon());
        }

        private void btnTTQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLyTaiKhoan());
        }

        private void btnTTQuanLyTacGIa_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLyTacGia());
        }

        private void btnTTQuanLyBanSaoSach_Click(object sender, EventArgs e)
        {
            //openChildForm(new FrmQuanLyDangKySach());
        }

        private void btnTTQuanLyPhieuDocTaiCho_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmPhieuDocTaiCho());
        }

        private void btnThongKeTopSach_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmThongKeTopSach());
        }

        private void btnQuanLyDKSach_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLyDangKySach());
        }

        private void btnThongTinNguoiDung_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmProfileNguoiDung());
        }

        private void btnQuanLyTheMuon_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLyTheMuon());
        }
    }
}
