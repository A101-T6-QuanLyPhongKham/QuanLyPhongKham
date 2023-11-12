namespace GUI
{
    partial class ListRoomForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pnlistRoom = new MetroFramework.Drawing.Html.HtmlPanel();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(275, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(145, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Phòng khám Tâm Anh";
            // 
            // pnlistRoom
            // 
            this.pnlistRoom.AutoScroll = true;
            this.pnlistRoom.AutoScrollMinSize = new System.Drawing.Size(1113, 23);
            this.pnlistRoom.BackColor = System.Drawing.SystemColors.Window;
            this.pnlistRoom.Location = new System.Drawing.Point(29, 69);
            this.pnlistRoom.Name = "pnlistRoom";
            this.pnlistRoom.Size = new System.Drawing.Size(1113, 629);
            this.pnlistRoom.TabIndex = 1;
            this.pnlistRoom.Text = "Danh sách phòng khám bệnh";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(864, 32);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(129, 17);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Xin chào bác sĩ Hải";
            // 
            // ListRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 763);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pnlistRoom);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ListRoomForm";
            this.Text = "ListRoomForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Drawing.Html.HtmlPanel pnlistRoom;
        private System.Windows.Forms.Label labelName;
    }
}