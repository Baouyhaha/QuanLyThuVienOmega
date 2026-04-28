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
    public partial class FrmProfileNguoiDung : Form
    {
        private NguoiMuonBUS bus = new NguoiMuonBUS();
        public FrmProfileNguoiDung()
        {
            InitializeComponent();
        }

        private void FrmProfileNguoiDung_Load(object sender, EventArgs e)
        {
            LoadThongTin();
        }

        private void LoadThongTin()
        {
            string taiKhoanDangNhap = TaiKhoanSession.TaiKhoanHienTai;
            DataTable dt = bus.LayThongTinHoSo(taiKhoanDangNhap);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                // Gán dữ liệu (Lưu ý: dùng đúng tên bí danh thầy đặt trong câu SQL)
                lblHoVaTen.Text = row["hoTen"].ToString();
                lblMSSV.Text = row["mssv"].ToString();
                lblSDT.Text = row["soDienThoai"].ToString();
                lblEmail.Text = row["email"].ToString();
                lblMaThe.Text = row["maNguoiMuon"].ToString();
                lblHocKy.Text = row["giaiDoanHoc"].ToString();
                lblTienCoc.Text = string.Format("{0:N0} VNĐ", row["soTienDatCoc"]);

                // Trạng thái (Giữ nguyên logic cũ)
                int trangThai = (row["trangThai"] == DBNull.Value) ? 0 : Convert.ToInt32(row["trangThai"]);

                if (trangThai == 1)
                {
                    lblTrangThai.Text = "Đã kích hoạt";
                    lblTrangThai.ForeColor = Color.Green;
                    btnGuiYeuCau.Visible = false;
                }
                else if (trangThai == 2)
                {
                    lblTrangThai.Text = "Đang chờ duyệt";
                    lblTrangThai.ForeColor = Color.DarkOrange;
                    btnGuiYeuCau.Visible = false;
                }
                else
                {
                    lblTrangThai.Text = "Chưa kích hoạt";
                    lblTrangThai.ForeColor = Color.Red;
                    btnGuiYeuCau.Visible = true;
                }
            }
        }

        private void btnGuiYeuCau_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn muốn gửi yêu cầu kích hoạt tài khoản?",
                                                  "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                bool thanhCong = bus.GuiYeuCauKichHoat(TaiKhoanSession.TaiKhoanHienTai);
                if (thanhCong)
                {
                    MessageBox.Show("Gửi yêu cầu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadThongTin(); // Tự động load lại màu sắc và ẩn nút
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
      
  
    }
}
