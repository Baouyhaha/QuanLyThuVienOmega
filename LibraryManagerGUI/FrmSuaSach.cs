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
    public partial class FrmSuaSach : Form
    {
        private SachBUS sachBUS = new SachBUS();
        private TacGiaBUS tacGiaBUS = new TacGiaBUS();
        private NhaPhatHanhBUS nhaPhatHanhBUS = new NhaPhatHanhBUS();
        public FrmSuaSach(string maSach, string tenSach, string isbn, string nxb, string tacGia, int soLuong)
        {
            InitializeComponent();

            txtMaSach.Text = maSach;
            txtTenSach.Text = tenSach;
            txtIsbn.Text = isbn;
            cboNhaPhatHanh.Text = nxb;  // Gán text cho ComboBox
            numSoLuong.Value = soLuong; // Gán value cho NumericUpDown
            cboTacGia.Text = tacGia;
            cboNhaPhatHanh.SelectedIndex = cboNhaPhatHanh.FindStringExact(nxb);
            cboTacGia.SelectedIndex = cboTacGia.FindStringExact(tacGia);
            // 2. Khóa ô Mã Sách lại (Không cho phép người dùng sửa Khóa Chính)
            txtMaSach.ReadOnly = true;
            txtMaSach.BackColor = SystemColors.Control; // Đổi màu nền thành xám cho trực quan
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Thu thập dữ liệu từ các TextBox/ComboBox đã được người dùng chỉnh sửa
                // Chúng ta tạo một đối tượng DTO mới chứa thông tin mới nhất
                SachDTO sachSua = new SachDTO
                {
                    maSach = txtMaSach.Text.Trim(), // Mã sách không đổi (đã khóa)
                    tenSach = txtTenSach.Text.Trim(),
                    isbn = txtIsbn.Text.Trim(),
                    // Lấy ID của Nhà xuất bản từ ComboBox
                    maNhaPhatHanh = Convert.ToInt32(cboNhaPhatHanh.SelectedValue),
                    // Lấy giá trị số từ NumericUpDown
                    soLuongHienCo = Convert.ToInt32(numSoLuong.Value),
                    maTacGia = Convert.ToInt32(cboTacGia.SelectedValue)

                };

                // 2. Gọi tầng BUS để thực hiện kiểm tra và cập nhật

                bool result = sachBUS.SuaSachInfo(sachSua);

                // 3. Xử lý kết quả trả về
                if (result)
                {
                    MessageBox.Show("Cập nhật thông tin sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // QUAN TRỌNG: Gán DialogResult là OK để Form Chính biết là đã sửa thành công
                    this.DialogResult = DialogResult.OK;

                    // Đóng Form Sửa lại
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại, vui lòng kiểm tra lại dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Hiển thị các lỗi nghiệp vụ từ tầng BUS (ví dụ: Tên sách trống)
                MessageBox.Show("Lỗi: " + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmSuaSach_Load(object sender, EventArgs e)
        {
            // Nạp dữ liệu cho Nhà Phát Hành
            cboNhaPhatHanh.DataSource = nhaPhatHanhBUS.LayDanhSachNXB();
            cboNhaPhatHanh.DisplayMember = "tenNhaPhatHanh"; // Tên hiện ra
            cboNhaPhatHanh.ValueMember = "maNhaPhatHanh";    // Mã ẩn bên dưới

            // Nạp dữ liệu cho Tác Giả
            cboTacGia.DataSource = tacGiaBUS.LayDanhSachTacGia();
            cboTacGia.DisplayMember = "tenTacGia"; // Tên hiện ra
            cboTacGia.ValueMember = "maTacGia";    // Mã ẩn bên dưới
        }
        private void LoadDataComboBox()
        {
            // ComboBox Tác giả
            cboTacGia.DataSource = tacGiaBUS.LayDanhSachTacGia();
            cboTacGia.DisplayMember = "tenTacGia";
            cboTacGia.ValueMember = "maTacGia";
            cboTacGia.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTacGia.AutoCompleteSource = AutoCompleteSource.ListItems;

            // ComboBox Nhà Phát Hành
            cboNhaPhatHanh.DataSource = nhaPhatHanhBUS.LayDanhSachNXB();
            cboNhaPhatHanh.DisplayMember = "tenNhaPhatHanh";
            cboNhaPhatHanh.ValueMember = "maNhaPhatHanh";
            cboNhaPhatHanh.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboNhaPhatHanh.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
    }
}
