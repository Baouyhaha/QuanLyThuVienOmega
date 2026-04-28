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
    public partial class FrmPhieuDocTaiCho : Form
    {
        private PhieuDocTaiChoBUS bus = new PhieuDocTaiChoBUS();
        public FrmPhieuDocTaiCho()
        {
            InitializeComponent();
        }

        private void FrmPhieuDocTaiCho_Load(object sender, EventArgs e)
        {
            HienThiMaPhieuMoi();
            txtCCCD.Focus();

            // Tính năng thông minh: Gõ xong nhấn Enter sẽ gọi thẳng nút Tạo phiếu
            this.AcceptButton = btnTaoPhieu;
        }

        private void HienThiMaPhieuMoi()
        {
            // Hiển thị mã phiếu sắp được tạo lên Label 
            // Giả sử tên Label của em ở chỗ "TỰ ĐỘNG hiện ra" là lblPhieuMoi
            lblPhieuMoi.Text = bus.SinhMaPhieuMoi();
        }

        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            lblTrangThai.Text = "Đang xử lý...";

            // Lấy dữ liệu từ giao diện đưa vào DTO em đã tạo
            PhieuDocTaiCho phieu = new PhieuDocTaiCho()
            {
                Cccd = txtCCCD.Text.Trim(),
                tenNguoiDoc = txtHoTen.Text.Trim(),
                maSach = txtQuetMaSach.Text.Trim()
            };

            // Gọi BUS xử lý
            string ketQua = bus.TaoPhieu(phieu);

            if (ketQua == "SUCCESS")
            {
                MessageBox.Show("Tạo phiếu thành công!\nMã phiếu: " + phieu.maPhieu,
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Trạng thái thành công
                lblTrangThai.Text = "Tạo phiếu thành công!";
                lblTrangThai.ForeColor = Color.Green;

                ResetForm();
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
            ResetForm();
        }
    }
}
