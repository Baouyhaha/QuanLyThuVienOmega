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
            this.lbxGioHang = new System.Windows.Forms.ListBox();
            this.lblThongTinGioSachDaChon = new System.Windows.Forms.Label();
            this.btnDangKyMuonSach = new Guna.UI2.WinForms.Guna2Button();
            this.panelGioSach = new System.Windows.Forms.Panel();
            this.btnXoaToanBo = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaSach = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panelGioSach.SuspendLayout();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 79);
            this.panel1.TabIndex = 24;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(859, 12);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox3.TabIndex = 45;
            this.guna2ControlBox3.Click += new System.EventHandler(this.guna2ControlBox3_Click);
            // 
            // lblDangKyMuonSach
            // 
            this.lblDangKyMuonSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDangKyMuonSach.AutoSize = true;
            this.lblDangKyMuonSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangKyMuonSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(94)))), ((int)(((byte)(34)))));
            this.lblDangKyMuonSach.Location = new System.Drawing.Point(325, 26);
            this.lblDangKyMuonSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDangKyMuonSach.Name = "lblDangKyMuonSach";
            this.lblDangKyMuonSach.Size = new System.Drawing.Size(221, 29);
            this.lblDangKyMuonSach.TabIndex = 1;
            this.lblDangKyMuonSach.Text = "Đăng ký mượn sách";
            this.lblDangKyMuonSach.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(404, 43);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(253, 31);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Đăng ký mượn sách";
            this.lblTieuDe.Click += new System.EventHandler(this.lblTieuDe_Click);
            // 
            // lbxGioHang
            // 
            this.lbxGioHang.FormattingEnabled = true;
            this.lbxGioHang.ItemHeight = 16;
            this.lbxGioHang.Location = new System.Drawing.Point(13, 43);
            this.lbxGioHang.Margin = new System.Windows.Forms.Padding(4);
            this.lbxGioHang.Name = "lbxGioHang";
            this.lbxGioHang.Size = new System.Drawing.Size(228, 308);
            this.lbxGioHang.TabIndex = 0;
            this.lbxGioHang.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblThongTinGioSachDaChon
            // 
            this.lblThongTinGioSachDaChon.AutoSize = true;
            this.lblThongTinGioSachDaChon.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblThongTinGioSachDaChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinGioSachDaChon.Location = new System.Drawing.Point(0, 0);
            this.lblThongTinGioSachDaChon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongTinGioSachDaChon.Name = "lblThongTinGioSachDaChon";
            this.lblThongTinGioSachDaChon.Size = new System.Drawing.Size(162, 20);
            this.lblThongTinGioSachDaChon.TabIndex = 6;
            this.lblThongTinGioSachDaChon.Text = "Giỏ sách đã chọn:";
            this.lblThongTinGioSachDaChon.Click += new System.EventHandler(this.lblThongTinGioSachDaChon_Click);
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
            this.btnDangKyMuonSach.Location = new System.Drawing.Point(30, 359);
            this.btnDangKyMuonSach.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangKyMuonSach.Name = "btnDangKyMuonSach";
            this.btnDangKyMuonSach.Size = new System.Drawing.Size(195, 44);
            this.btnDangKyMuonSach.TabIndex = 8;
            this.btnDangKyMuonSach.Text = " Xác nhận đăng ký ";
            this.btnDangKyMuonSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDangKyMuonSach.Click += new System.EventHandler(this.btnDangKyMuonSach_Click);
            // 
            // panelGioSach
            // 
            this.panelGioSach.Controls.Add(this.btnXoaToanBo);
            this.panelGioSach.Controls.Add(this.btnXoaSach);
            this.panelGioSach.Controls.Add(this.btnDangKyMuonSach);
            this.panelGioSach.Controls.Add(this.lblThongTinGioSachDaChon);
            this.panelGioSach.Controls.Add(this.lbxGioHang);
            this.panelGioSach.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGioSach.Location = new System.Drawing.Point(0, 79);
            this.panelGioSach.Margin = new System.Windows.Forms.Padding(4);
            this.panelGioSach.Name = "panelGioSach";
            this.panelGioSach.Size = new System.Drawing.Size(811, 478);
            this.panelGioSach.TabIndex = 32;
            this.panelGioSach.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGioSach_Paint);
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
            this.btnXoaToanBo.Location = new System.Drawing.Point(31, 411);
            this.btnXoaToanBo.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaToanBo.Name = "btnXoaToanBo";
            this.btnXoaToanBo.Size = new System.Drawing.Size(195, 38);
            this.btnXoaToanBo.TabIndex = 59;
            this.btnXoaToanBo.Text = "Xóa Toàn bộ và đóng";
            this.btnXoaToanBo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnXoaToanBo.Click += new System.EventHandler(this.btnXoaToanBo_Click);
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
            this.btnXoaSach.Location = new System.Drawing.Point(284, 43);
            this.btnXoaSach.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(132, 38);
            this.btnXoaSach.TabIndex = 58;
            this.btnXoaSach.Text = "Xóa Sách";
            this.btnXoaSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // FrmDangKyMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(907, 557);
            this.Controls.Add(this.panelGioSach);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDangKyMuonSach";
            this.Text = "FrmDangKyMuonSach";
            this.Load += new System.EventHandler(this.FrmDangKyMuonSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelGioSach.ResumeLayout(false);
            this.panelGioSach.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private System.Windows.Forms.Label lblDangKyMuonSach;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.ListBox lbxGioHang;
        private System.Windows.Forms.Label lblThongTinGioSachDaChon;
        private Guna.UI2.WinForms.Guna2Button btnDangKyMuonSach;
        private System.Windows.Forms.Panel panelGioSach;
        private Guna.UI2.WinForms.Guna2Button btnXoaToanBo;
        private Guna.UI2.WinForms.Guna2Button btnXoaSach;
    }
}