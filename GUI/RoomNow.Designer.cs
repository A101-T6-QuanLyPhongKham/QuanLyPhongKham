namespace GUI
{
    partial class RoomNow
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
            this.btnClose = new CustomControl.CT_Button();
            this.btnCancel = new CustomControl.CT_Button();
            this.txtDoctor = new CustomControl.CT_TextBox();
            this.txtRoom = new CustomControl.CT_TextBox();
            this.txtBirth = new CustomControl.CT_TextBox();
            this.txtName = new CustomControl.CT_TextBox();
            this.cT_Label4 = new CustomControl.CT_Label();
            this.cT_Label3 = new CustomControl.CT_Label();
            this.cT_Label2 = new CustomControl.CT_Label();
            this.cT_Label1 = new CustomControl.CT_Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(369, 338);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 50);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(167, 338);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 50);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Hủy phiếu";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtDoctor
            // 
            this.txtDoctor.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtDoctor.Location = new System.Drawing.Point(293, 264);
            this.txtDoctor.Name = "txtDoctor";
            this.txtDoctor.Size = new System.Drawing.Size(238, 30);
            this.txtDoctor.TabIndex = 18;
            // 
            // txtRoom
            // 
            this.txtRoom.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtRoom.Location = new System.Drawing.Point(293, 200);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(238, 30);
            this.txtRoom.TabIndex = 17;
            // 
            // txtBirth
            // 
            this.txtBirth.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtBirth.Location = new System.Drawing.Point(293, 132);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.Size = new System.Drawing.Size(238, 30);
            this.txtBirth.TabIndex = 16;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtName.Location = new System.Drawing.Point(293, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 30);
            this.txtName.TabIndex = 15;
            // 
            // cT_Label4
            // 
            this.cT_Label4.AutoSize = true;
            this.cT_Label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cT_Label4.Location = new System.Drawing.Point(90, 264);
            this.cT_Label4.Name = "cT_Label4";
            this.cT_Label4.Size = new System.Drawing.Size(60, 23);
            this.cT_Label4.TabIndex = 14;
            this.cT_Label4.Text = "Bác sĩ";
            // 
            // cT_Label3
            // 
            this.cT_Label3.AutoSize = true;
            this.cT_Label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cT_Label3.Location = new System.Drawing.Point(88, 200);
            this.cT_Label3.Name = "cT_Label3";
            this.cT_Label3.Size = new System.Drawing.Size(62, 23);
            this.cT_Label3.TabIndex = 13;
            this.cT_Label3.Text = "Phòng";
            // 
            // cT_Label2
            // 
            this.cT_Label2.AutoSize = true;
            this.cT_Label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cT_Label2.Location = new System.Drawing.Point(88, 71);
            this.cT_Label2.Name = "cT_Label2";
            this.cT_Label2.Size = new System.Drawing.Size(156, 23);
            this.cT_Label2.TabIndex = 12;
            this.cT_Label2.Text = "Họ tên bệnh nhân";
            // 
            // cT_Label1
            // 
            this.cT_Label1.AutoSize = true;
            this.cT_Label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cT_Label1.Location = new System.Drawing.Point(88, 132);
            this.cT_Label1.Name = "cT_Label1";
            this.cT_Label1.Size = new System.Drawing.Size(87, 23);
            this.cT_Label1.TabIndex = 11;
            this.cT_Label1.Text = "Năm sinh";
            // 
            // RoomNow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 526);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtDoctor);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.txtBirth);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cT_Label4);
            this.Controls.Add(this.cT_Label3);
            this.Controls.Add(this.cT_Label2);
            this.Controls.Add(this.cT_Label1);
            this.Name = "RoomNow";
            this.Text = "Thông tin phiếu khám hiện tại";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControl.CT_Label cT_Label1;
        private CustomControl.CT_Label cT_Label2;
        private CustomControl.CT_Label cT_Label3;
        private CustomControl.CT_Label cT_Label4;
        private CustomControl.CT_TextBox txtName;
        private CustomControl.CT_TextBox txtBirth;
        private CustomControl.CT_TextBox txtRoom;
        private CustomControl.CT_TextBox txtDoctor;
        private CustomControl.CT_Button btnCancel;
        private CustomControl.CT_Button btnClose;

    }
}