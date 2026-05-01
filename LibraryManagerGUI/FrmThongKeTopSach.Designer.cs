namespace LibraryManagerGUI
{
    partial class FrmThongKeTopSach
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
            this.rpTop10SP = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SuspendLayout();
            // 
            // rpTop10SP
            // 
            this.rpTop10SP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpTop10SP.Location = new System.Drawing.Point(0, 0);
            this.rpTop10SP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rpTop10SP.Name = "rpTop10SP";
            this.rpTop10SP.ServerReport.BearerToken = null;
            this.rpTop10SP.Size = new System.Drawing.Size(1067, 554);
            this.rpTop10SP.TabIndex = 0;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1001, 11);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox3.TabIndex = 5;
            // 
            // FrmThongKeTopSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.rpTop10SP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmThongKeTopSach";
            this.Text = "FrmThongKeTopSach";
            this.Load += new System.EventHandler(this.FrmThongKeTopSach_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpTop10SP;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
    }
}