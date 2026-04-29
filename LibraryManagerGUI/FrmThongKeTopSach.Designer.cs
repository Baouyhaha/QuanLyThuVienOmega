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
            this.SuspendLayout();
            // 
            // rpTop10SP
            // 
            this.rpTop10SP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpTop10SP.Location = new System.Drawing.Point(0, 0);
            this.rpTop10SP.Name = "rpTop10SP";
            this.rpTop10SP.ServerReport.BearerToken = null;
            this.rpTop10SP.Size = new System.Drawing.Size(800, 450);
            this.rpTop10SP.TabIndex = 0;
            // 
            // FrmThongKeTopSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpTop10SP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmThongKeTopSach";
            this.Text = "FrmThongKeTopSach";
            this.Load += new System.EventHandler(this.FrmThongKeTopSach_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpTop10SP;
    }
}