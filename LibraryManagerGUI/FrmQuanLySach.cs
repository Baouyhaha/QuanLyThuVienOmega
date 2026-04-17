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
            try
            {
                // Gán dữ liệu cho DataGridView
                dgvDanhSachSach.DataSource = sachBUS.GetDanhSachSach();

                // Cấu hình giao diện DataGridView
                DinhDangLuoi();
                if (dgvDanhSachSach.Columns["Mã ISBN"] != null)
                {
                    dgvDanhSachSach.Columns["Mã ISBN"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void DinhDangLuoi()
        {
            if (dgvDanhSachSach.Columns.Count > 0)
            { 
                // Đặt độ rộng cố định cho một số cột nếu cần
                dgvDanhSachSach.Columns["Mã Sách"].FillWeight = 50;  // Cột mã hẹp hơn
                dgvDanhSachSach.Columns["Số Lượng Có Sẵn"].FillWeight = 70;

            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {

            LoadData(); // Hàm tải lại DataGridView của bạn
        }

        private void btnMoFrmThemSach_Click(object sender, EventArgs e)
        {
            FrmThemSach formThem = new FrmThemSach();
            formThem.ShowDialog();
            LoadData(); // Tải lại dữ liệu sau khi thêm sách mới
        }

        private void btnMoFrmSuaSach_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem người dùng đã chọn dòng nào trên lưới chưa
            if (dgvDanhSachSach.SelectedRows.Count > 0)
            {
                // 2. Lấy dòng đang được chọn
                DataGridViewRow row = dgvDanhSachSach.SelectedRows[0];

                // 3. Lấy dữ liệu từ các cột (Tên cột phải chính xác như khi bạn SELECT trong SQL)
                string maSach = row.Cells["Mã Sách"].Value.ToString();
                string tenSach = row.Cells["Tên Sách"].Value.ToString();
                string isbn = row.Cells["Mã ISBN"].Value.ToString();
                string nxb = row.Cells["Nhà Xuất Bản"].Value.ToString();
                int soLuong = Convert.ToInt32(row.Cells["Số Lượng Có Sẵn"].Value);
                string tacGia = row.Cells["Tác Giả"].Value.ToString();

                // 4. Mở Form Sửa và ném các dữ liệu này vào dấu ngoặc đơn (Constructor)
                FrmSuaSach frmSua = new FrmSuaSach(maSach, tenSach, isbn, nxb, tacGia, soLuong);

                // 5. Nếu Form sửa đóng lại với kết quả OK thì load lại lưới
                if (frmSua.ShowDialog() == DialogResult.OK)
                {
                    LoadData(); // Hàm tải lại dữ liệu dgv của bạn
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một cuốn sách để sửa!");
            }
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem người dùng đã chọn dòng nào chưa
            if (dgvDanhSachSach.SelectedRows.Count > 0)
            {
                // 2. Lấy Mã Sách của dòng đang chọn
                string maSach = dgvDanhSachSach.SelectedRows[0].Cells["Mã Sách"].Value.ToString();
                string tenSach = dgvDanhSachSach.SelectedRows[0].Cells["Tên Sách"].Value.ToString();

                // 3. Hỏi xác nhận (Cực kỳ quan trọng với lệnh Xóa)
                DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa cuốn sách: {tenSach} (Mã: {maSach}) không?",
                                                  "Xác nhận xóa",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    // 4. Gọi BUS để thực hiện xóa
                    if (sachBUS.XoaSachInfo(maSach))
                    {
                        MessageBox.Show("Xóa sách thành công!", "Thông báo");
                        LoadData(); // Tải lại lưới để cập nhật danh sách mới
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại! Có thể sách đang nằm trong phiếu mượn.", "Lỗi");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn cuốn sách cần xóa trên bảng!");
            }
        }

        private void btnTimSach_Click(object sender, EventArgs e)
        {
            string keyword = txtTimSach.Text.Trim();

            // Nếu để trống thì load lại toàn bộ danh sách
            if (string.IsNullOrEmpty(keyword))
            {
                LoadData();
            }
            else
            {
                DataTable dt = sachBUS.TimKiemSach(keyword);
                dgvDanhSachSach.DataSource = dt;

                // Thông báo nếu không tìm thấy
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sách nào khớp với từ khóa!", "Kết quả");
                }
            }
        }

        private void txtTimSach_TextChanged(object sender, EventArgs e)
        {
            // Cứ mỗi khi gõ 1 chữ cái, lưới sẽ tự lọc lại ngay lập tức
            string keyword = txtTimSach.Text.Trim();
            dgvDanhSachSach.DataSource = sachBUS.TimKiemSach(keyword);
        }
    }
}