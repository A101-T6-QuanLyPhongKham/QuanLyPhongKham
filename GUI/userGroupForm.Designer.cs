namespace GUI
{
    partial class userGroupForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userGroupForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataBase = new GUI.DataBase();
            this.qL_NHOMNGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NHOMNGUOIDUNGTableAdapter = new GUI.DataBaseTableAdapters.QL_NHOMNGUOIDUNGTableAdapter();
            this.tableAdapterManager = new GUI.DataBaseTableAdapters.TableAdapterManager();
            this.qL_NHOMNGUOIDUNGBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.qL_NHOMNGUOIDUNGBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.qL_NHOMNGUOIDUNGDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOMNGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOMNGUOIDUNGBindingNavigator)).BeginInit();
            this.qL_NHOMNGUOIDUNGBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOMNGUOIDUNGDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhóm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Nhóm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ghi Chú";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(165, 22);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(200, 36);
            this.guna2TextBox1.TabIndex = 3;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(165, 85);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(200, 36);
            this.guna2TextBox2.TabIndex = 4;
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox3.Location = new System.Drawing.Point(165, 155);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PasswordChar = '\0';
            this.guna2TextBox3.PlaceholderText = "";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.Size = new System.Drawing.Size(200, 36);
            this.guna2TextBox3.TabIndex = 5;
            // 
            // dataBase
            // 
            this.dataBase.DataSetName = "DataBase";
            this.dataBase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qL_NHOMNGUOIDUNGBindingSource
            // 
            this.qL_NHOMNGUOIDUNGBindingSource.DataMember = "QL_NHOMNGUOIDUNG";
            this.qL_NHOMNGUOIDUNGBindingSource.DataSource = this.dataBase;
            // 
            // qL_NHOMNGUOIDUNGTableAdapter
            // 
            this.qL_NHOMNGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BENH_NHANTableAdapter = null;
            this.tableAdapterManager.CHITIET_HDTableAdapter = null;
            this.tableAdapterManager.CHUC_VUTableAdapter = null;
            this.tableAdapterManager.DM_MANHINHTableAdapter = null;
            this.tableAdapterManager.HOA_DONTableAdapter = null;
            this.tableAdapterManager.LICH_HENTableAdapter = null;
            this.tableAdapterManager.LOAI_KHAMTableAdapter = null;
            this.tableAdapterManager.NHAN_VIENTableAdapter = null;
            this.tableAdapterManager.PHIEU_KHAMTableAdapter = null;
            this.tableAdapterManager.QL_NGUOIDUNGNHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.QL_NGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.QL_NHOMNGUOIDUNGTableAdapter = this.qL_NHOMNGUOIDUNGTableAdapter;
            this.tableAdapterManager.QL_PHANQUYENTableAdapter = null;
            this.tableAdapterManager.THUOCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUI.DataBaseTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qL_NHOMNGUOIDUNGBindingNavigator
            // 
            this.qL_NHOMNGUOIDUNGBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.qL_NHOMNGUOIDUNGBindingNavigator.BindingSource = this.qL_NHOMNGUOIDUNGBindingSource;
            this.qL_NHOMNGUOIDUNGBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.qL_NHOMNGUOIDUNGBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.qL_NHOMNGUOIDUNGBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.qL_NHOMNGUOIDUNGBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.qL_NHOMNGUOIDUNGBindingNavigatorSaveItem});
            this.qL_NHOMNGUOIDUNGBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.qL_NHOMNGUOIDUNGBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.qL_NHOMNGUOIDUNGBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.qL_NHOMNGUOIDUNGBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.qL_NHOMNGUOIDUNGBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.qL_NHOMNGUOIDUNGBindingNavigator.Name = "qL_NHOMNGUOIDUNGBindingNavigator";
            this.qL_NHOMNGUOIDUNGBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.qL_NHOMNGUOIDUNGBindingNavigator.Size = new System.Drawing.Size(701, 27);
            this.qL_NHOMNGUOIDUNGBindingNavigator.TabIndex = 6;
            this.qL_NHOMNGUOIDUNGBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // qL_NHOMNGUOIDUNGBindingNavigatorSaveItem
            // 
            this.qL_NHOMNGUOIDUNGBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.qL_NHOMNGUOIDUNGBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("qL_NHOMNGUOIDUNGBindingNavigatorSaveItem.Image")));
            this.qL_NHOMNGUOIDUNGBindingNavigatorSaveItem.Name = "qL_NHOMNGUOIDUNGBindingNavigatorSaveItem";
            this.qL_NHOMNGUOIDUNGBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.qL_NHOMNGUOIDUNGBindingNavigatorSaveItem.Text = "Save Data";
            this.qL_NHOMNGUOIDUNGBindingNavigatorSaveItem.Click += new System.EventHandler(this.qL_NHOMNGUOIDUNGBindingNavigatorSaveItem_Click);
            // 
            // qL_NHOMNGUOIDUNGDataGridView
            // 
            this.qL_NHOMNGUOIDUNGDataGridView.AutoGenerateColumns = false;
            this.qL_NHOMNGUOIDUNGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_NHOMNGUOIDUNGDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.qL_NHOMNGUOIDUNGDataGridView.DataSource = this.qL_NHOMNGUOIDUNGBindingSource;
            this.qL_NHOMNGUOIDUNGDataGridView.Location = new System.Drawing.Point(34, 216);
            this.qL_NHOMNGUOIDUNGDataGridView.Name = "qL_NHOMNGUOIDUNGDataGridView";
            this.qL_NHOMNGUOIDUNGDataGridView.RowTemplate.Height = 24;
            this.qL_NHOMNGUOIDUNGDataGridView.Size = new System.Drawing.Size(587, 220);
            this.qL_NHOMNGUOIDUNGDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MANHOM";
            this.dataGridViewTextBoxColumn1.HeaderText = "MANHOM";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENNHOM";
            this.dataGridViewTextBoxColumn2.HeaderText = "TENNHOM";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GHICHU";
            this.dataGridViewTextBoxColumn3.HeaderText = "GHICHU";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // userGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 472);
            this.Controls.Add(this.qL_NHOMNGUOIDUNGDataGridView);
            this.Controls.Add(this.qL_NHOMNGUOIDUNGBindingNavigator);
            this.Controls.Add(this.guna2TextBox3);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "userGroupForm";
            this.Text = "userGroupForm";
            this.Load += new System.EventHandler(this.userGroupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOMNGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOMNGUOIDUNGBindingNavigator)).EndInit();
            this.qL_NHOMNGUOIDUNGBindingNavigator.ResumeLayout(false);
            this.qL_NHOMNGUOIDUNGBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOMNGUOIDUNGDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private DataBase dataBase;
        private System.Windows.Forms.BindingSource qL_NHOMNGUOIDUNGBindingSource;
        private DataBaseTableAdapters.QL_NHOMNGUOIDUNGTableAdapter qL_NHOMNGUOIDUNGTableAdapter;
        private DataBaseTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator qL_NHOMNGUOIDUNGBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton qL_NHOMNGUOIDUNGBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView qL_NHOMNGUOIDUNGDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}