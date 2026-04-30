using LibraryManagerDTO;
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
using static Guna.UI2.Native.WinApi;

namespace LibraryManagerGUI
{
    public partial class FrmDangKyMuonSach : Form
    {
        public List<SachDTO> danhSachChon = new List<SachDTO>();
        string maDocGiaHienTai = TaiKhoanSession.MaNguoiMuonHienTai;
        NguoiMuonBUS busNguoiMuon = new NguoiMuonBUS();
        ThongTinMuonTraBUS thongTinMuonTraBUS = new ThongTinMuonTraBUS();

        public FrmDangKyMuonSach()
        {
            InitializeComponent();
        }


        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {

        }



        private void btnDangKyMuonSach_Click(object sender, EventArgs e)
        {
            if (FrmTimKiemSach.GioHang == null || FrmTimKiemSach.GioHang.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống!", "Cảnh báo");
                return;
            }

            // Tính tiền cọc an toàn
            long tongGiaTri = 0;
            foreach (DataRow row in FrmTimKiemSach.GioHang.Rows)
            {
                if (row["Giá Tiền"] != DBNull.Value)
                {
                    // Dùng TryParse cho chắc ăn 100%
                    long.TryParse(row["Giá Tiền"].ToString(), out long gia);
                    tongGiaTri += gia;
                }
            }
            int tienCoc = (int)(tongGiaTri * 0.2);

            try
            {
                // Gọi BUS (giữ nguyên đoạn này của em)
                bool ketQua = thongTinMuonTraBUS.ChotDonMuonSach(
                    TaiKhoanSession.MaNguoiMuonHienTai,
                    dtpHanTra.Value,
                    tienCoc,
                    FrmTimKiemSach.GioHang
                );

                if (ketQua)
                {
                    MessageBox.Show("Đăng ký thành công!", "Thông báo");
                    FrmTimKiemSach.GioHang.Clear();
                    this.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        

        private void lblTieuDe_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            // Sửa logic xóa từ ListBox sang DataGridView
            if (dgvSachMuon.CurrentRow != null && dgvSachMuon.CurrentRow.Index >= 0)
            {
                int index = dgvSachMuon.CurrentRow.Index;
                FrmTimKiemSach.GioHang.Rows.RemoveAt(index);

                // Tính lại tiền sau khi xóa một cuốn sách
                TinhTienCoc();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một cuốn sách trong danh sách để xóa!", "Thông báo");
            }
        }

        private void FrmDangKyMuonSach_Load(object sender, EventArgs e)
        {
            // 1. Thông tin cơ bản
            lblNgayMuon.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblMaDocGia.Text = TaiKhoanSession.MaNguoiMuonHienTai;

            // 2. Kiểm tra Thẻ
            DataTable dtThe = busNguoiMuon.LayThongTinThe(TaiKhoanSession.MaNguoiMuonHienTai);
            if (dtThe.Rows.Count > 0)
            {
                DataRow rowThe = dtThe.Rows[0];
                lblTenDocGia.Text = rowThe["hoTen"].ToString();
                int trangThaiThe = Convert.ToInt32(rowThe["trangThai"]);
                string ngayHetHan = rowThe["ngayHetHan"].ToString();

                if (trangThaiThe == 1) // Giả sử 1 là hết hạn
                {
                    lblTrangThaiThe.Text = $"Hết hạn ({ngayHetHan})";
                    lblTrangThaiThe.ForeColor = Color.Red;
                    btnDangKyMuonSach.Enabled = false;
                }
                else
                {
                    lblTrangThaiThe.Text = $"Hợp lệ (Hạn: {ngayHetHan})";
                    lblTrangThaiThe.ForeColor = Color.Green;
                    btnDangKyMuonSach.Enabled = true;
                }
            }

            // 3. Hiển thị sách đã chọn và Tính tiền
            dgvSachMuon.DataSource = FrmTimKiemSach.GioHang;



            // 1. Mở rộng MinDate và MaxDate để dọn đường
            // Đặt MinDate về một mốc an toàn trong quá khứ, MaxDate ra thật xa
            dtpHanTra.MinDate = new DateTime(2000, 1, 1);
            dtpHanTra.MaxDate = new DateTime(2100, 1, 1);

            // 2. Gán giá trị Value em mong muốn (cộng 14 ngày)
            DateTime ngayHienTai = DateTime.Now;
            dtpHanTra.Value = ngayHienTai.AddDays(14).Date;

            // 3. Bây giờ mới "siết" MinDate và MaxDate lại đúng giới hạn
            dtpHanTra.MinDate = ngayHienTai.AddDays(1).Date;
            dtpHanTra.MaxDate = ngayHienTai.AddDays(14).Date;
            TinhTienCoc();

        }
        private void TinhTienCoc()
        {
            long tongGiaTri = 0;
            if (FrmTimKiemSach.GioHang != null)
            {
                foreach (DataRow row in FrmTimKiemSach.GioHang.Rows)
                {
                    // Kiểm tra cột có tồn tại và không NULL
                    if (row.Table.Columns.Contains("Giá Tiền") && row["Giá Tiền"] != DBNull.Value)
                    {
                        // Vì ta đã nạp kiểu int sạch ở bước trên, nên chỉ cần ép kiểu là xong
                        tongGiaTri += Convert.ToInt64(row["Giá Tiền"]);
                    }
                }
            }

            double tienCoc = tongGiaTri * 0.2; //
            lblTongGiaTri.Text = $"Tổng giá gốc: {tongGiaTri:N0} VNĐ"; //
            lblTienCoc.Text = $"Tiền cọc (20%): {tienCoc:N0} VNĐ"; //
        }


        private void btnXoaToanBo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn hủy toàn bộ danh sách đăng ký không?",
                                                   "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (FrmTimKiemSach.GioHang != null)
                {
                    FrmTimKiemSach.GioHang.Clear();
                }

                if (danhSachChon != null)
                {
                    danhSachChon.Clear();
                }

                // Cập nhật lại số tiền về 0 trước khi đóng
                TinhTienCoc();
                this.Close();
            }
        }
    }
}
