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

        private void LoadBaoCao()
        {
            try
            {
                // 1. Gọi BUS lấy DataTable từ SQL Server
                DataTable dtThongKe = bus.ThongKeTop10Sach();

                // 2. LUÔN LUÔN làm sạch DataSource cũ
                reportViewer1.LocalReport.DataSources.Clear();

                // 3. Đóng gói dữ liệu (KỂ CẢ KHI dtThongKe RỖNG, VẪN PHẢI BƠM VÀO)
                if (dtThongKe != null)
                {
                    // Tên "DataSet1" phải khớp y hệt file RDLC
                    ReportDataSource rds = new ReportDataSource("DataSet1", dtThongKe);

                    // 4. Cung cấp DataSource cho ReportViewer
                    reportViewer1.LocalReport.DataSources.Add(rds);

                    // 5. Làm mới và hiển thị
                    reportViewer1.RefreshReport();

                    // Xử lý thông báo UX cho người dùng nếu không có số liệu
                    if (dtThongKe.Rows.Count == 0)
                    {
                        MessageBox.Show("Hiện tại hệ thống chưa có dữ liệu sách mượn để thống kê!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmThongKeTopSach_Load(object sender, EventArgs e)
        {
            LoadBaoCao();
        }
    }
}
