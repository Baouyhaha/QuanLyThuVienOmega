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
    public partial class FrmPhatHanhThe : Form
    {
        private TheMuonBUS theMuonBUS = new TheMuonBUS();
        public FrmPhatHanhThe()
        {
            InitializeComponent();
            radSinhVien.Checked = true;
        }

        private void radSinhVien_CheckedChanged(object sender, EventArgs e)
        {
            if (radSinhVien.Checked)
            {
                txtMSSV.Enabled = true;
                txtTienCoc.Enabled = false;
                txtTienCoc.Text = "0"; // Sinh viên không cần cọc
            }
        }

        private void radKhach_CheckedChanged(object sender, EventArgs e)
        {
            if (radKhach.Checked)
            {
                txtMSSV.Enabled = false;
                txtMSSV.Text = ""; // Khách không có MSSV
                txtTienCoc.Enabled = true;
            }
        }

        private void btnCapThe_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ giao diện
            string tenTaiKhoan = txtTenTaiKhoan.Text.Trim();
            bool laSinhVien = radSinhVien.Checked;
            string mssv = txtMSSV.Text.Trim();
            string tienCoc = txtTienCoc.Text.Trim();

            // Gọi BUS xử lý
            string ketQua = theMuonBUS.PhatHanhThe(tenTaiKhoan, laSinhVien, mssv, tienCoc);

            // Xử lý thông báo trả về
            if (ketQua == "SUCCESS")
            {
                MessageBox.Show("Phát hành thẻ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Có thể code thêm hàm ResetForm() để xóa trắng các ô nhập liệu sau khi lưu thành công
            }
            else
            {
                MessageBox.Show(ketQua, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
