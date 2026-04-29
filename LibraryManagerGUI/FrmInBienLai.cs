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
    public partial class FrmInBienLai : Form
    {
        private BienLaiBUS bus = new BienLaiBUS();

        // Nhận tham số từ form khác truyền sang
        private string maPhieuMuon;
        private string maBanSaoSach;

        public FrmInBienLai(string maPhieu, string maBanSao)
        {
            InitializeComponent();
            this.maPhieuMuon = maPhieu;
            this.maBanSaoSach = maBanSao;
        }

        private void FrmInBienLai_Load(object sender, EventArgs e)
        {

            try
            {
                DataTable dt = bus.GetDuLieuBienLai(maPhieuMuon, maBanSaoSach);

                if (dt != null && dt.Rows.Count > 0)
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    // Nhớ đặt tên "DataSet1" khớp với tên trong file rdlc của em
                    ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                    reportViewer1.LocalReport.ReportPath = @"RptBienLai.rdlc";
                    reportViewer1.LocalReport.DataSources.Add(rds);
                    reportViewer1.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin biên lai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form nếu không có dữ liệu
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị biên lai: \n" + ex.Message, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
