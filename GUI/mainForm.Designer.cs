namespace GUI
{
    partial class mainForm
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
            this.menu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbGreeting = new System.Windows.Forms.Label();
            this.labelMenu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menu.Location = new System.Drawing.Point(3, 73);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(322, 959);
            this.menu.TabIndex = 0;
            this.menu.MouseHover += new System.EventHandler(this.menu_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lbGreeting);
            this.panel2.Controls.Add(this.labelMenu);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1960, 60);
            this.panel2.TabIndex = 1;
            // 
            // lbGreeting
            // 
            this.lbGreeting.AutoSize = true;
            this.lbGreeting.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGreeting.ForeColor = System.Drawing.Color.Black;
            this.lbGreeting.Location = new System.Drawing.Point(1285, 21);
            this.lbGreeting.Name = "lbGreeting";
            this.lbGreeting.Size = new System.Drawing.Size(94, 28);
            this.lbGreeting.TabIndex = 1;
            this.lbGreeting.Text = "Xin chào";
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenu.Location = new System.Drawing.Point(96, 19);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(120, 29);
            this.labelMenu.TabIndex = 0;
            this.labelMenu.Text = "Danh mục";
            this.labelMenu.Click += new System.EventHandler(this.labelMenu_Click);
            this.labelMenu.MouseLeave += new System.EventHandler(this.labelMenu_MouseLeave);
            this.labelMenu.MouseHover += new System.EventHandler(this.labelMenu_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(304, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phòng khám đa khoa Tâm Anh";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainPanel.Location = new System.Drawing.Point(331, 73);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1710, 959);
            this.mainPanel.TabIndex = 2;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1092);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menu);
            this.Name = "mainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label lbGreeting;
        private System.Windows.Forms.Label labelMenu;
    }
}