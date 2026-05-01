using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagerBUS;
namespace LibraryManagerGUI
{
    public partial class FrmChoMuonSach : Form
    {
        MuonTraBUS bus = new MuonTraBUS();
        string maGiaoDichHienTai = "";
        public FrmChoMuonSach()
        {
            InitializeComponent();
        }

        private void btnQuetThe_Click(object sender, EventArgs e)
        {
            //string maThe = txtMaThe.Text.Trim();
            //DataTable dtHeader = bus.GetRegistrationHeader(maThe);

            //if (dtHeader.Rows.Count > 0)
            //{
            //    DataRow r = dtHeader.Rows[0];
            //    maGiaoDichHienTai = r["maThongTinhMuonTraSach"].ToString();

            //    // Hiển thị thông tin lên giao diện
            //    lblHoTwnMaDocGia.Text = r["ten"].ToString(); // Nhãn em nên đặt tên cho dễ nhớ
            //    lblHanThe.Text = r["hanTra"].ToString();

            //    // Load danh sách sách đã đăng ký lên Grid
            //    //
            //    dgvDanhSachSachDaDangKy.DataSource = bus.GetRegistrationDetails(maGiaoDichHienTai);

            //    // Hiện số lượng
            //    lblSoLuongSachThucGiao.Text = dgvDanhSachSachDaDangKy.Rows.Count.ToString();
            //}
            //else
            //{
            //    MessageBox.Show("Thẻ này không có đơn đăng ký mượn nào đang chờ xử lý!", "Thông báo");
            //}
            try
            {
                string maThe = txtMaThe.Text.Trim();
                DataTable dtHeader = bus.GetRegistrationHeader(maThe);

                if (dtHeader != null && dtHeader.Rows.Count > 0)
                {
                    DataRow r = dtHeader.Rows[0];
                    // Lưu mã phiếu vào biến toàn cục
                    maGiaoDichHienTai = r["maThongTinhMuonTraSach"].ToString();

                    lblHoTwnMaDocGia.Text = r["ten"].ToString();
                    lblHanThe.Text = r["hanTra"].ToString();

                    // DÒNG BỊ LỖI: Ta bọc thêm kiểm tra dữ liệu
                    DataTable dtDetails = bus.GetRegistrationDetails(maGiaoDichHienTai);

                    if (dtDetails != null)
                    {
                        dgvDanhSachSachDaDangKy.DataSource = dtDetails;
                        lblSoLuongSachThucGiao.Text = dtDetails.Rows.Count.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Thẻ này không có đơn đăng ký mượn chờ xử lý!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                // HIỂN THỊ LỖI TẠI ĐÂY - Không để nó văng ra Form Đăng nhập
                MessageBox.Show("Lỗi thực thi dữ liệu: " + ex.Message, "Lỗi Nghiệp Vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXacNhanGiaoSach_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maGiaoDichHienTai)) return;

            // Thu thập danh sách mã bản sao từ Grid để cập nhật trạng thái
            List<string> dsMaBS = new List<string>();
            foreach (DataGridViewRow row in dgvDanhSachSachDaDangKy.Rows)
            {
                if (row.Cells["maBanSao"].Value != null)
                    dsMaBS.Add(row.Cells["maBanSao"].Value.ToString());
            }

            // Gọi BUS xử lý
            string res = bus.ConfirmLending(maGiaoDichHienTai, dsMaBS);

            if (res == "SUCCESS")
            {
                MessageBox.Show("Đã xác nhận giao sách thành công!", "Thành công");
                // Xóa trắng để làm lượt mới
                txtMaThe.Clear();
                dgvDanhSachSachDaDangKy.DataSource = null;
                maGiaoDichHienTai = "";
            }
            else { MessageBox.Show(res, "Lỗi"); }
        }
    }
}
