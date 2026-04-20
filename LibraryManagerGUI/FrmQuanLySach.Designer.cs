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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLySach));
            this.dgvDanhSachSach = new System.Windows.Forms.DataGridView();
            this.tet = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnXoaSach = new Guna.UI2.WinForms.Guna2Button();
            this.btnMoFrmSuaSach = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimSach = new Guna.UI2.WinForms.Guna2Button();
            this.btnMoFrmThemSach = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtTimSach = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSach)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhSachSach
            // 
            this.dgvDanhSachSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachSach.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhSachSach.Name = "dgvDanhSachSach";
            this.dgvDanhSachSach.ReadOnly = true;
            this.dgvDanhSachSach.RowHeadersWidth = 51;
            this.dgvDanhSachSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachSach.Size = new System.Drawing.Size(800, 266);
            this.dgvDanhSachSach.TabIndex = 0;
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
            this.guna2Panel1.Controls.Add(this.txtTimSach);
            this.guna2Panel1.Controls.Add(this.btnXoaSach);
            this.guna2Panel1.Controls.Add(this.btnMoFrmSuaSach);
            this.guna2Panel1.Controls.Add(this.btnLamMoi);
            this.guna2Panel1.Controls.Add(this.btnTimSach);
            this.guna2Panel1.Controls.Add(this.btnMoFrmThemSach);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.tet);
            this.guna2Panel1.Controls.Add(this.button1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(800, 184);
            this.guna2Panel1.TabIndex = 50;
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
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // btnMoFrmSuaSach
            // 
            this.btnMoFrmSuaSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoFrmSuaSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMoFrmSuaSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMoFrmSuaSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMoFrmSuaSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMoFrmSuaSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(146)))), ((int)(((byte)(38)))));
            this.btnMoFrmSuaSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMoFrmSuaSach.ForeColor = System.Drawing.Color.White;
            this.btnMoFrmSuaSach.Image = ((System.Drawing.Image)(resources.GetObject("btnMoFrmSuaSach.Image")));
            this.btnMoFrmSuaSach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMoFrmSuaSach.Location = new System.Drawing.Point(566, 115);
            this.btnMoFrmSuaSach.Name = "btnMoFrmSuaSach";
            this.btnMoFrmSuaSach.Size = new System.Drawing.Size(107, 31);
            this.btnMoFrmSuaSach.TabIndex = 54;
            this.btnMoFrmSuaSach.Text = "Sửa Sách";
            this.btnMoFrmSuaSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnMoFrmSuaSach.Click += new System.EventHandler(this.btnMoFrmSuaSach_Click);
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
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
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
            this.btnTimSach.Size = new System.Drawing.Size(103, 31);
            this.btnTimSach.TabIndex = 53;
            this.btnTimSach.Text = "Tìm Sách";
            this.btnTimSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnTimSach.Click += new System.EventHandler(this.btnTimSach_Click);
            // 
            // btnMoFrmThemSach
            // 
            this.btnMoFrmThemSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoFrmThemSach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMoFrmThemSach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMoFrmThemSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMoFrmThemSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMoFrmThemSach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(146)))), ((int)(((byte)(38)))));
            this.btnMoFrmThemSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMoFrmThemSach.ForeColor = System.Drawing.Color.White;
            this.btnMoFrmThemSach.Image = ((System.Drawing.Image)(resources.GetObject("btnMoFrmThemSach.Image")));
            this.btnMoFrmThemSach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMoFrmThemSach.Location = new System.Drawing.Point(566, 77);
            this.btnMoFrmThemSach.Name = "btnMoFrmThemSach";
            this.btnMoFrmThemSach.Size = new System.Drawing.Size(107, 31);
            this.btnMoFrmThemSach.TabIndex = 52;
            this.btnMoFrmThemSach.Text = "Thêm Sách";
            this.btnMoFrmThemSach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnMoFrmThemSach.Click += new System.EventHandler(this.btnMoFrmThemSach_Click);
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
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(764, 2);
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
            this.label4.Location = new System.Drawing.Point(281, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "ỨNG DỤNG QUẢN LÝ SÁCH";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.dgvDanhSachSach);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 184);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(800, 266);
            this.guna2Panel2.TabIndex = 51;
            // 
            // txtTimSach
            // 
            this.txtTimSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimSach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimSach.DefaultText = "";
            this.txtTimSach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimSach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimSach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimSach.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimSach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimSach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimSach.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimSach.Location = new System.Drawing.Point(149, 78);
            this.txtTimSach.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTimSach.Name = "txtTimSach";
            this.txtTimSach.PlaceholderText = "";
            this.txtTimSach.SelectedText = "";
            this.txtTimSach.Size = new System.Drawing.Size(330, 34);
            this.txtTimSach.TabIndex = 56;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSach)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachSach;
        private System.Windows.Forms.Label tet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnXoaSach;
        private Guna.UI2.WinForms.Guna2Button btnMoFrmSuaSach;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnTimSach;
        private Guna.UI2.WinForms.Guna2Button btnMoFrmThemSach;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2TextBox txtTimSach;
    }
}