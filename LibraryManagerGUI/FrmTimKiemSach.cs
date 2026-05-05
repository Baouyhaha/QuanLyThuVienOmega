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
    public partial class FrmTimKiemSach : Form
    {

        public static DataTable GioHang = new DataTable();

        // 2. MỚI: TẠO STATIC CONSTRUCTOR (Hàm khởi tạo tĩnh - Không có chữ public)
        // Hàm này sẽ tự động chạy 1 lần duy nhất ngay khi phần mềm vừa nhắc đến FrmTimKiemSach
        static FrmTimKiemSach()
        {
            GioHang.Columns.Add("Mã Sách", typeof(string));
            GioHang.Columns.Add("Tên Sách", typeof(string));
            GioHang.Columns.Add("Giá Tiền", typeof(long)); 
        }

        SachBUS sachBus = new SachBUS();

        public FrmTimKiemSach()
        {
            InitializeComponent();
           
        }
       
        private void FrmTimKiemSach_Load(object sender, EventArgs e)
        {
            SachBUS sachBus = new SachBUS();
            DataTable dtSach = sachBus.GetDanhSachSachFrmTimKiem    (); // Gọi hàm đã cập nhật ở DAL
            dgvTimKiemSach.DataSource = dtSach;
            AutoCompleteStringCollection danhSachGoiY = new AutoCompleteStringCollection();

            foreach (DataRow row in dtSach.Rows)
            {
                // 0. Nạp Mã Sách (Để thủ thư gõ mã là ra luôn)
                AddGoiY(row, "maSach", danhSachGoiY);

                // 1. Nạp Tên Sách
                AddGoiY(row, "tenSach", danhSachGoiY);

                // 2. Nạp Tác Giả (Phải khớp với tên AS "TacGia" trong SQL trên)
                AddGoiY(row, "TacGia", danhSachGoiY);

                // 3. Nạp Nhà Xuất Bản
                AddGoiY(row, "tenNhaPhatHanh", danhSachGoiY);
            }

            txtTimSach.AutoCompleteCustomSource = danhSachGoiY;
            txtTimSach.AutoCompleteMode = AutoCompleteMode.SuggestAppend; // Dùng SuggestAppend nhìn sẽ xịn hơn
            txtTimSach.AutoCompleteSource = AutoCompleteSource.CustomSource;

            dgvTimKiemSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        // Hàm phụ trợ để tránh viết lặp code và kiểm tra cột tồn tại
        private void AddGoiY(DataRow row, string colName, AutoCompleteStringCollection collection)
        {
            if (row.Table.Columns.Contains(colName))
            {
                string value = row[colName].ToString();
                // Kiểm tra không rỗng và chưa tồn tại trong danh sách thì mới thêm
                if (!string.IsNullOrWhiteSpace(value) && !collection.Contains(value))
                {
                    collection.Add(value);
                }
            }
        }

        private void dgvTimKiemSach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            // Tránh click vào tiêu đề cột
            if (e.RowIndex < 0) return;

            // =================================================================
            // 🚧 TRẠM KIỂM SOÁT TỪ VÒNG NHẤN ĐÚP
            // =================================================================
            try
            {
                NguoiMuonBUS busNguoiMuon = new NguoiMuonBUS();
                string maNguoiMuon = TaiKhoanSession.MaNguoiMuonHienTai;

                // Bổ sung: Ép cứng mã nếu đang test nhảy cóc
                if (string.IsNullOrEmpty(maNguoiMuon)) maNguoiMuon = "NM0001";

                DataTable dtThe = busNguoiMuon.LayThongTinThe(maNguoiMuon);

                // 1. Nếu không tìm thấy thẻ nào -> Chưa có thẻ
                if (dtThe == null || dtThe.Rows.Count == 0)
                {
                    MessageBox.Show("Bạn chưa có thẻ thư viện!\nVui lòng đăng ký cấp thẻ trước khi mượn sách.",
                                    "Từ chối phục vụ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return; // Đuổi về
                }

                // 2. Nếu có thẻ -> Kiểm tra xem hết hạn chưa (1 là hết hạn)
                int trangThaiThe = Convert.ToInt32(dtThe.Rows[0]["trangThai"]);
                if (trangThaiThe == 1)
                {
                    MessageBox.Show($"Thẻ thư viện của bạn đã hết hạn!\nVui lòng gia hạn thẻ để tiếp tục mượn sách.",
                                    "Thẻ hết hạn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Đuổi về
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kiểm tra thẻ: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // =================================================================

            // 1. Lấy thông tin đầu sách từ dòng được chọn
            string maSach = dgvTimKiemSach.Rows[e.RowIndex].Cells["maSach"].Value.ToString();
            string tenSach = dgvTimKiemSach.Rows[e.RowIndex].Cells["tenSach"].Value.ToString();

            // 2. Gọi BUS để hệ thống tự động tìm bản sao "ngon" nhất
            string maBanSaoTimDuoc = sachBus.TimBanSaoDeMuon(maSach);

            if (!string.IsNullOrEmpty(maBanSaoTimDuoc))
            {
                DialogResult dr = MessageBox.Show(
                    $"Đầu sách: {tenSach}\n" +
                    $"Hệ thống đã chọn bản sao: {maBanSaoTimDuoc}\n\n" +
                    $"Bạn có muốn thêm cuốn này vào danh sách đăng ký mượn không?",
                    "Xác nhận chọn sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        // Kiểm tra trùng lặp trong giỏ
                        foreach (DataRow row in GioHang.Rows)
                        {
                            if (row["Mã Sách"].ToString() == maBanSaoTimDuoc)
                            {
                                MessageBox.Show($"Bản sao {maBanSaoTimDuoc} này đã có trong giỏ hàng rồi!\nVui lòng chọn cuốn khác.",
                                                "Cảnh báo trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }

                        // Lấy giá tiền và thêm vào giỏ
                        long gia = sachBus.LayGiaTienCuaBanSao(maBanSaoTimDuoc);
                        GioHang.Rows.Add(maBanSaoTimDuoc, tenSach, gia);

                        MessageBox.Show($"Đã thêm cuốn {maBanSaoTimDuoc} (Giá: {gia:N0}đ) vào giỏ!\nHiện trong giỏ đang có {GioHang.Rows.Count} cuốn.",
                                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi thêm sách vào giỏ: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Hết sách
                MessageBox.Show(
                    $"Rất tiếc! Đầu sách '{tenSach}' hiện tại không còn bản sao nào có sẵn để mượn.\n\n" +
                    "Lý do: Sách đã bị mượn hết, đã có người đăng ký, hoặc chỉ còn bản sao đọc tại chỗ.",
                    "Thông báo hết sách", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
    


        public void LoadDuLieuTimKiem()
        {
            // 1. GUI gọi BUS để lấy DataTable
            DataTable dt = sachBus.LayTatCaSach();

            // 2. GUI thực hiện đổi Số -> Chữ (như thầy chỉ ở trên)
            foreach (DataRow row in dt.Rows) { /* code đổi 0, 1 thành chữ */ }

            // 3. GUI đổ vào Grid hiển thị
            dgvTimKiemSach.DataSource = dt;
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

        private void dgvTimKiemSach_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra để tránh lỗi khi Grid rỗng
            if (e.RowIndex < 0 || e.Value == null) return;

            // 1. Format cột Loại Bản Sao (Giả sử cột này tên là "loaiBanSao")
            if (dgvTimKiemSach.Columns[e.ColumnIndex].Name == "loaiBanSao")
            {
                if (e.Value.ToString() == "1") e.Value = "Đọc tại chỗ";
                else if (e.Value.ToString() == "2") e.Value = "Mượn về nhà";

                e.FormattingApplied = true; // Báo cho Grid biết "tôi đã format xong rồi"
            }

            // 2. Format cột Trạng Thái (Giả sử cột này tên là "trangThai")
            if (dgvTimKiemSach.Columns[e.ColumnIndex].Name == "trangThai")
            {
                if (e.Value.ToString() == "0") e.Value = "Sẵn sàng";
                else if (e.Value.ToString() == "1") e.Value = "Đang mượn";
                else if (e.Value.ToString() == "2") e.Value = "Đã đăng ký";

                e.FormattingApplied = true;
            }
        }

        private void txtTimSach_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
