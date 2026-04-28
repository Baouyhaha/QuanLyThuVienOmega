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
    public partial class FrmQuanLyTheMuon : Form
    {
        TheMuonBUS bus = new TheMuonBUS();
        public FrmQuanLyTheMuon()
        {
            InitializeComponent();
        }

        private void FrmQuanLyTheMuon_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            dgvTheMuon.DataSource = bus.GetAll();
            // Tùy chỉnh tiêu đề cột cho đẹp
            dgvTheMuon.Columns["maTheMuon"].HeaderText = "Mã Thẻ";
            dgvTheMuon.Columns["HoTen"].HeaderText = "Họ Tên Độc Giả";
            dgvTheMuon.Columns["ngayHetHan"].HeaderText = "Ngày Hết Hạn";
        }

        private void btnMoFrmThemThe_Click(object sender, EventArgs e)
        {
            FrmPhatHanhThe frm = new FrmPhatHanhThe(); // Thay bằng tên Form phát hành của em
            frm.ShowDialog();
            LoadData(); // Load lại sau khi thêm
        }

        private void btnMoFrmSuaThe_Click(object sender, EventArgs e)
        {
            if (dgvTheMuon.SelectedRows.Count > 0)
            {
                string maSelected = dgvTheMuon.SelectedRows[0].Cells["maTheMuon"].Value.ToString();
                // Truyền mã thẻ sang Form cập nhật
                FrmCapNhatThongTinThe frm = new FrmCapNhatThongTinThe(maSelected);
                frm.ShowDialog();
                LoadData();
            }
        }

        private void btnXoaThe_Click(object sender, EventArgs e)
        {
            if (dgvTheMuon.SelectedRows.Count > 0)
            {
                string ma = dgvTheMuon.SelectedRows[0].Cells["maTheMuon"].Value.ToString();
                if (MessageBox.Show("Bạn có chắc muốn xóa thẻ này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (bus.DeleteCard(ma)) LoadData();
                }
            }
        }

        private void txtTimSach_TextChanged(object sender, EventArgs e)
        {
            dgvTheMuon.DataSource = bus.Search(txtTimKiem.Text.Trim());
        }

        private void dgvTheMuon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvTheMuon.Columns[e.ColumnIndex].Name == "ngayHetHan")
            {
                DateTime date = Convert.ToDateTime(e.Value);
                if (date < DateTime.Now)
                {
                    e.CellStyle.ForeColor = Color.Red;
                    e.CellStyle.Font = new Font(dgvTheMuon.Font, FontStyle.Bold);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            LoadData();
        }
    }
}
