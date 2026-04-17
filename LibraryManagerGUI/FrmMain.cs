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
        public FrmMain()
        {
            InitializeComponent();
        }

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
            // Chiều cao tối đa khi mở hết các nút con (ví dụ có 3 nút con, mỗi nút 45px + nút chính 50px = 185px)
            int maxHeight = 185;
            // Chiều cao tối thiểu khi đóng (chỉ hiện nút chính)
            int minHeight = 50;

            if (isSachCollapsed)
            {
                // Đang đóng -> Mở ra
                panelSubMenu_ChucNang.Height += 10; // Tốc độ trượt
                if (panelSubMenu_ChucNang.Height >= maxHeight)
                {
                    panelSubMenu_ChucNang.Height = maxHeight;
                    timerMenuChucNang.Stop();
                    isSachCollapsed = false;
                }
            }
            else
            {
                // Đang mở -> Đóng lại
                panelSubMenu_ChucNang.Height -= 10;
                if (panelSubMenu_ChucNang.Height <= minHeight)
                {
                    panelSubMenu_ChucNang.Height = minHeight;
                    timerMenuChucNang.Stop();
                    isSachCollapsed = true;
                }
            }
        }

        // Sự kiện Click vào nút chính
        private void btnChucNang_Click(object sender, EventArgs e)
        {
            timerMenuChucNang.Start();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLySach());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmNhanTraSach());
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
    }
}
