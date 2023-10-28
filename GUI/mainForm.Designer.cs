namespace GUI
{
    partial class mainForm
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
            this.htmlPanel1 = new MetroFramework.Drawing.Html.HtmlPanel();
            this.chuC_VUTableAdapter1 = new GUI.QLPKTableAdapters.CHUC_VUTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tiếpĐónBệnhNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.htmlPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // htmlPanel1
            // 
            this.htmlPanel1.AutoScroll = true;
            this.htmlPanel1.AutoScrollMinSize = new System.Drawing.Size(285, 23);
            this.htmlPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlPanel1.Controls.Add(this.menuStrip1);
            this.htmlPanel1.Location = new System.Drawing.Point(6, 63);
            this.htmlPanel1.Name = "htmlPanel1";
            this.htmlPanel1.Size = new System.Drawing.Size(285, 549);
            this.htmlPanel1.TabIndex = 0;
            this.htmlPanel1.Text = "htmlPanel1";
            // 
            // chuC_VUTableAdapter1
            // 
            this.chuC_VUTableAdapter1.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(285, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiếpĐónBệnhNhânToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 24);
            this.toolStripMenuItem1.Text = "Quản lý khám bệnh";
            // 
            // tiếpĐónBệnhNhânToolStripMenuItem
            // 
            this.tiếpĐónBệnhNhânToolStripMenuItem.Name = "tiếpĐónBệnhNhânToolStripMenuItem";
            this.tiếpĐónBệnhNhânToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.tiếpĐónBệnhNhânToolStripMenuItem.Text = "Tiếp đón bệnh nhân";
            this.tiếpĐónBệnhNhânToolStripMenuItem.Click += new System.EventHandler(this.tiếpĐónBệnhNhânToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 618);
            this.Controls.Add(this.htmlPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.htmlPanel1.ResumeLayout(false);
            this.htmlPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlPanel htmlPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tiếpĐónBệnhNhânToolStripMenuItem;
        private QLPKTableAdapters.CHUC_VUTableAdapter chuC_VUTableAdapter1;

    }
}