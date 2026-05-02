using LibraryManagerBUS;
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
    public partial class FrmKhachMuonSachDocTaiCho : Form
    {
        private PhieuDocTaiChoBUS bus = new PhieuDocTaiChoBUS();

        public FrmKhachMuonSachDocTaiCho()
        {
            InitializeComponent();
        }

        private void FrmKhachMuonSachDocTaiCho_Load(object sender, EventArgs e)
        {
            ResetGiaiDoan1();
        }

        private void ResetGiaiDoan1()
        {
            txtCCCD.Clear();
            txtHoTen.Clear();
            txtMaSach.Clear();

            lblLoiChao.Text = "Vui lòng nhập số CCCD và nhấn Enter";
            lblLoiChao.ForeColor = Color.Black;

            pnlThongTin.Visible = false; // Ẩn toàn bộ phần nhập tên, mã sách, nút xác nhận
            txtCCCD.Enabled = true;
            txtCCCD.Focus();
        }

        private void txtCCCD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Tắt tiếng "Bíp" của Windows khi nhấn Enter

                string cccd = txtCCCD.Text.Trim();
                string result = bus.KiemTraKhachVangLai(cccd);

                if (result == "ERROR_FORMAT")
                {
                    lblLoiChao.Text = "Lỗi: Số CCCD phải gồm đúng 12 chữ số!";
                    lblLoiChao.ForeColor = Color.Red;
                    return;
                }

                // Nếu hợp lệ -> Chuyển sang Giai đoạn 2
                pnlThongTin.Visible = true; // Hiện phần dưới lên
                txtCCCD.Enabled = false;    // Khóa ô CCCD lại không cho sửa nữa

                if (result == "NEW_GUEST")
                {
                    lblLoiChao.Text = "Chào mừng bạn lần đầu đến thư viện!";
                    lblLoiChao.ForeColor = Color.Blue;
                    txtHoTen.Focus(); // Yêu cầu khách tự nhập tên
                }
                else
                {
                    lblLoiChao.Text = "Chào mừng bạn trở lại, " + result + "!";
                    lblLoiChao.ForeColor = Color.Green;
                    txtHoTen.Text = result; // Tự động điền tên cũ
                    txtMaSach.Focus();      // Nhảy thẳng xuống ô mã sách để quét luôn
                }
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // Gom dữ liệu đưa vào DTO
            PhieuDocTaiCho phieuMoi = new PhieuDocTaiCho()
            {
                Cccd = txtCCCD.Text.Trim(),
                tenNguoiDoc = txtHoTen.Text.Trim(),

                // ĐÃ SỬA Ở ĐÂY: Gán vào maBanSao thay vì maSach để khớp với DB mới
                maBanSao = txtMaSach.Text.Trim()
            };

            // Gọi hàm TaoPhieu đã được tối ưu hóa ở BUS
            string ketQua = bus.TaoPhieu(phieuMoi);

            if (ketQua == "SUCCESS")
            {
                MessageBox.Show("Đã ghi nhận phiếu đọc sách!\nMã phiếu: " + phieuMoi.maPhieu,
                                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetGiaiDoan1();
            }
            else
            {
                // Báo lỗi từ tầng BUS (ví dụ: Bản sao không tồn tại, đang bị mượn...)
                MessageBox.Show(ketQua, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}