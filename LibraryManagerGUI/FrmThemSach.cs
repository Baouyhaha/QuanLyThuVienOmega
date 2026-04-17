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
    public partial class FrmThemSach : Form
    {
        private SachBUS sachBUS = new SachBUS();
        private TacGiaBUS tacGiaBUS = new TacGiaBUS();
        private NhaPhatHanhBUS nxbBUS = new NhaPhatHanhBUS();

        public FrmThemSach()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Gom dữ liệu từ các ô nhập liệu
                SachDTO sachMoi = new SachDTO
                {
                    maSach = txtMaSach.Text.Trim(),
                    tenSach = txtTenSach.Text.Trim(),
                    maNhaPhatHanh = Convert.ToInt32(cboNhaPhatHanh.SelectedValue),
                    isbn = txtIsbn.Text.Trim(),
                    // Lấy giá trị từ NumericUpDown thay vì TextBox
                    soLuongHienCo = Convert.ToInt32(numSoLuong.Value),
                    maTacGia = Convert.ToInt32(cboTacGia.SelectedValue)
                };

                // 2. Gọi BUS để xử lý
                bool ketQua = sachBUS.ThemSachMoi(sachMoi);

                // 3. Xử lý kết quả
                if (ketQua)
                {
                    MessageBox.Show("Thêm sách mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // BÁO TÍN HIỆU THÀNH CÔNG VỀ CHO FORM CHÍNH
                    this.DialogResult = DialogResult.OK;

                    // Đóng Form nhập liệu lại
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm sách thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng kiểm tra lại định dạng số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Tùy chọn: Nút Hủy / Thoát
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FrmThemSach_Load(object sender, EventArgs e)
        {
            try
            {
                // ==========================================
                // --- 1. LOAD COMBOBOX TÁC GIẢ  ---
                // ==========================================
                cboTacGia.DataSource = tacGiaBUS.LayDanhSachTacGia();
                cboTacGia.DisplayMember = "tenTacGia";
                cboTacGia.ValueMember = "maTacGia";

                // ==========================================
                // --- 2. LOAD COMBOBOX NHÀ PHÁT HÀNH ---
                // ==========================================
                cboNhaPhatHanh.DataSource = nxbBUS.LayDanhSachNXB();
                cboNhaPhatHanh.DisplayMember = "tenNhaPhatHanh"; // Tên để hiển thị (Chữ)
                cboNhaPhatHanh.ValueMember = "maNhaPhatHanh";    // Mã để ngầm lưu DB (Số)


                // ==========================================
                // 3. BẬT TÍNH NĂNG TÌM KIẾM THÔNG MINH
                // ==========================================
                cboTacGia.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cboTacGia.AutoCompleteSource = AutoCompleteSource.ListItems;
                cboNhaPhatHanh.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cboNhaPhatHanh.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }
    }

}
