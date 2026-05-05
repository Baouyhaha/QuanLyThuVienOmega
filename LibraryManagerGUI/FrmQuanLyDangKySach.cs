using LibraryManagerBUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace LibraryManagerGUI
{
    public partial class FrmQuanLyDangKySach : Form
    {
        private ThongTinMuonTraBUS muonTraBus = new ThongTinMuonTraBUS();
        public FrmQuanLyDangKySach()
        {
            InitializeComponent();
        }

        private void btnLocTrangThai_Click(object sender, EventArgs e)
        {
            // 1. Lấy từ khóa (Mã phiếu/Mã SV/Tên SV) - dùng đúng tên txt của Danh
            string tuKhoa = txtTimPhieu.Text.Trim();

            // 2. Lấy giá trị trạng thái từ ComboBox (0, 1, -1 hoặc -2 cho Tất cả)
            int trangThai = (int)cboTrangThai.SelectedValue;

            // 3. Đổ dữ liệu vào Grid bên trái
            dgvPhieuCho.DataSource = muonTraBus.LocPhieuMuon(tuKhoa, trangThai);

            // 4. Dọn dẹp bảng bên phải (Logic của Danh)
            if (dgvChiTietSach.DataSource is DataTable dt)
            {
                dt.Rows.Clear();
            }

            // 5. MỚI: Gọi hàm ẩn các Label để giao diện sạch sẽ
            AnCacLabelKetQua();
        }

        private void btnPheDuyetVaGiaoSach_Click(object sender, EventArgs e)
        {

            // 1. Kiểm tra xem có dòng nào được chọn không
            if (dgvPhieuCho.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một phiếu từ danh sách chờ!", "Thông báo");
                return;
            }

            string maPhieu = dgvPhieuCho.CurrentRow.Cells["maThongTinhMuonTraSach"].Value.ToString();

            // 2. Hỏi xác nhận trước khi thực hiện Transaction trong DB
            DialogResult dr = MessageBox.Show($"Xác nhận giao sách cho phiếu: {maPhieu}?", "Xác nhận",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                if (muonTraBus.PheDuyetGiaoSach(maPhieu))
                {
                    MessageBox.Show("Đã phê duyệt và giao sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình phê duyệt.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvPhieuCho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // 1. Lấy mã phiếu từ dòng được chọn
            string maPhieu = dgvPhieuCho.Rows[e.RowIndex].Cells["maThongTinhMuonTraSach"].Value.ToString();

            // 2. Hiển thị thông tin tổng quan lên các Label
            lblSoLuongSach.Text = dgvPhieuCho.Rows[e.RowIndex].Cells["soLuong"].Value.ToString();
            lblTongTienCoc.Text = string.Format("{0:N0} VNĐ", dgvPhieuCho.Rows[e.RowIndex].Cells["tienDatCoc"].Value);

            // 3. Hiển thị trạng thái thẻ (Dùng logic Danh đã chốt)
            int trangThaiThe = Convert.ToInt32(dgvPhieuCho.Rows[e.RowIndex].Cells["trangThaiThe"].Value);
            lblTrangThaiThe.Text = (trangThaiThe == 1) ? "Hợp lệ" : "Bị khóa/Hết hạn";
            lblTrangThaiThe.ForeColor = (trangThaiThe == 1) ? Color.Green : Color.Red;

            // --- MỚI: HIỆN CÁC LABEL SAU KHI ĐÃ GÁN DỮ LIỆU ---
            lblSoLuongSach.Visible = true;
            lblTongTienCoc.Visible = true;
            lblTrangThaiThe.Visible = true;

            // 4. Gọi BUS để lấy chi tiết sách và hiện lên dgvChiTietSach (Bảng bên phải)
            dgvChiTietSach.DataSource = muonTraBus.GetChiTietSachTrongPhieu(maPhieu);
        }
    

        private void FrmQuanLyDangKySach_Load(object sender, EventArgs e)
        {

            // 1. Tạo một danh sách các trạng thái (Key là chữ hiển thị, Value là số lưu database)
            Dictionary<string, int> listTrangThai = new Dictionary<string, int>();
            listTrangThai.Add("Tất cả", -2);          // Quy ước ở hàm LocPhieuMuon của em
            listTrangThai.Add("Đang chờ duyệt", 0);   // Trạng thái khi sinh viên mới đăng ký
            listTrangThai.Add("Đã giao sách", 1);     // Trạng thái đang mượn
            listTrangThai.Add("Đã trả", 2);           // Trạng thái đã trả xong
            listTrangThai.Add("Đã hủy", -1);          // Trạng thái phiếu bị hủy

            // 2. Ép danh sách này vào ComboBox
            cboTrangThai.DataSource = new BindingSource(listTrangThai, null);
            cboTrangThai.DisplayMember = "Key";   // Cột hiện ra cho người dùng xem
            cboTrangThai.ValueMember = "Value";   // Cột giá trị ẩn đi để code dùng
            // Load dữ liệu lên Grid bên trái ngay khi mở Form
            RefreshData();
            lblSoLuongSach.Visible = false;
            lblTongTienCoc.Visible = false;
            lblTrangThaiThe.Visible = false;

        }

        private void btnHuyPhieu_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra dòng chọn (Tránh lỗi Crash)
            if (dgvPhieuCho.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một phiếu để hủy!", "Thông báo");
                return;
            }

            // 2. Lấy mã phiếu (Fix lỗi maPhieu không tồn tại)
            string maPhieu = dgvPhieuCho.CurrentRow.Cells["maThongTinhMuonTraSach"].Value.ToString();

            // 3. Hỏi xác nhận (Đầy đủ như code Danh gửi)
            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn HỦY phiếu {maPhieu} không?\nSách sẽ được giải phóng cho người khác mượn.",
                                              "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                // 4. GỌI QUA BUS (Chỗ này thay cho đống SqlConnection dài dòng)
                if (muonTraBus.HuyPhieuMuon(maPhieu))
                {
                    MessageBox.Show("Đã hủy phiếu và giải phóng sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshData(); // Cập nhật lại Grid
                }
                else
                {
                    MessageBox.Show("Hủy phiếu thất bại. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtTimPhieu_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimPhieu.Text.Trim();

            // Gọi BUS để lấy dữ liệu lọc
            DataTable dt = muonTraBus.TimKiemNhanhChoThuThu(tuKhoa);
            dgvPhieuCho.DataSource = dt;

            // Reset bảng chi tiết bên phải nếu cần
            if (dgvChiTietSach.DataSource is DataTable dtChiTiet)
            {
                dtChiTiet.Rows.Clear();
            }

        }
        private void AnCacLabelKetQua()
        {
            lblSoLuongSach.Visible = false;
            lblTongTienCoc.Visible = false;
            lblTrangThaiThe.Visible = false;
        }
        private void RefreshData()
        {

            // 1. Nạp lại danh sách phiếu chờ từ BUS
            dgvPhieuCho.DataSource = muonTraBus.GetDsPhieuChoDuyet();

            // 2. Làm trống bảng chi tiết bên phải (Giữ nguyên logic của em)
            if (dgvChiTietSach.DataSource != null)
            {
                ((DataTable)dgvChiTietSach.DataSource).Rows.Clear();
            }

            // 3. Gọi hàm ẩn các Label thông tin (Mới thêm vào)
            AnCacLabelKetQua();
        }
        private void LoadComboBoxTrangThai()
        {
            // Tạo một danh sách các lựa chọn
            var listTrangThai = new[] {
        new { Text = "Tất cả", Value = -2 },
        new { Text = "Chờ duyệt", Value = 0 },
        new { Text = "Đang mượn", Value = 1 },
        new { Text = "Đã hủy", Value = -1 }
    };

            cboTrangThai.DataSource = listTrangThai.ToList();
            cboTrangThai.DisplayMember = "Text";  // Hiển thị chữ cho người dùng xem
            cboTrangThai.ValueMember = "Value";    // Trả về số cho code xử lý
        }

    }
}
