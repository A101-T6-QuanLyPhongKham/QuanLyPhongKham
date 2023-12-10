namespace GUI
{
    partial class PrescriptionForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbbCategory = new MetroFramework.Controls.MetroComboBox();
            this.dateReturnpicker = new System.Windows.Forms.DateTimePicker();
            this.txtReminder = new System.Windows.Forms.RichTextBox();
            this.cT_Label1 = new CustomControl.CT_Label();
            this.cT_Label2 = new CustomControl.CT_Label();
            this.cT_Label3 = new CustomControl.CT_Label();
            this.btnFind = new CustomControl.CT_Button();
            this.btnAdd = new CustomControl.CT_Button();
            this.btnReset = new CustomControl.CT_Button();
            this.btnPrint = new CustomControl.CT_Button();
            this.btnDelete = new CustomControl.CT_Button();
            this.cT_Label4 = new CustomControl.CT_Label();
            this.dgvListWithCategory = new CustomControl.CT_DataGrid();
            this.dgvPrescription = new CustomControl.CT_DataGrid();
            this.txtInput = new CustomControl.CT_TextBox();
            this.cT_Label5 = new CustomControl.CT_Label();
            this.cT_Label6 = new CustomControl.CT_Label();
            this.MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiDinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListWithCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescription)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbCategory
            // 
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.ItemHeight = 24;
            this.cbbCategory.Location = new System.Drawing.Point(480, 63);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(370, 30);
            this.cbbCategory.TabIndex = 0;
            this.cbbCategory.UseSelectable = true;
            this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged);
            // 
            // dateReturnpicker
            // 
            this.dateReturnpicker.Location = new System.Drawing.Point(97, 415);
            this.dateReturnpicker.Name = "dateReturnpicker";
            this.dateReturnpicker.Size = new System.Drawing.Size(342, 22);
            this.dateReturnpicker.TabIndex = 24;
            // 
            // txtReminder
            // 
            this.txtReminder.Location = new System.Drawing.Point(97, 515);
            this.txtReminder.Name = "txtReminder";
            this.txtReminder.Size = new System.Drawing.Size(342, 346);
            this.txtReminder.TabIndex = 25;
            this.txtReminder.Text = "";
            // 
            // cT_Label1
            // 
            this.cT_Label1.AutoSize = true;
            this.cT_Label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cT_Label1.Location = new System.Drawing.Point(596, 22);
            this.cT_Label1.Name = "cT_Label1";
            this.cT_Label1.Size = new System.Drawing.Size(144, 23);
            this.cT_Label1.TabIndex = 27;
            this.cT_Label1.Text = "Danh mục thuốc";
            // 
            // cT_Label2
            // 
            this.cT_Label2.AutoSize = true;
            this.cT_Label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cT_Label2.Location = new System.Drawing.Point(1193, 22);
            this.cT_Label2.Name = "cT_Label2";
            this.cT_Label2.Size = new System.Drawing.Size(168, 23);
            this.cT_Label2.TabIndex = 28;
            this.cT_Label2.Text = "Tìm theo tên thuốc";
            // 
            // cT_Label3
            // 
            this.cT_Label3.AutoSize = true;
            this.cT_Label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cT_Label3.Location = new System.Drawing.Point(970, 93);
            this.cT_Label3.Name = "cT_Label3";
            this.cT_Label3.Size = new System.Drawing.Size(147, 23);
            this.cT_Label3.TabIndex = 29;
            this.cT_Label3.Text = "Danh sách thuốc";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(1506, 48);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(135, 50);
            this.btnFind.TabIndex = 30;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(570, 897);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 50);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Thêm ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(1226, 897);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 50);
            this.btnReset.TabIndex = 32;
            this.btnReset.Text = "Chọn lại";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPrint.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(1019, 897);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(135, 50);
            this.btnPrint.TabIndex = 33;
            this.btnPrint.Text = "In đơn thuốc";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(794, 897);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 50);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // cT_Label4
            // 
            this.cT_Label4.AutoSize = true;
            this.cT_Label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cT_Label4.Location = new System.Drawing.Point(982, 489);
            this.cT_Label4.Name = "cT_Label4";
            this.cT_Label4.Size = new System.Drawing.Size(96, 23);
            this.cT_Label4.TabIndex = 35;
            this.cT_Label4.Text = "Đơn thuốc";
            // 
            // dgvListWithCategory
            // 
            this.dgvListWithCategory.BackgroundColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListWithCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListWithCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListWithCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThuoc,
            this.TenThuoc,
            this.DonViTinh,
            this.ChiDinh});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListWithCategory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListWithCategory.Location = new System.Drawing.Point(480, 128);
            this.dgvListWithCategory.Name = "dgvListWithCategory";
            this.dgvListWithCategory.ReadOnly = true;
            this.dgvListWithCategory.RowHeadersVisible = false;
            this.dgvListWithCategory.RowTemplate.Height = 24;
            this.dgvListWithCategory.Size = new System.Drawing.Size(1455, 346);
            this.dgvListWithCategory.TabIndex = 36;
            // 
            // dgvPrescription
            // 
            this.dgvPrescription.BackgroundColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrescription.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrescription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrescription.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPrescription.Location = new System.Drawing.Point(480, 515);
            this.dgvPrescription.Name = "dgvPrescription";
            this.dgvPrescription.RowHeadersVisible = false;
            this.dgvPrescription.RowTemplate.Height = 24;
            this.dgvPrescription.Size = new System.Drawing.Size(1455, 346);
            this.dgvPrescription.TabIndex = 37;
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtInput.Location = new System.Drawing.Point(1039, 52);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(370, 30);
            this.txtInput.TabIndex = 38;
            // 
            // cT_Label5
            // 
            this.cT_Label5.AutoSize = true;
            this.cT_Label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cT_Label5.Location = new System.Drawing.Point(195, 352);
            this.cT_Label5.Name = "cT_Label5";
            this.cT_Label5.Size = new System.Drawing.Size(132, 23);
            this.cT_Label5.TabIndex = 39;
            this.cT_Label5.Text = "Ngày tái khám";
            // 
            // cT_Label6
            // 
            this.cT_Label6.AutoSize = true;
            this.cT_Label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cT_Label6.Location = new System.Drawing.Point(234, 472);
            this.cT_Label6.Name = "cT_Label6";
            this.cT_Label6.Size = new System.Drawing.Size(74, 23);
            this.cT_Label6.TabIndex = 40;
            this.cT_Label6.Text = "Lời dặn";
            // 
            // MaThuoc
            // 
            this.MaThuoc.HeaderText = "Mã thuốc";
            this.MaThuoc.Name = "MaThuoc";
            this.MaThuoc.ReadOnly = true;
            this.MaThuoc.Width = 150;
            // 
            // TenThuoc
            // 
            this.TenThuoc.HeaderText = "Tên thuốc";
            this.TenThuoc.Name = "TenThuoc";
            this.TenThuoc.ReadOnly = true;
            this.TenThuoc.Width = 350;
            // 
            // DonViTinh
            // 
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            // 
            // ChiDinh
            // 
            this.ChiDinh.HeaderText = "Chỉ định";
            this.ChiDinh.Name = "ChiDinh";
            this.ChiDinh.ReadOnly = true;
            this.ChiDinh.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên thuốc";
            this.Column3.Name = "Column3";
            this.Column3.Width = 350;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Đơn vị tính";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số lượng";
            this.Column5.Name = "Column5";
            this.Column5.Width = 140;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Sáng ";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Trưa";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Tối";
            this.Column8.Name = "Column8";
            // 
            // PrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1062);
            this.Controls.Add(this.cT_Label6);
            this.Controls.Add(this.cT_Label5);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.dgvPrescription);
            this.Controls.Add(this.dgvListWithCategory);
            this.Controls.Add(this.cT_Label4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.cT_Label3);
            this.Controls.Add(this.cT_Label2);
            this.Controls.Add(this.cT_Label1);
            this.Controls.Add(this.txtReminder);
            this.Controls.Add(this.dateReturnpicker);
            this.Controls.Add(this.cbbCategory);
            this.Name = "PrescriptionForm";
            this.Text = "Kê đơn thuốc";
            this.Load += new System.EventHandler(this.SelectDrugForm_Load);
            this.Shown += new System.EventHandler(this.SelectDrugForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListWithCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbbCategory;
        private System.Windows.Forms.DateTimePicker dateReturnpicker;
        private System.Windows.Forms.RichTextBox txtReminder;
        private CustomControl.CT_Label cT_Label1;
        private CustomControl.CT_Label cT_Label2;
        private CustomControl.CT_Label cT_Label3;
        private CustomControl.CT_Button btnFind;
        private CustomControl.CT_Button btnAdd;
        private CustomControl.CT_Button btnReset;
        private CustomControl.CT_Button btnPrint;
        private CustomControl.CT_Button btnDelete;
        private CustomControl.CT_Label cT_Label4;
        private CustomControl.CT_DataGrid dgvListWithCategory;
        private CustomControl.CT_DataGrid dgvPrescription;
        private CustomControl.CT_TextBox txtInput;
        private CustomControl.CT_Label cT_Label5;
        private CustomControl.CT_Label cT_Label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiDinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}