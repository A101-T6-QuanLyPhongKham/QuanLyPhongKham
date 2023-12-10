namespace GUI
{
    partial class PhongChoKham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbAll = new System.Windows.Forms.GroupBox();
            this.rdbChecked = new MetroFramework.Controls.MetroRadioButton();
            this.rdbCheck = new MetroFramework.Controls.MetroRadioButton();
            this.rdbAllList = new MetroFramework.Controls.MetroRadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnView = new CustomControl.CT_Button();
            this.cT_Button1 = new CustomControl.CT_Button();
            this.dgvListPatient = new CustomControl.CT_DataGrid();
            this.MaBenhNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChieuCao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanNang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HuyetAp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhipTim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhietDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelName = new CustomControl.CT_Label();
            this.labeldate = new CustomControl.CT_Label();
            this.cT_Button2 = new CustomControl.CT_Button();
            this.rdbAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(612, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHÒNG CHỜ KHÁM BỆNH";
            // 
            // rdbAll
            // 
            this.rdbAll.Controls.Add(this.rdbChecked);
            this.rdbAll.Controls.Add(this.rdbCheck);
            this.rdbAll.Controls.Add(this.rdbAllList);
            this.rdbAll.Location = new System.Drawing.Point(512, 63);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(413, 77);
            this.rdbAll.TabIndex = 1;
            this.rdbAll.TabStop = false;
            this.rdbAll.Text = "Tùy chọn";
            // 
            // rdbChecked
            // 
            this.rdbChecked.AutoSize = true;
            this.rdbChecked.Location = new System.Drawing.Point(296, 39);
            this.rdbChecked.Name = "rdbChecked";
            this.rdbChecked.Size = new System.Drawing.Size(75, 17);
            this.rdbChecked.TabIndex = 2;
            this.rdbChecked.Text = "Đã khám";
            this.rdbChecked.UseSelectable = true;
            // 
            // rdbCheck
            // 
            this.rdbCheck.AutoSize = true;
            this.rdbCheck.Location = new System.Drawing.Point(159, 39);
            this.rdbCheck.Name = "rdbCheck";
            this.rdbCheck.Size = new System.Drawing.Size(89, 17);
            this.rdbCheck.TabIndex = 1;
            this.rdbCheck.Text = "Chưa khám";
            this.rdbCheck.UseSelectable = true;
            // 
            // rdbAllList
            // 
            this.rdbAllList.AutoSize = true;
            this.rdbAllList.Location = new System.Drawing.Point(21, 39);
            this.rdbAllList.Name = "rdbAllList";
            this.rdbAllList.Size = new System.Drawing.Size(59, 17);
            this.rdbAllList.TabIndex = 0;
            this.rdbAllList.Text = "Tất cả";
            this.rdbAllList.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(794, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "DANH SÁCH BỆNH NHÂN";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnView.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(808, 681);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(135, 50);
            this.btnView.TabIndex = 9;
            this.btnView.Text = "Xem thông tin";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // cT_Button1
            // 
            this.cT_Button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.cT_Button1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cT_Button1.ForeColor = System.Drawing.Color.White;
            this.cT_Button1.Location = new System.Drawing.Point(1079, 681);
            this.cT_Button1.Name = "cT_Button1";
            this.cT_Button1.Size = new System.Drawing.Size(135, 50);
            this.cT_Button1.TabIndex = 10;
            this.cT_Button1.Text = "Xóa dòng";
            this.cT_Button1.UseVisualStyleBackColor = false;
            // 
            // dgvListPatient
            // 
            this.dgvListPatient.BackgroundColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBenhNhan,
            this.HoTen,
            this.NgaySinh,
            this.GioiTinh,
            this.ChieuCao,
            this.CanNang,
            this.HuyetAp,
            this.NhipTim,
            this.NhietDo});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListPatient.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListPatient.Location = new System.Drawing.Point(23, 197);
            this.dgvListPatient.Name = "dgvListPatient";
            this.dgvListPatient.ReadOnly = true;
            this.dgvListPatient.RowHeadersVisible = false;
            this.dgvListPatient.RowTemplate.Height = 24;
            this.dgvListPatient.Size = new System.Drawing.Size(2623, 426);
            this.dgvListPatient.TabIndex = 11;
            // 
            // MaBenhNhan
            // 
            this.MaBenhNhan.HeaderText = "Mã bệnh nhân";
            this.MaBenhNhan.Name = "MaBenhNhan";
            this.MaBenhNhan.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // NgaySinh
            // 
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // ChieuCao
            // 
            this.ChieuCao.HeaderText = "Chiều Cao";
            this.ChieuCao.Name = "ChieuCao";
            this.ChieuCao.ReadOnly = true;
            // 
            // CanNang
            // 
            this.CanNang.HeaderText = "Cân Nặng";
            this.CanNang.Name = "CanNang";
            this.CanNang.ReadOnly = true;
            // 
            // HuyetAp
            // 
            this.HuyetAp.HeaderText = "Huyết Áp";
            this.HuyetAp.Name = "HuyetAp";
            this.HuyetAp.ReadOnly = true;
            // 
            // NhipTim
            // 
            this.NhipTim.HeaderText = "Nhịp Tim";
            this.NhipTim.Name = "NhipTim";
            this.NhipTim.ReadOnly = true;
            // 
            // NhietDo
            // 
            this.NhietDo.HeaderText = "Nhiệt Độ";
            this.NhietDo.Name = "NhietDo";
            this.NhietDo.ReadOnly = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.labelName.Location = new System.Drawing.Point(1010, 26);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(100, 23);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "cT_Label1";
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.labeldate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.labeldate.Location = new System.Drawing.Point(1274, 26);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(100, 23);
            this.labeldate.TabIndex = 13;
            this.labeldate.Text = "cT_Label1";
            // 
            // cT_Button2
            // 
            this.cT_Button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.cT_Button2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cT_Button2.ForeColor = System.Drawing.Color.White;
            this.cT_Button2.Location = new System.Drawing.Point(975, 79);
            this.cT_Button2.Name = "cT_Button2";
            this.cT_Button2.Size = new System.Drawing.Size(135, 53);
            this.cT_Button2.TabIndex = 14;
            this.cT_Button2.Text = "Làm mới";
            this.cT_Button2.UseVisualStyleBackColor = false;
            this.cT_Button2.Click += new System.EventHandler(this.cT_Button2_Click);
            // 
            // PhongChoKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 874);
            this.Controls.Add(this.cT_Button2);
            this.Controls.Add(this.labeldate);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.dgvListPatient);
            this.Controls.Add(this.cT_Button1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdbAll);
            this.Controls.Add(this.label1);
            this.Name = "PhongChoKham";
            this.Load += new System.EventHandler(this.PhongChoKham_Load);
            this.rdbAll.ResumeLayout(false);
            this.rdbAll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox rdbAll;
        private MetroFramework.Controls.MetroRadioButton rdbChecked;
        private MetroFramework.Controls.MetroRadioButton rdbCheck;
        private MetroFramework.Controls.MetroRadioButton rdbAllList;
        private System.Windows.Forms.Label label3;
        private CustomControl.CT_Button btnView;
        private CustomControl.CT_Button cT_Button1;
        private CustomControl.CT_DataGrid dgvListPatient;
        private CustomControl.CT_Label labelName;
        private CustomControl.CT_Label labeldate;
        private CustomControl.CT_Button cT_Button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBenhNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChieuCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanNang;
        private System.Windows.Forms.DataGridViewTextBoxColumn HuyetAp;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhipTim;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhietDo;
    }
}