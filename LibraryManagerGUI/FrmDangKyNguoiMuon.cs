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
using LibraryManagerBUS;
using LibraryManagerDTO;
namespace LibraryManagerGUI
{
    public partial class FrmDangKyTheMuon_NguoiDung : Form
    {
        DangKyTheBUS bus = new DangKyTheBUS();
        public string TenDangNhapHienTai { get; set; }
        public FrmDangKyTheMuon_NguoiDung()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(txtMaDinhDanh.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các thông tin bắt buộc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Xác nhận gửi yêu cầu đăng ký thẻ mượn?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (confirm == DialogResult.OK)
            {
                DangKyTheDTO khachMoi = new DangKyTheDTO()
                {
                    TenTaiKhoan = TaiKhoanSession.TaiKhoanHienTai,
                    HoTen = txtHoTen.Text.Trim(),
                    NgaySinh = dtpNgaySinh.Value,
                    Sdt = txtSDT.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim(),
                    LoaiDocGia = cmbLoaiDocGia.Text,
                    MaDinhDanh = txtMaDinhDanh.Text.Trim()
                };

                string ketQua = bus.XuLyDangKy(khachMoi);

                if (ketQua == "SUCCESS")
                {
                    MessageBox.Show("Đăng ký thẻ mượn thành công.", "Thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(ketQua, "Lỗi");
                }
            }
        }
        private void ResetForm()
        {
            txtHoTen.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            txtMaDinhDanh.Clear();
            txtHoTen.Focus();
        }
    }
}
