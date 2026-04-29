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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTimKiemSach.Rows[e.RowIndex];
                string ma = dgvTimKiemSach.Columns.Contains("maSach") ? row.Cells["maSach"].Value.ToString() : row.Cells["Mã Sách"].Value.ToString();
                string ten = dgvTimKiemSach.Columns.Contains("tenSach") ? row.Cells["tenSach"].Value.ToString() : row.Cells["Tên Sách"].Value.ToString();

                // --- KHÚC NÀY LÀ QUAN TRỌNG NHẤT ---
                int soLuongDuocMuon = sachBus.KiemTraKhaNangMuon(ma);

                if (soLuongDuocMuon <= 0)
                {
                    MessageBox.Show($"Xin lỗi, cuốn '{ten}' hiện không còn bản sao nào có sẵn để mượn về nhà. " +
                                    "\n(Có thể sách đang bị mượn hết hoặc chỉ còn bản đọc tại chỗ)",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Chặn lại, không cho add vào giỏ hàng
                }

                // Nếu còn sách thì tiến hành kiểm tra trùng và thêm vào GioHang như cũ
                bool daCo = false;
                foreach (DataRow dr in GioHang.Rows)
                {
                    if (dr["Mã Sách"].ToString() == ma) { daCo = true; break; }
                }

                if (!daCo)
                {
                    GioHang.Rows.Add(ma, ten);
                    MessageBox.Show($"Đã thêm '{ten}' vào giỏ đăng ký mượn!", "Thành công");
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
       
    }
    
}
