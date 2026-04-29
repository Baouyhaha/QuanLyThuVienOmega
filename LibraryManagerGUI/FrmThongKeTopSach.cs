using LibraryManagerBUS;
using Microsoft.Reporting.WinForms;
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
    public partial class FrmThongKeTopSach : Form
    {
        private ThongKeBUS bus = new ThongKeBUS();
        public FrmThongKeTopSach()
        {
            InitializeComponent();
        }

        private void FrmThongKeTopSach_Load(object sender, EventArgs e)
        {

            LoadBaoCao();
        }
        private void LoadBaoCao()
        {
            try
            {
                // 1. Gọi BUS lấy dữ liệu (Mặc định lấy Top 10)
                DataTable dt = bus.GetTopSachHot(10);

                if (dt != null && dt.Rows.Count > 0)
                {
                    // 2. Clear cấu hình cũ của ReportViewer
                    rpTop10SP.LocalReport.DataSources.Clear();

                    // 3. Tạo DataSource mới. 
                    // LƯU Ý: Chữ "DataSet1" dưới đây phải KHỚP 100% với tên Dataset trong file .rdlc của em
                    ReportDataSource rds = new ReportDataSource("DataSet1", dt);

                    // 4. Trỏ đường dẫn tới file thiết kế rdlc
                    // Nhớ copy tên file rdlc của em vào đây
                    rpTop10SP.LocalReport.ReportPath = @"RptTopSach.rdlc";

                    rpTop10SP.LocalReport.DataSources.Add(rds);

                    // 5. Làm mới và hiển thị
                    rpTop10SP.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu mượn sách nào để thống kê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Tầng GUI bắt lỗi cuối cùng và hiển thị an toàn cho người dùng
                MessageBox.Show("Lỗi hiển thị báo cáo: \n" + ex.Message, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
