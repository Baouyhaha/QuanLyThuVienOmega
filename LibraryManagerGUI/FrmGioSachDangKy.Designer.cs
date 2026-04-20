namespace LibraryManagerGUI
{
    partial class FrmGioSachDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGioSachDangKy));
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblDangKyMuonSach = new System.Windows.Forms.Label();
            this.lbxGioHang = new System.Windows.Forms.ListBox();
            this.btnXoaSach = new Guna.UI2.WinForms.Guna2Button();
            this.btnDangKyMuonSach = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1021, 79);
            this.panel1.TabIndex = 25;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(973, 12);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox3.TabIndex = 45;
            // 
            // lblDangKyMuonSach
            // 
            this.lblDangKyMuonSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDangKyMuonSach.AutoSize = true;
            this.lblDangKyMuonSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangKyMuonSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(94)))), ((int)(((byte)(34)))));
            this.lblDangKyMuonSach.Location = new System.Drawing.Point(382, 26);
            this.lblDangKyMuonSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDangKyMuonSach.Name = "lblDangKyMuonSach";
            this.lblDangKyMuonSach.Size = new System.Drawing.Size(221, 29);
            this.lblDangKyMuonSach.TabIndex = 1;
            this.lblDangKyMuonSach.Text = "Đăng ký mượn sách";
            // 
            // lbxGioHang
            // 
            this.lbxGioHang.FormattingEnabled = true;
            this.lbxGioHang.ItemHeight = 16;
            this.lbxGioHang.Location = new System.Drawing.Point(286, 133);
            this.lbxGioHang.Name = "lbxGioHang";
            this.lbxGioHang.Size = new System.Drawing.Size(190, 180);
            this.lbxGioHang.TabIndex = 26;
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
            this.btnXoaSach.Location = new System.Drawing.Point(532, 133);
            this.btnXoaSach.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(132, 38);
            this.btnXoaSach.TabIndex = 56;
            this.btnXoaSach.Text = "Xóa Sách";
            this.btnXoaSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);
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
            this.btnDangKyMuonSach.Location = new System.Drawing.Point(286, 346);
            this.btnDangKyMuonSach.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangKyMuonSach.Name = "btnDangKyMuonSach";
            this.btnDangKyMuonSach.Size = new System.Drawing.Size(190, 44);
            this.btnDangKyMuonSach.TabIndex = 9;
            this.btnDangKyMuonSach.Text = " Đăng ký mượn sách";
            this.btnDangKyMuonSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmGioSachDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 558);
            this.Controls.Add(this.btnXoaSach);
            this.Controls.Add(this.lbxGioHang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDangKyMuonSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGioSachDangKy";
            this.Text = "FrmGioSachDangKy";
            this.Load += new System.EventHandler(this.FrmGioSachDangKy_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnDangKyMuonSach;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private System.Windows.Forms.Label lblDangKyMuonSach;
        private System.Windows.Forms.ListBox lbxGioHang;
        private Guna.UI2.WinForms.Guna2Button btnXoaSach;
    }
}