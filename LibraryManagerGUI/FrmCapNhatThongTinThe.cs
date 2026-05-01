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
        private int trangThaiHienTai = 0;
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
            DataTable dt = theMuonBUS.TimKiemThongTinThe(maThe);

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                // Đổ dữ liệu lên các TextBox
                txtTenTaiKhoan.Text = row["tenTaiKhoan"].ToString();
                txtHoTen.Text = row["ten"].ToString();
                txtSoDienThoai.Text = row["soDienThoai"].ToString();
                txtNgayHetHan.Text = row["ngayHetHan"].ToString();

                // XỬ LÝ TRẠNG THÁI (Code dọn dẹp):
                // Thử tìm cột trangThai, nếu có thì mới cập nhật giao diện, không có thì bỏ qua (không hiện MessageBox lỗi nữa)
                if (dt.Columns.Contains("trangThai"))
                {
                    trangThaiHienTai = Convert.ToInt32(row["trangThai"]);
                    CapNhatGiaoDienTrangThai(trangThaiHienTai); // Gọi hàm đổi màu nút/nhãn đã viết
                }
            }

        }
        private void HienThiTrangThai(int trangThai)
        {
            if (trangThai == 0)
            {
                lblTrangThaiThe.Text = "TRẠNG THÁI: ĐANG HOẠT ĐỘNG";
                lblTrangThaiThe.ForeColor = Color.Green;
                btnKhoaMoThe.Text = "Khóa thẻ";
                btnKhoaMoThe.FillColor = Color.Red; // Nếu dùng Guna2Button
            }
            else
            {
                lblTrangThaiThe.Text = "TRẠNG THÁI: ĐANG BỊ KHÓA";
                lblTrangThaiThe.ForeColor = Color.Red;
                btnKhoaMoThe.Text = "Mở khóa thẻ";
                btnKhoaMoThe.FillColor = Color.Green;
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

        private void btnKhoaMoThe_Click(object sender, EventArgs e)
        {
            string maThe = txtMaThe.Text.Trim();
            if (string.IsNullOrEmpty(maThe)) return;

            // Đảo ngược trạng thái: Nếu 0 (đang mở) -> 1 (khóa), nếu 1 (đang khóa) -> 0 (mở)
            int trangThaiMoi = (trangThaiHienTai == 0) ? 1 : 0;
            string hanhDong = (trangThaiMoi == 1) ? "KHÓA" : "MỞ KHÓA";

            if (MessageBox.Show($"Bạn có chắc chắn muốn {hanhDong} thẻ này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Gọi BUS xử lý (Nhớ khai báo hàm ThayDoiTrangThaiThe trong BUS như thầy hướng dẫn ở bước trước)
                string ketQua = theMuonBUS.ThayDoiTrangThaiThe(maThe, trangThaiMoi);

                if (ketQua == "SUCCESS")
                {
                    MessageBox.Show($"{hanhDong} thẻ thành công!", "Thông báo");
                    trangThaiHienTai = trangThaiMoi; // Cập nhật lại biến nhớ
                    CapNhatGiaoDienTrangThai(trangThaiHienTai); // Cập nhật màu sắc nút bấm/nhãn
                }
                else
                {
                    MessageBox.Show(ketQua, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Hàm giúp giao diện thay đổi trực quan
        private void CapNhatGiaoDienTrangThai(int status)
        {
            {
                if (status == 0) // Trạng thái 0: Đang hoạt động
                {
                    lblTrangThaiThe.Text = "TRẠNG THÁI: ĐANG HOẠT ĐỘNG";
                    lblTrangThaiThe.ForeColor = Color.Green; // Chữ màu xanh
                    btnKhoaMoThe.Text = "Khóa thẻ";
                    btnKhoaMoThe.FillColor = Color.Red; // Nút chuyển sang màu đỏ để người dùng biết bấm vào sẽ Khóa
                }
                else // Trạng thái 1: Đang bị khóa
                {
                    lblTrangThaiThe.Text = "TRẠNG THÁI: ĐANG BỊ KHÓA";
                    lblTrangThaiThe.ForeColor = Color.Red; // Chữ màu đỏ
                    btnKhoaMoThe.Text = "Mở khóa thẻ";
                    btnKhoaMoThe.FillColor = Color.Green; // Nút chuyển sang màu xanh để bấm vào sẽ Mở
                }
            }
        }

        private void FrmCapNhatThongTinThe_Load(object sender, EventArgs e)
        {
            LoadChiTietThe();
        }
        private void LoadChiTietThe()
        {
            string maThe = txtMaThe.Text.Trim();
            DataTable dt = theMuonBUS.TimKiemThongTinThe(maThe);

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                // Đổ dữ liệu lên các ô nhập liệu
                txtTenTaiKhoan.Text = row["tenTaiKhoan"].ToString();
                txtHoTen.Text = row["ten"].ToString();
                txtNgayHetHan.Text = row["ngayHetHan"].ToString();

                // Xử lý trạng thái và thay đổi màu chữ ngay khi load form
                if (dt.Columns.Contains("trangThai"))
                {
                    trangThaiHienTai = Convert.ToInt32(row["trangThai"]);
                    CapNhatGiaoDienTrangThai(trangThaiHienTai); // Gọi hàm đổi màu nhãn
                }
            }
        }
    }
}
