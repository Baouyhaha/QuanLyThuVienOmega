namespace LibraryManagerGUI
{
    partial class FrmQuanLyTheMuon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTheMuon = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMoFrmThemThe = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimThe = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnMoFrmSuaThe = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaThe = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cmbLocTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnLocChoDuyet = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheMuon)).BeginInit();
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTheMuon
            // 
            this.dgvTheMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTheMuon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTheMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTheMuon.Location = new System.Drawing.Point(0, 226);
            this.dgvTheMuon.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTheMuon.Name = "dgvTheMuon";
            this.dgvTheMuon.ReadOnly = true;
            this.dgvTheMuon.RowHeadersWidth = 51;
            this.dgvTheMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTheMuon.Size = new System.Drawing.Size(1111, 423);
            this.dgvTheMuon.TabIndex = 52;
            this.dgvTheMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTheMuon_CellClick);
            this.dgvTheMuon.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTheMuon_CellFormatting);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(146)))), ((int)(((byte)(38)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.button1.Location = new System.Drawing.Point(964, 95);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.MaximumSize = new System.Drawing.Size(133, 84);
            this.button1.MinimumSize = new System.Drawing.Size(64, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 39);
            this.button1.TabIndex = 46;
            this.button1.Text = "[Sửa]";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tet
            // 
            this.tet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tet.AutoSize = true;
            this.tet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tet.Location = new System.Drawing.Point(40, 90);
            this.tet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tet.Name = "tet";
            this.tet.Size = new System.Drawing.Size(92, 24);
            this.tet.TabIndex = 43;
            this.tet.Text = "Tìm kiếm ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 49;
            this.label2.Text = "Mã thẻ mượn/";
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
            this.panel1.Size = new System.Drawing.Size(1111, 79);
            this.panel1.TabIndex = 50;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1063, 2);
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
            this.label4.Location = new System.Drawing.Point(397, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "CHỨC NĂNG QUẢN LÝ THẺ MƯỢN";
            // 
            // btnMoFrmThemThe
            // 
            this.btnMoFrmThemThe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoFrmThemThe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMoFrmThemThe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMoFrmThemThe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMoFrmThemThe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMoFrmThemThe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(146)))), ((int)(((byte)(38)))));
            this.btnMoFrmThemThe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMoFrmThemThe.ForeColor = System.Drawing.Color.White;
            this.btnMoFrmThemThe.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMoFrmThemThe.Location = new System.Drawing.Point(799, 95);
            this.btnMoFrmThemThe.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoFrmThemThe.Name = "btnMoFrmThemThe";
            this.btnMoFrmThemThe.Size = new System.Drawing.Size(143, 38);
            this.btnMoFrmThemThe.TabIndex = 52;
            this.btnMoFrmThemThe.Text = "Thêm thẻ";
            this.btnMoFrmThemThe.Click += new System.EventHandler(this.btnMoFrmThemThe_Click);
            // 
            // btnTimThe
            // 
            this.btnTimThe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimThe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimThe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimThe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimThe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(146)))), ((int)(((byte)(38)))));
            this.btnTimThe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimThe.ForeColor = System.Drawing.Color.White;
            this.btnTimThe.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTimThe.Location = new System.Drawing.Point(199, 142);
            this.btnTimThe.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimThe.MaximumSize = new System.Drawing.Size(143, 38);
            this.btnTimThe.Name = "btnTimThe";
            this.btnTimThe.Size = new System.Drawing.Size(137, 38);
            this.btnTimThe.TabIndex = 53;
            this.btnTimThe.Text = "Tìm Thẻ mượn";
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
            this.btnLamMoi.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLamMoi.Location = new System.Drawing.Point(963, 96);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(132, 38);
            this.btnLamMoi.TabIndex = 54;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnMoFrmSuaThe
            // 
            this.btnMoFrmSuaThe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoFrmSuaThe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMoFrmSuaThe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMoFrmSuaThe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMoFrmSuaThe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMoFrmSuaThe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(146)))), ((int)(((byte)(38)))));
            this.btnMoFrmSuaThe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMoFrmSuaThe.ForeColor = System.Drawing.Color.White;
            this.btnMoFrmSuaThe.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMoFrmSuaThe.Location = new System.Drawing.Point(799, 142);
            this.btnMoFrmSuaThe.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoFrmSuaThe.Name = "btnMoFrmSuaThe";
            this.btnMoFrmSuaThe.Size = new System.Drawing.Size(143, 38);
            this.btnMoFrmSuaThe.TabIndex = 54;
            this.btnMoFrmSuaThe.Text = "Sửa thẻ";
            this.btnMoFrmSuaThe.Click += new System.EventHandler(this.btnMoFrmSuaThe_Click);
            // 
            // btnXoaThe
            // 
            this.btnXoaThe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaThe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaThe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaThe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaThe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaThe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(146)))), ((int)(((byte)(38)))));
            this.btnXoaThe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaThe.ForeColor = System.Drawing.Color.White;
            this.btnXoaThe.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXoaThe.Location = new System.Drawing.Point(963, 142);
            this.btnXoaThe.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaThe.Name = "btnXoaThe";
            this.btnXoaThe.Size = new System.Drawing.Size(132, 38);
            this.btnXoaThe.TabIndex = 55;
            this.btnXoaThe.Text = "Xóa Thẻ";
            this.btnXoaThe.Click += new System.EventHandler(this.btnXoaThe_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Location = new System.Drawing.Point(199, 96);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiem.MaximumSize = new System.Drawing.Size(1500, 38);
            this.txtTimKiem.MinimumSize = new System.Drawing.Size(300, 38);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(593, 38);
            this.txtTimKiem.TabIndex = 56;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimSach_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 57;
            this.label1.Text = "Tên thẻ mượn";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.cmbLocTrangThai);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.txtTimKiem);
            this.guna2Panel1.Controls.Add(this.btnXoaThe);
            this.guna2Panel1.Controls.Add(this.btnMoFrmSuaThe);
            this.guna2Panel1.Controls.Add(this.btnLamMoi);
            this.guna2Panel1.Controls.Add(this.btnLocChoDuyet);
            this.guna2Panel1.Controls.Add(this.btnTimThe);
            this.guna2Panel1.Controls.Add(this.btnMoFrmThemThe);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.tet);
            this.guna2Panel1.Controls.Add(this.button1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1111, 226);
            this.guna2Panel1.TabIndex = 51;
            // 
            // cmbLocTrangThai
            // 
            this.cmbLocTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cmbLocTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLocTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocTrangThai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLocTrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLocTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbLocTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbLocTrangThai.ItemHeight = 30;
            this.cmbLocTrangThai.Location = new System.Drawing.Point(381, 141);
            this.cmbLocTrangThai.Name = "cmbLocTrangThai";
            this.cmbLocTrangThai.Size = new System.Drawing.Size(140, 36);
            this.cmbLocTrangThai.TabIndex = 58;
            this.cmbLocTrangThai.SelectedIndexChanged += new System.EventHandler(this.cmbLocTrangThai_SelectedIndexChanged);
            // 
            // btnLocChoDuyet
            // 
            this.btnLocChoDuyet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLocChoDuyet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLocChoDuyet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLocChoDuyet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLocChoDuyet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLocChoDuyet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(146)))), ((int)(((byte)(38)))));
            this.btnLocChoDuyet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLocChoDuyet.ForeColor = System.Drawing.Color.White;
            this.btnLocChoDuyet.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLocChoDuyet.Location = new System.Drawing.Point(564, 139);
            this.btnLocChoDuyet.Margin = new System.Windows.Forms.Padding(4);
            this.btnLocChoDuyet.MaximumSize = new System.Drawing.Size(143, 38);
            this.btnLocChoDuyet.Name = "btnLocChoDuyet";
            this.btnLocChoDuyet.Size = new System.Drawing.Size(137, 38);
            this.btnLocChoDuyet.TabIndex = 53;
            this.btnLocChoDuyet.Text = "Xem yêu cầu";
            this.btnLocChoDuyet.Click += new System.EventHandler(this.btnLocChoDuyet_Click);
            // 
            // FrmQuanLyTheMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 649);
            this.Controls.Add(this.dgvTheMuon);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQuanLyTheMuon";
            this.Text = "FrmQuanLyTheMuon";
            this.Load += new System.EventHandler(this.FrmQuanLyTheMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheMuon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTheMuon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label tet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnMoFrmThemThe;
        private Guna.UI2.WinForms.Guna2Button btnTimThe;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnMoFrmSuaThe;
        private Guna.UI2.WinForms.Guna2Button btnXoaThe;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbLocTrangThai;
        private Guna.UI2.WinForms.Guna2Button btnLocChoDuyet;
    }
}