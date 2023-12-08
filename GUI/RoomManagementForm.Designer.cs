namespace GUI
{
    partial class RoomManagementForm
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
            this.dgvRoomList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbState = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSpecialty = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRoomList
            // 
            this.dgvRoomList.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dgvRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomList.Location = new System.Drawing.Point(3, 411);
            this.dgvRoomList.Name = "dgvRoomList";
            this.dgvRoomList.ReadOnly = true;
            this.dgvRoomList.RowTemplate.Height = 24;
            this.dgvRoomList.Size = new System.Drawing.Size(1394, 1500);
            this.dgvRoomList.TabIndex = 0;
            this.dgvRoomList.SelectionChanged += new System.EventHandler(this.dgvRoomList_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chuyên khoa";
            // 
            // cbState
            // 
            this.cbState.AutoSize = true;
            this.cbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbState.Location = new System.Drawing.Point(579, 154);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(124, 29);
            this.cbState.TabIndex = 3;
            this.cbState.Text = "Hoạt động";
            this.cbState.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(64, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 50);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Fuchsia;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(64, 133);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 50);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.HotPink;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(64, 222);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 50);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtSpecialty
            // 
            // 
            // 
            // 
            this.txtSpecialty.CustomButton.Image = null;
            this.txtSpecialty.CustomButton.Location = new System.Drawing.Point(305, 1);
            this.txtSpecialty.CustomButton.Name = "";
            this.txtSpecialty.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtSpecialty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSpecialty.CustomButton.TabIndex = 1;
            this.txtSpecialty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSpecialty.CustomButton.UseSelectable = true;
            this.txtSpecialty.CustomButton.Visible = false;
            this.txtSpecialty.Lines = new string[0];
            this.txtSpecialty.Location = new System.Drawing.Point(579, 83);
            this.txtSpecialty.MaxLength = 32767;
            this.txtSpecialty.Name = "txtSpecialty";
            this.txtSpecialty.PasswordChar = '\0';
            this.txtSpecialty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSpecialty.SelectedText = "";
            this.txtSpecialty.SelectionLength = 0;
            this.txtSpecialty.SelectionStart = 0;
            this.txtSpecialty.ShortcutsEnabled = true;
            this.txtSpecialty.Size = new System.Drawing.Size(333, 29);
            this.txtSpecialty.TabIndex = 7;
            this.txtSpecialty.UseSelectable = true;
            this.txtSpecialty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSpecialty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Trạng thái";
            // 
            // RoomManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSpecialty);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRoomList);
            this.Name = "RoomManagementForm";
            this.Size = new System.Drawing.Size(1400, 797);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRoomList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbState;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private MetroFramework.Controls.MetroTextBox txtSpecialty;
        private System.Windows.Forms.Label label2;
    }
}