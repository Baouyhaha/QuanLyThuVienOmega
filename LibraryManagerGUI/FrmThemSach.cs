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
using LibraryManagerBUS;
namespace LibraryManagerGUI

{
    public partial class FrmThemSach : Form
    {
        private SachBUS sachBUS = new SachBUS();
        NhaPhatHanhBUS nphBUS = new NhaPhatHanhBUS();
        //private TacGiaBUS tacGiaBUS = new TacGiaBUS();
        TacGiaBUS tgBUS = new TacGiaBUS();

        public FrmThemSach()
        {
            InitializeComponent();

        }
        private List<int> LayDanhSachMaTacGia()
        {
            List<int> dsMa = new List<int>();
            foreach (var item in lstTacGiaChon.Items)
            {
                // item có dạng "1 - Phạm Hữu Khang"
                // Tách chuỗi tại dấu "-" và lấy phần tử đầu tiên (chính là mã)
                string maStr = item.ToString().Split('-')[0].Trim();
                dsMa.Add(int.Parse(maStr));
            }
            return dsMa;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // --- BƯỚC 1: KIỂM TRA DỮ LIỆU ĐẦU VÀO (VALIDATION) ---
                if (string.IsNullOrWhiteSpace(txtTenSach.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên sách!"); return;
                }
                if (lstTacGiaChon.Items.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một tác giả!"); return;
                }
                if (string.IsNullOrWhiteSpace(cboNXB.Text))
                {
                    MessageBox.Show("Vui lòng chọn hoặc nhập Nhà xuất bản!"); return;
                }

                // --- BƯỚC 2: XỬ LÝ NHÀ XUẤT BẢN (THÔNG MINH) ---
                // Lấy mã NXB hiện có hoặc tự động tạo mới nếu thủ thư gõ tên mới
                int maNXB = nphBUS.LayHoacTaoMaNXB(cboNXB.Text);

                // --- BƯỚC 3: ĐÓNG GÓI DỮ LIỆU SÁCH (SachDTO) ---
                SachDTO sach = new SachDTO
                {
                    maSach = txtMaSach.Text, // Mã đã sinh tự động lúc mở Form
                    tenSach = txtTenSach.Text.Trim(),
                    maNhaPhatHanh = maNXB,
                    isbn = txtISBN.Text.Trim(),
                    soLuongHienCo = (int)numSoLuong.Value
                };

                // --- BƯỚC 4: GOM DANH SÁCH TÁC GIẢ ---
                List<int> dsMaTG = LayDanhSachMaTacGia();

                // --- BƯỚC 5: GOM DANH SÁCH BẢN SAO TỪ DATAGRIDVIEW ---
                List<BanSaoSachDTO> dsBanSao = new List<BanSaoSachDTO>();
                foreach (DataGridViewRow row in dgvBanSao.Rows)
                {
                    if (row.IsNewRow) continue; // Bỏ qua dòng trống cuối cùng của Grid

                    BanSaoSachDTO bs = new BanSaoSachDTO
                    {
                        banSaoSach = row.Cells["colMaBS"].Value.ToString(),
                        maSach = sach.maSach,
                        // Tách số thứ tự từ mã bản sao (VD: S001-05 -> lấy 5)
                        soThuTu = int.Parse(row.Cells["colMaBS"].Value.ToString().Split('-')[1]),
                        // Chuyển đổi tên loại sang số (1: Đọc tại chỗ, 2: Mượn về)
                        loaiBanSao = row.Cells["colLoai"].Value.ToString() == "Mượn về" ? 2 : 1,
                        gia = Convert.ToInt32(row.Cells["colGia"].Value),
                        trangThai = 0, // 0: Có sẵn
                        xoa = 0        // 0: Chưa xóa
                    };
                    dsBanSao.Add(bs);
                }

                // --- BƯỚC 6: GỌI LỚP BUS ĐỂ LƯU (CÓ TRANSACTION) ---
                bool ketQua = sachBUS.LuuPhieuNhapSach(sach, dsMaTG, dsBanSao);

                if (ketQua)
                {
                    MessageBox.Show("Thêm sách và bản sao thành công!");
                    this.Close(); // Đóng form sau khi hoàn tất
                }
                else
                {
                    MessageBox.Show("Lỗi hệ thống! Không thể lưu dữ liệu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra: " + ex.Message);
            }
        }

        // Tùy chọn: Nút Hủy / Thoát
        private void btnHuy_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.Cancel;
            //this.Close();
        }

