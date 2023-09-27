namespace GUI
{
    partial class addUserToGroupForm
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
            System.Windows.Forms.Label tENNHOMLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addUserToGroupForm));
            this.dataBase = new GUI.DataBase();
            this.qL_NGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NGUOIDUNGTableAdapter = new GUI.DataBaseTableAdapters.QL_NGUOIDUNGTableAdapter();
            this.tableAdapterManager = new GUI.DataBaseTableAdapters.TableAdapterManager();
            this.qL_NGUOIDUNGNHOMNGUOIDUNGTableAdapter = new GUI.DataBaseTableAdapters.QL_NGUOIDUNGNHOMNGUOIDUNGTableAdapter();
            this.qL_NHOMNGUOIDUNGTableAdapter = new GUI.DataBaseTableAdapters.QL_NHOMNGUOIDUNGTableAdapter();
            this.qL_NGUOIDUNGBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.qL_NGUOIDUNGBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dgvUserList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qL_NGUOIDUNGNHOMNGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NGUOIDUNGNHOMNGUOIDUNGDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qL_NHOMNGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbbGroupName = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            tENNHOMLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGBindingNavigator)).BeginInit();
            this.qL_NGUOIDUNGBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGNHOMNGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGNHOMNGUOIDUNGDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOMNGUOIDUNGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tENNHOMLabel
            // 
            tENNHOMLabel.AutoSize = true;
            tENNHOMLabel.Location = new System.Drawing.Point(289, 64);
            tENNHOMLabel.Name = "tENNHOMLabel";
            tENNHOMLabel.Size = new System.Drawing.Size(82, 17);
            tENNHOMLabel.TabIndex = 3;
            tENNHOMLabel.Text = "TENNHOM:";
            // 
            // dataBase
            // 
            this.dataBase.DataSetName = "DataBase";
            this.dataBase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qL_NGUOIDUNGBindingSource
            // 
            this.qL_NGUOIDUNGBindingSource.DataMember = "QL_NGUOIDUNG";
            this.qL_NGUOIDUNGBindingSource.DataSource = this.dataBase;
            // 
            // qL_NGUOIDUNGTableAdapter
            // 
            this.qL_NGUOIDUNGTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.QL_NGUOIDUNGNHOMNGUOIDUNGTableAdapter = this.qL_NGUOIDUNGNHOMNGUOIDUNGTableAdapter;
            this.tableAdapterManager.QL_NGUOIDUNGTableAdapter = this.qL_NGUOIDUNGTableAdapter;
            this.tableAdapterManager.QL_NHOMNGUOIDUNGTableAdapter = this.qL_NHOMNGUOIDUNGTableAdapter;
            this.tableAdapterManager.QL_PHANQUYENTableAdapter = null;
            this.tableAdapterManager.THUOCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUI.DataBaseTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qL_NGUOIDUNGNHOMNGUOIDUNGTableAdapter
            // 
            this.qL_NGUOIDUNGNHOMNGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // qL_NHOMNGUOIDUNGTableAdapter
            // 
            this.qL_NHOMNGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // qL_NGUOIDUNGBindingNavigator
            // 
            this.qL_NGUOIDUNGBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.qL_NGUOIDUNGBindingNavigator.BindingSource = this.qL_NGUOIDUNGBindingSource;
            this.qL_NGUOIDUNGBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.qL_NGUOIDUNGBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.qL_NGUOIDUNGBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.qL_NGUOIDUNGBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.qL_NGUOIDUNGBindingNavigatorSaveItem});
            this.qL_NGUOIDUNGBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.qL_NGUOIDUNGBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.qL_NGUOIDUNGBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.qL_NGUOIDUNGBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.qL_NGUOIDUNGBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.qL_NGUOIDUNGBindingNavigator.Name = "qL_NGUOIDUNGBindingNavigator";
            this.qL_NGUOIDUNGBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.qL_NGUOIDUNGBindingNavigator.Size = new System.Drawing.Size(1051, 27);
            this.qL_NGUOIDUNGBindingNavigator.TabIndex = 0;
            this.qL_NGUOIDUNGBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // qL_NGUOIDUNGBindingNavigatorSaveItem
            // 
            this.qL_NGUOIDUNGBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.qL_NGUOIDUNGBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("qL_NGUOIDUNGBindingNavigatorSaveItem.Image")));
            this.qL_NGUOIDUNGBindingNavigatorSaveItem.Name = "qL_NGUOIDUNGBindingNavigatorSaveItem";
            this.qL_NGUOIDUNGBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.qL_NGUOIDUNGBindingNavigatorSaveItem.Text = "Save Data";
            this.qL_NGUOIDUNGBindingNavigatorSaveItem.Click += new System.EventHandler(this.qL_NGUOIDUNGBindingNavigatorSaveItem_Click);
            // 
            // dgvUserList
            // 
            this.dgvUserList.AutoGenerateColumns = false;
            this.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvUserList.DataSource = this.qL_NGUOIDUNGBindingSource;
            this.dgvUserList.Location = new System.Drawing.Point(22, 136);
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.RowTemplate.Height = 24;
            this.dgvUserList.Size = new System.Drawing.Size(392, 220);
            this.dgvUserList.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TENDANGNHAP";
            this.dataGridViewTextBoxColumn1.HeaderText = "TENDANGNHAP";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MATKHAU";
            this.dataGridViewTextBoxColumn2.HeaderText = "MATKHAU";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HOATDONG";
            this.dataGridViewTextBoxColumn3.HeaderText = "HOATDONG";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NV_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "NV_ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // qL_NGUOIDUNGNHOMNGUOIDUNGBindingSource
            // 
            this.qL_NGUOIDUNGNHOMNGUOIDUNGBindingSource.DataMember = "QL_NGUOIDUNGNHOMNGUOIDUNG";
            this.qL_NGUOIDUNGNHOMNGUOIDUNGBindingSource.DataSource = this.dataBase;
            // 
            // qL_NGUOIDUNGNHOMNGUOIDUNGDataGridView
            // 
            this.qL_NGUOIDUNGNHOMNGUOIDUNGDataGridView.AutoGenerateColumns = false;
            this.qL_NGUOIDUNGNHOMNGUOIDUNGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_NGUOIDUNGNHOMNGUOIDUNGDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.qL_NGUOIDUNGNHOMNGUOIDUNGDataGridView.DataSource = this.qL_NGUOIDUNGNHOMNGUOIDUNGBindingSource;
            this.qL_NGUOIDUNGNHOMNGUOIDUNGDataGridView.Location = new System.Drawing.Point(599, 136);
            this.qL_NGUOIDUNGNHOMNGUOIDUNGDataGridView.Name = "qL_NGUOIDUNGNHOMNGUOIDUNGDataGridView";
            this.qL_NGUOIDUNGNHOMNGUOIDUNGDataGridView.RowTemplate.Height = 24;
            this.qL_NGUOIDUNGNHOMNGUOIDUNGDataGridView.Size = new System.Drawing.Size(369, 220);
            this.qL_NGUOIDUNGNHOMNGUOIDUNGDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TENDANGNHAP";
            this.dataGridViewTextBoxColumn5.HeaderText = "TENDANGNHAP";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MANHOMNGUOIDUNG";
            this.dataGridViewTextBoxColumn6.HeaderText = "MANHOMNGUOIDUNG";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "GHICHU";
            this.dataGridViewTextBoxColumn7.HeaderText = "GHICHU";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // qL_NHOMNGUOIDUNGBindingSource
            // 
            this.qL_NHOMNGUOIDUNGBindingSource.DataMember = "QL_NHOMNGUOIDUNG";
            this.qL_NHOMNGUOIDUNGBindingSource.DataSource = this.dataBase;
            // 
            // cbbGroupName
            // 
            this.cbbGroupName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.qL_NHOMNGUOIDUNGBindingSource, "TENNHOM", true));
            this.cbbGroupName.FormattingEnabled = true;
            this.cbbGroupName.Location = new System.Drawing.Point(377, 61);
            this.cbbGroupName.Name = "cbbGroupName";
            this.cbbGroupName.Size = new System.Drawing.Size(121, 24);
            this.cbbGroupName.TabIndex = 4;
            this.cbbGroupName.SelectedIndexChanged += new System.EventHandler(this.cbbGroupName_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thêm vào nhóm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(438, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "Xóa khỏi nhóm";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // addUserToGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 444);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(tENNHOMLabel);
            this.Controls.Add(this.cbbGroupName);
            this.Controls.Add(this.qL_NGUOIDUNGNHOMNGUOIDUNGDataGridView);
            this.Controls.Add(this.dgvUserList);
            this.Controls.Add(this.qL_NGUOIDUNGBindingNavigator);
            this.Name = "addUserToGroupForm";
            this.Text = "s";
            this.Load += new System.EventHandler(this.addUserToGroupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGBindingNavigator)).EndInit();
            this.qL_NGUOIDUNGBindingNavigator.ResumeLayout(false);
            this.qL_NGUOIDUNGBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGNHOMNGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGNHOMNGUOIDUNGDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOMNGUOIDUNGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataBase dataBase;
        private System.Windows.Forms.BindingSource qL_NGUOIDUNGBindingSource;
        private DataBaseTableAdapters.QL_NGUOIDUNGTableAdapter qL_NGUOIDUNGTableAdapter;
        private DataBaseTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator qL_NGUOIDUNGBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton qL_NGUOIDUNGBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dgvUserList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataBaseTableAdapters.QL_NGUOIDUNGNHOMNGUOIDUNGTableAdapter qL_NGUOIDUNGNHOMNGUOIDUNGTableAdapter;
        private System.Windows.Forms.BindingSource qL_NGUOIDUNGNHOMNGUOIDUNGBindingSource;
        private DataBaseTableAdapters.QL_NHOMNGUOIDUNGTableAdapter qL_NHOMNGUOIDUNGTableAdapter;
        private System.Windows.Forms.DataGridView qL_NGUOIDUNGNHOMNGUOIDUNGDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource qL_NHOMNGUOIDUNGBindingSource;
        private System.Windows.Forms.ComboBox cbbGroupName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}