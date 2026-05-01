namespace LibraryManagerGUI
{
    partial class FrmQuanLyTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyTaiKhoan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLocTrangThai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTenHienThi = new System.Windows.Forms.Label();
            this.lblMaDinhDanhHienThi = new System.Windows.Forms.Label();
            this.txtSoTienThu = new System.Windows.Forms.TextBox();
            this.btnDuyetVaKichHoat = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuyKichHoat = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(827, 79);
            this.panel1.TabIndex = 51;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(779, 2);
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
            this.label4.Location = new System.Drawing.Point(255, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(344, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "CHỨC NĂNG QUẢN LÝ TÀI KHOẢN";
            // 
            // cboLocTrangThai
            // 
            this.cboLocTrangThai.FormattingEnabled = true;
            this.cboLocTrangThai.Location = new System.Drawing.Point(128, 161);
            this.cboLocTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLocTrangThai.Name = "cboLocTrangThai";
            this.cboLocTrangThai.Size = new System.Drawing.Size(173, 24);
            this.cboLocTrangThai.TabIndex = 52;
            this.cboLocTrangThai.SelectedIndexChanged += new System.EventHandler(this.cboLocTrangThai_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "Tìm kiếm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "Trạng thái:";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhSach.Location = new System.Drawing.Point(0, 315);
            this.dgvDanhSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(827, 209);
            this.dgvDanhSach.TabIndex = 55;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(471, 132);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(73, 16);
            this.lbl.TabIndex = 56;
            this.lbl.Text = "Họ và Tên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 57;
            this.label5.Text = "Số tiền thu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 58;
            this.label6.Text = "Mã Định Danh:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(128, 126);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(173, 22);
            this.txtTimKiem.TabIndex = 59;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lblTenHienThi
            // 
            this.lblTenHienThi.AutoSize = true;
            this.lblTenHienThi.Location = new System.Drawing.Point(573, 132);
            this.lblTenHienThi.Name = "lblTenHienThi";
            this.lblTenHienThi.Size = new System.Drawing.Size(92, 16);
            this.lblTenHienThi.TabIndex = 60;
            this.lblTenHienThi.Text = "lblTenHienThi";
            this.lblTenHienThi.Visible = false;
            // 
            // lblMaDinhDanhHienThi
            // 
            this.lblMaDinhDanhHienThi.AutoSize = true;
            this.lblMaDinhDanhHienThi.Location = new System.Drawing.Point(573, 161);
            this.lblMaDinhDanhHienThi.Name = "lblMaDinhDanhHienThi";
            this.lblMaDinhDanhHienThi.Size = new System.Drawing.Size(146, 16);
            this.lblMaDinhDanhHienThi.TabIndex = 61;
            this.lblMaDinhDanhHienThi.Text = "lblMaDinhDanhHienThi";
            this.lblMaDinhDanhHienThi.Visible = false;
            // 
            // txtSoTienThu
            // 
            this.txtSoTienThu.Location = new System.Drawing.Point(576, 196);
            this.txtSoTienThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoTienThu.Name = "txtSoTienThu";
            this.txtSoTienThu.Size = new System.Drawing.Size(135, 22);
            this.txtSoTienThu.TabIndex = 63;
            // 
            // btnDuyetVaKichHoat
            // 
            this.btnDuyetVaKichHoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDuyetVaKichHoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDuyetVaKichHoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDuyetVaKichHoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDuyetVaKichHoat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(146)))), ((int)(((byte)(38)))));
            this.btnDuyetVaKichHoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDuyetVaKichHoat.ForeColor = System.Drawing.Color.White;
            this.btnDuyetVaKichHoat.Image = ((System.Drawing.Image)(resources.GetObject("btnDuyetVaKichHoat.Image")));
            this.btnDuyetVaKichHoat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDuyetVaKichHoat.Location = new System.Drawing.Point(164, 242);
            this.btnDuyetVaKichHoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnDuyetVaKichHoat.MaximumSize = new System.Drawing.Size(180, 38);
            this.btnDuyetVaKichHoat.Name = "btnDuyetVaKichHoat";
            this.btnDuyetVaKichHoat.Size = new System.Drawing.Size(175, 38);
            this.btnDuyetVaKichHoat.TabIndex = 64;
            this.btnDuyetVaKichHoat.Text = "Duyệt và kích hoạt";
            this.btnDuyetVaKichHoat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDuyetVaKichHoat.Click += new System.EventHandler(this.btnDuyetVaKichHoat_Click);
            // 
            // btnHuyKichHoat
            // 
            this.btnHuyKichHoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuyKichHoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuyKichHoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuyKichHoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuyKichHoat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(146)))), ((int)(((byte)(38)))));
            this.btnHuyKichHoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHuyKichHoat.ForeColor = System.Drawing.Color.White;
            this.btnHuyKichHoat.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyKichHoat.Image")));
            this.btnHuyKichHoat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHuyKichHoat.Location = new System.Drawing.Point(475, 242);
            this.btnHuyKichHoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuyKichHoat.MaximumSize = new System.Drawing.Size(143, 38);
            this.btnHuyKichHoat.Name = "btnHuyKichHoat";
            this.btnHuyKichHoat.Size = new System.Drawing.Size(143, 38);
            this.btnHuyKichHoat.TabIndex = 65;
            this.btnHuyKichHoat.Text = "Hủy Kích Hoạt";
            this.btnHuyKichHoat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnHuyKichHoat.Click += new System.EventHandler(this.btnHuyKichHoat_Click);
            // 
            // FrmQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 524);
            this.Controls.Add(this.btnHuyKichHoat);
            this.Controls.Add(this.btnDuyetVaKichHoat);
            this.Controls.Add(this.txtSoTienThu);
            this.Controls.Add(this.lblMaDinhDanhHienThi);
            this.Controls.Add(this.lblTenHienThi);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboLocTrangThai);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmQuanLyTaiKhoan";
            this.Text = "FrmQuanLyTaiKhoan";
            this.Load += new System.EventHandler(this.FrmQuanLyTaiKhoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboLocTrangThai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTenHienThi;
        private System.Windows.Forms.Label lblMaDinhDanhHienThi;
        private System.Windows.Forms.TextBox txtSoTienThu;
        private Guna.UI2.WinForms.Guna2Button btnDuyetVaKichHoat;
        private Guna.UI2.WinForms.Guna2Button btnHuyKichHoat;
    }
}