        private void LoadDataToCombobox()
        {
            // Lấy danh sách NXB từ BUS
            DataTable dtNXB = nphBUS.LayDanhSachNXB();
            cboNXB.DataSource = dtNXB;
            cboNXB.DisplayMember = "tenNhaPhatHanh";
            cboNXB.ValueMember = "maNhaPhatHanh";

            // Bật tính năng gợi ý
            cboNXB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboNXB.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void FrmThemSach_Load(object sender, EventArgs e)
        {
            txtMaSach.Text = sachBUS.SinhMaSachTuDong(); // Mã mặc định S004
            LoadDataToCombobox(); // Nạp NXB
            LoadTacGia();         // Nạp Tác giả (đã sửa dùng BUS)
            SetupGridBanSao();    // Khởi tạo các cột cho Grid
        }
        private void numSoLuong_ValueChanged(object sender, EventArgs e)
        {
            // 1. Lấy mã sách hiện tại từ ô txtMaSach (ví dụ: S001)
            string ms = txtMaSach.Text;
            if (string.IsNullOrEmpty(ms)) return;

            // 2. Lấy số lượng từ numSoLuong
            int soLuong = (int)numSoLuong.Value;

            // 3. Xóa dữ liệu cũ trong Grid để nạp lại từ đầu (tránh trùng lặp)
            dgvBanSao.Rows.Clear();

            // 4. Lấy số thứ tự lớn nhất hiện tại từ database thông qua BUS
            // (Giả sử sách S001 đã có 2 cuốn, thì cuốn mới phải bắt đầu từ STT 3)
            int sttHienTai = sachBUS.LaySoThuTuLonNhat(ms);

            for (int i = 1; i <= soLuong; i++)
            {
                int sttMoi = sttHienTai + i;
                // Sinh mã bản sao theo quy tắc: S001-01, S001-02...
                string maBS = ms + "-" + sttMoi.ToString("D2");

                // Thêm một dòng mới vào Grid
                // Giả sử Grid có các cột: Mã bản sao, Loại (ComboBox), Giá, Trạng thái
                dgvBanSao.Rows.Add(maBS, "Mượn về", 50000, "Có sẵn");
            }
        }

        private void btnThemTacGia_Click(object sender, EventArgs e)
        {
            if (cboTacGia.SelectedValue == null) return;

            string ma = cboTacGia.SelectedValue.ToString();
            string ten = cboTacGia.Text;

            // Kiểm tra trùng: Nếu tác giả này đã có trong ListBox thì không thêm nữa
            foreach (var item in lstTacGiaChon.Items)
            {
                if (item.ToString().StartsWith(ma + " -")) return;
            }
            // Thêm định dạng: "Mã - Tên" để sau này dễ tách mã khi Lưu [cite: 329]
            lstTacGiaChon.Items.Add(ma + " - " + ten);
        }
        private void LoadTacGia()
        {
            // KHÔNG gọi TacGiaDAL nữa. Thay vào đó, gọi tgBUS
            DataTable dt = tgBUS.LayDanhSachTacGia();

            cboTacGia.DataSource = dt;
            cboTacGia.DisplayMember = "tenTacGia"; // Phải khớp với tên cột trong DB 
            cboTacGia.ValueMember = "maTacGia";

            cboTacGia.SelectedIndex = -1;
        }
        private void SetupGridBanSao()
        {
            dgvBanSao.Columns.Clear();
            dgvBanSao.AutoGenerateColumns = false;

            // --- SỬA LỖI MẤT TIÊU ĐỀ (DÀNH CHO GUNA) ---
            dgvBanSao.ColumnHeadersVisible = true;
            dgvBanSao.ColumnHeadersHeight = 35; // Bắt buộc phải có số này tiêu đề mới hiện
            dgvBanSao.ThemeStyle.HeaderStyle.Height = 35;

            // 1. Cột Mã bản sao
            dgvBanSao.Columns.Add("colMaBS", "Mã Bản Sao");
            dgvBanSao.Columns["colMaBS"].ReadOnly = true;

            // 2. Cột Loại bản sao (SỬA LỖI VALUE NOT VALID)
            DataGridViewComboBoxColumn colLoai = new DataGridViewComboBoxColumn();
            colLoai.HeaderText = "Loại";
            colLoai.Name = "colLoai";
            colLoai.Items.Clear(); // Xóa sạch để tránh rác dữ liệu
            colLoai.Items.Add("Mượn về"); // Ghi nhớ chính xác chữ này
            colLoai.Items.Add("Tại chỗ");
            dgvBanSao.Columns.Add(colLoai);

            // 3. Cột Giá
            dgvBanSao.Columns.Add("colGia", "Giá");

            // 4. Cột Trạng thái
            dgvBanSao.Columns.Add("colTrangThai", "Trạng thái");
            dgvBanSao.Columns["colTrangThai"].ReadOnly = true;
        }

        private void btnThemTG_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtTenTG_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
