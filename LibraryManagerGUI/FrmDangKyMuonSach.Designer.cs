namespace LibraryManagerGUI
{
    partial class FrmDangKyMuonSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangKyMuonSach));
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblDangKyMuonSach = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblThongTinGioSachDaChon = new System.Windows.Forms.Label();
            this.btnDangKyMuonSach = new Guna.UI2.WinForms.Guna2Button();
            this.panelGioSach = new System.Windows.Forms.Panel();
            this.dgvSachMuon = new System.Windows.Forms.DataGridView();
            this.lblTongGiaTri = new System.Windows.Forms.Label();
            this.btnXoaToanBo = new Guna.UI2.WinForms.Guna2Button();
            this.lblTienCoc = new System.Windows.Forms.Label();
            this.btnXoaSach = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpHanTra = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTrangThaiThe = new System.Windows.Forms.Label();
            this.lblTenDocGia = new System.Windows.Forms.Label();
            this.lblMaDocGia = new System.Windows.Forms.Label();
            this.lblNgayMuon = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelGioSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.guna2ControlBox3);
            this.panel1.Controls.Add(this.lblDangKyMuonSach);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 64);
            this.panel1.TabIndex = 24;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(644, 10);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(34, 24);
            this.guna2ControlBox3.TabIndex = 45;
            this.guna2ControlBox3.Click += new System.EventHandler(this.guna2ControlBox3_Click);
            // 
            // lblDangKyMuonSach
            // 
            this.lblDangKyMuonSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDangKyMuonSach.AutoSize = true;
            this.lblDangKyMuonSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangKyMuonSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(94)))), ((int)(((byte)(34)))));
            this.lblDangKyMuonSach.Location = new System.Drawing.Point(244, 21);
            this.lblDangKyMuonSach.Name = "lblDangKyMuonSach";
            this.lblDangKyMuonSach.Size = new System.Drawing.Size(177, 24);
            this.lblDangKyMuonSach.TabIndex = 1;
            this.lblDangKyMuonSach.Text = "Đăng ký mượn sách";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(303, 35);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(202, 25);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Đăng ký mượn sách";
            this.lblTieuDe.Click += new System.EventHandler(this.lblTieuDe_Click);
            // 
            // lblThongTinGioSachDaChon
            // 
            this.lblThongTinGioSachDaChon.AutoSize = true;
            this.lblThongTinGioSachDaChon.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblThongTinGioSachDaChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinGioSachDaChon.Location = new System.Drawing.Point(0, 0);
            this.lblThongTinGioSachDaChon.Name = "lblThongTinGioSachDaChon";
            this.lblThongTinGioSachDaChon.Size = new System.Drawing.Size(140, 17);
            this.lblThongTinGioSachDaChon.TabIndex = 6;
            this.lblThongTinGioSachDaChon.Text = "Giỏ sách đã chọn:";
            // 
            // btnDangKyMuonSach
            // 
            this.btnDangKyMuonSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKyMuonSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangKyMuonSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangKyMuonSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangKyMuonSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(146)))), ((int)(((byte)(38)))));
            this.btnDangKyMuonSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDangKyMuonSach.ForeColor = System.Drawing.Color.White;
            this.btnDangKyMuonSach.Image = ((System.Drawing.Image)(resources.GetObject("btnDangKyMuonSach.Image")));
            this.btnDangKyMuonSach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangKyMuonSach.Location = new System.Drawing.Point(513, 256);
            this.btnDangKyMuonSach.Name = "btnDangKyMuonSach";
            this.btnDangKyMuonSach.Size = new System.Drawing.Size(146, 31);
            this.btnDangKyMuonSach.TabIndex = 8;
            this.btnDangKyMuonSach.Text = " Xác nhận đăng ký ";
            this.btnDangKyMuonSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDangKyMuonSach.Click += new System.EventHandler(this.btnDangKyMuonSach_Click);
            // 
            // panelGioSach
            // 
            this.panelGioSach.Controls.Add(this.dgvSachMuon);
            this.panelGioSach.Controls.Add(this.lblTongGiaTri);
            this.panelGioSach.Controls.Add(this.btnXoaToanBo);
            this.panelGioSach.Controls.Add(this.lblTienCoc);
            this.panelGioSach.Controls.Add(this.btnXoaSach);
            this.panelGioSach.Controls.Add(this.btnDangKyMuonSach);
            this.panelGioSach.Controls.Add(this.label2);
            this.panelGioSach.Controls.Add(this.lblThongTinGioSachDaChon);
            this.panelGioSach.Controls.Add(this.label1);
            this.panelGioSach.Location = new System.Drawing.Point(0, 258);
            this.panelGioSach.Name = "panelGioSach";
            this.panelGioSach.Size = new System.Drawing.Size(680, 351);
            this.panelGioSach.TabIndex = 32;
            // 
            // dgvSachMuon
            // 
            this.dgvSachMuon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSachMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSachMuon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSachMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSachMuon.Location = new System.Drawing.Point(9, 19);
            this.dgvSachMuon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSachMuon.Name = "dgvSachMuon";
            this.dgvSachMuon.RowHeadersWidth = 51;
            this.dgvSachMuon.RowTemplate.Height = 24;
            this.dgvSachMuon.Size = new System.Drawing.Size(680, 96);
            this.dgvSachMuon.TabIndex = 60;
            // 
            // lblTongGiaTri
            // 
            this.lblTongGiaTri.AutoSize = true;
            this.lblTongGiaTri.Location = new System.Drawing.Point(186, 156);
            this.lblTongGiaTri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongGiaTri.Name = "lblTongGiaTri";
            this.lblTongGiaTri.Size = new System.Drawing.Size(60, 13);
            this.lblTongGiaTri.TabIndex = 63;
            this.lblTongGiaTri.Text = "Tổng giá trị";
            // 
            // btnXoaToanBo
            // 
            this.btnXoaToanBo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaToanBo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaToanBo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaToanBo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaToanBo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaToanBo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(146)))), ((int)(((byte)(38)))));
            this.btnXoaToanBo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaToanBo.ForeColor = System.Drawing.Color.White;
            this.btnXoaToanBo.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaToanBo.Image")));
            this.btnXoaToanBo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXoaToanBo.Location = new System.Drawing.Point(27, 256);
            this.btnXoaToanBo.Name = "btnXoaToanBo";
            this.btnXoaToanBo.Size = new System.Drawing.Size(146, 31);
            this.btnXoaToanBo.TabIndex = 59;
            this.btnXoaToanBo.Text = "Xóa Toàn bộ và đóng";
            this.btnXoaToanBo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnXoaToanBo.Click += new System.EventHandler(this.btnXoaToanBo_Click);
            // 
            // lblTienCoc
            // 
            this.lblTienCoc.AutoSize = true;
            this.lblTienCoc.Location = new System.Drawing.Point(186, 188);
            this.lblTienCoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTienCoc.Name = "lblTienCoc";
            this.lblTienCoc.Size = new System.Drawing.Size(49, 13);
            this.lblTienCoc.TabIndex = 65;
            this.lblTienCoc.Text = "Tiền cọc";
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(146)))), ((int)(((byte)(38)))));
            this.btnXoaSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaSach.ForeColor = System.Drawing.Color.White;
            this.btnXoaSach.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaSach.Image")));
            this.btnXoaSach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXoaSach.Location = new System.Drawing.Point(308, 256);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(99, 31);
            this.btnXoaSach.TabIndex = 58;
            this.btnXoaSach.Text = "Xóa Sách";
            this.btnXoaSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Tiền cọc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Tổng giá trị:";
            // 
            // dtpHanTra
            // 
            this.dtpHanTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHanTra.Location = new System.Drawing.Point(92, 214);
            this.dtpHanTra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpHanTra.Name = "dtpHanTra";
            this.dtpHanTra.Size = new System.Drawing.Size(91, 20);
            this.dtpHanTra.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "Mã độc giả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "Họ và Tên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Trạng thái thẻ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 219);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 70;
            this.label7.Text = "Ngày trả:";
            // 
            // lblTrangThaiThe
            // 
            this.lblTrangThaiThe.AutoSize = true;
            this.lblTrangThaiThe.Location = new System.Drawing.Point(74, 130);
            this.lblTrangThaiThe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrangThaiThe.Name = "lblTrangThaiThe";
            this.lblTrangThaiThe.Size = new System.Drawing.Size(85, 13);
            this.lblTrangThaiThe.TabIndex = 72;
            this.lblTrangThaiThe.Text = "lblTrangThaiThe";
            // 
            // lblTenDocGia
            // 
            this.lblTenDocGia.AutoSize = true;
            this.lblTenDocGia.Location = new System.Drawing.Point(74, 106);
            this.lblTenDocGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenDocGia.Name = "lblTenDocGia";
            this.lblTenDocGia.Size = new System.Drawing.Size(72, 13);
            this.lblTenDocGia.TabIndex = 73;
            this.lblTenDocGia.Text = "lblTenDocGia";
            // 
            // lblMaDocGia
            // 
            this.lblMaDocGia.AutoSize = true;
            this.lblMaDocGia.Location = new System.Drawing.Point(70, 84);
            this.lblMaDocGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaDocGia.Name = "lblMaDocGia";
            this.lblMaDocGia.Size = new System.Drawing.Size(53, 13);
            this.lblMaDocGia.TabIndex = 74;
            this.lblMaDocGia.Text = "madocgia";
            // 
            // lblNgayMuon
            // 
            this.lblNgayMuon.AutoSize = true;
            this.lblNgayMuon.Location = new System.Drawing.Point(89, 181);
            this.lblNgayMuon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayMuon.Name = "lblNgayMuon";
            this.lblNgayMuon.Size = new System.Drawing.Size(69, 13);
            this.lblNgayMuon.TabIndex = 71;
            this.lblNgayMuon.Text = "lblNgayMuon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "Ngày mượn:";
            // 
            // FrmDangKyMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(680, 570);
            this.Controls.Add(this.lblMaDocGia);
            this.Controls.Add(this.lblTenDocGia);
            this.Controls.Add(this.lblTrangThaiThe);
            this.Controls.Add(this.lblNgayMuon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpHanTra);
            this.Controls.Add(this.panelGioSach);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDangKyMuonSach";
            this.Text = "FrmDangKyMuonSach";
            this.Load += new System.EventHandler(this.FrmDangKyMuonSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelGioSach.ResumeLayout(false);
            this.panelGioSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private System.Windows.Forms.Label lblDangKyMuonSach;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblThongTinGioSachDaChon;
        private Guna.UI2.WinForms.Guna2Button btnDangKyMuonSach;
        private System.Windows.Forms.Panel panelGioSach;
        private Guna.UI2.WinForms.Guna2Button btnXoaToanBo;
        private Guna.UI2.WinForms.Guna2Button btnXoaSach;
        private System.Windows.Forms.DataGridView dgvSachMuon;
        private System.Windows.Forms.DateTimePicker dtpHanTra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTongGiaTri;
        private System.Windows.Forms.Label lblTienCoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTrangThaiThe;
        private System.Windows.Forms.Label lblTenDocGia;
        private System.Windows.Forms.Label lblMaDocGia;
        private System.Windows.Forms.Label lblNgayMuon;
        private System.Windows.Forms.Label label6;
    }
}