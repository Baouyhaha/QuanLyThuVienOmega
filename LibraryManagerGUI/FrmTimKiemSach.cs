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
    public partial class FrmTimKiemSach : Form
    {
        public static DataTable GioHang = new DataTable();
        SachBUS sachBus = new SachBUS();
        public FrmTimKiemSach()
        {
            InitializeComponent();
            if (GioHang.Columns.Count == 0)
            {
                GioHang.Columns.Add("Mã Sách");
                GioHang.Columns.Add("Tên Sách");
            }
        }

        private void FrmTimKiemSach_Load(object sender, EventArgs e)
        {
            SachBUS sachBus = new SachBUS();

            // Lấy dữ liệu (chỉ gồm 4 cột đã lọc sẵn từ SQL)
            dgvTimKiemSach.DataSource = sachBus.GetDanhSachSachFrmTimKiem();

            // Định dạng lại cột Giá cho dễ nhìn
            if (dgvTimKiemSach.Columns["Giá"] != null)
            {
                dgvTimKiemSach.Columns["Giá"].DefaultCellStyle.Format = "N0";
                dgvTimKiemSach.Columns["Giá"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            // Tự động giãn đều các cột
            dgvTimKiemSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvTimKiemSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // 2. Sự kiện Double Click vào DataGridView
            // Đảm bảo không click nhầm vào dòng tiêu đề (RowIndex = -1)
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ dòng vừa click
                string maSach = dgvTimKiemSach.Rows[e.RowIndex].Cells["Mã Sách"].Value.ToString();
                string tenSach = dgvTimKiemSach.Rows[e.RowIndex].Cells["Tên Sách"].Value.ToString();

                // Kiểm tra xem sách này đã có trong giỏ chưa (tránh add trùng 1 cuốn 2 lần)
                bool daTonTai = false;
                foreach (DataRow row in GioHang.Rows)
                {
                    if (row["Mã Sách"].ToString() == maSach)
                    {
                        daTonTai = true;
                        break;
                    }
                }

                if (!daTonTai)
                {
                    // Thêm vào giỏ hàng tạm
                    GioHang.Rows.Add(maSach, tenSach);
                    MessageBox.Show($"Đã thêm '{tenSach}' vào giỏ đăng ký mượn!", "Thành công");
                }
                else
                {
                    MessageBox.Show("Sách này đã có trong giỏ của bạn rồi!", "Thông báo");
                }
            }
        }

        private void btnTimSach_Click(object sender, EventArgs e)
        {

        }

        private void btnMoFrmDangKyMuonSach_Click(object sender, EventArgs e)
        {
            FrmGioSachDangKy formGioSachDangKy = new FrmGioSachDangKy();
            formGioSachDangKy.ShowDialog(); 
        }

        private void txtTimSach_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimSach.Text.Trim(); // Lấy chữ người dùng vừa gõ

            SachBUS sachBus = new SachBUS();

            // Nếu ô tìm kiếm trống thì load lại toàn bộ sách
            if (string.IsNullOrEmpty(tuKhoa))
            {
                dgvTimKiemSach.DataSource = sachBus.GetDanhSachSachFrmTimKiem();
            }
            else
            {
                // Nếu có chữ thì gọi hàm tìm kiếm thông minh
                dgvTimKiemSach.DataSource = sachBus.TimKiemSachThongMinh(tuKhoa);
            }

            // Nhớ gọi lại đoạn code ẩn cột Mã sách đi nhé
            if (dgvTimKiemSach.Columns.Contains("Mã Sách"))
            {
                dgvTimKiemSach.Columns["Mã Sách"].Visible = false;
            }
        }
    }
    
}
