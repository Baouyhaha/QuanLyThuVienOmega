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
            if (GioHang == null)
            {
                GioHang = new DataTable();
            }
            GioHang.Columns.Clear(); // Xóa sạch cột cũ nếu có
            GioHang.Columns.Add("Mã Sách");
            GioHang.Columns.Add("Tên Sách");
            GioHang.Columns.Add("Giá Tiền", typeof(int));
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

                // 1. KIỂM TRA CHẾ ĐỘ (Ngăn sinh viên click khi chưa tìm kiếm)
                // Vì lúc mới Load form không có giá tiền, nên bắt buộc phải tìm kiếm mới cho mượn
                if (!dgvTimKiemSach.Columns.Contains("loaiBanSao") || !dgvTimKiemSach.Columns.Contains("gia"))
                {
                    MessageBox.Show("Vui lòng gõ tên sách và nhấn nút 'TÌM KIẾM' trước khi chọn để hệ thống tính giá tiền cọc!", "Hướng dẫn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // Dừng lại, không chạy code bên dưới nữa
                }

                // 2. LẤY DỮ LIỆU AN TOÀN BẰNG TÊN CỘT (Thay vì dùng số 3, 4)
                int.TryParse(row.Cells["loaiBanSao"].Value?.ToString(), out int loaiBS);
                int.TryParse(row.Cells["trangThai"].Value?.ToString(), out int tThai);

                // 3. HÀNG RÀO CHẶN SÁCH
                if (loaiBS != 2)
                {
                    MessageBox.Show("Sách này chỉ được đọc tại chỗ, không cho mượn về!", "Thông báo");
                    return;
                }

                if (tThai != 0)
                {
                    MessageBox.Show("Sách này hiện đã có người mượn hoặc chưa sẵn sàng!", "Thông báo");
                    return;
                }

                // 4. LẤY GIÁ VÀ MÃ (An toàn không văng lỗi)
                string giaGoc = row.Cells["gia"].Value?.ToString() ?? "0";
                string cleanGia = System.Text.RegularExpressions.Regex.Replace(giaGoc, @"[^\d]", "");
                int.TryParse(cleanGia, out int giaTriTien);

                string maChon = row.Cells["maSach"].Value?.ToString() ?? "";
                string tenChon = row.Cells["tenSach"].Value?.ToString() ?? "";

                // 5. KIỂM TRA TRÙNG VÀ NẠP VÀO GIỎ HÀNG
                foreach (DataRow r in GioHang.Rows)
                {
                    if (r["Mã Sách"].ToString() == maChon)
                    {
                        MessageBox.Show("Sách này đã có trong giỏ hàng rồi nhé!");
                        return;
                    }
                }

                // Thêm chuẩn 3 cột: Mã, Tên, Giá (int)
                GioHang.Rows.Add(maChon, tenChon, giaTriTien);
                MessageBox.Show($"Đã thêm '{tenChon}' vào giỏ hàng thành công!");
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
