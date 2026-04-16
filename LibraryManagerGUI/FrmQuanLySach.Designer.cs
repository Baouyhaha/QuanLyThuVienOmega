namespace LibraryManagerGUI
{
    partial class FrmQuanLySach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLySach));
            this.datagridView = new System.Windows.Forms.DataGridView();
            this.txtTimSach = new System.Windows.Forms.TextBox();
            this.tet = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThemSach = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimSach = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaSach = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaSach = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridView)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagridView
            // 
            this.datagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridView.Location = new System.Drawing.Point(0, 0);
            this.datagridView.Name = "datagridView";
            this.datagridView.Size = new System.Drawing.Size(800, 266);
            this.datagridView.TabIndex = 0;
            // 
            // txtTimSach
            // 
            this.txtTimSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimSach.Location = new System.Drawing.Point(149, 77);
            this.txtTimSach.MaximumSize = new System.Drawing.Size(400, 32);
            this.txtTimSach.MaxLength = 32651;
            this.txtTimSach.MinimumSize = new System.Drawing.Size(250, 22);
            this.txtTimSach.Multiline = true;
            this.txtTimSach.Name = "txtTimSach";
            this.txtTimSach.Size = new System.Drawing.Size(285, 32);
            this.txtTimSach.TabIndex = 1;
            // 
            // tet
            // 
            this.tet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tet.AutoSize = true;
            this.tet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tet.Location = new System.Drawing.Point(30, 73);
            this.tet.Name = "tet";
            this.tet.Size = new System.Drawing.Size(73, 18);
            this.tet.TabIndex = 43;
            this.tet.Text = "Tìm kiếm ";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(146)))), ((int)(((byte)(38)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.button1.Location = new System.Drawing.Point(690, 77);
            this.button1.MaximumSize = new System.Drawing.Size(100, 68);
            this.button1.MinimumSize = new System.Drawing.Size(48, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 32);
            this.button1.TabIndex = 46;
            this.button1.Text = "[Sửa]";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 18);
            this.label2.TabIndex = 49;
            this.label2.Text = "mã sách/ tên sách:";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnXoaSach);
            this.guna2Panel1.Controls.Add(this.btnSuaSach);
            this.guna2Panel1.Controls.Add(this.btnLamMoi);
            this.guna2Panel1.Controls.Add(this.btnTimSach);
            this.guna2Panel1.Controls.Add(this.btnThemSach);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.txtTimSach);
            this.guna2Panel1.Controls.Add(this.tet);
            this.guna2Panel1.Controls.Add(this.button1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(800, 184);
            this.guna2Panel1.TabIndex = 50;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.datagridView);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 184);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(800, 266);
            this.guna2Panel2.TabIndex = 51;
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
            this.panel1.Size = new System.Drawing.Size(800, 64);
            this.panel1.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(94)))), ((int)(((byte)(34)))));
            this.label4.Location = new System.Drawing.Point(281, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "ỨNG DỤNG QUẢN LÝ SÁCH";
            // 
            // btnThemSach
            // 
            this.btnThemSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(146)))), ((int)(((byte)(38)))));
            this.btnThemSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemSach.ForeColor = System.Drawing.Color.White;
            this.btnThemSach.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSach.Image")));
            this.btnThemSach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThemSach.Location = new System.Drawing.Point(566, 77);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(107, 31);
            this.btnThemSach.TabIndex = 52;
            this.btnThemSach.Text = "Thêm Sách";
            this.btnThemSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnTimSach
            // 
            this.btnTimSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(146)))), ((int)(((byte)(38)))));
            this.btnTimSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimSach.ForeColor = System.Drawing.Color.White;
            this.btnTimSach.Image = ((System.Drawing.Image)(resources.GetObject("btnTimSach.Image")));
            this.btnTimSach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTimSach.Location = new System.Drawing.Point(149, 115);
            this.btnTimSach.MaximumSize = new System.Drawing.Size(107, 31);
            this.btnTimSach.Name = "btnTimSach";
            this.btnTimSach.Size = new System.Drawing.Size(107, 31);
            this.btnTimSach.TabIndex = 53;
            this.btnTimSach.Text = "Tìm Sách";
            this.btnTimSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamMoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(146)))), ((int)(((byte)(38)))));
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLamMoi.Location = new System.Drawing.Point(689, 78);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(99, 31);
            this.btnLamMoi.TabIndex = 54;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSuaSach
            // 
            this.btnSuaSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(146)))), ((int)(((byte)(38)))));
            this.btnSuaSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSuaSach.ForeColor = System.Drawing.Color.White;
            this.btnSuaSach.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaSach.Image")));
            this.btnSuaSach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSuaSach.Location = new System.Drawing.Point(566, 115);
            this.btnSuaSach.Name = "btnSuaSach";
            this.btnSuaSach.Size = new System.Drawing.Size(107, 31);
            this.btnSuaSach.TabIndex = 54;
            this.btnSuaSach.Text = "Sửa Sách";
            this.btnSuaSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.btnXoaSach.Location = new System.Drawing.Point(689, 115);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(99, 31);
            this.btnXoaSach.TabIndex = 55;
            this.btnXoaSach.Text = "Xóa Sách";
            this.btnXoaSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(764, 2);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(34, 24);
            this.guna2ControlBox3.TabIndex = 5;
            // 
            // FrmQuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQuanLySach";
            this.Text = "FrmQuanLySach";
            this.Load += new System.EventHandler(this.FrmQuanLySach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridView)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridView;
        private System.Windows.Forms.TextBox txtTimSach;
        private System.Windows.Forms.Label tet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnXoaSach;
        private Guna.UI2.WinForms.Guna2Button btnSuaSach;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnTimSach;
        private Guna.UI2.WinForms.Guna2Button btnThemSach;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
    }
}