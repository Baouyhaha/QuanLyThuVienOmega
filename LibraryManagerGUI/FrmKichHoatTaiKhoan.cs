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
    public partial class FrmKichHoatTaiKhoan : Form
    {
        private TheMuonBUS bus = new TheMuonBUS();
        public FrmKichHoatTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnKichHoat_Click(object sender, EventArgs e)
        {
            string tk = txtTenTaiKhoan.Text.Trim();
            string ma = txtMaKichHoat.Text.Trim();

            // Đẩy xuống tầng BUS
            string ketQua = bus.KichHoatTaiKhoan(tk, ma);

            if (ketQua == "SUCCESS")
            {
                MessageBox.Show("Kích hoạt thẻ thành công! Bạn có thể sử dụng các dịch vụ của thư viện ngay bây giờ.",
                                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Đóng form kích hoạt
            }
            else
            {
                MessageBox.Show(ketQua, "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
