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

namespace LibraryManagerGUI
{
    public partial class FrmNhanTraSach : Form
    {
        MuonTraBUS bus = new MuonTraBUS();
        public FrmNhanTraSach()
        {
            InitializeComponent();
        }

        private void btnTimKiemSach_Click(object sender, EventArgs e)
        {
            string maThe = txtMaThe.Text.Trim();
            DataTable dt = bus.LaySachDangMuon(maThe);

            if (dt.Rows.Count > 0)
            {
                dgvNhanTraSach.DataSource = dt;
                // Lấy tên độc giả từ dòng đầu tiên của kết quả (vì join đã lấy được tên)
                // lblHoTenDocGiaHien.Text = ...
            }
            else
            {
                MessageBox.Show("Độc giả này hiện không giữ sách nào của thư viện.");
            }
        }

        private void dgvNhanTraSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhanTraSach.CurrentRow != null)
            {
                string hanTra = dgvNhanTraSach.CurrentRow.Cells["hanTra"].Value.ToString();
                int tienPhat = bus.TinhTienPhat(hanTra);
                lblHienTienPhat.Text = tienPhat.ToString("N0") + " VNĐ";
            }
        }

        private void btnNhanTra_Click(object sender, EventArgs e)
        {
            if (dgvNhanTraSach.CurrentRow == null) return;

            string maP = dgvNhanTraSach.CurrentRow.Cells["maThongTinhMuonTraSach"].Value.ToString();
            string maBS = dgvNhanTraSach.CurrentRow.Cells["maBanSao"].Value.ToString();
            int tienPhat = bus.TinhTienPhat(dgvNhanTraSach.CurrentRow.Cells["hanTra"].Value.ToString());

            if (bus.ThucHienTraSach(maP, maBS, tienPhat, "Trả sách tại quầy"))
            {
                MessageBox.Show("Trả sách thành công!");
                btnTimKiemSach.PerformClick(); // Load lại Grid
            }
        }
    }
}
