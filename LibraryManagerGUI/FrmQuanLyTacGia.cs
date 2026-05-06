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
using LibraryManagerDTO;

namespace LibraryManagerGUI
{
    public partial class FrmQuanLyTacGia : Form
    {
        private TacGiaBUS tgBUS = new TacGiaBUS();
        public FrmQuanLyTacGia()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                dgvTacGia.DataSource = tgBUS.LayDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmQuanLyTacGia_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTacGia.Rows[e.RowIndex];
                txtMaTacGia.Text = row.Cells["Mã Tác Giả"].Value.ToString();
                txtTenTacGia.Text = row.Cells["Tên Tác Giả"].Value.ToString();

                // Khi sửa hoặc xóa thì không cho phép sửa lại Mã tác giả (Khóa chính)
                txtMaTacGia.ReadOnly = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int ma;
                if (!int.TryParse(txtMaTacGia.Text.Trim(), out ma))
                {
                    MessageBox.Show("Mã tác giả phải là một số nguyên hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                TacGiaDTO tg = new TacGiaDTO
                {
                    MaTacGia = ma,
                    TenTacGia = txtTenTacGia.Text.Trim()
                };

                if (tgBUS.Them(tg))
                {
                    MessageBox.Show("Thêm tác giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Nhập Liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaTacGia.Text))
                {
                    MessageBox.Show("Vui lòng chọn tác giả cần sửa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                TacGiaDTO tg = new TacGiaDTO
                {
                    MaTacGia = int.Parse(txtMaTacGia.Text),
                    TenTacGia = txtTenTacGia.Text.Trim()
                };

                if (tgBUS.Sua(tg))
                {
                    MessageBox.Show("Cập nhật thông tin tác giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaTacGia.Text))
                {
                    MessageBox.Show("Vui lòng chọn tác giả cần xóa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int maXoa = int.Parse(txtMaTacGia.Text);

                DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa tác giả có mã {maXoa} không?",
                                                  "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (tgBUS.Xoa(maXoa))
                    {
                        MessageBox.Show("Xóa tác giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ClearFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void ClearFields()
        {
            txtMaTacGia.Text = "";
            txtTenTacGia.Text = "";
            txtMaTacGia.ReadOnly = false; // Mở lại quyền nhập mã cho lần thêm mới sau
        }
    }
}
