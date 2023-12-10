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
            this.cbbType = new MetroFramework.Controls.MetroComboBox();
            this.cbbDVT = new MetroFramework.Controls.MetroComboBox();
            this.cbbProvider = new MetroFramework.Controls.MetroComboBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.htmlPanel1 = new MetroFramework.Drawing.Html.HtmlPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cT_Label6 = new CustomControl.CT_Label();
            this.cT_Label5 = new CustomControl.CT_Label();
            this.cT_Label7 = new CustomControl.CT_Label();
            this.cT_Label4 = new CustomControl.CT_Label();
            this.cT_Label8 = new CustomControl.CT_Label();
            this.cT_Label3 = new CustomControl.CT_Label();
            this.cT_Label2 = new CustomControl.CT_Label();
            this.txtCode = new CustomControl.CT_TextBox();
            this.cbbDate = new CustomControl.CT_TextBox();
            this.txtPrice = new CustomControl.CT_TextBox();
            this.cT_Label1 = new CustomControl.CT_Label();
            this.txtName = new CustomControl.CT_TextBox();
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
            this.dgvList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvList_CellFormatting);
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
            this.Dongia.HeaderText = "Đơn giá (Đồng)";
            this.Dongia.Name = "Dongia";
            this.Dongia.ReadOnly = true;
            // 
            // Hansudung
            // 
            this.Hansudung.HeaderText = "Hạn sử dụng (Tháng)";
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
            // cbbType
            // 
            this.cbbType.FormattingEnabled = true;
            this.cbbType.ItemHeight = 24;
            this.cbbType.Location = new System.Drawing.Point(171, 115);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(347, 30);
            this.cbbType.TabIndex = 6;
            this.cbbType.UseSelectable = true;
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
            this.cbbDVT.Location = new System.Drawing.Point(171, 197);
            this.cbbDVT.Name = "cbbDVT";
            this.cbbDVT.Size = new System.Drawing.Size(347, 30);
            this.cbbDVT.TabIndex = 10;
            this.cbbDVT.UseSelectable = true;
            // 
            // cbbProvider
            // 
            this.cbbProvider.FormattingEnabled = true;
            this.cbbProvider.ItemHeight = 24;
            this.cbbProvider.Location = new System.Drawing.Point(734, 195);
            this.cbbProvider.Name = "cbbProvider";
            this.cbbProvider.Size = new System.Drawing.Size(347, 30);
            this.cbbProvider.TabIndex = 13;
            this.cbbProvider.UseSelectable = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(1283, 94);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(347, 152);
            this.txtDescription.TabIndex = 14;
            this.txtDescription.Text = "";
            // 
            // htmlPanel1
            // 
            this.htmlPanel1.AutoScroll = true;
            this.htmlPanel1.AutoScrollMinSize = new System.Drawing.Size(1682, 23);
            this.htmlPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlPanel1.Controls.Add(this.label2);
            this.htmlPanel1.Controls.Add(this.label1);
            this.htmlPanel1.Controls.Add(this.cT_Label6);
            this.htmlPanel1.Controls.Add(this.cT_Label5);
            this.htmlPanel1.Controls.Add(this.cT_Label7);
            this.htmlPanel1.Controls.Add(this.cT_Label4);
            this.htmlPanel1.Controls.Add(this.cT_Label8);
            this.htmlPanel1.Controls.Add(this.cT_Label3);
            this.htmlPanel1.Controls.Add(this.cT_Label2);
            this.htmlPanel1.Controls.Add(this.txtCode);
            this.htmlPanel1.Controls.Add(this.cbbDate);
            this.htmlPanel1.Controls.Add(this.txtPrice);
            this.htmlPanel1.Controls.Add(this.cT_Label1);
            this.htmlPanel1.Controls.Add(this.txtName);
            this.htmlPanel1.Controls.Add(this.txtDescription);
            this.htmlPanel1.Controls.Add(this.cbbProvider);
            this.htmlPanel1.Controls.Add(this.cbbDVT);
            this.htmlPanel1.Controls.Add(this.cbbType);
            this.htmlPanel1.Location = new System.Drawing.Point(252, 479);
            this.htmlPanel1.Name = "htmlPanel1";
            this.htmlPanel1.Size = new System.Drawing.Size(1682, 271);
            this.htmlPanel1.TabIndex = 15;
            this.htmlPanel1.Text = "Thông tin thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(588, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "(Tháng)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(590, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "(Đồng)";
            // 
            // cT_Label6
            // 
            this.cT_Label6.AutoSize = true;
            this.cT_Label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cT_Label6.Location = new System.Drawing.Point(1129, 113);
            this.cT_Label6.Name = "cT_Label6";
            this.cT_Label6.Size = new System.Drawing.Size(79, 23);
            this.cT_Label6.TabIndex = 26;
            this.cT_Label6.Text = "Chỉ định";
            // 
            // cT_Label5
            // 
            this.cT_Label5.AutoSize = true;
            this.cT_Label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cT_Label5.Location = new System.Drawing.Point(569, 113);
            this.cT_Label5.Name = "cT_Label5";
            this.cT_Label5.Size = new System.Drawing.Size(115, 23);
            this.cT_Label5.TabIndex = 25;
            this.cT_Label5.Text = "Hạn sử dụng";
            // 
            // cT_Label7
            // 
            this.cT_Label7.AutoSize = true;
            this.cT_Label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cT_Label7.Location = new System.Drawing.Point(1129, 45);
            this.cT_Label7.Name = "cT_Label7";
            this.cT_Label7.Size = new System.Drawing.Size(89, 23);
            this.cT_Label7.TabIndex = 27;
            this.cT_Label7.Text = "Mã thuốc";
            // 
            // cT_Label4
            // 
            this.cT_Label4.AutoSize = true;
            this.cT_Label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cT_Label4.Location = new System.Drawing.Point(580, 38);
            this.cT_Label4.Name = "cT_Label4";
            this.cT_Label4.Size = new System.Drawing.Size(80, 23);
            this.cT_Label4.TabIndex = 24;
            this.cT_Label4.Text = "Đơn giá ";
            // 
            // cT_Label8
            // 
            this.cT_Label8.AutoSize = true;
            this.cT_Label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cT_Label8.Location = new System.Drawing.Point(569, 193);
            this.cT_Label8.Name = "cT_Label8";
            this.cT_Label8.Size = new System.Drawing.Size(122, 23);
            this.cT_Label8.TabIndex = 28;
            this.cT_Label8.Text = "Nhà cung cấp";
            // 
            // cT_Label3
            // 
            this.cT_Label3.AutoSize = true;
            this.cT_Label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cT_Label3.Location = new System.Drawing.Point(20, 195);
            this.cT_Label3.Name = "cT_Label3";
            this.cT_Label3.Size = new System.Drawing.Size(103, 23);
            this.cT_Label3.TabIndex = 23;
            this.cT_Label3.Text = "Đơn vị tính";
            // 
            // cT_Label2
            // 
            this.cT_Label2.AutoSize = true;
            this.cT_Label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cT_Label2.Location = new System.Drawing.Point(20, 117);
            this.cT_Label2.Name = "cT_Label2";
            this.cT_Label2.Size = new System.Drawing.Size(93, 23);
            this.cT_Label2.TabIndex = 22;
            this.cT_Label2.Text = "Danh mục";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtCode.Location = new System.Drawing.Point(1283, 34);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(347, 30);
            this.txtCode.TabIndex = 21;
            // 
            // cbbDate
            // 
            this.cbbDate.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cbbDate.Location = new System.Drawing.Point(734, 113);
            this.cbbDate.Name = "cbbDate";
            this.cbbDate.Size = new System.Drawing.Size(347, 30);
            this.cbbDate.TabIndex = 20;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtPrice.Location = new System.Drawing.Point(734, 38);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(347, 30);
            this.txtPrice.TabIndex = 19;
            // 
            // cT_Label1
            // 
            this.cT_Label1.AutoSize = true;
            this.cT_Label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cT_Label1.Location = new System.Drawing.Point(20, 36);
            this.cT_Label1.Name = "cT_Label1";
            this.cT_Label1.Size = new System.Drawing.Size(93, 23);
            this.cT_Label1.TabIndex = 18;
            this.cT_Label1.Text = "Tên thuốc";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtName.Location = new System.Drawing.Point(171, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(347, 30);
            this.txtName.TabIndex = 17;
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
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
        private MetroFramework.Controls.MetroComboBox cbbType;
        private MetroFramework.Controls.MetroComboBox cbbDVT;
        private MetroFramework.Controls.MetroComboBox cbbProvider;
        private System.Windows.Forms.RichTextBox txtDescription;
        private MetroFramework.Drawing.Html.HtmlPanel htmlPanel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mathuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Danhmuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donvitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hansudung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nhacungcap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chidinh;
        private CustomControl.CT_TextBox txtName;
        private CustomControl.CT_Label cT_Label1;
        private CustomControl.CT_Label cT_Label6;
        private CustomControl.CT_Label cT_Label5;
        private CustomControl.CT_Label cT_Label7;
        private CustomControl.CT_Label cT_Label4;
        private CustomControl.CT_Label cT_Label8;
        private CustomControl.CT_Label cT_Label3;
        private CustomControl.CT_Label cT_Label2;
        private CustomControl.CT_TextBox txtCode;
        private CustomControl.CT_TextBox cbbDate;
        private CustomControl.CT_TextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}