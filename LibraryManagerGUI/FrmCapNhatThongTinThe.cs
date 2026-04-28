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
    public partial class FrmCapNhatThongTinThe : Form
    {
        private TheMuonBUS theMuonBUS = new TheMuonBUS();
        public FrmCapNhatThongTinThe(string maTheNhanVe)
        {
            InitializeComponent();
            // Gán giá trị nhận được vào TextBox
            txtMaThe.Text = maTheNhanVe;
            // Tự động kích hoạt nút tìm kiếm để đổ dữ liệu lên luôn khi vừa mở Form
            btnTimKiem_Click(null, null);
        }
        public FrmCapNhatThongTinThe()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maThe = txtMaThe.Text.Trim();
            if (string.IsNullOrEmpty(maThe))
            {
                MessageBox.Show("Vui lòng nhập Mã Thẻ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = theMuonBUS.TimKiemThongTinThe(maThe);

            if (dt != null && dt.Rows.Count > 0)
            {
                // Đổ dữ liệu từ DataTable lên các TextBox
                DataRow row = dt.Rows[0];
                txtTenTaiKhoan.Text = row["tenTaiKhoan"].ToString();
                txtHoTen.Text = row["ten"].ToString();
                txtSoDienThoai.Text = row["soDienThoai"].ToString();

                string ngayHetHanStr = row["ngayHetHan"].ToString();
                txtNgayHetHan.Text = ngayHetHanStr; // Ô TextBox "ngày hết hạn thẻ" (cũ)

                // Kiểm tra hạn thẻ (Màu đỏ nếu hết hạn)
                KiemTraMauSacHanThe(ngayHetHanStr);

                // Gợi ý ngày gia hạn mới (+ 6 tháng vào dtpHanTheHienTai)
                dtpHanTheHienTai.Value = DateTime.Now.AddMonths(6);
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin cho Mã Thẻ này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Có thể viết thêm hàm XoaTrangDuLieu() ở đây
            }

        }
        // --- HÀM KIỂM TRA MÀU SẮC NGÀY HẾT HẠN ---
        private void KiemTraMauSacHanThe(string ngayHetHanStr)
        {
            try
            {
                // Cố gắng chuyển chuỗi trong DB thành kiểu DateTime để so sánh
                // Em nhớ đổi định dạng "MM/dd/yyyy" thành định dạng em lưu trong SQL nhé
                DateTime ngayHetHan = DateTime.ParseExact(ngayHetHanStr, "MM/dd/yyyy", null);

                if (ngayHetHan < DateTime.Now)
                {
                    // Nếu đã hết hạn (nhỏ hơn ngày hiện tại) -> Đổi màu chữ sang ĐỎ
                    txtNgayHetHan.ForeColor = Color.Red;
                    txtNgayHetHan.Font = new Font(txtNgayHetHan.Font, FontStyle.Bold);
                }
                else
                {
                    // Nếu còn hạn -> Trả về màu Đen bình thường
                    txtNgayHetHan.ForeColor = Color.Black;
                    txtNgayHetHan.Font = new Font(txtNgayHetHan.Font, FontStyle.Regular);
                }
            }
            catch
            {
                // Bỏ qua lỗi nếu chuỗi ngày tháng trong DB bị sai định dạng
            }
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            string maThe = txtMaThe.Text.Trim();
            // Lấy ngày mới từ DateTimePicker
            DateTime ngayMoi = dtpHanTheHienTai.Value;

            // Gọi BUS xử lý
            string ketQua = theMuonBUS.GiaHanThe(maThe, ngayMoi);

            if (ketQua == "SUCCESS")
            {
                MessageBox.Show("Gia hạn thẻ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cập nhật lại giao diện ngay lập tức
                txtNgayHetHan.Text = ngayMoi.ToString("MM/dd/yyyy");
                KiemTraMauSacHanThe(txtNgayHetHan.Text); // Trả lại màu đen vì đã có hạn mới
            }
            else
            {
                MessageBox.Show(ketQua, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maThe = txtMaThe.Text.Trim();
            if (string.IsNullOrEmpty(maThe)) return;

            // Thu thập dữ liệu từ UI
            string hoTen = txtHoTen.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            DateTime ngaySinh = dtpNgaySinh.Value;

            if (MessageBox.Show("Xác nhận cập nhật thông tin cá nhân?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Chỉ gửi những gì cần sửa ở bảng Tài Khoản
                string ketQua = theMuonBUS.CapNhatThongTin(maThe, hoTen, sdt, ngaySinh);

                if (ketQua == "SUCCESS")
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(ketQua, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
