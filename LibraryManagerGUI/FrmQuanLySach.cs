using LibraryManagerBUS;
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
    public partial class FrmQuanLySach : Form
    {
        public FrmQuanLySach()
        {
            InitializeComponent();
        }
        private SachBUS sachBUS = new SachBUS();
        private void FrmQuanLySach_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            // Gọi BUS để lấy dữ liệu và đổ vào Grid
            dgvDanhSachSach.DataSource = sachBUS.LayDanhSachSach();

            // Đổi tên cột hiển thị cho đẹp
            dgvDanhSachSach.Columns["maSach"].HeaderText = "Mã Sách";
            dgvDanhSachSach.Columns["tenSach"].HeaderText = "Tên Sách";
            dgvDanhSachSach.Columns["tenNhaPhatHanh"].HeaderText = "Nhà Xuất Bản";
            dgvDanhSachSach.Columns["soLuongHienCo"].HeaderText = "SL Hiện Có";
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData(); // Hàm tải lại DataGridView của bạn
        }

        private void btnMoFrmThemSach_Click(object sender, EventArgs e)
        {
            FrmThemSach frm = new FrmThemSach();
            frm.ShowDialog(); // Mở dưới dạng hộp thoại

            // Sau khi FrmThemSach đóng lại, gọi lại hàm LoadData để cập nhật sách mới thêm
            LoadData();
        }

        private void btnMoFrmSuaSach_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dgvDanhSachSach.SelectedRows.Count > 0)
            {
                // Phải đảm bảo tên cột "maSach" đúng với tên em đặt trong Grid
                string maS = dgvDanhSachSach.SelectedRows[0].Cells["maSach"].Value.ToString();

                // Truyền maS vào Form Sửa
                FrmSuaSach frm = new FrmSuaSach(maS);
                frm.ShowDialog();

                LoadData(); // Load lại danh sách sau khi sửa xong
            }
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem đã chọn dòng nào chưa
            if (dgvDanhSachSach.SelectedRows.Count > 0)
            {
                // Lấy mã sách từ cột đầu tiên của dòng đang chọn
                string maSach = dgvDanhSachSach.SelectedRows[0].Cells["maSach"].Value.ToString();
                string tenSach = dgvDanhSachSach.SelectedRows[0].Cells["tenSach"].Value.ToString();

                // 2. Xác nhận trước khi xóa
                DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa đầu sách: {tenSach}?",
                                  "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    // 3. Gọi BUS xử lý
                    string ketQua = sachBUS.XoaSachNghiepVu(maSach);

                    if (ketQua == "Thành công")
                    {
                        MessageBox.Show("Đã xóa sách thành công!");
                        LoadData(); // Load lại Grid để cập nhật danh sách
                    }
                    else
                    {
                        MessageBox.Show(ketQua, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một cuốn sách để xóa!");
            }
        }

        private void btnTimSach_Click(object sender, EventArgs e)
        {
            string keyword = txtTimSach.Text.Trim();
            dgvDanhSachSach.DataSource = sachBUS.TimKiemSach(keyword);
        }

        private void txtTimSach_TextChanged(object sender, EventArgs e)
        {
            // Cứ mỗi khi gõ 1 chữ cái, lưới sẽ tự lọc lại ngay lập tức
            string keyword = txtTimSach.Text.Trim();
            dgvDanhSachSach.DataSource = sachBUS.TimKiemSach(keyword);
        }
    }
}