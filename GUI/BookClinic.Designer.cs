namespace GUI
{
    partial class BookClinic
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
            this.btnConfirm = new MetroFramework.Controls.MetroButton();
            this.btnReturn = new MetroFramework.Controls.MetroButton();
            this.pnInfo = new MetroFramework.Drawing.Html.HtmlPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGenderB = new MetroFramework.Controls.MetroTextBox();
            this.txtAddressB = new MetroFramework.Controls.MetroTextBox();
            this.txtDayOfBirthB = new MetroFramework.Controls.MetroTextBox();
            this.txtPhoneNumberB = new MetroFramework.Controls.MetroTextBox();
            this.txtNameB = new MetroFramework.Controls.MetroTextBox();
            this.panelPK = new MetroFramework.Drawing.Html.HtmlPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtState = new MetroFramework.Controls.MetroTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumberPeople = new MetroFramework.Controls.MetroTextBox();
            this.cbbListDoctor = new MetroFramework.Controls.MetroComboBox();
            this.txtNumber = new MetroFramework.Controls.MetroTextBox();
            this.txtSpecialty = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnInfo.SuspendLayout();
            this.panelPK.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(41, 164);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(152, 51);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Xác nhận ";
            this.btnConfirm.UseSelectable = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(41, 448);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(151, 58);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Trở về";
            this.btnReturn.UseSelectable = true;
            // 
            // pnInfo
            // 
            this.pnInfo.AutoScroll = true;
            this.pnInfo.AutoScrollMinSize = new System.Drawing.Size(958, 23);
            this.pnInfo.BackColor = System.Drawing.SystemColors.Window;
            this.pnInfo.Controls.Add(this.label5);
            this.pnInfo.Controls.Add(this.label4);
            this.pnInfo.Controls.Add(this.label3);
            this.pnInfo.Controls.Add(this.label2);
            this.pnInfo.Controls.Add(this.label1);
            this.pnInfo.Controls.Add(this.txtGenderB);
            this.pnInfo.Controls.Add(this.txtAddressB);
            this.pnInfo.Controls.Add(this.txtDayOfBirthB);
            this.pnInfo.Controls.Add(this.txtPhoneNumberB);
            this.pnInfo.Controls.Add(this.txtNameB);
            this.pnInfo.Location = new System.Drawing.Point(237, 97);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(958, 269);
            this.pnInfo.TabIndex = 4;
            this.pnInfo.Text = "Thông tin bệnh nhân";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ngày sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Họ Tên";
            // 
            // txtGenderB
            // 
            // 
            // 
            // 
            this.txtGenderB.CustomButton.Image = null;
            this.txtGenderB.CustomButton.Location = new System.Drawing.Point(270, 1);
            this.txtGenderB.CustomButton.Name = "";
            this.txtGenderB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGenderB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGenderB.CustomButton.TabIndex = 1;
            this.txtGenderB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGenderB.CustomButton.UseSelectable = true;
            this.txtGenderB.CustomButton.Visible = false;
            this.txtGenderB.Lines = new string[0];
            this.txtGenderB.Location = new System.Drawing.Point(604, 61);
            this.txtGenderB.MaxLength = 32767;
            this.txtGenderB.Name = "txtGenderB";
            this.txtGenderB.PasswordChar = '\0';
            this.txtGenderB.ReadOnly = true;
            this.txtGenderB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGenderB.SelectedText = "";
            this.txtGenderB.SelectionLength = 0;
            this.txtGenderB.SelectionStart = 0;
            this.txtGenderB.ShortcutsEnabled = true;
            this.txtGenderB.Size = new System.Drawing.Size(292, 23);
            this.txtGenderB.TabIndex = 4;
            this.txtGenderB.UseSelectable = true;
            this.txtGenderB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGenderB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAddressB
            // 
            // 
            // 
            // 
            this.txtAddressB.CustomButton.Image = null;
            this.txtAddressB.CustomButton.Location = new System.Drawing.Point(270, 1);
            this.txtAddressB.CustomButton.Name = "";
            this.txtAddressB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAddressB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddressB.CustomButton.TabIndex = 1;
            this.txtAddressB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddressB.CustomButton.UseSelectable = true;
            this.txtAddressB.CustomButton.Visible = false;
            this.txtAddressB.Lines = new string[0];
            this.txtAddressB.Location = new System.Drawing.Point(604, 159);
            this.txtAddressB.MaxLength = 32767;
            this.txtAddressB.Name = "txtAddressB";
            this.txtAddressB.PasswordChar = '\0';
            this.txtAddressB.ReadOnly = true;
            this.txtAddressB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddressB.SelectedText = "";
            this.txtAddressB.SelectionLength = 0;
            this.txtAddressB.SelectionStart = 0;
            this.txtAddressB.ShortcutsEnabled = true;
            this.txtAddressB.Size = new System.Drawing.Size(292, 23);
            this.txtAddressB.TabIndex = 3;
            this.txtAddressB.UseSelectable = true;
            this.txtAddressB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddressB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDayOfBirthB
            // 
            // 
            // 
            // 
            this.txtDayOfBirthB.CustomButton.Image = null;
            this.txtDayOfBirthB.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.txtDayOfBirthB.CustomButton.Name = "";
            this.txtDayOfBirthB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDayOfBirthB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDayOfBirthB.CustomButton.TabIndex = 1;
            this.txtDayOfBirthB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDayOfBirthB.CustomButton.UseSelectable = true;
            this.txtDayOfBirthB.CustomButton.Visible = false;
            this.txtDayOfBirthB.Lines = new string[0];
            this.txtDayOfBirthB.Location = new System.Drawing.Point(154, 117);
            this.txtDayOfBirthB.MaxLength = 32767;
            this.txtDayOfBirthB.Name = "txtDayOfBirthB";
            this.txtDayOfBirthB.PasswordChar = '\0';
            this.txtDayOfBirthB.ReadOnly = true;
            this.txtDayOfBirthB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDayOfBirthB.SelectedText = "";
            this.txtDayOfBirthB.SelectionLength = 0;
            this.txtDayOfBirthB.SelectionStart = 0;
            this.txtDayOfBirthB.ShortcutsEnabled = true;
            this.txtDayOfBirthB.Size = new System.Drawing.Size(204, 23);
            this.txtDayOfBirthB.TabIndex = 2;
            this.txtDayOfBirthB.UseSelectable = true;
            this.txtDayOfBirthB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDayOfBirthB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPhoneNumberB
            // 
            // 
            // 
            // 
            this.txtPhoneNumberB.CustomButton.Image = null;
            this.txtPhoneNumberB.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.txtPhoneNumberB.CustomButton.Name = "";
            this.txtPhoneNumberB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhoneNumberB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhoneNumberB.CustomButton.TabIndex = 1;
            this.txtPhoneNumberB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhoneNumberB.CustomButton.UseSelectable = true;
            this.txtPhoneNumberB.CustomButton.Visible = false;
            this.txtPhoneNumberB.Lines = new string[0];
            this.txtPhoneNumberB.Location = new System.Drawing.Point(154, 175);
            this.txtPhoneNumberB.MaxLength = 32767;
            this.txtPhoneNumberB.Name = "txtPhoneNumberB";
            this.txtPhoneNumberB.PasswordChar = '\0';
            this.txtPhoneNumberB.ReadOnly = true;
            this.txtPhoneNumberB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhoneNumberB.SelectedText = "";
            this.txtPhoneNumberB.SelectionLength = 0;
            this.txtPhoneNumberB.SelectionStart = 0;
            this.txtPhoneNumberB.ShortcutsEnabled = true;
            this.txtPhoneNumberB.Size = new System.Drawing.Size(204, 23);
            this.txtPhoneNumberB.TabIndex = 1;
            this.txtPhoneNumberB.UseSelectable = true;
            this.txtPhoneNumberB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhoneNumberB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNameB
            // 
            // 
            // 
            // 
            this.txtNameB.CustomButton.Image = null;
            this.txtNameB.CustomButton.Location = new System.Drawing.Point(178, 2);
            this.txtNameB.CustomButton.Name = "";
            this.txtNameB.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtNameB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNameB.CustomButton.TabIndex = 1;
            this.txtNameB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNameB.CustomButton.UseSelectable = true;
            this.txtNameB.CustomButton.Visible = false;
            this.txtNameB.Lines = new string[0];
            this.txtNameB.Location = new System.Drawing.Point(154, 50);
            this.txtNameB.MaxLength = 32767;
            this.txtNameB.Name = "txtNameB";
            this.txtNameB.PasswordChar = '\0';
            this.txtNameB.ReadOnly = true;
            this.txtNameB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNameB.SelectedText = "";
            this.txtNameB.SelectionLength = 0;
            this.txtNameB.SelectionStart = 0;
            this.txtNameB.ShortcutsEnabled = true;
            this.txtNameB.Size = new System.Drawing.Size(204, 28);
            this.txtNameB.TabIndex = 0;
            this.txtNameB.UseSelectable = true;
            this.txtNameB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNameB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panelPK
            // 
            this.panelPK.AutoScroll = true;
            this.panelPK.AutoScrollMinSize = new System.Drawing.Size(896, 23);
            this.panelPK.BackColor = System.Drawing.SystemColors.Window;
            this.panelPK.Controls.Add(this.label10);
            this.panelPK.Controls.Add(this.txtState);
            this.panelPK.Controls.Add(this.label9);
            this.panelPK.Controls.Add(this.label8);
            this.panelPK.Controls.Add(this.txtNumberPeople);
            this.panelPK.Controls.Add(this.cbbListDoctor);
            this.panelPK.Controls.Add(this.txtNumber);
            this.panelPK.Controls.Add(this.txtSpecialty);
            this.panelPK.Controls.Add(this.label7);
            this.panelPK.Controls.Add(this.label6);
            this.panelPK.Location = new System.Drawing.Point(237, 394);
            this.panelPK.Name = "panelPK";
            this.panelPK.Size = new System.Drawing.Size(896, 271);
            this.panelPK.TabIndex = 5;
            this.panelPK.Text = "Thông tin phòng khám";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(435, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Số lượng bệnh nhân hiện tại";
            // 
            // txtState
            // 
            // 
            // 
            // 
            this.txtState.CustomButton.Image = null;
            this.txtState.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtState.CustomButton.Name = "";
            this.txtState.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtState.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtState.CustomButton.TabIndex = 1;
            this.txtState.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtState.CustomButton.UseSelectable = true;
            this.txtState.CustomButton.Visible = false;
            this.txtState.Lines = new string[0];
            this.txtState.Location = new System.Drawing.Point(669, 70);
            this.txtState.MaxLength = 32767;
            this.txtState.Name = "txtState";
            this.txtState.PasswordChar = '\0';
            this.txtState.ReadOnly = true;
            this.txtState.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtState.SelectedText = "";
            this.txtState.SelectionLength = 0;
            this.txtState.SelectionStart = 0;
            this.txtState.ShortcutsEnabled = true;
            this.txtState.Size = new System.Drawing.Size(205, 23);
            this.txtState.TabIndex = 8;
            this.txtState.UseSelectable = true;
            this.txtState.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtState.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(440, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Trạng Thái";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Bác sĩ";
            // 
            // txtNumberPeople
            // 
            // 
            // 
            // 
            this.txtNumberPeople.CustomButton.Image = null;
            this.txtNumberPeople.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtNumberPeople.CustomButton.Name = "";
            this.txtNumberPeople.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNumberPeople.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumberPeople.CustomButton.TabIndex = 1;
            this.txtNumberPeople.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumberPeople.CustomButton.UseSelectable = true;
            this.txtNumberPeople.CustomButton.Visible = false;
            this.txtNumberPeople.Lines = new string[0];
            this.txtNumberPeople.Location = new System.Drawing.Point(669, 140);
            this.txtNumberPeople.MaxLength = 32767;
            this.txtNumberPeople.Name = "txtNumberPeople";
            this.txtNumberPeople.PasswordChar = '\0';
            this.txtNumberPeople.ReadOnly = true;
            this.txtNumberPeople.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumberPeople.SelectedText = "";
            this.txtNumberPeople.SelectionLength = 0;
            this.txtNumberPeople.SelectionStart = 0;
            this.txtNumberPeople.ShortcutsEnabled = true;
            this.txtNumberPeople.Size = new System.Drawing.Size(205, 23);
            this.txtNumberPeople.TabIndex = 5;
            this.txtNumberPeople.UseSelectable = true;
            this.txtNumberPeople.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumberPeople.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbbListDoctor
            // 
            this.cbbListDoctor.FormattingEnabled = true;
            this.cbbListDoctor.ItemHeight = 24;
            this.cbbListDoctor.Location = new System.Drawing.Point(190, 183);
            this.cbbListDoctor.Name = "cbbListDoctor";
            this.cbbListDoctor.Size = new System.Drawing.Size(196, 30);
            this.cbbListDoctor.TabIndex = 4;
            this.cbbListDoctor.UseSelectable = true;
            // 
            // txtNumber
            // 
            // 
            // 
            // 
            this.txtNumber.CustomButton.Image = null;
            this.txtNumber.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.txtNumber.CustomButton.Name = "";
            this.txtNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumber.CustomButton.TabIndex = 1;
            this.txtNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumber.CustomButton.UseSelectable = true;
            this.txtNumber.CustomButton.Visible = false;
            this.txtNumber.Lines = new string[0];
            this.txtNumber.Location = new System.Drawing.Point(192, 64);
            this.txtNumber.MaxLength = 32767;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.PasswordChar = '\0';
            this.txtNumber.ReadOnly = true;
            this.txtNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumber.SelectedText = "";
            this.txtNumber.SelectionLength = 0;
            this.txtNumber.SelectionStart = 0;
            this.txtNumber.ShortcutsEnabled = true;
            this.txtNumber.Size = new System.Drawing.Size(194, 23);
            this.txtNumber.TabIndex = 3;
            this.txtNumber.UseSelectable = true;
            this.txtNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSpecialty
            // 
            // 
            // 
            // 
            this.txtSpecialty.CustomButton.Image = null;
            this.txtSpecialty.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.txtSpecialty.CustomButton.Name = "";
            this.txtSpecialty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSpecialty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSpecialty.CustomButton.TabIndex = 1;
            this.txtSpecialty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSpecialty.CustomButton.UseSelectable = true;
            this.txtSpecialty.CustomButton.Visible = false;
            this.txtSpecialty.Lines = new string[0];
            this.txtSpecialty.Location = new System.Drawing.Point(192, 116);
            this.txtSpecialty.MaxLength = 32767;
            this.txtSpecialty.Name = "txtSpecialty";
            this.txtSpecialty.PasswordChar = '\0';
            this.txtSpecialty.ReadOnly = true;
            this.txtSpecialty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSpecialty.SelectedText = "";
            this.txtSpecialty.SelectionLength = 0;
            this.txtSpecialty.SelectionStart = 0;
            this.txtSpecialty.ShortcutsEnabled = true;
            this.txtSpecialty.Size = new System.Drawing.Size(194, 23);
            this.txtSpecialty.TabIndex = 2;
            this.txtSpecialty.UseSelectable = true;
            this.txtSpecialty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSpecialty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Số Phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chuyên khoa";
            // 
            // BookClinic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 801);
            this.Controls.Add(this.panelPK);
            this.Controls.Add(this.pnInfo);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnConfirm);
            this.Name = "BookClinic";
            this.Text = "BookClinic";
            this.Load += new System.EventHandler(this.BookClinic_Load);
            this.pnInfo.ResumeLayout(false);
            this.pnInfo.PerformLayout();
            this.panelPK.ResumeLayout(false);
            this.panelPK.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnConfirm;
        private MetroFramework.Controls.MetroButton btnReturn;
        private MetroFramework.Drawing.Html.HtmlPanel pnInfo;
        private MetroFramework.Controls.MetroTextBox txtNameB;
        private MetroFramework.Drawing.Html.HtmlPanel panelPK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtGenderB;
        private MetroFramework.Controls.MetroTextBox txtAddressB;
        private MetroFramework.Controls.MetroTextBox txtDayOfBirthB;
        private MetroFramework.Controls.MetroTextBox txtPhoneNumberB;
        private System.Windows.Forms.Label label10;
        private MetroFramework.Controls.MetroTextBox txtState;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroTextBox txtNumberPeople;
        private MetroFramework.Controls.MetroComboBox cbbListDoctor;
        private MetroFramework.Controls.MetroTextBox txtNumber;
        private MetroFramework.Controls.MetroTextBox txtSpecialty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}