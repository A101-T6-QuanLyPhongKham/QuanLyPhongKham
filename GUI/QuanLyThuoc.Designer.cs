namespace GUI
{
    partial class QuanLyThuoc
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
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.Mathuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Danhmuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donvitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hansudung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nhacungcap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chidinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbType = new MetroFramework.Controls.MetroComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.cbbDVT = new MetroFramework.Controls.MetroComboBox();
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.cbbDate = new MetroFramework.Controls.MetroTextBox();
            this.cbbProvider = new MetroFramework.Controls.MetroComboBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.htmlPanel1 = new MetroFramework.Drawing.Html.HtmlPanel();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.htmlPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mathuoc,
            this.Tenthuoc,
            this.Danhmuc,
            this.Donvitinh,
            this.Soluong,
            this.Dongia,
            this.Hansudung,
            this.Nhacungcap,
            this.Chidinh});
            this.dgvList.Location = new System.Drawing.Point(3, 3);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowTemplate.Height = 24;
            this.dgvList.Size = new System.Drawing.Size(2593, 426);
            this.dgvList.TabIndex = 0;
            this.dgvList.SelectionChanged += new System.EventHandler(this.dgvList_SelectionChanged);
            // 
            // Mathuoc
            // 
            this.Mathuoc.HeaderText = "Mã thuốc";
            this.Mathuoc.Name = "Mathuoc";
            this.Mathuoc.ReadOnly = true;
            // 
            // Tenthuoc
            // 
            this.Tenthuoc.HeaderText = "Tên thuốc";
            this.Tenthuoc.Name = "Tenthuoc";
            this.Tenthuoc.ReadOnly = true;
            // 
            // Danhmuc
            // 
            this.Danhmuc.HeaderText = "Danh mục";
            this.Danhmuc.Name = "Danhmuc";
            this.Danhmuc.ReadOnly = true;
            // 
            // Donvitinh
            // 
            this.Donvitinh.HeaderText = "Đơn vị tính";
            this.Donvitinh.Name = "Donvitinh";
            this.Donvitinh.ReadOnly = true;
            // 
            // Soluong
            // 
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.Name = "Soluong";
            this.Soluong.ReadOnly = true;
            // 
            // Dongia
            // 
            this.Dongia.HeaderText = "Đơn giá";
            this.Dongia.Name = "Dongia";
            this.Dongia.ReadOnly = true;
            // 
            // Hansudung
            // 
            this.Hansudung.HeaderText = "Hạn sử dụng";
            this.Hansudung.Name = "Hansudung";
            this.Hansudung.ReadOnly = true;
            // 
            // Nhacungcap
            // 
            this.Nhacungcap.HeaderText = "Nhà cung cấp";
            this.Nhacungcap.Name = "Nhacungcap";
            this.Nhacungcap.ReadOnly = true;
            // 
            // Chidinh
            // 
            this.Chidinh.HeaderText = "Chỉ định";
            this.Chidinh.Name = "Chidinh";
            this.Chidinh.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đơn vị tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hạn sử dụng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhà cung cấp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Đơn giá";
            // 
            // cbbType
            // 
            this.cbbType.FormattingEnabled = true;
            this.cbbType.ItemHeight = 24;
            this.cbbType.Location = new System.Drawing.Point(174, 90);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(216, 30);
            this.cbbType.TabIndex = 6;
            this.cbbType.UseSelectable = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Danh mục";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(901, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Chỉ định";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(174, 30);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(215, 23);
            this.txtName.TabIndex = 9;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbbDVT
            // 
            this.cbbDVT.FormattingEnabled = true;
            this.cbbDVT.ItemHeight = 24;
            this.cbbDVT.Items.AddRange(new object[] {
            "Viên",
            "Chai",
            "Lọ",
            "Gói",
            "Tuýp",
            "Ống"});
            this.cbbDVT.Location = new System.Drawing.Point(174, 162);
            this.cbbDVT.Name = "cbbDVT";
            this.cbbDVT.Size = new System.Drawing.Size(219, 30);
            this.cbbDVT.TabIndex = 10;
            this.cbbDVT.UseSelectable = true;
            // 
            // txtPrice
            // 
            // 
            // 
            // 
            this.txtPrice.CustomButton.Image = null;
            this.txtPrice.CustomButton.Location = new System.Drawing.Point(211, 1);
            this.txtPrice.CustomButton.Name = "";
            this.txtPrice.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrice.CustomButton.TabIndex = 1;
            this.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrice.CustomButton.UseSelectable = true;
            this.txtPrice.CustomButton.Visible = false;
            this.txtPrice.Lines = new string[0];
            this.txtPrice.Location = new System.Drawing.Point(584, 30);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(239, 29);
            this.txtPrice.TabIndex = 11;
            this.txtPrice.UseSelectable = true;
            this.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbbDate
            // 
            // 
            // 
            // 
            this.cbbDate.CustomButton.Image = null;
            this.cbbDate.CustomButton.Location = new System.Drawing.Point(219, 2);
            this.cbbDate.CustomButton.Name = "";
            this.cbbDate.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.cbbDate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbbDate.CustomButton.TabIndex = 1;
            this.cbbDate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbbDate.CustomButton.UseSelectable = true;
            this.cbbDate.CustomButton.Visible = false;
            this.cbbDate.Lines = new string[0];
            this.cbbDate.Location = new System.Drawing.Point(584, 99);
            this.cbbDate.MaxLength = 32767;
            this.cbbDate.Name = "cbbDate";
            this.cbbDate.PasswordChar = '\0';
            this.cbbDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cbbDate.SelectedText = "";
            this.cbbDate.SelectionLength = 0;
            this.cbbDate.SelectionStart = 0;
            this.cbbDate.ShortcutsEnabled = true;
            this.cbbDate.Size = new System.Drawing.Size(239, 22);
            this.cbbDate.TabIndex = 12;
            this.cbbDate.UseSelectable = true;
            this.cbbDate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbbDate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbbProvider
            // 
            this.cbbProvider.FormattingEnabled = true;
            this.cbbProvider.ItemHeight = 24;
            this.cbbProvider.Location = new System.Drawing.Point(584, 152);
            this.cbbProvider.Name = "cbbProvider";
            this.cbbProvider.Size = new System.Drawing.Size(239, 30);
            this.cbbProvider.TabIndex = 13;
            this.cbbProvider.UseSelectable = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(993, 81);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(350, 152);
            this.txtDescription.TabIndex = 14;
            this.txtDescription.Text = "";
            // 
            // htmlPanel1
            // 
            this.htmlPanel1.AutoScroll = true;
            this.htmlPanel1.AutoScrollMinSize = new System.Drawing.Size(1463, 23);
            this.htmlPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlPanel1.Controls.Add(this.label8);
            this.htmlPanel1.Controls.Add(this.txtCode);
            this.htmlPanel1.Controls.Add(this.txtDescription);
            this.htmlPanel1.Controls.Add(this.cbbProvider);
            this.htmlPanel1.Controls.Add(this.cbbDate);
            this.htmlPanel1.Controls.Add(this.txtPrice);
            this.htmlPanel1.Controls.Add(this.cbbDVT);
            this.htmlPanel1.Controls.Add(this.txtName);
            this.htmlPanel1.Controls.Add(this.label7);
            this.htmlPanel1.Controls.Add(this.label6);
            this.htmlPanel1.Controls.Add(this.cbbType);
            this.htmlPanel1.Controls.Add(this.label5);
            this.htmlPanel1.Controls.Add(this.label4);
            this.htmlPanel1.Controls.Add(this.label3);
            this.htmlPanel1.Controls.Add(this.label2);
            this.htmlPanel1.Controls.Add(this.label1);
            this.htmlPanel1.Location = new System.Drawing.Point(82, 462);
            this.htmlPanel1.Name = "htmlPanel1";
            this.htmlPanel1.Size = new System.Drawing.Size(1450, 271);
            this.htmlPanel1.TabIndex = 15;
            this.htmlPanel1.Text = "Thông tin thuốc";
            this.htmlPanel1.Click += new System.EventHandler(this.htmlPanel1_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(993, 19);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(353, 22);
            this.txtCode.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(894, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Mã thuốc";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(486, 766);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 50);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Fuchsia;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(782, 766);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 50);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.HotPink;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(1054, 766);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 50);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // QuanLyThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.htmlPanel1);
            this.Controls.Add(this.dgvList);
            this.Name = "QuanLyThuoc";
            this.Size = new System.Drawing.Size(2000, 874);
            this.Load += new System.EventHandler(this.QuanLyThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.htmlPanel1.ResumeLayout(false);
            this.htmlPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroComboBox cbbType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroComboBox cbbDVT;
        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroTextBox cbbDate;
        private MetroFramework.Controls.MetroComboBox cbbProvider;
        private System.Windows.Forms.RichTextBox txtDescription;
        private MetroFramework.Drawing.Html.HtmlPanel htmlPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mathuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Danhmuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donvitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hansudung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nhacungcap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chidinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}