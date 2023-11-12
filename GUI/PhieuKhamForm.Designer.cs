namespace GUI
{
    partial class PhieuKhamForm
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
            this.rptPhieuKham = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            this.viewrpt = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // viewrpt
            // 
            this.viewrpt.ActiveViewIndex = -1;
            this.viewrpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewrpt.Cursor = System.Windows.Forms.Cursors.Default;
            this.viewrpt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewrpt.Location = new System.Drawing.Point(0, 0);
            this.viewrpt.Name = "viewrpt";
            this.viewrpt.Size = new System.Drawing.Size(715, 490);
            this.viewrpt.TabIndex = 0;
            // 
            // PhieuKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 490);
            this.Controls.Add(this.viewrpt);
            this.Name = "PhieuKham";
            this.Text = "PhieuKham";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.CrystalReports.Engine.ReportDocument rptPhieuKham;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer viewrpt;
    }
}