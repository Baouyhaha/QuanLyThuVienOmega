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
            this.btnDuyetThe = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuyThe = new Guna.UI2.WinForms.Guna2Button();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 64);
            this.panel1.TabIndex = 51;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(584, 2);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(34, 24);
            this.guna2ControlBox3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(94)))), ((int)(((byte)(34)))));
            this.label4.Location = new System.Drawing.Point(191, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "CHỨC NĂNG QUẢN LÝ SÁCH";
            // 
            // cboLocTrangThai
            // 
            this.cboLocTrangThai.FormattingEnabled = true;
            this.cboLocTrangThai.Location = new System.Drawing.Point(96, 131);
            this.cboLocTrangThai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboLocTrangThai.Name = "cboLocTrangThai";
            this.cboLocTrangThai.Size = new System.Drawing.Size(131, 21);
            this.cboLocTrangThai.TabIndex = 52;
            this.cboLocTrangThai.SelectedIndexChanged += new System.EventHandler(this.cboLocTrangThai_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Tìm kiếm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Trạng thái:";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhSach.Location = new System.Drawing.Point(0, 256);
            this.dgvDanhSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(620, 170);
            this.dgvDanhSach.TabIndex = 55;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(353, 107);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(61, 13);
            this.lbl.TabIndex = 56;
            this.lbl.Text = "Họ và Tên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Số tiền thu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Mã Định Danh:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(96, 102);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(131, 20);
            this.txtTimKiem.TabIndex = 59;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lblTenHienThi
            // 
            this.lblTenHienThi.AutoSize = true;
            this.lblTenHienThi.Location = new System.Drawing.Point(430, 107);
            this.lblTenHienThi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenHienThi.Name = "lblTenHienThi";
            this.lblTenHienThi.Size = new System.Drawing.Size(73, 13);
            this.lblTenHienThi.TabIndex = 60;
            this.lblTenHienThi.Text = "lblTenHienThi";
            this.lblTenHienThi.Visible = false;
            // 
            // lblMaDinhDanhHienThi
            // 
            this.lblMaDinhDanhHienThi.AutoSize = true;
            this.lblMaDinhDanhHienThi.Location = new System.Drawing.Point(430, 131);
            this.lblMaDinhDanhHienThi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaDinhDanhHienThi.Name = "lblMaDinhDanhHienThi";
            this.lblMaDinhDanhHienThi.Size = new System.Drawing.Size(117, 13);
            this.lblMaDinhDanhHienThi.TabIndex = 61;
            this.lblMaDinhDanhHienThi.Text = "lblMaDinhDanhHienThi";
            this.lblMaDinhDanhHienThi.Visible = false;
            // 
            // txtSoTienThu
            // 
            this.txtSoTienThu.Location = new System.Drawing.Point(432, 159);
            this.txtSoTienThu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoTienThu.Name = "txtSoTienThu";
            this.txtSoTienThu.Size = new System.Drawing.Size(102, 20);
            this.txtSoTienThu.TabIndex = 63;
            // 
            // btnDuyetThe
            // 
            this.btnDuyetThe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDuyetThe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDuyetThe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDuyetThe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDuyetThe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(146)))), ((int)(((byte)(38)))));
            this.btnDuyetThe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDuyetThe.ForeColor = System.Drawing.Color.White;
            this.btnDuyetThe.Image = ((System.Drawing.Image)(resources.GetObject("btnDuyetThe.Image")));
            this.btnDuyetThe.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDuyetThe.Location = new System.Drawing.Point(123, 197);
            this.btnDuyetThe.MaximumSize = new System.Drawing.Size(107, 31);
            this.btnDuyetThe.Name = "btnDuyetThe";
            this.btnDuyetThe.Size = new System.Drawing.Size(103, 31);
            this.btnDuyetThe.TabIndex = 64;
            this.btnDuyetThe.Text = "Duyệt Thẻ";
            this.btnDuyetThe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDuyetThe.Click += new System.EventHandler(this.btnDuyetThe_Click);
            // 
            // btnHuyThe
            // 
            this.btnHuyThe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuyThe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuyThe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuyThe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuyThe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(146)))), ((int)(((byte)(38)))));
            this.btnHuyThe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHuyThe.ForeColor = System.Drawing.Color.White;
            this.btnHuyThe.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyThe.Image")));
            this.btnHuyThe.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHuyThe.Location = new System.Drawing.Point(356, 197);
            this.btnHuyThe.MaximumSize = new System.Drawing.Size(107, 31);
            this.btnHuyThe.Name = "btnHuyThe";
            this.btnHuyThe.Size = new System.Drawing.Size(103, 31);
            this.btnHuyThe.TabIndex = 65;
            this.btnHuyThe.Text = "Hủy thẻ";
            this.btnHuyThe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnHuyThe.Click += new System.EventHandler(this.btnHuyThe_Click);
            // 
            // FrmQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 426);
            this.Controls.Add(this.btnHuyThe);
            this.Controls.Add(this.btnDuyetThe);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private Guna.UI2.WinForms.Guna2Button btnDuyetThe;
        private Guna.UI2.WinForms.Guna2Button btnHuyThe;
    }
}