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
            this.timerMenuChucNang = new System.Windows.Forms.Timer(this.components);
            this.panelDesktop = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblXinChao = new System.Windows.Forms.Label();
            this.timerSidebar = new System.Windows.Forms.Timer(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnChucNang = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuanLySach = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuanLyThe = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuayMuonTra = new Guna.UI2.WinForms.Guna2Button();
            this.btnGioSach = new Guna.UI2.WinForms.Guna2Button();
            this.btnLichSuMuon = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimKiemSach = new Guna.UI2.WinForms.Guna2Button();
            this.btnDangKyMuonSach = new Guna.UI2.WinForms.Guna2Button();
            this.btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.btnThongTin = new Guna.UI2.WinForms.Guna2Button();
            this.btnCaiDat = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.panelSubMenu_ChucNang.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.AutoScroll = true;
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 53);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(235, 600);
            this.panelSidebar.TabIndex = 1;
            // 
            // panelSubMenu_ChucNang
            // 
            this.panelSubMenu_ChucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.panelSubMenu_ChucNang.Controls.Add(this.btnChucNang);
            this.panelSubMenu_ChucNang.Controls.Add(this.btnQuanLySach);
            this.panelSubMenu_ChucNang.Controls.Add(this.btnQuanLyThe);
            this.panelSubMenu_ChucNang.Controls.Add(this.btnQuayMuonTra);
            this.panelSubMenu_ChucNang.Controls.Add(this.btnGioSach);
            this.panelSubMenu_ChucNang.Controls.Add(this.btnLichSuMuon);
            this.panelSubMenu_ChucNang.Controls.Add(this.btnTimKiemSach);
            this.panelSubMenu_ChucNang.Controls.Add(this.btnDangKyMuonSach);
            this.panelSubMenu_ChucNang.Location = new System.Drawing.Point(381, 55);
            this.panelSubMenu_ChucNang.Name = "panelSubMenu_ChucNang";
            this.panelSubMenu_ChucNang.Size = new System.Drawing.Size(232, 504);
            this.panelSubMenu_ChucNang.TabIndex = 8;
            // 
            // timerMenuChucNang
            // 
            this.timerMenuChucNang.Interval = 10;
            this.timerMenuChucNang.Tick += new System.EventHandler(this.timerMenuChucNang_Tick);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.panelSubMenu_ChucNang);
            this.panelDesktop.Controls.Add(this.btnDangXuat);
            this.panelDesktop.Controls.Add(this.btnThongTin);
            this.panelDesktop.Controls.Add(this.btnCaiDat);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(235, 53);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(832, 600);
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
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 4;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(869, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 3;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(803, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
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
            this.btnChucNang.Location = new System.Drawing.Point(3, 3);
            this.btnChucNang.Name = "btnChucNang";
            this.btnChucNang.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnChucNang.Size = new System.Drawing.Size(229, 66);
            this.btnChucNang.TabIndex = 3;
            this.btnChucNang.Text = "Chức Năng";
            this.btnChucNang.Click += new System.EventHandler(this.btnChucNang_Click);
            // 
            // btnQuanLySach
            // 
            this.btnQuanLySach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnQuanLySach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLySach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLySach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuanLySach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuanLySach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLySach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnQuanLySach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQuanLySach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnQuanLySach.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLySach.Image")));
            this.btnQuanLySach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQuanLySach.Location = new System.Drawing.Point(3, 75);
            this.btnQuanLySach.Name = "btnQuanLySach";
            this.btnQuanLySach.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnQuanLySach.Size = new System.Drawing.Size(201, 39);
            this.btnQuanLySach.TabIndex = 4;
            this.btnQuanLySach.Text = "Quản lý sách";
            this.btnQuanLySach.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnQuanLyThe
            // 
            this.btnQuanLyThe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnQuanLyThe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLyThe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuanLyThe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuanLyThe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuanLyThe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLyThe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnQuanLyThe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQuanLyThe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnQuanLyThe.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLyThe.Image")));
            this.btnQuanLyThe.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQuanLyThe.Location = new System.Drawing.Point(3, 120);
            this.btnQuanLyThe.Name = "btnQuanLyThe";
            this.btnQuanLyThe.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnQuanLyThe.Size = new System.Drawing.Size(201, 39);
            this.btnQuanLyThe.TabIndex = 5;
            this.btnQuanLyThe.Text = "Quản lý thẻ";
            this.btnQuanLyThe.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // btnQuayMuonTra
            // 
            this.btnQuayMuonTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnQuayMuonTra.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuayMuonTra.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuayMuonTra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuayMuonTra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuayMuonTra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuayMuonTra.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnQuayMuonTra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnQuayMuonTra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnQuayMuonTra.Image = ((System.Drawing.Image)(resources.GetObject("btnQuayMuonTra.Image")));
            this.btnQuayMuonTra.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnQuayMuonTra.Location = new System.Drawing.Point(3, 165);
            this.btnQuayMuonTra.Name = "btnQuayMuonTra";
            this.btnQuayMuonTra.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnQuayMuonTra.Size = new System.Drawing.Size(201, 39);
            this.btnQuayMuonTra.TabIndex = 6;
            this.btnQuayMuonTra.Text = "Quản lý mượn trả";
            // 
            // btnGioSach
            // 
            this.btnGioSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnGioSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGioSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGioSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGioSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGioSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGioSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnGioSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGioSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnGioSach.Image = ((System.Drawing.Image)(resources.GetObject("btnGioSach.Image")));
            this.btnGioSach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGioSach.Location = new System.Drawing.Point(3, 210);
            this.btnGioSach.Name = "btnGioSach";
            this.btnGioSach.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnGioSach.Size = new System.Drawing.Size(201, 39);
            this.btnGioSach.TabIndex = 7;
            this.btnGioSach.Text = "Giỏ sách";
            // 
            // btnLichSuMuon
            // 
            this.btnLichSuMuon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnLichSuMuon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLichSuMuon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLichSuMuon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLichSuMuon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLichSuMuon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLichSuMuon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnLichSuMuon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLichSuMuon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnLichSuMuon.Image = ((System.Drawing.Image)(resources.GetObject("btnLichSuMuon.Image")));
            this.btnLichSuMuon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLichSuMuon.Location = new System.Drawing.Point(3, 255);
            this.btnLichSuMuon.Name = "btnLichSuMuon";
            this.btnLichSuMuon.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLichSuMuon.Size = new System.Drawing.Size(201, 39);
            this.btnLichSuMuon.TabIndex = 8;
            this.btnLichSuMuon.Text = "lịch sử mượn";
            // 
            // btnTimKiemSach
            // 
            this.btnTimKiemSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnTimKiemSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiemSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiemSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiemSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiemSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTimKiemSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnTimKiemSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimKiemSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnTimKiemSach.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemSach.Image")));
            this.btnTimKiemSach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTimKiemSach.Location = new System.Drawing.Point(3, 300);
            this.btnTimKiemSach.Name = "btnTimKiemSach";
            this.btnTimKiemSach.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTimKiemSach.Size = new System.Drawing.Size(201, 39);
            this.btnTimKiemSach.TabIndex = 9;
            this.btnTimKiemSach.Text = "Tìm kiếm sách";
            this.btnTimKiemSach.Click += new System.EventHandler(this.btnTimKiemSach_Click);
            // 
            // btnDangKyMuonSach
            // 
            this.btnDangKyMuonSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnDangKyMuonSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKyMuonSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKyMuonSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangKyMuonSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangKyMuonSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangKyMuonSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(113)))), ((int)(((byte)(240)))));
            this.btnDangKyMuonSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDangKyMuonSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnDangKyMuonSach.Image = ((System.Drawing.Image)(resources.GetObject("btnDangKyMuonSach.Image")));
            this.btnDangKyMuonSach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangKyMuonSach.Location = new System.Drawing.Point(3, 345);
            this.btnDangKyMuonSach.Name = "btnDangKyMuonSach";
            this.btnDangKyMuonSach.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDangKyMuonSach.Size = new System.Drawing.Size(201, 39);
            this.btnDangKyMuonSach.TabIndex = 10;
            this.btnDangKyMuonSach.Text = "Đăng ký mượn sách";
            this.btnDangKyMuonSach.Click += new System.EventHandler(this.btnDangKyMuonSach_Click);
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
            this.btnDangXuat.Location = new System.Drawing.Point(27, 258);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(232, 66);
            this.btnDangXuat.TabIndex = 5;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
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
            this.btnThongTin.Location = new System.Drawing.Point(27, 402);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(232, 66);
            this.btnThongTin.TabIndex = 6;
            this.btnThongTin.Text = "Thông tin";
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
            this.btnCaiDat.Location = new System.Drawing.Point(27, 330);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Size = new System.Drawing.Size(232, 66);
            this.btnCaiDat.TabIndex = 7;
            this.btnCaiDat.Text = "Cài đặt";
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
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 653);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panelSubMenu_ChucNang.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2Button btnQuanLySach;
        private Guna.UI2.WinForms.Guna2Button btnQuanLyThe;
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
        private Guna.UI2.WinForms.Guna2Button btnQuayMuonTra;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2Button btnGioSach;
        private Guna.UI2.WinForms.Guna2Button btnLichSuMuon;
        private Guna.UI2.WinForms.Guna2Button btnTimKiemSach;
        private Guna.UI2.WinForms.Guna2Button btnDangKyMuonSach;
    }
}