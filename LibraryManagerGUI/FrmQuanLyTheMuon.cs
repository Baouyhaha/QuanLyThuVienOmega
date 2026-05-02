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
    public partial class FrmQuanLyTheMuon : Form
    {
        TheMuonBUS bus = new TheMuonBUS();
        bool isViewingPending = false;
        public FrmQuanLyTheMuon()
        {
            InitializeComponent();

        }

        private void FrmQuanLyTheMuon_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {

            if (isViewingPending)
            {
                dgvTheMuon.DataSource = bus.GetDanhSachChoDuyet();
                // Thay đổi Header nếu cần
                //dgvTheMuon.DataSource = bus.GetAll();
                // Tùy chỉnh tiêu đề cột cho đẹp
                //dgvTheMuon.Columns["maTheMuon"].HeaderText = "Mã Thẻ";
                //dgvTheMuon.Columns["HoTen"].HeaderText = "Họ Tên Độc Giả";
                //dgvTheMuon.Columns["ngayHetHan"].HeaderText = "Ngày Hết Hạn";
            }
            else
            {
                dgvTheMuon.DataSource = bus.GetAll();
            }
        }

        private void btnMoFrmThemThe_Click(object sender, EventArgs e)
        {
            FrmPhatHanhThe frm = new FrmPhatHanhThe(); // Thay bằng tên Form phát hành của em
            frm.ShowDialog();
            LoadData(); // Load lại sau khi thêm
        }

        private void btnMoFrmSuaThe_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTheMuon.SelectedRows.Count > 0)
                {
                    string maSelected = dgvTheMuon.SelectedRows[0].Cells["maTheMuon"].Value.ToString();
                    FrmCapNhatThongTinThe frm = new FrmCapNhatThongTinThe(maSelected);
                    frm.ShowDialog();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở form sửa: " + ex.Message, "Lỗi Hệ Thống");
            }
        }
        
        private void btnXoaThe_Click(object sender, EventArgs e)
        {
            if (dgvTheMuon.SelectedRows.Count > 0)
            {
                string ma = dgvTheMuon.SelectedRows[0].Cells["maTheMuon"].Value.ToString();
                if (MessageBox.Show("Bạn có chắc muốn xóa thẻ này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bus.DeleteCard(ma)) LoadData();
                }
            }
        }

        private void txtTimSach_TextChanged(object sender, EventArgs e)
        {
            dgvTheMuon.DataSource = bus.Search(txtTimKiem.Text.Trim());
        }

        private void dgvTheMuon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra đúng cột Ngày hết hạn và giá trị không được null
            if (dgvTheMuon.Columns[e.ColumnIndex].Name == "ngayHetHan" && e.Value != null && e.Value != DBNull.Value)
            {
                DateTime date;
                string dateString = e.Value.ToString();

                // Sử dụng TryParseExact để ép kiểu theo đúng định dạng dd/MM/yyyy đã thiết kế
                if (DateTime.TryParseExact(dateString, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out date))
                {
                    // Nếu ngày hết hạn nhỏ hơn ngày hiện tại (đã hết hạn)
                    if (date < DateTime.Now)
                    {
                        e.CellStyle.ForeColor = Color.Red; // Đổi màu chữ sang đỏ để cảnh báo
                        e.CellStyle.Font = new Font(dgvTheMuon.Font, FontStyle.Bold); // In đậm
                    }
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            LoadData();
        }

        private void cmbLocTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLocTrangThai.SelectedIndex == 1) // Chờ kích hoạt
            {
                dgvTheMuon.DataSource = bus.GetDanhSachChoDuyet(); // Hàm lấy nguoimuon có trangThai = 0
            }
            else
            {
                LoadData(); // Load danh sách thẻ mượn bình thường
            }
        }

        private void btnLocChoDuyet_Click(object sender, EventArgs e)
        {
            isViewingPending = !isViewingPending;
            btnLocChoDuyet.Text = isViewingPending ? "Xem tất cả thẻ" : "Xem yêu cầu chờ duyệt";
            LoadData();
        }

        private void dgvTheMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isViewingPending && e.RowIndex >= 0)
            {
                string maNM = dgvTheMuon.Rows[e.RowIndex].Cells["maNguoiMuon"].Value.ToString();
                string ten = dgvTheMuon.Rows[e.RowIndex].Cells["hoTen"].Value.ToString();

                if (MessageBox.Show($"Duyệt cấp thẻ cho: {ten}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bus.DuyetCapThe(maNM))
                    {
                        MessageBox.Show("Cấp thẻ thành công!");
                        LoadData();
                    }
                }
            }
        }
    }
}
