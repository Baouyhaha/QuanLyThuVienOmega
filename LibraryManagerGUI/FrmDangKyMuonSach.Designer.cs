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
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.panelTimKiem = new System.Windows.Forms.Panel();
            this.btnTimKiemSach = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimSach = new System.Windows.Forms.TextBox();
            this.dgvKhoSach = new System.Windows.Forms.DataGridView();
            this.panelKhoSach = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblThongTinGioSachDaChon = new System.Windows.Forms.Label();
            this.btnThemGioSach = new Guna.UI2.WinForms.Guna2Button();
            this.btnDangKyMuonSach = new Guna.UI2.WinForms.Guna2Button();
            this.panelGioSach = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoSach)).BeginInit();
            this.panelKhoSach.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1067, 79);
            this.panel1.TabIndex = 24;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1019, 12);
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
            this.lblDangKyMuonSach.Location = new System.Drawing.Point(405, 26);
            this.lblDangKyMuonSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDangKyMuonSach.Name = "lblDangKyMuonSach";
            this.lblDangKyMuonSach.Size = new System.Drawing.Size(221, 29);
            this.lblDangKyMuonSach.TabIndex = 1;
            this.lblDangKyMuonSach.Text = "Đăng ký mượn sách";
            this.lblDangKyMuonSach.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(4, 11);
            this.lblTimKiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(100, 16);
            this.lblTimKiem.TabIndex = 33;
            this.lblTimKiem.Text = "Tìm kiếm sách: ";
            this.lblTimKiem.Click += new System.EventHandler(this.lblTimKiem_Click);
            // 
            // panelTimKiem
            // 
            this.panelTimKiem.Controls.Add(this.btnTimKiemSach);
            this.panelTimKiem.Controls.Add(this.lblTimKiem);
            this.panelTimKiem.Controls.Add(this.txtTimSach);
            this.panelTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTimKiem.Location = new System.Drawing.Point(0, 79);
            this.panelTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.panelTimKiem.Name = "panelTimKiem";
            this.panelTimKiem.Size = new System.Drawing.Size(778, 39);
            this.panelTimKiem.TabIndex = 34;
            this.panelTimKiem.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTimKiem_Paint);
            // 
            // btnTimKiemSach
            // 
            this.btnTimKiemSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiemSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiemSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiemSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiemSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiemSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(146)))), ((int)(((byte)(38)))));
            this.btnTimKiemSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimKiemSach.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemSach.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemSach.Image")));
            this.btnTimKiemSach.Location = new System.Drawing.Point(642, 11);
            this.btnTimKiemSach.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiemSach.Name = "btnTimKiemSach";
            this.btnTimKiemSach.Size = new System.Drawing.Size(128, 25);
            this.btnTimKiemSach.TabIndex = 35;
            this.btnTimKiemSach.Text = "Tìm kiếm";
            this.btnTimKiemSach.Click += new System.EventHandler(this.btnTimKiemSach_Click_1);
            // 
            // txtTimSach
            // 
            this.txtTimSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimSach.Location = new System.Drawing.Point(112, 11);
            this.txtTimSach.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimSach.MaximumSize = new System.Drawing.Size(1200, 20);
            this.txtTimSach.MinimumSize = new System.Drawing.Size(300, 20);
            this.txtTimSach.Name = "txtTimSach";
            this.txtTimSach.Size = new System.Drawing.Size(300, 22);
            this.txtTimSach.TabIndex = 32;
            this.txtTimSach.TextChanged += new System.EventHandler(this.txtTimSach_TextChanged);
            // 
            // dgvKhoSach
            // 
            this.dgvKhoSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhoSach.Location = new System.Drawing.Point(0, 0);
            this.dgvKhoSach.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKhoSach.Name = "dgvKhoSach";
            this.dgvKhoSach.RowHeadersWidth = 51;
            this.dgvKhoSach.Size = new System.Drawing.Size(778, 475);
            this.dgvKhoSach.TabIndex = 0;
            this.dgvKhoSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhoSach_CellContentClick_1);
            // 
            // panelKhoSach
            // 
            this.panelKhoSach.Controls.Add(this.dgvKhoSach);
            this.panelKhoSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelKhoSach.Location = new System.Drawing.Point(0, 79);
            this.panelKhoSach.Margin = new System.Windows.Forms.Padding(4);
            this.panelKhoSach.Name = "panelKhoSach";
            this.panelKhoSach.Size = new System.Drawing.Size(778, 475);
            this.panelKhoSach.TabIndex = 33;
            this.panelKhoSach.Paint += new System.Windows.Forms.PaintEventHandler(this.panelKhoSach_Paint);
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(17, 38);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(228, 308);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblThongTinGioSachDaChon
            // 
            this.lblThongTinGioSachDaChon.AutoSize = true;
            this.lblThongTinGioSachDaChon.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblThongTinGioSachDaChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinGioSachDaChon.Location = new System.Drawing.Point(0, 0);
            this.lblThongTinGioSachDaChon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongTinGioSachDaChon.Name = "lblThongTinGioSachDaChon";
            this.lblThongTinGioSachDaChon.Size = new System.Drawing.Size(140, 20);
            this.lblThongTinGioSachDaChon.TabIndex = 6;
            this.lblThongTinGioSachDaChon.Text = "Giỏ sách đã chọn";
            this.lblThongTinGioSachDaChon.Click += new System.EventHandler(this.lblThongTinGioSachDaChon_Click);
            // 
            // btnThemGioSach
            // 
            this.btnThemGioSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemGioSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemGioSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemGioSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemGioSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(146)))), ((int)(((byte)(38)))));
            this.btnThemGioSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemGioSach.ForeColor = System.Drawing.Color.White;
            this.btnThemGioSach.Image = ((System.Drawing.Image)(resources.GetObject("btnThemGioSach.Image")));
            this.btnThemGioSach.Location = new System.Drawing.Point(40, 366);
            this.btnThemGioSach.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemGioSach.Name = "btnThemGioSach";
            this.btnThemGioSach.Size = new System.Drawing.Size(172, 44);
            this.btnThemGioSach.TabIndex = 7;
            this.btnThemGioSach.Text = "Thêm vào giỏ sách";
            this.btnThemGioSach.Click += new System.EventHandler(this.btnThemGioSach_Click);
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
            this.btnDangKyMuonSach.Location = new System.Drawing.Point(40, 427);
            this.btnDangKyMuonSach.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangKyMuonSach.Name = "btnDangKyMuonSach";
            this.btnDangKyMuonSach.Size = new System.Drawing.Size(172, 44);
            this.btnDangKyMuonSach.TabIndex = 8;
            this.btnDangKyMuonSach.Text = "Thêm vào giỏ sách";
            this.btnDangKyMuonSach.Click += new System.EventHandler(this.btnDangKyMuonSach_Click);
            // 
            // panelGioSach
            // 
            this.panelGioSach.Controls.Add(this.btnDangKyMuonSach);
            this.panelGioSach.Controls.Add(this.btnThemGioSach);
            this.panelGioSach.Controls.Add(this.lblThongTinGioSachDaChon);
            this.panelGioSach.Controls.Add(this.listBox1);
            this.panelGioSach.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelGioSach.Location = new System.Drawing.Point(778, 79);
            this.panelGioSach.Margin = new System.Windows.Forms.Padding(4);
            this.panelGioSach.Name = "panelGioSach";
            this.panelGioSach.Size = new System.Drawing.Size(289, 475);
            this.panelGioSach.TabIndex = 32;
            this.panelGioSach.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGioSach_Paint);
            // 
            // FrmDangKyMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panelTimKiem);
            this.Controls.Add(this.panelKhoSach);
            this.Controls.Add(this.panelGioSach);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDangKyMuonSach";
            this.Text = "FrmDangKyMuonSach";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTimKiem.ResumeLayout(false);
            this.panelTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoSach)).EndInit();
            this.panelKhoSach.ResumeLayout(false);
            this.panelGioSach.ResumeLayout(false);
            this.panelGioSach.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private System.Windows.Forms.Label lblDangKyMuonSach;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Panel panelTimKiem;
        private Guna.UI2.WinForms.Guna2Button btnTimKiemSach;
        private System.Windows.Forms.TextBox txtTimSach;
        private System.Windows.Forms.DataGridView dgvKhoSach;
        private System.Windows.Forms.Panel panelKhoSach;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblThongTinGioSachDaChon;
        private Guna.UI2.WinForms.Guna2Button btnThemGioSach;
        private Guna.UI2.WinForms.Guna2Button btnDangKyMuonSach;
        private System.Windows.Forms.Panel panelGioSach;
    }
}