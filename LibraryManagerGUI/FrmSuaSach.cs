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
    public partial class FrmSuaSach : Form
    {
        string maSachSua;
        private SachBUS sachBUS = new SachBUS();
        private TacGiaBUS tgBUS = new TacGiaBUS();
        private NhaPhatHanhBUS nphBUS = new NhaPhatHanhBUS();
        public FrmSuaSach(string maSach)
        {
            InitializeComponent();
            this.maSachSua = maSach;
        }
        private List<int> LayDanhSachMaTacGia()
        {
            List<int> dsMa = new List<int>();
            // Giả sử tên CheckedListBox của em là clbTacGia hoặc lstTacGiaChon
            // Ở đây thầy dùng theo ảnh của em là danh sách các tác giả đã chọn
            foreach (var item in lstTacGiaChon.Items)
            {
                // item có dạng: "1 - Phạm Hữu Khang"
                string s = item.ToString();
                // Tách lấy phần trước dấu "-"
                string maStr = s.Split('-')[0].Trim();
                dsMa.Add(int.Parse(maStr));
            }
            return dsMa;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FrmSuaSach_Load(object sender, EventArgs e)
        {
            // BƯỚC 1: Thiết lập cấu trúc Grid và nạp các danh sách lựa chọn
            SetupGrid(); // Hàm tạo cột cho dgvBanSao
            LoadAllNhaPhatHanh(); // Nạp tất cả NXB vào cboNXB
            LoadAllTacGia(); // Nạp tất cả Tác giả vào cboTacGia (để chọn thêm nếu cần)

            // BƯỚC 2: Lấy dữ liệu của cuốn sách cần sửa dựa vào maSachSua
            // 2.1. Đổ thông tin cơ bản (Tên, ISBN, NXB)
            DataTable dtSach = sachBUS.LayThongTinChiTiet(maSachSua);
            if (dtSach.Rows.Count > 0)
            {
                DataRow r = dtSach.Rows[0];
                txtTenSach.Text = r["tenSach"].ToString();
                txtISBN.Text = r["isbn"].ToString();
                numSoLuong.Value = Convert.ToInt32(r["soLuongHienCo"]);

                // CHÚ Ý: Dòng này giúp ComboBox tự nhảy đến đúng NXB của sách
                cboNXB.SelectedValue = r["maNhaPhatHanh"];
            }

            // 2.2. Đổ danh sách tác giả đã có của sách vào ListBox
            DataTable dtTG = sachBUS.LayDSTacGiaCuaSach(maSachSua);
            lstTacGiaChon.Items.Clear();
            foreach (DataRow r in dtTG.Rows)
            {
                lstTacGiaChon.Items.Add(r["maTacGia"].ToString() + " - " + r["tenTacGia"].ToString());
            }

            // 2.3. Đổ danh sách bản sao vào Grid
            DataTable dtBS = sachBUS.LayDSBanSaoCuaSach(maSachSua);
            dgvBanSao.Rows.Clear();
            foreach (DataRow r in dtBS.Rows)
            {
                // Chuyển đổi số 1, 2 từ DB sang chữ để hiện lên ComboBox trong Grid
                string loaiStr = r["loaiBanSao"].ToString() == "2" ? "Mượn về" : "Tại chỗ";
                dgvBanSao.Rows.Add(r["banSaoSach"], loaiStr, r["gia"]);
            }
        }
        // Hàm nạp tất cả Nhà xuất bản vào ComboBox
        private void LoadAllNhaPhatHanh()
        {
            // Gọi BUS để lấy toàn bộ danh sách NXB
            DataTable dt = nphBUS.LayDanhSachNXB();
            cboNXB.DataSource = dt;
            cboNXB.DisplayMember = "tenNhaPhatHanh"; // Tên hiển thị
            cboNXB.ValueMember = "maNhaPhatHanh";     // Giá trị ẩn (ID)
        }

        // Hàm nạp tất cả Tác giả vào ComboBox (để thủ thư chọn thêm nếu muốn)
        private void LoadAllTacGia()
        {
            // Gọi BUS để lấy toàn bộ danh sách Tác giả
            DataTable dt = tgBUS.LayDanhSachTacGia();
            cboTacGia.DataSource = dt;
            cboTacGia.DisplayMember = "tenTacGia";
            cboTacGia.ValueMember = "maTacGia";

            cboTacGia.SelectedIndex = -1; // Để mặc định là không chọn ai
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // 1. Gom DTO Sách
            SachDTO sach = new SachDTO
            {
                maSach = maSachSua,
                tenSach = txtTenSach.Text.Trim(),
                maNhaPhatHanh = (int)cboNXB.SelectedValue,
                isbn = txtISBN.Text.Trim(),
                soLuongHienCo = (int)numSoLuong.Value
            };

            // 2. Tách ID tác giả từ chuỗi "ID - Tên"
            List<int> dsMaTG = new List<int>();
            foreach (var item in lstTacGiaChon.Items)
                dsMaTG.Add(int.Parse(item.ToString().Split('-')[0].Trim()));

            // 3. Gom danh sách bản sao từ Grid
            List<BanSaoSachDTO> dsBS = new List<BanSaoSachDTO>();
            foreach (DataGridViewRow row in dgvBanSao.Rows)
            {
                if (row.Cells["colMaBS"].Value == null) continue;
                string mabs = row.Cells["colMaBS"].Value.ToString();
                dsBS.Add(new BanSaoSachDTO
                {
                    banSaoSach = mabs,
                    maSach = maSachSua,
                    soThuTu = int.Parse(mabs.Split('-')[1]),
                    loaiBanSao = row.Cells["colLoai"].Value.ToString() == "Mượn về" ? 2 : 1,
                    gia = Convert.ToInt32(row.Cells["colGia"].Value)
                });
            }

            // 4. Lưu
            if (sachBUS.CapNhatToanBoSach(sach, dsMaTG, dsBS))
            {
                MessageBox.Show("Cập nhật thành công!");
                this.Close();
            }
        }
        private void SetupGrid()
        {
            dgvBanSao.Columns.Clear();
            dgvBanSao.ColumnHeadersVisible = true;
            dgvBanSao.ColumnHeadersHeight = 35; // Bắt buộc để hiện tiêu đề

            dgvBanSao.Columns.Add("colMaBS", "Mã Bản Sao");

            DataGridViewComboBoxColumn colLoai = new DataGridViewComboBoxColumn();
            colLoai.HeaderText = "Loại";
            colLoai.Name = "colLoai";
            colLoai.Items.Add("Mượn về");
            colLoai.Items.Add("Tại chỗ");
            dgvBanSao.Columns.Add(colLoai);

            dgvBanSao.Columns.Add("colGia", "Giá");

            // Khử lỗi "Value is not valid" của DataGridView
            dgvBanSao.DataError += (s, e) => { e.ThrowException = false; };
        }
        private void LoadDataOld()
        {
            // Đổ thông tin sách
            DataTable dtSach = sachBUS.LayThongTinChiTiet(maSachSua);
            if (dtSach.Rows.Count > 0)
            {
                DataRow r = dtSach.Rows[0];
                txtTenSach.Text = r["tenSach"].ToString();
                txtISBN.Text = r["isbn"].ToString();
                numSoLuong.Value = Convert.ToInt32(r["soLuongHienCo"]);
                cboNXB.SelectedValue = r["maNhaPhatHanh"];
            }

            // Đổ danh sách tác giả vào ListBox
            DataTable dtTG = sachBUS.LayDSTacGiaCuaSach(maSachSua);
            lstTacGiaChon.Items.Clear();
            foreach (DataRow r in dtTG.Rows)
                lstTacGiaChon.Items.Add(r["maTacGia"] + " - " + r["tenTacGia"]);

            // Đổ danh sách bản sao vào Grid
            DataTable dtBS = sachBUS.LayDSBanSaoCuaSach(maSachSua);
            foreach (DataRow r in dtBS.Rows)
                dgvBanSao.Rows.Add(r["banSaoSach"], r["loaiBanSao"].ToString() == "2" ? "Mượn về" : "Tại chỗ", r["gia"]);
        }

        private void btnThemTacGia_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem người dùng đã chọn tác giả nào ở ComboBox chưa
            if (cboTacGia.SelectedValue == null || cboTacGia.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một tác giả từ danh sách!");
                return;
            }

            // 2. Lấy thông tin từ ComboBox
            string ma = cboTacGia.SelectedValue.ToString();
            string ten = cboTacGia.Text;
            string itemThem = ma + " - " + ten;

            // 3. Kiểm tra trùng lặp: Nếu tác giả này đã có trong ListBox thì không thêm nữa
            if (lstTacGiaChon.Items.Contains(itemThem))
            {
                MessageBox.Show("Tác giả này đã có trong danh sách chọn!");
                return;
            }

            // 4. Thêm vào ListBox
            lstTacGiaChon.Items.Add(itemThem);
        }
    }
}
