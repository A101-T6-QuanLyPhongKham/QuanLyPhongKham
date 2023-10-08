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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nguoiDungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhómNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcMànHìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phânQuyềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmNgườiDùngVàoNhómToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(867, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(867, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nguoiDungToolStripMenuItem,
            this.nhómNgườiDùngToolStripMenuItem,
            this.danhMụcMànHìnhToolStripMenuItem,
            this.phânQuyềnToolStripMenuItem,
            this.thêmNgườiDùngVàoNhómToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(83, 24);
            this.toolStripMenuItem1.Text = "Hệ thống";
            // 
            // nguoiDungToolStripMenuItem
            // 
            this.nguoiDungToolStripMenuItem.Name = "nguoiDungToolStripMenuItem";
            this.nguoiDungToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.nguoiDungToolStripMenuItem.Tag = "SF001";
            this.nguoiDungToolStripMenuItem.Text = "Người dùng";
            this.nguoiDungToolStripMenuItem.Click += new System.EventHandler(this.nguoiDungToolStripMenuItem_Click);
            // 
            // nhómNgườiDùngToolStripMenuItem
            // 
            this.nhómNgườiDùngToolStripMenuItem.Name = "nhómNgườiDùngToolStripMenuItem";
            this.nhómNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.nhómNgườiDùngToolStripMenuItem.Tag = "SF002";
            this.nhómNgườiDùngToolStripMenuItem.Text = "Nhóm người dùng";
            // 
            // danhMụcMànHìnhToolStripMenuItem
            // 
            this.danhMụcMànHìnhToolStripMenuItem.Name = "danhMụcMànHìnhToolStripMenuItem";
            this.danhMụcMànHìnhToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.danhMụcMànHìnhToolStripMenuItem.Tag = "SF003";
            this.danhMụcMànHìnhToolStripMenuItem.Text = "Danh mục màn hình";
            this.danhMụcMànHìnhToolStripMenuItem.Click += new System.EventHandler(this.danhMụcMànHìnhToolStripMenuItem_Click);
            // 
            // phânQuyềnToolStripMenuItem
            // 
            this.phânQuyềnToolStripMenuItem.Name = "phânQuyềnToolStripMenuItem";
            this.phânQuyềnToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.phânQuyềnToolStripMenuItem.Tag = "SF004";
            this.phânQuyềnToolStripMenuItem.Text = "Phân quyền";
            this.phânQuyềnToolStripMenuItem.Click += new System.EventHandler(this.phânQuyềnToolStripMenuItem_Click);
            // 
            // thêmNgườiDùngVàoNhómToolStripMenuItem
            // 
            this.thêmNgườiDùngVàoNhómToolStripMenuItem.Name = "thêmNgườiDùngVàoNhómToolStripMenuItem";
            this.thêmNgườiDùngVàoNhómToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.thêmNgườiDùngVàoNhómToolStripMenuItem.Tag = "SF005";
            this.thêmNgườiDùngVàoNhómToolStripMenuItem.Text = "Thêm người dùng vào nhóm";
            this.thêmNgườiDùngVàoNhómToolStripMenuItem.Click += new System.EventHandler(this.thêmNgườiDùngVàoNhómToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 496);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nguoiDungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhómNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcMànHìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phânQuyềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmNgườiDùngVàoNhómToolStripMenuItem;
    }
}