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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                // Gọi thử DAL để test kết nối
                LibraryManagerDAL.DbHelper db = new LibraryManagerDAL.DbHelper();
                using (var conn = db.getConnection())
                {
                    conn.Open();
                    MessageBox.Show("Kết nối Database thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //string user = txtTenTaiKhoan.Text;
            //string pass = txtMatKhau.Text;

            //LibraryManagerBUS.TaiKhoanBUS bus = new LibraryManagerBUS.TaiKhoanBUS();
            //string result = bus.login(user, pass, out string role, out int status);

            //if (result == "Success")
            //{
            //    MessageBox.Show($"Đăng nhập thành công với quyền {role}!");
            //    this.Hide();
            //    // Mở MainForm và truyền thông tin phân quyền
            //    FrmMain main = new FrmMain(role, status);
            //    main.Show();
            //}
            //else
            //{
            //    MessageBox.Show(result);
            //}
        }

        private void btnKhach_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //// Vào MainForm với quyền Guest [cite: 171, 218]
            //FrmMain main = new FrmMain("Guest", 0);
            //main.Show();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FrmSignIn formKy = new FrmSignIn();
            formKy.Show();
            this.Hide();
        }
    }
}
