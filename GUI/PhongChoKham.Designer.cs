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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbAll = new System.Windows.Forms.GroupBox();
            this.rdbChecked = new MetroFramework.Controls.MetroRadioButton();
            this.rdbCheck = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.labelName = new System.Windows.Forms.Label();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.dgvListPatient = new MetroFramework.Controls.MetroGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.labeldate = new System.Windows.Forms.Label();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.rdbAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(338, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHÒNG CHỜ KHÁM BỆNH";
            // 
            // rdbAll
            // 
            this.rdbAll.Controls.Add(this.rdbChecked);
            this.rdbAll.Controls.Add(this.rdbCheck);
            this.rdbAll.Controls.Add(this.metroRadioButton1);
            this.rdbAll.Location = new System.Drawing.Point(71, 117);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(413, 64);
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
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(21, 39);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(59, 17);
            this.metroRadioButton1.TabIndex = 0;
            this.metroRadioButton1.Text = "Tất cả";
            this.metroRadioButton1.UseSelectable = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(625, 69);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(46, 17);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "label2";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(805, 131);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 50);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvListPatient
            // 
            this.dgvListPatient.AllowUserToResizeRows = false;
            this.dgvListPatient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListPatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListPatient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvListPatient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListPatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListPatient.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListPatient.EnableHeadersVisualStyles = false;
            this.dgvListPatient.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvListPatient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListPatient.Location = new System.Drawing.Point(71, 235);
            this.dgvListPatient.Name = "dgvListPatient";
            this.dgvListPatient.ReadOnly = true;
            this.dgvListPatient.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListPatient.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListPatient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListPatient.RowTemplate.Height = 24;
            this.dgvListPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListPatient.Size = new System.Drawing.Size(854, 508);
            this.dgvListPatient.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(376, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "DANH SÁCH BỆNH NHÂN";
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.labeldate.Location = new System.Drawing.Point(775, 69);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(46, 17);
            this.labeldate.TabIndex = 6;
            this.labeldate.Text = "label4";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(963, 235);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(109, 47);
            this.metroButton2.TabIndex = 7;
            this.metroButton2.Text = "Xem thông tin";
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(963, 334);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(108, 48);
            this.metroButton3.TabIndex = 8;
            this.metroButton3.Text = "Hủy";
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(963, 430);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(108, 48);
            this.metroButton4.TabIndex = 9;
            this.metroButton4.Text = "Gọi khám";
            this.metroButton4.UseSelectable = true;
            // 
            // PhongChoKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 781);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.labeldate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvListPatient);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.rdbAll);
            this.Controls.Add(this.label1);
            this.Name = "PhongChoKham";
            this.Text = "KhamBenh";
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
        private System.Windows.Forms.Label labelName;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private MetroFramework.Controls.MetroGrid dgvListPatient;
        private MetroFramework.Controls.MetroRadioButton rdbChecked;
        private MetroFramework.Controls.MetroRadioButton rdbCheck;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labeldate;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
    }
}