namespace LibraryManagerGUI
{
    partial class FrmQuanLyDangKySach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyDangKySach));
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimPhieu = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLocTrangThai = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuCho = new System.Windows.Forms.DataGridView();
            this.dgvChiTietSach = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSoLuongSach = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTongTienCoc = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTrangThaiThe = new System.Windows.Forms.Label();
            this.btnPheDuyetVaGiaoSach = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuyPhieu = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuCho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.guna2ControlBox3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 79);
            this.panel1.TabIndex = 52;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(935, 2);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(94)))), ((int)(((byte)(34)))));
            this.label4.Location = new System.Drawing.Point(292, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(385, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "CHỨC NĂNG QUẢN LÝ ĐĂNG KÝ SÁCH";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "Tìm kiếm Phiếu yêu cầu:";
            // 
            // txtTimPhieu
            // 
            this.txtTimPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimPhieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimPhieu.DefaultText = "";
            this.txtTimPhieu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimPhieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimPhieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimPhieu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimPhieu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimPhieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimPhieu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimPhieu.Location = new System.Drawing.Point(167, 98);
            this.txtTimPhieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimPhieu.MaximumSize = new System.Drawing.Size(1500, 38);
            this.txtTimPhieu.MinimumSize = new System.Drawing.Size(300, 38);
            this.txtTimPhieu.Name = "txtTimPhieu";
            this.txtTimPhieu.PlaceholderText = "";
            this.txtTimPhieu.SelectedText = "";
            this.txtTimPhieu.Size = new System.Drawing.Size(320, 38);
            this.txtTimPhieu.TabIndex = 57;
            this.txtTimPhieu.TextChanged += new System.EventHandler(this.txtTimPhieu_TextChanged);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(710, 105);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(121, 24);
            this.cboTrangThai.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(619, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 59;
            this.label2.Text = "Trạng thái";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 60;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLocTrangThai
            // 
            this.btnLocTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLocTrangThai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLocTrangThai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLocTrangThai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLocTrangThai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLocTrangThai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(146)))), ((int)(((byte)(38)))));
            this.btnLocTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLocTrangThai.ForeColor = System.Drawing.Color.White;
            this.btnLocTrangThai.Image = ((System.Drawing.Image)(resources.GetObject("btnLocTrangThai.Image")));
            this.btnLocTrangThai.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLocTrangThai.Location = new System.Drawing.Point(710, 148);
            this.btnLocTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.btnLocTrangThai.MaximumSize = new System.Drawing.Size(143, 38);
            this.btnLocTrangThai.MinimumSize = new System.Drawing.Size(120, 38);
            this.btnLocTrangThai.Name = "btnLocTrangThai";
            this.btnLocTrangThai.Size = new System.Drawing.Size(121, 38);
            this.btnLocTrangThai.TabIndex = 66;
            this.btnLocTrangThai.Text = "Lọc ";
            this.btnLocTrangThai.Click += new System.EventHandler(this.btnLocTrangThai_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPhieuCho);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 276);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[DANH SÁCH PHIẾU ĐANG CHỜ]";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 219);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(983, 276);
            this.splitContainer1.SplitterDistance = 497;
            this.splitContainer1.TabIndex = 69;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvChiTietSach);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 276);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[CHI TIẾT SÁCH ĐÃ CHỌN]";
            // 
            // dgvPhieuCho
            // 
            this.dgvPhieuCho.AllowUserToAddRows = false;
            this.dgvPhieuCho.AllowUserToDeleteRows = false;
            this.dgvPhieuCho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuCho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuCho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuCho.Location = new System.Drawing.Point(3, 23);
            this.dgvPhieuCho.Name = "dgvPhieuCho";
            this.dgvPhieuCho.RowHeadersWidth = 51;
            this.dgvPhieuCho.RowTemplate.Height = 24;
            this.dgvPhieuCho.Size = new System.Drawing.Size(491, 250);
            this.dgvPhieuCho.TabIndex = 0;
            this.dgvPhieuCho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuCho_CellClick);
            // 
            // dgvChiTietSach
            // 
            this.dgvChiTietSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietSach.Location = new System.Drawing.Point(3, 23);
            this.dgvChiTietSach.Name = "dgvChiTietSach";
            this.dgvChiTietSach.RowHeadersWidth = 51;
            this.dgvChiTietSach.RowTemplate.Height = 24;
            this.dgvChiTietSach.Size = new System.Drawing.Size(476, 250);
            this.dgvChiTietSach.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 518);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 70;
            this.label3.Text = "Số Lượng:";
            // 
            // lblSoLuongSach
            // 
            this.lblSoLuongSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoLuongSach.AutoSize = true;
            this.lblSoLuongSach.Location = new System.Drawing.Point(99, 518);
            this.lblSoLuongSach.Name = "lblSoLuongSach";
            this.lblSoLuongSach.Size = new System.Drawing.Size(64, 16);
            this.lblSoLuongSach.TabIndex = 71;
            this.lblSoLuongSach.Text = "Số Lượng";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 518);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 72;
            this.label5.Text = "Tổng tiền cọc thu:";
            // 
            // lblTongTienCoc
            // 
            this.lblTongTienCoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongTienCoc.AutoSize = true;
            this.lblTongTienCoc.Location = new System.Drawing.Point(377, 518);
            this.lblTongTienCoc.Name = "lblTongTienCoc";
            this.lblTongTienCoc.Size = new System.Drawing.Size(111, 16);
            this.lblTongTienCoc.TabIndex = 73;
            this.lblTongTienCoc.Text = "Tổng tiền cọc thu:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(650, 518);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 74;
            this.label6.Text = "Trạng Thái thẻ:";
            // 
            // lblTrangThaiThe
            // 
            this.lblTrangThaiThe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrangThaiThe.AutoSize = true;
            this.lblTrangThaiThe.Location = new System.Drawing.Point(750, 518);
            this.lblTrangThaiThe.Name = "lblTrangThaiThe";
            this.lblTrangThaiThe.Size = new System.Drawing.Size(94, 16);
            this.lblTrangThaiThe.TabIndex = 75;
            this.lblTrangThaiThe.Text = "Trạng Thái thẻ";
            // 
            // btnPheDuyetVaGiaoSach
            // 
            this.btnPheDuyetVaGiaoSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPheDuyetVaGiaoSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPheDuyetVaGiaoSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPheDuyetVaGiaoSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPheDuyetVaGiaoSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPheDuyetVaGiaoSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(146)))), ((int)(((byte)(38)))));
            this.btnPheDuyetVaGiaoSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPheDuyetVaGiaoSach.ForeColor = System.Drawing.Color.White;
            this.btnPheDuyetVaGiaoSach.Image = ((System.Drawing.Image)(resources.GetObject("btnPheDuyetVaGiaoSach.Image")));
            this.btnPheDuyetVaGiaoSach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPheDuyetVaGiaoSach.Location = new System.Drawing.Point(653, 558);
            this.btnPheDuyetVaGiaoSach.Margin = new System.Windows.Forms.Padding(4);
            this.btnPheDuyetVaGiaoSach.MaximumSize = new System.Drawing.Size(230, 38);
            this.btnPheDuyetVaGiaoSach.MinimumSize = new System.Drawing.Size(137, 38);
            this.btnPheDuyetVaGiaoSach.Name = "btnPheDuyetVaGiaoSach";
            this.btnPheDuyetVaGiaoSach.Size = new System.Drawing.Size(213, 38);
            this.btnPheDuyetVaGiaoSach.TabIndex = 76;
            this.btnPheDuyetVaGiaoSach.Text = "Phê Duyệt và Giao Sách";
            this.btnPheDuyetVaGiaoSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPheDuyetVaGiaoSach.Click += new System.EventHandler(this.btnPheDuyetVaGiaoSach_Click);
            // 
            // btnHuyPhieu
            // 
            this.btnHuyPhieu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuyPhieu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuyPhieu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuyPhieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuyPhieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuyPhieu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(146)))), ((int)(((byte)(38)))));
            this.btnHuyPhieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHuyPhieu.ForeColor = System.Drawing.Color.White;
            this.btnHuyPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyPhieu.Image")));
            this.btnHuyPhieu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHuyPhieu.Location = new System.Drawing.Point(167, 558);
            this.btnHuyPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuyPhieu.MaximumSize = new System.Drawing.Size(143, 38);
            this.btnHuyPhieu.MinimumSize = new System.Drawing.Size(137, 38);
            this.btnHuyPhieu.Name = "btnHuyPhieu";
            this.btnHuyPhieu.Size = new System.Drawing.Size(137, 38);
            this.btnHuyPhieu.TabIndex = 77;
            this.btnHuyPhieu.Text = "Hủy Phiếu";
            this.btnHuyPhieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnHuyPhieu.Click += new System.EventHandler(this.btnHuyPhieu_Click);
            // 
            // FrmQuanLyDangKySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 627);
            this.Controls.Add(this.btnHuyPhieu);
            this.Controls.Add(this.btnPheDuyetVaGiaoSach);
            this.Controls.Add(this.lblTrangThaiThe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTongTienCoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSoLuongSach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnLocTrangThai);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.txtTimPhieu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQuanLyDangKySach";
            this.Text = "FrmQuanLyDangKySach";
            this.Load += new System.EventHandler(this.FrmQuanLyDangKySach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuCho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTimPhieu;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2Button btnLocTrangThai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPhieuCho;
        private System.Windows.Forms.DataGridView dgvChiTietSach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSoLuongSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTongTienCoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTrangThaiThe;
        private Guna.UI2.WinForms.Guna2Button btnPheDuyetVaGiaoSach;
        private Guna.UI2.WinForms.Guna2Button btnHuyPhieu;
    }
}