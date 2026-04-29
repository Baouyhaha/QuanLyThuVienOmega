namespace LibraryManagerGUI
{
    partial class FrmTimKiemSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTimKiemSach));
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblTieuDeNhanTraSach = new System.Windows.Forms.Label();
            this.dgvTimKiemSach = new System.Windows.Forms.DataGridView();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMoFrmDangKyMuonSach = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimSach = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimSach = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemSach)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ControlBox3);
            this.guna2CustomGradientPanel1.Controls.Add(this.lblTieuDeNhanTraSach);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(800, 111);
            this.guna2CustomGradientPanel1.TabIndex = 2;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(764, 2);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(34, 24);
            this.guna2ControlBox3.TabIndex = 6;
            // 
            // lblTieuDeNhanTraSach
            // 
            this.lblTieuDeNhanTraSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTieuDeNhanTraSach.AutoSize = true;
            this.lblTieuDeNhanTraSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDeNhanTraSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(94)))), ((int)(((byte)(34)))));
            this.lblTieuDeNhanTraSach.Location = new System.Drawing.Point(288, 41);
            this.lblTieuDeNhanTraSach.Name = "lblTieuDeNhanTraSach";
            this.lblTieuDeNhanTraSach.Size = new System.Drawing.Size(173, 29);
            this.lblTieuDeNhanTraSach.TabIndex = 0;
            this.lblTieuDeNhanTraSach.Text = "Tìm kiếm Sách";
            // 
            // dgvTimKiemSach
            // 
            this.dgvTimKiemSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiemSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTimKiemSach.Location = new System.Drawing.Point(0, 265);
            this.dgvTimKiemSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTimKiemSach.Name = "dgvTimKiemSach";
            this.dgvTimKiemSach.RowHeadersWidth = 51;
            this.dgvTimKiemSach.RowTemplate.Height = 24;
            this.dgvTimKiemSach.Size = new System.Drawing.Size(800, 275);
            this.dgvTimKiemSach.TabIndex = 62;
            this.dgvTimKiemSach.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimKiemSach_CellDoubleClick);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.guna2CustomGradientPanel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnMoFrmDangKyMuonSach);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.txtTimSach);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.btnTimSach);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 111);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(800, 154);
            this.guna2Panel1.TabIndex = 63;
            // 
            // btnMoFrmDangKyMuonSach
            // 
            this.btnMoFrmDangKyMuonSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoFrmDangKyMuonSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMoFrmDangKyMuonSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMoFrmDangKyMuonSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMoFrmDangKyMuonSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMoFrmDangKyMuonSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(146)))), ((int)(((byte)(38)))));
            this.btnMoFrmDangKyMuonSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMoFrmDangKyMuonSach.ForeColor = System.Drawing.Color.White;
            this.btnMoFrmDangKyMuonSach.Image = global::LibraryManagerGUI.Properties.Resources.book_signing;
            this.btnMoFrmDangKyMuonSach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMoFrmDangKyMuonSach.Location = new System.Drawing.Point(580, 63);
            this.btnMoFrmDangKyMuonSach.MinimumSize = new System.Drawing.Size(103, 31);
            this.btnMoFrmDangKyMuonSach.Name = "btnMoFrmDangKyMuonSach";
            this.btnMoFrmDangKyMuonSach.Size = new System.Drawing.Size(103, 31);
            this.btnMoFrmDangKyMuonSach.TabIndex = 69;
            this.btnMoFrmDangKyMuonSach.Text = "Đăng ký sách";
            this.btnMoFrmDangKyMuonSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnMoFrmDangKyMuonSach.Click += new System.EventHandler(this.btnMoFrmDangKyMuonSach_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Tên Sách/tác giả/ tên bảng";
            // 
            // txtTimSach
            // 
            this.txtTimSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimSach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimSach.DefaultText = "";
            this.txtTimSach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimSach.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimSach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimSach.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimSach.Location = new System.Drawing.Point(177, 26);
            this.txtTimSach.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTimSach.MaximumSize = new System.Drawing.Size(1125, 31);
            this.txtTimSach.MinimumSize = new System.Drawing.Size(225, 31);
            this.txtTimSach.Name = "txtTimSach";
            this.txtTimSach.PlaceholderText = "";
            this.txtTimSach.SelectedText = "";
            this.txtTimSach.Size = new System.Drawing.Size(335, 31);
            this.txtTimSach.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Tìm kiếm bằng ";
            // 
            // btnTimSach
            // 
            this.btnTimSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(146)))), ((int)(((byte)(38)))));
            this.btnTimSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimSach.ForeColor = System.Drawing.Color.White;
            this.btnTimSach.Image = ((System.Drawing.Image)(resources.GetObject("btnTimSach.Image")));
            this.btnTimSach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTimSach.Location = new System.Drawing.Point(580, 26);
            this.btnTimSach.MaximumSize = new System.Drawing.Size(107, 31);
            this.btnTimSach.MinimumSize = new System.Drawing.Size(103, 31);
            this.btnTimSach.Name = "btnTimSach";
            this.btnTimSach.Size = new System.Drawing.Size(103, 31);
            this.btnTimSach.TabIndex = 65;
            this.btnTimSach.Text = "Tìm Sách";
            this.btnTimSach.Click += new System.EventHandler(this.btnTimSach_Click);
            // 
            // FrmTimKiemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dgvTimKiemSach);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmTimKiemSach";
            this.Text = "FrmTimSach";
            this.Load += new System.EventHandler(this.FrmTimKiemSach_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemSach)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private System.Windows.Forms.Label lblTieuDeNhanTraSach;
        private System.Windows.Forms.DataGridView dgvTimKiemSach;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtTimSach;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnTimSach;
        private Guna.UI2.WinForms.Guna2Button btnMoFrmDangKyMuonSach;
    }
}