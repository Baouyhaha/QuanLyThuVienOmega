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
    public partial class FrmDangKyTheMuon_NguoiDung : Form
    {
        private DangKyTheBUS bus = new DangKyTheBUS();
        public FrmDangKyTheMuon_NguoiDung()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // 1. Gom dữ liệu trên Form vào đối tượng DTO
            DangKyTheDTO khachMoi = new DangKyTheDTO()
            {
                HoTen = txtHoTen.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value,
                Sdt = txtSDT.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim(),
                LoaiDocGia = cmbLoaiDocGia.Text, // Lấy giá trị "Sinh viên" hoặc "Khách ngoài"
                MaDinhDanh = txtMaDinhDanh.Text.Trim()
            };

            // 2. Gọi BUS để xử lý
            string ketQua = bus.XuLyDangKy(khachMoi);

            if (ketQua == "SUCCESS")
            {
                // THÔNG BÁO DÀNH CHO NGƯỜI DÙNG
                MessageBox.Show("Yêu cầu đăng ký thẻ của bạn đã được gửi thành công!\n\nVui lòng đem theo Thẻ Sinh Viên hoặc CCCD đến quầy thủ thư để hoàn tất thủ tục và nhận thẻ.",
                                "Đăng ký thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ResetForm();
            }
            else
            {
                MessageBox.Show(ketQua, "Có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
