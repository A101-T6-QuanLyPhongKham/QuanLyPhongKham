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
            this.pnlistRoom = new MetroFramework.Drawing.Html.HtmlPanel();
            this.SuspendLayout();
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
            // ListRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlistRoom);
            this.Name = "ListRoomForm";
            this.Size = new System.Drawing.Size(1295, 763);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlPanel pnlistRoom;
    }
}