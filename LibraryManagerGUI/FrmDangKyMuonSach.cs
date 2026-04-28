using LibraryManagerDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace LibraryManagerGUI
{
    public partial class FrmDangKyMuonSach : Form
    {
        public List<SachDTO> danhSachChon = new List<SachDTO>();
        public FrmDangKyMuonSach()
        {
            InitializeComponent();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtTimSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiemSach_Click(object sender, EventArgs e)
        {

        }

        private void dgvKhoSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelGioSach_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThemGioSach_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {

        }

        private void dgvKhoSach_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblThongTinGioSachDaChon_Click(object sender, EventArgs e)
        {

        }

        private void btnDangKyMuonSach_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiemSach_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panelKhoSach_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTimKiem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTieuDe_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem người dùng đã chọn cuốn sách nào trong ListBox chưa
            if (lbxGioHang.SelectedIndex != -1)
            {
                // 2. Lấy vị trí (index) của dòng đang chọn
                int index = lbxGioHang.SelectedIndex;

                // 3. Xóa dòng tương ứng trong DataTable "gốc" (GioHang) 
                // Vì GioHang là biến static ở Form Tìm Kiếm nên mình gọi trực tiếp
                FrmTimKiemSach.GioHang.Rows.RemoveAt(index);

                // 4. Thông báo nhỏ để người dùng biết
                // MessageBox.Show("Đã xóa sách khỏi danh sách đăng ký.");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một cuốn sách trong danh sách để xóa!", "Thông báo");
            }
        }

        private void FrmDangKyMuonSach_Load(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ biến static của Form Tìm Kiếm
            DataTable dtGio = FrmTimKiemSach.GioHang;

            // Đổ vào ListBox
            lbxGioHang.DataSource = dtGio;
            lbxGioHang.DisplayMember = "Tên Sách"; // Cái hiện lên cho người dùng xem
            lbxGioHang.ValueMember = "Mã Sách";    // Cái giá trị ngầm bên dưới để mình code
        }

        private void btnXoaToanBo_Click(object sender, EventArgs e)
        {
            // 1. Xác nhận với người dùng để tránh bấm nhầm
            DialogResult result = MessageBox.Show("Bạn có muốn hủy toàn bộ danh sách đăng ký không?",
                                                  "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 2. Xóa sạch mọi dòng trong DataTable "gốc" (biến tĩnh ở Form Tìm Kiếm)
                // Đây chính là cách làm triệt để nhất dựa trên logic nút Xóa bạn đã viết
                if (FrmTimKiemSach.GioHang != null)
                {
                    FrmTimKiemSach.GioHang.Clear();
                }

                // 3. Xóa List DTO để đồng bộ dữ liệu (Nếu bạn vẫn dùng List<Book> song song)
                if (danhSachChon != null)
                {
                    danhSachChon.Clear();
                }

                // 4. Thông báo và tắt form
                // Vì DataTable đã Clear, khi bạn mở lại Form, ListBox sẽ tự động trống trơn
                this.Close();
            }
        }
    }
}
