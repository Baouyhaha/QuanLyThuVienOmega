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


namespace LibraryManagerGUI
{
    public partial class FrmQuanLyTaiKhoan : Form
    {
        private TaiKhoanBUS bus = new TaiKhoanBUS();

        public FrmQuanLyTaiKhoan()
        {

            InitializeComponent();
        }
        private void LoadData()
        {
            string search = txtTimKiem.Text.Trim();

            // Chuyển đổi từ Index của ComboBox sang giá trị trạng thái trong DB
            int status = -1;
            if (cboLocTrangThai.SelectedIndex == 1) status = 0;
            else if (cboLocTrangThai.SelectedIndex == 2) status = 1;
            else if (cboLocTrangThai.SelectedIndex == 3) status = 2;

            dgvDanhSach.DataSource = bus.LayDanhSach(search, status);
        }
        private void FrmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            // Thêm các lựa chọn vào ComboBox
            cboLocTrangThai.Items.Clear();
            cboLocTrangThai.Items.Add("--- Tất cả ---");   // Index 0 -> tương ứng -1
            cboLocTrangThai.Items.Add("Đã khóa (0)");      // Index 1 -> tương ứng 0
            cboLocTrangThai.Items.Add("Đã kích hoạt (1)"); // Index 2 -> tương ứng 1
            cboLocTrangThai.Items.Add("Chờ duyệt (2)");    // Index 3 -> tương ứng 2
            cboLocTrangThai.SelectedIndex = 0; // Mặc định chọn Tất cả

            LoadData();
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSach.Rows[e.RowIndex];

                // Gán lên các Label em đã thiết kế trên ảnh
                lblTenHienThi.Text = row.Cells["hoTen"].Value.ToString();
                lblMaDinhDanhHienThi.Text = row.Cells["maDinhDanh"].Value.ToString();
                txtSoTienThu.Text = row.Cells["soTienDatCoc"].Value.ToString();

                // Lưu lại mã người mượn vào một biến tạm hoặc Tag của Form để dùng khi bấm nút
                this.Tag = row.Cells["maNguoiMuon"].Value.ToString();
                lblTenHienThi.Visible = true;
                lblMaDinhDanhHienThi.Visible = true;
            }
        }

        private void btnDuyetThe_Click(object sender, EventArgs e)
        {
            string maNM = this.Tag?.ToString();
            if (string.IsNullOrEmpty(maNM)) return;

            int tien = int.Parse(txtSoTienThu.Text);

            if (bus.DuyetHoacHuyThe(maNM, 1, tien)) // 1 là Đã kích hoạt
            {
                MessageBox.Show("Đã duyệt và kích hoạt thẻ thành công!");
                LoadData();
            }
        }

        private void btnHuyThe_Click(object sender, EventArgs e)
        {
            string maNM = this.Tag?.ToString();
            if (string.IsNullOrEmpty(maNM)) return;

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn hủy/khóa thẻ này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (bus.DuyetHoacHuyThe(maNM, 0, 0)) // 0 là Khóa/Chưa kích hoạt, tiền cọc về 0
                {
                    MessageBox.Show("Đã hủy thẻ thành công!");
                    LoadData();
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cboLocTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
