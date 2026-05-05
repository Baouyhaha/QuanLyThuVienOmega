namespace LibraryManagerGUI
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSubMenu_ChucNang = new System.Windows.Forms.FlowLayoutPanel();
            this.btnChucNang = new Guna.UI2.WinForms.Guna2Button();
            this.btnXemThongTinSach = new Guna.UI2.WinForms.Guna2Button();
            this.btnDangKyDocTaiCho = new Guna.UI2.WinForms.Guna2Button();
            this.btnDKMuonSach = new Guna.UI2.WinForms.Guna2Button();
            this.btnDKTheMuon = new Guna.UI2.WinForms.Guna2Button();
            this.btnTTChoMuonSach = new Guna.UI2.WinForms.Guna2Button();
            this.btnTTQuanLyTaiKhoan = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuanLyDKSach = new Guna.UI2.WinForms.Guna2Button();
            this.btnTTQuanLyTacGIa = new Guna.UI2.WinForms.Guna2Button();
            this.btnTTQuanLySach = new Guna.UI2.WinForms.Guna2Button();
            this.btnTTQuanLyBanSaoSach = new Guna.UI2.WinForms.Guna2Button();
            this.btnTTNhanTraSach = new Guna.UI2.WinForms.Guna2Button();
            this.btnTTQuanLyPhieuDocTaiCho = new Guna.UI2.WinForms.Guna2Button();
            this.btnThongKeTopSach = new Guna.UI2.WinForms.Guna2Button();
            this.btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.btnCaiDat = new Guna.UI2.WinForms.Guna2Button();
            this.btnThongTin = new Guna.UI2.WinForms.Guna2Button();
            this.timerMenuChucNang = new System.Windows.Forms.Timer(this.components);
            this.panelDesktop = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblXinChao = new System.Windows.Forms.Label();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.timerSidebar = new System.Windows.Forms.Timer(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnThongTinNguoiDung = new Guna.UI2.WinForms.Guna2Button();
            this.panelSidebar.SuspendLayout();
            this.panelSubMenu_ChucNang.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.AutoScroll = true;
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.panelSidebar.Controls.Add(this.panelSubMenu_ChucNang);
            this.panelSidebar.Controls.Add(this.btnDangXuat);
            this.panelSidebar.Controls.Add(this.btnCaiDat);
            this.panelSidebar.Controls.Add(this.btnThongTin);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 53);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(235, 685);
            this.panelSidebar.TabIndex = 1;
            // 
            // panelSubMenu_ChucNang
            // 
            this.panelSubMenu_ChucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.panelSubMenu_ChucNang.Controls.Add(this.btnChucNang);
            this.panelSubMenu_ChucNang.Controls.Add(this.btnThongTinNguoiDung);
            this.panelSubMenu_ChucNang.Controls.Add(this.btnXemThongTinSach);
            this.panelSubMenu_ChucNang.Controls.Add(this.btnDangKyDocTaiCho);
            this.panelSubMenu_ChucNang.Controls.Add(this.btnDKMuonSach);
            this.panelSubMenu_ChucNang.Controls.Add(this.btnDKTheMuon);
            this.panelSubMenu_ChucNang.Controls.Add(this.btnTTChoMuonSach);
            this.panelSubMenu_ChucNang.Controls.Add(this.btnTTQuanLyTaiKhoan);
            this.panelSubMenu_ChucNang.Controls.Add(this.btnQuanLyDKSach);
            this.panelSubMenu_ChucNang.Controls.Add(this.btnTTQuanLyTacGIa);
            this.panelSubMenu_ChucNang.Controls.Add(this.btnTTQuanLySach);
            this.panelSubMenu_ChucNang.Controls.Add(this.btnTTQuanLyBanSaoSach);
            this.panelSubMenu_ChucNang.Controls.Add(this.btnTTNhanTraSach);
            this.panelSubMenu_ChucNang.Controls.Add(this.btnTTQuanLyPhieuDocTaiCho);
            this.panelSubMenu_ChucNang.Controls.Add(this.btnThongKeTopSach);
            this.panelSubMenu_ChucNang.Location = new System.Drawing.Point(3, 2);
            this.panelSubMenu_ChucNang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSubMenu_ChucNang.Name = "panelSubMenu_ChucNang";
            this.panelSubMenu_ChucNang.Size = new System.Drawing.Size(232, 66);
            this.panelSubMenu_ChucNang.TabIndex = 8;
            // 
            // btnChucNang
            // 
            this.btnChucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnChucNang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChucNang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChucNang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChucNang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChucNang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnChucNang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChucNang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnChucNang.Image = ((System.Drawing.Image)(resources.GetObject("btnChucNang.Image")));
            this.btnChucNang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnChucNang.Location = new System.Drawing.Point(3, 2);
            this.btnChucNang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChucNang.Name = "btnChucNang";
            this.btnChucNang.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnChucNang.Size = new System.Drawing.Size(229, 66);
            this.btnChucNang.TabIndex = 3;
            this.btnChucNang.Text = "Chức Năng";
            this.btnChucNang.Click += new System.EventHandler(this.btnChucNang_Click);
            // 
            // btnXemThongTinSach
            // 
            this.btnXemThongTinSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnXemThongTinSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXemThongTinSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXemThongTinSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXemThongTinSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXemThongTinSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnXemThongTinSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXemThongTinSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnXemThongTinSach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXemThongTinSach.Location = new System.Drawing.Point(3, 122);
            this.btnXemThongTinSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXemThongTinSach.Name = "btnXemThongTinSach";
            this.btnXemThongTinSach.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnXemThongTinSach.Size = new System.Drawing.Size(201, 46);
            this.btnXemThongTinSach.TabIndex = 19;
            this.btnXemThongTinSach.Text = "tìm kiếm và xem sách";
            this.btnXemThongTinSach.Click += new System.EventHandler(this.btnXemThongTinSach_Click);
            // 
            // btnDangKyDocTaiCho
            // 
            this.btnDangKyDocTaiCho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnDangKyDocTaiCho.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKyDocTaiCho.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKyDocTaiCho.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangKyDocTaiCho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangKyDocTaiCho.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnDangKyDocTaiCho.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDangKyDocTaiCho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnDangKyDocTaiCho.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangKyDocTaiCho.Location = new System.Drawing.Point(3, 172);
            this.btnDangKyDocTaiCho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangKyDocTaiCho.Name = "btnDangKyDocTaiCho";
            this.btnDangKyDocTaiCho.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDangKyDocTaiCho.Size = new System.Drawing.Size(201, 46);
            this.btnDangKyDocTaiCho.TabIndex = 20;
            this.btnDangKyDocTaiCho.Text = "Đăng ký đọc tại chỗ";
            this.btnDangKyDocTaiCho.Click += new System.EventHandler(this.btnDangKyDocTaiCho_Click);
            // 
            // btnDKMuonSach
            // 
            this.btnDKMuonSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnDKMuonSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDKMuonSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDKMuonSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDKMuonSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDKMuonSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnDKMuonSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDKMuonSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnDKMuonSach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDKMuonSach.Location = new System.Drawing.Point(3, 222);
            this.btnDKMuonSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDKMuonSach.Name = "btnDKMuonSach";
            this.btnDKMuonSach.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDKMuonSach.Size = new System.Drawing.Size(201, 46);
            this.btnDKMuonSach.TabIndex = 21;
            this.btnDKMuonSach.Text = "Đăng ký mượn sách";
            this.btnDKMuonSach.Click += new System.EventHandler(this.btnDKMuonSach_Click);
            // 
            // btnDKTheMuon
            // 
            this.btnDKTheMuon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnDKTheMuon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDKTheMuon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDKTheMuon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDKTheMuon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDKTheMuon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnDKTheMuon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDKTheMuon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnDKTheMuon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDKTheMuon.Location = new System.Drawing.Point(3, 272);
            this.btnDKTheMuon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDKTheMuon.Name = "btnDKTheMuon";
            this.btnDKTheMuon.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDKTheMuon.Size = new System.Drawing.Size(201, 46);
            this.btnDKTheMuon.TabIndex = 22;
            this.btnDKTheMuon.Text = "Đăng Ký thẻ mượn(Chưa update)";
            this.btnDKTheMuon.Click += new System.EventHandler(this.btnDangKyTheMuon_Click);
            // 
            // btnTTChoMuonSach
            // 
            this.btnTTChoMuonSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnTTChoMuonSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTTChoMuonSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTTChoMuonSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTTChoMuonSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTTChoMuonSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnTTChoMuonSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTTChoMuonSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnTTChoMuonSach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTTChoMuonSach.Location = new System.Drawing.Point(3, 322);
            this.btnTTChoMuonSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTTChoMuonSach.Name = "btnTTChoMuonSach";
            this.btnTTChoMuonSach.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTTChoMuonSach.Size = new System.Drawing.Size(201, 46);
            this.btnTTChoMuonSach.TabIndex = 27;
            this.btnTTChoMuonSach.Text = "Cho mượn sách";
            this.btnTTChoMuonSach.Click += new System.EventHandler(this.btnTTChoMuonSach_Click);
            // 
            // btnTTQuanLyTaiKhoan
            // 
            this.btnTTQuanLyTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnTTQuanLyTaiKhoan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTTQuanLyTaiKhoan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTTQuanLyTaiKhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTTQuanLyTaiKhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTTQuanLyTaiKhoan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnTTQuanLyTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTTQuanLyTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnTTQuanLyTaiKhoan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTTQuanLyTaiKhoan.Location = new System.Drawing.Point(3, 372);
            this.btnTTQuanLyTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTTQuanLyTaiKhoan.Name = "btnTTQuanLyTaiKhoan";
            this.btnTTQuanLyTaiKhoan.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTTQuanLyTaiKhoan.Size = new System.Drawing.Size(201, 46);
            this.btnTTQuanLyTaiKhoan.TabIndex = 31;
            this.btnTTQuanLyTaiKhoan.Text = "Quản Lý Tài Khoản";
            this.btnTTQuanLyTaiKhoan.Click += new System.EventHandler(this.btnTTQuanLyTaiKhoan_Click);
            // 
            // btnQuanLyDKSach
            // 
            this.btnQuanLyDKSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnQuanLyDKSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLyDKSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLyDKSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuanLyDKSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuanLyDKSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnQuanLyDKSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQuanLyDKSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnQuanLyDKSach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQuanLyDKSach.Location = new System.Drawing.Point(3, 422);
            this.btnQuanLyDKSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuanLyDKSach.Name = "btnQuanLyDKSach";
            this.btnQuanLyDKSach.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnQuanLyDKSach.Size = new System.Drawing.Size(201, 46);
            this.btnQuanLyDKSach.TabIndex = 30;
            this.btnQuanLyDKSach.Text = "Quản lý dăng ký sách";
            this.btnQuanLyDKSach.Click += new System.EventHandler(this.btnQuanLyDKSach_Click);
            // 
            // btnTTQuanLyTacGIa
            // 
            this.btnTTQuanLyTacGIa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnTTQuanLyTacGIa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTTQuanLyTacGIa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTTQuanLyTacGIa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTTQuanLyTacGIa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTTQuanLyTacGIa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnTTQuanLyTacGIa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTTQuanLyTacGIa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnTTQuanLyTacGIa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTTQuanLyTacGIa.Location = new System.Drawing.Point(3, 472);
            this.btnTTQuanLyTacGIa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTTQuanLyTacGIa.Name = "btnTTQuanLyTacGIa";
            this.btnTTQuanLyTacGIa.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTTQuanLyTacGIa.Size = new System.Drawing.Size(201, 46);
            this.btnTTQuanLyTacGIa.TabIndex = 32;
            this.btnTTQuanLyTacGIa.Text = "Quản lý tác giả";
            this.btnTTQuanLyTacGIa.Click += new System.EventHandler(this.btnTTQuanLyTacGIa_Click);
            // 
            // btnTTQuanLySach
            // 
            this.btnTTQuanLySach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnTTQuanLySach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTTQuanLySach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTTQuanLySach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTTQuanLySach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTTQuanLySach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnTTQuanLySach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTTQuanLySach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnTTQuanLySach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTTQuanLySach.Location = new System.Drawing.Point(3, 522);
            this.btnTTQuanLySach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTTQuanLySach.Name = "btnTTQuanLySach";
            this.btnTTQuanLySach.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTTQuanLySach.Size = new System.Drawing.Size(201, 46);
            this.btnTTQuanLySach.TabIndex = 29;
            this.btnTTQuanLySach.Text = "Quản Lý Sách";
            this.btnTTQuanLySach.Click += new System.EventHandler(this.btnTTQuanLySach_Click);
            // 
            // btnTTQuanLyBanSaoSach
            // 
            this.btnTTQuanLyBanSaoSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnTTQuanLyBanSaoSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTTQuanLyBanSaoSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTTQuanLyBanSaoSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTTQuanLyBanSaoSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTTQuanLyBanSaoSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnTTQuanLyBanSaoSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTTQuanLyBanSaoSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnTTQuanLyBanSaoSach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTTQuanLyBanSaoSach.Location = new System.Drawing.Point(3, 572);
            this.btnTTQuanLyBanSaoSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTTQuanLyBanSaoSach.Name = "btnTTQuanLyBanSaoSach";
            this.btnTTQuanLyBanSaoSach.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTTQuanLyBanSaoSach.Size = new System.Drawing.Size(201, 46);
            this.btnTTQuanLyBanSaoSach.TabIndex = 33;
            this.btnTTQuanLyBanSaoSach.Text = "Quản lý bản sao sách";
            this.btnTTQuanLyBanSaoSach.Click += new System.EventHandler(this.btnTTQuanLyBanSaoSach_Click);
            // 
            // btnTTNhanTraSach
            // 
            this.btnTTNhanTraSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnTTNhanTraSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTTNhanTraSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTTNhanTraSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTTNhanTraSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTTNhanTraSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnTTNhanTraSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTTNhanTraSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnTTNhanTraSach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTTNhanTraSach.Location = new System.Drawing.Point(3, 622);
            this.btnTTNhanTraSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTTNhanTraSach.Name = "btnTTNhanTraSach";
            this.btnTTNhanTraSach.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTTNhanTraSach.Size = new System.Drawing.Size(201, 46);
            this.btnTTNhanTraSach.TabIndex = 28;
            this.btnTTNhanTraSach.Text = "Nhận Trả Sách";
            this.btnTTNhanTraSach.Click += new System.EventHandler(this.btnTTNhanTraSach_Click);
            // 
            // btnTTQuanLyPhieuDocTaiCho
            // 
            this.btnTTQuanLyPhieuDocTaiCho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnTTQuanLyPhieuDocTaiCho.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTTQuanLyPhieuDocTaiCho.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTTQuanLyPhieuDocTaiCho.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTTQuanLyPhieuDocTaiCho.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTTQuanLyPhieuDocTaiCho.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnTTQuanLyPhieuDocTaiCho.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTTQuanLyPhieuDocTaiCho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnTTQuanLyPhieuDocTaiCho.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTTQuanLyPhieuDocTaiCho.Location = new System.Drawing.Point(3, 672);
            this.btnTTQuanLyPhieuDocTaiCho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTTQuanLyPhieuDocTaiCho.Name = "btnTTQuanLyPhieuDocTaiCho";
            this.btnTTQuanLyPhieuDocTaiCho.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTTQuanLyPhieuDocTaiCho.Size = new System.Drawing.Size(201, 46);
            this.btnTTQuanLyPhieuDocTaiCho.TabIndex = 34;
            this.btnTTQuanLyPhieuDocTaiCho.Text = "Quản Lý phiếu đọc tại chỗ";
            this.btnTTQuanLyPhieuDocTaiCho.Click += new System.EventHandler(this.btnTTQuanLyPhieuDocTaiCho_Click);
            // 
            // btnThongKeTopSach
            // 
            this.btnThongKeTopSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnThongKeTopSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKeTopSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongKeTopSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongKeTopSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongKeTopSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnThongKeTopSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThongKeTopSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnThongKeTopSach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThongKeTopSach.Location = new System.Drawing.Point(3, 722);
            this.btnThongKeTopSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongKeTopSach.Name = "btnThongKeTopSach";
            this.btnThongKeTopSach.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnThongKeTopSach.Size = new System.Drawing.Size(201, 46);
            this.btnThongKeTopSach.TabIndex = 35;
            this.btnThongKeTopSach.Text = "thống kê sách mượn nhiều nhất";
            this.btnThongKeTopSach.Click += new System.EventHandler(this.btnThongKeTopSach_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnDangXuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangXuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangXuat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDangXuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangXuat.Location = new System.Drawing.Point(3, 72);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(232, 66);
            this.btnDangXuat.TabIndex = 5;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnCaiDat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCaiDat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCaiDat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCaiDat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCaiDat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnCaiDat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCaiDat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnCaiDat.Image = ((System.Drawing.Image)(resources.GetObject("btnCaiDat.Image")));
            this.btnCaiDat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCaiDat.Location = new System.Drawing.Point(3, 142);
            this.btnCaiDat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Size = new System.Drawing.Size(232, 66);
            this.btnCaiDat.TabIndex = 7;
            this.btnCaiDat.Text = "Cài đặt";
            // 
            // btnThongTin
            // 
            this.btnThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnThongTin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongTin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongTin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongTin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongTin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnThongTin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnThongTin.Image = ((System.Drawing.Image)(resources.GetObject("btnThongTin.Image")));
            this.btnThongTin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThongTin.Location = new System.Drawing.Point(3, 212);
            this.btnThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(232, 66);
            this.btnThongTin.TabIndex = 6;
            this.btnThongTin.Text = "Thông tin";
            // 
            // timerMenuChucNang
            // 
            this.timerMenuChucNang.Interval = 10;
            this.timerMenuChucNang.Tick += new System.EventHandler(this.timerMenuChucNang_Tick);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(235, 53);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(832, 685);
            this.panelDesktop.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(85, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ỨNG DỤNG QUẢN LÝ THƯ VIỆN";
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(933, 12);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox3.TabIndex = 4;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(869, 12);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox1.TabIndex = 3;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(803, 12);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(94)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.guna2ControlBox2);
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Controls.Add(this.guna2ControlBox3);
            this.panel1.Controls.Add(this.lblXinChao);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBoxMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 53);
            this.panel1.TabIndex = 0;
            // 
            // lblXinChao
            // 
            this.lblXinChao.AutoSize = true;
            this.lblXinChao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.lblXinChao.Location = new System.Drawing.Point(396, 18);
            this.lblXinChao.Name = "lblXinChao";
            this.lblXinChao.Size = new System.Drawing.Size(110, 16);
            this.lblXinChao.TabIndex = 2;
            this.lblXinChao.Text = "Đây là tittle vai trò";
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.pictureBoxMenu.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMenu.Image")));
            this.pictureBoxMenu.Location = new System.Drawing.Point(16, 4);
            this.pictureBoxMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(39, 42);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMenu.TabIndex = 1;
            this.pictureBoxMenu.TabStop = false;
            this.pictureBoxMenu.Click += new System.EventHandler(this.pictureBoxMenu_Click);
            // 
            // timerSidebar
            // 
            this.timerSidebar.Interval = 10;
            this.timerSidebar.Tick += new System.EventHandler(this.timerSidebar_Tick);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // btnThongTinNguoiDung
            // 
            this.btnThongTinNguoiDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnThongTinNguoiDung.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongTinNguoiDung.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongTinNguoiDung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongTinNguoiDung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongTinNguoiDung.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnThongTinNguoiDung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThongTinNguoiDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnThongTinNguoiDung.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThongTinNguoiDung.Location = new System.Drawing.Point(3, 72);
            this.btnThongTinNguoiDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongTinNguoiDung.Name = "btnThongTinNguoiDung";
            this.btnThongTinNguoiDung.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnThongTinNguoiDung.Size = new System.Drawing.Size(201, 46);
            this.btnThongTinNguoiDung.TabIndex = 20;
            this.btnThongTinNguoiDung.Text = "Profile người dùng";
            this.btnThongTinNguoiDung.Click += new System.EventHandler(this.btnThongTinNguoiDung_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 738);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelSubMenu_ChucNang.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FlowLayoutPanel panelSidebar;
        private Guna.UI2.WinForms.Guna2Button btnChucNang;
        private Guna.UI2.WinForms.Guna2Button btnDangXuat;
        private Guna.UI2.WinForms.Guna2Button btnThongTin;
        private Guna.UI2.WinForms.Guna2Button btnCaiDat;
        private System.Windows.Forms.FlowLayoutPanel panelSubMenu_ChucNang;
        private System.Windows.Forms.Timer timerMenuChucNang;
        private Guna.UI2.WinForms.Guna2Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerSidebar;
        private System.Windows.Forms.Label lblXinChao;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2Button btnDKTheMuon;
        private Guna.UI2.WinForms.Guna2Button btnDKMuonSach;
        private Guna.UI2.WinForms.Guna2Button btnDangKyDocTaiCho;
        private Guna.UI2.WinForms.Guna2Button btnXemThongTinSach;
        private Guna.UI2.WinForms.Guna2Button btnTTQuanLyPhieuDocTaiCho;
        private Guna.UI2.WinForms.Guna2Button btnTTQuanLyBanSaoSach;
        private Guna.UI2.WinForms.Guna2Button btnTTQuanLyTacGIa;
        private Guna.UI2.WinForms.Guna2Button btnTTQuanLyTaiKhoan;
        private Guna.UI2.WinForms.Guna2Button btnQuanLyDKSach;
        private Guna.UI2.WinForms.Guna2Button btnTTQuanLySach;
        private Guna.UI2.WinForms.Guna2Button btnTTNhanTraSach;
        private Guna.UI2.WinForms.Guna2Button btnTTChoMuonSach;
        private Guna.UI2.WinForms.Guna2Button btnThongKeTopSach;
        private Guna.UI2.WinForms.Guna2Button btnThongTinNguoiDung;
    }
}