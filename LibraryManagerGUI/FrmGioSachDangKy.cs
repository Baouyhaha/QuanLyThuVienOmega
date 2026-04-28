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

namespace LibraryManagerGUI
{
    public partial class FrmGioSachDangKy : Form
    {
        BindingList<SachDTO> gioSach = new BindingList<SachDTO>();
        public FrmGioSachDangKy()
        {
            InitializeComponent();
        }

        private void FrmGioSachDangKy_Load(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ biến static của Form Tìm Kiếm
            DataTable dtGio = FrmTimKiemSach.GioHang;

            // Đổ vào ListBox
            lbxGioHang.DataSource = dtGio;
            lbxGioHang.DisplayMember = "Tên Sách"; // Cái hiện lên cho người dùng xem
            lbxGioHang.ValueMember = "Mã Sách";    // Cái giá trị ngầm bên dưới để mình code
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
