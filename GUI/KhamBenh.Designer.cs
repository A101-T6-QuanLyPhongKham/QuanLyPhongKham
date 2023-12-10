namespace GUI
{
    partial class KhamBenh
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
            this.htmlPanel2 = new MetroFramework.Drawing.Html.HtmlPanel();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.btnDrug = new CustomControl.CT_Button();
            this.htmlPanel1 = new MetroFramework.Drawing.Html.HtmlPanel();
            this.cT_Label1 = new CustomControl.CT_Label();
            this.cT_Label2 = new CustomControl.CT_Label();
            this.cT_Label3 = new CustomControl.CT_Label();
            this.cT_Label4 = new CustomControl.CT_Label();
            this.txtName = new CustomControl.CT_TextBox();
            this.txtBirth = new CustomControl.CT_TextBox();
            this.txtGender = new CustomControl.CT_TextBox();
            this.txtPhone = new CustomControl.CT_TextBox();
            this.cT_Label5 = new CustomControl.CT_Label();
            this.cT_Label6 = new CustomControl.CT_Label();
            this.cT_Label7 = new CustomControl.CT_Label();
            this.cT_Label8 = new CustomControl.CT_Label();
            this.cT_Label9 = new CustomControl.CT_Label();
            this.txtTemperature = new CustomControl.CT_TextBoxOnlyNumber();
            this.txtWeight = new CustomControl.CT_TextBoxOnlyNumber();
            this.cT_Label10 = new CustomControl.CT_Label();
            this.txtHeart = new CustomControl.CT_TextBoxOnlyNumber();
            this.txtBloodPressure = new CustomControl.CT_TextBoxOnlyNumber();
            this.txtHeight = new CustomControl.CT_TextBoxOnlyNumber();
            this.htmlPanel2.SuspendLayout();
            this.htmlPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // htmlPanel2
            // 
            this.htmlPanel2.AutoScroll = true;
            this.htmlPanel2.AutoScrollMinSize = new System.Drawing.Size(1150, 23);
            this.htmlPanel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlPanel2.Controls.Add(this.txtHeight);
            this.htmlPanel2.Controls.Add(this.txtBloodPressure);
            this.htmlPanel2.Controls.Add(this.txtHeart);
            this.htmlPanel2.Controls.Add(this.cT_Label10);
            this.htmlPanel2.Controls.Add(this.txtWeight);
            this.htmlPanel2.Controls.Add(this.txtTemperature);
            this.htmlPanel2.Controls.Add(this.cT_Label9);
            this.htmlPanel2.Controls.Add(this.cT_Label6);
            this.htmlPanel2.Controls.Add(this.cT_Label8);
            this.htmlPanel2.Controls.Add(this.cT_Label5);
            this.htmlPanel2.Controls.Add(this.cT_Label7);
            this.htmlPanel2.Controls.Add(this.txtDescription);
            this.htmlPanel2.Location = new System.Drawing.Point(402, 306);
            this.htmlPanel2.Name = "htmlPanel2";
            this.htmlPanel2.Size = new System.Drawing.Size(1150, 422);
            this.htmlPanel2.TabIndex = 1;
            this.htmlPanel2.Text = "Thông tin khám";
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(651, 1);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(127, 127);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(196, 267);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(779, 129);
            this.txtDescription.TabIndex = 15;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnDrug
            // 
            this.btnDrug.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDrug.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnDrug.ForeColor = System.Drawing.Color.White;
            this.btnDrug.Location = new System.Drawing.Point(878, 757);
            this.btnDrug.Name = "btnDrug";
            this.btnDrug.Size = new System.Drawing.Size(135, 50);
            this.btnDrug.TabIndex = 2;
            this.btnDrug.Text = "Kê đơn thuốc";
            this.btnDrug.UseVisualStyleBackColor = false;
            this.btnDrug.Click += new System.EventHandler(this.btnDrug_Click);
            // 
            // htmlPanel1
            // 
            this.htmlPanel1.AutoScroll = true;
            this.htmlPanel1.AutoScrollMinSize = new System.Drawing.Size(1160, 23);
            this.htmlPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlPanel1.Controls.Add(this.txtPhone);
            this.htmlPanel1.Controls.Add(this.txtGender);
            this.htmlPanel1.Controls.Add(this.txtBirth);
            this.htmlPanel1.Controls.Add(this.txtName);
            this.htmlPanel1.Controls.Add(this.cT_Label4);
            this.htmlPanel1.Controls.Add(this.cT_Label3);
            this.htmlPanel1.Controls.Add(this.cT_Label2);
            this.htmlPanel1.Controls.Add(this.cT_Label1);
            this.htmlPanel1.Location = new System.Drawing.Point(402, 90);
            this.htmlPanel1.Name = "htmlPanel1";
            this.htmlPanel1.Size = new System.Drawing.Size(1160, 183);
            this.htmlPanel1.TabIndex = 0;
            this.htmlPanel1.Text = "Thông tin bệnh nhân";
            // 
            // cT_Label1
            // 
            this.cT_Label1.AutoSize = true;
            this.cT_Label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cT_Label1.Location = new System.Drawing.Point(44, 51);
            this.cT_Label1.Name = "cT_Label1";
            this.cT_Label1.Size = new System.Drawing.Size(66, 23);
            this.cT_Label1.TabIndex = 8;
            this.cT_Label1.Text = "Họ tên";
            // 
            // cT_Label2
            // 
            this.cT_Label2.AutoSize = true;
            this.cT_Label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cT_Label2.Location = new System.Drawing.Point(44, 106);
            this.cT_Label2.Name = "cT_Label2";
            this.cT_Label2.Size = new System.Drawing.Size(92, 23);
            this.cT_Label2.TabIndex = 9;
            this.cT_Label2.Text = "Ngày sinh";
            // 
            // cT_Label3
            // 
            this.cT_Label3.AutoSize = true;
            this.cT_Label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cT_Label3.Location = new System.Drawing.Point(544, 44);
            this.cT_Label3.Name = "cT_Label3";
            this.cT_Label3.Size = new System.Drawing.Size(85, 23);
            this.cT_Label3.TabIndex = 10;
            this.cT_Label3.Text = "Giới tính";
            // 
            // cT_Label4
            // 
            this.cT_Label4.AutoSize = true;
            this.cT_Label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cT_Label4.Location = new System.Drawing.Point(544, 106);
            this.cT_Label4.Name = "cT_Label4";
            this.cT_Label4.Size = new System.Drawing.Size(96, 23);
            this.cT_Label4.TabIndex = 11;
            this.cT_Label4.Text = "Điện thoại";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtName.Location = new System.Drawing.Point(196, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 30);
            this.txtName.TabIndex = 12;
            // 
            // txtBirth
            // 
            this.txtBirth.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtBirth.Location = new System.Drawing.Point(196, 106);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.Size = new System.Drawing.Size(250, 30);
            this.txtBirth.TabIndex = 13;
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtGender.Location = new System.Drawing.Point(725, 42);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(250, 30);
            this.txtGender.TabIndex = 14;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtPhone.Location = new System.Drawing.Point(725, 106);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(250, 30);
            this.txtPhone.TabIndex = 15;
            // 
            // cT_Label5
            // 
            this.cT_Label5.AutoSize = true;
            this.cT_Label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cT_Label5.Location = new System.Drawing.Point(55, 61);
            this.cT_Label5.Name = "cT_Label5";
            this.cT_Label5.Size = new System.Drawing.Size(81, 23);
            this.cT_Label5.TabIndex = 18;
            this.cT_Label5.Text = "Nhiệt độ";
            // 
            // cT_Label6
            // 
            this.cT_Label6.AutoSize = true;
            this.cT_Label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cT_Label6.Location = new System.Drawing.Point(544, 61);
            this.cT_Label6.Name = "cT_Label6";
            this.cT_Label6.Size = new System.Drawing.Size(87, 23);
            this.cT_Label6.TabIndex = 19;
            this.cT_Label6.Text = "Huyết áp";
            // 
            // cT_Label7
            // 
            this.cT_Label7.AutoSize = true;
            this.cT_Label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cT_Label7.Location = new System.Drawing.Point(52, 136);
            this.cT_Label7.Name = "cT_Label7";
            this.cT_Label7.Size = new System.Drawing.Size(89, 23);
            this.cT_Label7.TabIndex = 2;
            this.cT_Label7.Text = "Cân nặng";
            // 
            // cT_Label8
            // 
            this.cT_Label8.AutoSize = true;
            this.cT_Label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cT_Label8.Location = new System.Drawing.Point(55, 195);
            this.cT_Label8.Name = "cT_Label8";
            this.cT_Label8.Size = new System.Drawing.Size(81, 23);
            this.cT_Label8.TabIndex = 3;
            this.cT_Label8.Text = "Nhịp tim";
            // 
            // cT_Label9
            // 
            this.cT_Label9.AutoSize = true;
            this.cT_Label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cT_Label9.Location = new System.Drawing.Point(52, 267);
            this.cT_Label9.Name = "cT_Label9";
            this.cT_Label9.Size = new System.Drawing.Size(99, 23);
            this.cT_Label9.TabIndex = 4;
            this.cT_Label9.Text = "Chẩn đoán";
            // 
            // txtTemperature
            // 
            this.txtTemperature.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtTemperature.Location = new System.Drawing.Point(196, 61);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(250, 30);
            this.txtTemperature.TabIndex = 20;
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtWeight.Location = new System.Drawing.Point(196, 135);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(250, 30);
            this.txtWeight.TabIndex = 21;
            // 
            // cT_Label10
            // 
            this.cT_Label10.AutoSize = true;
            this.cT_Label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cT_Label10.Location = new System.Drawing.Point(544, 133);
            this.cT_Label10.Name = "cT_Label10";
            this.cT_Label10.Size = new System.Drawing.Size(131, 23);
            this.cT_Label10.TabIndex = 22;
            this.cT_Label10.Text = "Chiều cao(cm)";
            // 
            // txtHeart
            // 
            this.txtHeart.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtHeart.Location = new System.Drawing.Point(196, 195);
            this.txtHeart.Name = "txtHeart";
            this.txtHeart.Size = new System.Drawing.Size(779, 30);
            this.txtHeart.TabIndex = 23;
            // 
            // txtBloodPressure
            // 
            this.txtBloodPressure.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtBloodPressure.Location = new System.Drawing.Point(725, 61);
            this.txtBloodPressure.Name = "txtBloodPressure";
            this.txtBloodPressure.Size = new System.Drawing.Size(250, 30);
            this.txtBloodPressure.TabIndex = 24;
            // 
            // txtHeight
            // 
            this.txtHeight.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtHeight.Location = new System.Drawing.Point(725, 133);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(250, 30);
            this.txtHeight.TabIndex = 25;
            // 
            // KhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 874);
            this.Controls.Add(this.htmlPanel2);
            this.Controls.Add(this.htmlPanel1);
            this.Controls.Add(this.btnDrug);
            this.Name = "KhamBenh";
            this.Text = "Khám Bệnh";
            this.htmlPanel2.ResumeLayout(false);
            this.htmlPanel2.PerformLayout();
            this.htmlPanel1.ResumeLayout(false);
            this.htmlPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlPanel htmlPanel2;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private CustomControl.CT_Button btnDrug;
        private CustomControl.CT_TextBoxOnlyNumber txtHeight;
        private CustomControl.CT_TextBoxOnlyNumber txtBloodPressure;
        private CustomControl.CT_TextBoxOnlyNumber txtHeart;
        private CustomControl.CT_Label cT_Label10;
        private CustomControl.CT_TextBoxOnlyNumber txtWeight;
        private CustomControl.CT_TextBoxOnlyNumber txtTemperature;
        private CustomControl.CT_Label cT_Label9;
        private CustomControl.CT_Label cT_Label6;
        private CustomControl.CT_Label cT_Label8;
        private CustomControl.CT_Label cT_Label5;
        private CustomControl.CT_Label cT_Label7;
        private MetroFramework.Drawing.Html.HtmlPanel htmlPanel1;
        private CustomControl.CT_TextBox txtPhone;
        private CustomControl.CT_TextBox txtGender;
        private CustomControl.CT_TextBox txtBirth;
        private CustomControl.CT_TextBox txtName;
        private CustomControl.CT_Label cT_Label4;
        private CustomControl.CT_Label cT_Label3;
        private CustomControl.CT_Label cT_Label2;
        private CustomControl.CT_Label cT_Label1;
    }
}