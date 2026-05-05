using LibraryManagerBUS;
using LibraryManagerDTO;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LibraryManagerGUI
{
    public partial class FrmPhieuDocTaiCho : Form
    {
        private PhieuDocTaiChoBUS bus = new PhieuDocTaiChoBUS();

        public FrmPhieuDocTaiCho()
        {
            InitializeComponent();
        }

        private void FrmPhieuDocTaiCho_Load(object sender, EventArgs e)
        {
            ResetForm();

            // Tính năng thông minh: Gõ xong nhấn Enter sẽ gọi thẳng nút Tạo phiếu
            this.AcceptButton = btnTaoPhieu;
            LoadDanhSachDoc();
        }

        private void HienThiMaPhieuMoi()
        {
            // Hiển thị mã phiếu sắp được tạo lên Label 
            lblPhieuMoi.Text = bus.SinhMaPhieuMoi();
        }

        // TÍNH NĂNG THÔNG MINH CHO THỦ THƯ: Quét/Nhập CCCD xong nhấn Enter tự động điền tên
        private void txtCCCD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Tắt tiếng "Bíp"

                string cccd = txtCCCD.Text.Trim();
                string result = bus.KiemTraKhachVangLai(cccd);

                if (result == "ERROR_FORMAT")
                {
                    lblTrangThai.Text = "Lỗi: Số CCCD phải gồm đúng 12 chữ số!";
                    lblTrangThai.ForeColor = Color.Red;
                    return;
                }

                if (result == "NEW_GUEST")
                {
                    lblTrangThai.Text = "Khách mới! Vui lòng nhập họ tên.";
                    lblTrangThai.ForeColor = Color.Blue;
                    txtHoTen.Focus();
                }
                else
                {
                    lblTrangThai.Text = "Đã tìm thấy thông tin khách cũ!";
                    lblTrangThai.ForeColor = Color.Green;
                    txtHoTen.Text = result; // Tự động điền tên cũ
                    txtQuetMaSach.Focus();  // Nhảy thẳng xuống ô mã sách
                }
            }
        }

        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            lblTrangThai.Text = "Đang xử lý...";
            lblTrangThai.ForeColor = Color.Black;

            // Lấy dữ liệu từ giao diện đưa vào DTO 
            PhieuDocTaiCho phieu = new PhieuDocTaiCho()
            {
                Cccd = txtCCCD.Text.Trim(),
                tenNguoiDoc = txtHoTen.Text.Trim(),
                // ĐÃ SỬA LỖI Ở ĐÂY: Gán vào maBanSao thay vì maSach
                maBanSao = txtQuetMaSach.Text.Trim()
            };

            // Gọi BUS xử lý
            string ketQua = bus.TaoPhieu(phieu);

            if (ketQua == "SUCCESS")
            {
                MessageBox.Show("Tạo phiếu thành công!\nMã phiếu: " + bus.SinhMaPhieuMoi(), // Lấy mã mới để báo (vì mã cũ vừa bị tiêu thụ)
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();
                LoadDanhSachDoc();

                // Trạng thái thành công báo sau khi Reset
                lblTrangThai.Text = "Tạo phiếu thành công!";
                lblTrangThai.ForeColor = Color.Green;
            }
            else
            {
                lblTrangThai.Text = "Lỗi: Kiểm tra lại thông tin!";
                lblTrangThai.ForeColor = Color.Red;
                MessageBox.Show(ketQua, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ResetForm()
        {
            txtCCCD.Clear();
            txtHoTen.Clear();
            txtQuetMaSach.Clear();
            lblTrangThai.Text = "Sẵn sàng tạo phiếu!";
            lblTrangThai.ForeColor = Color.Black;

            HienThiMaPhieuMoi(); // Cập nhật mã cho phiếu tiếp theo
            txtCCCD.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem thủ thư đã click chọn dòng nào trên DataGridView chưa
            if (dgvDanhSachDoc.CurrentRow == null || dgvDanhSachDoc.CurrentRow.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn một phiếu đang đọc trên lưới để nhận trả sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Lấy Mã phiếu và Mã bản sao sách một cách an toàn nhất (Lấy từ DataBoundItem)
                DataRowView row = (DataRowView)dgvDanhSachDoc.CurrentRow.DataBoundItem;

                // CHÚ Ý: Đảm bảo trong câu lệnh SELECT ở hàm LayDanhSachHienTai() (Tầng DAL)
                // em phải lấy cả cột "maPhieu" và "maBanSao" lên nhé.
                string maPhieu = row["maPhieu"].ToString();
                string maBanSao = row["maBanSao"].ToString();

                // 3. Hỏi lại cho chắc chắn
                DialogResult dr = MessageBox.Show($"Xác nhận khách đã trả lại cuốn sách có mã '{maBanSao}' của phiếu '{maPhieu}'?",
                                                  "Xác nhận trả sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    // 4. Gọi BUS xử lý (Hàm này sẽ gọi xuống DAL để chạy Transaction UPDATE cả 2 bảng)
                    string ketQua = bus.NhanTraSachKhachVangLai(maPhieu, maBanSao);

                    if (ketQua == "SUCCESS")
                    {
                        MessageBox.Show("Khách đã trả sách thành công!\nTrạng thái sách đã chuyển về: Sẵn sàng mượn.",
                                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                        LoadDanhSachDoc();
                    }
                    else
                    {
                        MessageBox.Show(ketQua, "Lỗi khi trả sách", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy dữ liệu từ lưới. Vui lòng kiểm tra lại câu truy vấn SELECT!\nChi tiết: " + ex.Message,
                                "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDanhSachDoc()
        {
            // Gọi BUS để lấy dữ liệu
            dgvDanhSachDoc.DataSource = bus.LayDanhSachHienTai();

            // Tối ưu hiển thị: Cho bảng tự giãn đều các cột
            dgvDanhSachDoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}