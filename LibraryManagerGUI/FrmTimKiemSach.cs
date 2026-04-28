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
            DataTable dtSach = sachBus.GetDanhSachSachFrmTimKiem();
            dgvTimKiemSach.DataSource = dtSach;

            AutoCompleteStringCollection danhSachGoiY = new AutoCompleteStringCollection();

            // Duyệt qua từng dòng trong DataTable
            foreach (DataRow row in dtSach.Rows)
            {
                // 1. Nạp Tên Sách (Thử cả 2 trường hợp có dấu và không dấu để chắc chắn)
                AddGoiY(row, "Tên Sách", danhSachGoiY);
                AddGoiY(row, "TenSach", danhSachGoiY);

                // 2. Nạp Tác Giả
                AddGoiY(row, "Tác Giả", danhSachGoiY);
                AddGoiY(row, "TacGia", danhSachGoiY);

                // 3. Nạp Nhà Xuất Bản
                AddGoiY(row, "Nhà Xuất Bản", danhSachGoiY);
                AddGoiY(row, "NhaXuatBan", danhSachGoiY);
                AddGoiY(row, "NXB", danhSachGoiY); // Thử thêm cột NXB nếu có
            }

            txtTimSach.AutoCompleteCustomSource = danhSachGoiY;
            txtTimSach.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtTimSach.AutoCompleteSource = AutoCompleteSource.CustomSource;
            dgvTimKiemSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Hàm phụ trợ để tránh viết lặp code và kiểm tra cột tồn tại
        private void AddGoiY(DataRow row, string colName, AutoCompleteStringCollection collection)
        {
            // Kiểm tra xem DataTable có cột này không
            if (row.Table.Columns.Contains(colName))
            {
                string value = row[colName].ToString();
                if (!string.IsNullOrWhiteSpace(value) && !collection.Contains(value))
                {
                    collection.Add(value);
                }
            }
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
            string tuKhoa = txtTimSach.Text.Trim(); // Lấy từ khóa khách nhập
            SachBUS sachBus = new SachBUS();

            // Nếu để trống thì load lại toàn bộ
            if (string.IsNullOrEmpty(tuKhoa))
            {
                dgvTimKiemSach.DataSource = sachBus.GetDanhSachSachFrmTimKiem();
            }
            else
            {
                // Nếu có chữ thì gọi hàm tìm kiếm đa tiêu chí
                dgvTimKiemSach.DataSource = sachBus.TimKiemSachThongMinh(tuKhoa);
            }
        }

        private void btnMoFrmDangKyMuonSach_Click(object sender, EventArgs e)
        {
            FrmDangKyMuonSach formDangKyMuonSach = new FrmDangKyMuonSach();
            formDangKyMuonSach.ShowDialog(); 
        }

        private void txtTimSach_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvTimKiemSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
