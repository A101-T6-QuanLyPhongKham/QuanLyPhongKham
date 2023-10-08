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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addUserToGroupForm));
            this.qLPK = new GUI.QLPK();
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionTableAdapter = new GUI.QLPKTableAdapters.QL_NGUOIDUNGNHOMNGUOIDUNG_ConditionTableAdapter();
            this.tableAdapterManager = new GUI.QLPKTableAdapters.TableAdapterManager();
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qL_NHOMNGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NHOMNGUOIDUNGTableAdapter = new GUI.QLPKTableAdapters.QL_NHOMNGUOIDUNGTableAdapter();
            this.cbbGroup = new System.Windows.Forms.ComboBox();
            this.qL_NGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NGUOIDUNGTableAdapter = new GUI.QLPKTableAdapters.QL_NGUOIDUNGTableAdapter();
            this.qL_NGUOIDUNGDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.qL_NGUOIDUNGNHOMNGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NGUOIDUNGNHOMNGUOIDUNGTableAdapter = new GUI.QLPKTableAdapters.QL_NGUOIDUNGNHOMNGUOIDUNGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLPK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigator)).BeginInit();
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOMNGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGNHOMNGUOIDUNGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // qLPK
            // 
            this.qLPK.DataSetName = "QLPK";
            this.qLPK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingSource
            // 
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingSource.DataMember = "QL_NGUOIDUNGNHOMNGUOIDUNG_Condition";
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingSource.DataSource = this.qLPK;
            // 
            // qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionTableAdapter
            // 
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.QL_NGUOIDUNGNHOMNGUOIDUNG_ConditionTableAdapter = this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionTableAdapter;
            this.tableAdapterManager.QL_NGUOIDUNGNHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.QL_NGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.QL_NHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.QL_PHANQUYENTableAdapter = null;
            this.tableAdapterManager.THUOCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUI.QLPKTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigator
            // 
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigator.BindingSource = this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingSource;
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigatorSaveItem});
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigator.Name = "qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigator";
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigator.Size = new System.Drawing.Size(834, 25);
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigator.TabIndex = 0;
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigatorSaveItem
            // 
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigatorSaveItem.Image")));
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigatorSaveItem.Name = "qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigatorSaveItem";
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigatorSaveItem.Text = "Save Data";
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigatorSaveItem.Click += new System.EventHandler(this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigatorSaveItem_Click);
            // 
            // qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionDataGridView
            // 
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionDataGridView.AutoGenerateColumns = false;
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionDataGridView.DataSource = this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingSource;
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionDataGridView.Location = new System.Drawing.Point(342, 99);
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionDataGridView.Name = "qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionDataGridView";
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionDataGridView.Size = new System.Drawing.Size(300, 220);
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TENDANGNHAP";
            this.dataGridViewTextBoxColumn1.HeaderText = "TENDANGNHAP";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MANHOMNGUOIDUNG";
            this.dataGridViewTextBoxColumn2.HeaderText = "MANHOMNGUOIDUNG";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GHICHU";
            this.dataGridViewTextBoxColumn3.HeaderText = "GHICHU";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // qL_NHOMNGUOIDUNGBindingSource
            // 
            this.qL_NHOMNGUOIDUNGBindingSource.DataMember = "QL_NHOMNGUOIDUNG";
            this.qL_NHOMNGUOIDUNGBindingSource.DataSource = this.qLPK;
            // 
            // qL_NHOMNGUOIDUNGTableAdapter
            // 
            this.qL_NHOMNGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // cbbGroup
            // 
            this.cbbGroup.DataSource = this.qL_NHOMNGUOIDUNGBindingSource;
            this.cbbGroup.DisplayMember = "TENNHOM";
            this.cbbGroup.FormattingEnabled = true;
            this.cbbGroup.Location = new System.Drawing.Point(157, 56);
            this.cbbGroup.Name = "cbbGroup";
            this.cbbGroup.Size = new System.Drawing.Size(300, 21);
            this.cbbGroup.TabIndex = 3;
            this.cbbGroup.ValueMember = "MANHOM";
            this.cbbGroup.SelectedIndexChanged += new System.EventHandler(this.qL_NHOMNGUOIDUNGComboBox_SelectedIndexChanged);
            // 
            // qL_NGUOIDUNGBindingSource
            // 
            this.qL_NGUOIDUNGBindingSource.DataMember = "QL_NGUOIDUNG";
            this.qL_NGUOIDUNGBindingSource.DataSource = this.qLPK;
            // 
            // qL_NGUOIDUNGTableAdapter
            // 
            this.qL_NGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // qL_NGUOIDUNGDataGridView
            // 
            this.qL_NGUOIDUNGDataGridView.AutoGenerateColumns = false;
            this.qL_NGUOIDUNGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_NGUOIDUNGDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.qL_NGUOIDUNGDataGridView.DataSource = this.qL_NGUOIDUNGBindingSource;
            this.qL_NGUOIDUNGDataGridView.Location = new System.Drawing.Point(12, 99);
            this.qL_NGUOIDUNGDataGridView.Name = "qL_NGUOIDUNGDataGridView";
            this.qL_NGUOIDUNGDataGridView.Size = new System.Drawing.Size(300, 220);
            this.qL_NGUOIDUNGDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TENDANGNHAP";
            this.dataGridViewTextBoxColumn4.HeaderText = "TENDANGNHAP";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MATKHAU";
            this.dataGridViewTextBoxColumn5.HeaderText = "MATKHAU";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "HOATDONG";
            this.dataGridViewTextBoxColumn6.HeaderText = "HOATDONG";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NV_ID";
            this.dataGridViewTextBoxColumn7.HeaderText = "NV_ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(538, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // qL_NGUOIDUNGNHOMNGUOIDUNGBindingSource
            // 
            this.qL_NGUOIDUNGNHOMNGUOIDUNGBindingSource.DataMember = "FK__QL_NGUOID__TENDA__3A81B327";
            this.qL_NGUOIDUNGNHOMNGUOIDUNGBindingSource.DataSource = this.qL_NGUOIDUNGBindingSource;
            // 
            // qL_NGUOIDUNGNHOMNGUOIDUNGTableAdapter
            // 
            this.qL_NGUOIDUNGNHOMNGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // addUserToGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 410);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.qL_NGUOIDUNGDataGridView);
            this.Controls.Add(this.cbbGroup);
            this.Controls.Add(this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionDataGridView);
            this.Controls.Add(this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigator);
            this.Name = "addUserToGroupForm";
            this.Text = "addUserToGroupForm";
            this.Load += new System.EventHandler(this.addUserToGroupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLPK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigator)).EndInit();
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigator.ResumeLayout(false);
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOMNGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NGUOIDUNGNHOMNGUOIDUNGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLPK qLPK;
        private System.Windows.Forms.BindingSource qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingSource;
        private QLPKTableAdapters.QL_NGUOIDUNGNHOMNGUOIDUNG_ConditionTableAdapter qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionTableAdapter;
        private QLPKTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource qL_NHOMNGUOIDUNGBindingSource;
        private QLPKTableAdapters.QL_NHOMNGUOIDUNGTableAdapter qL_NHOMNGUOIDUNGTableAdapter;
        private System.Windows.Forms.ComboBox cbbGroup;
        private System.Windows.Forms.BindingSource qL_NGUOIDUNGBindingSource;
        private QLPKTableAdapters.QL_NGUOIDUNGTableAdapter qL_NGUOIDUNGTableAdapter;
        private System.Windows.Forms.DataGridView qL_NGUOIDUNGDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource qL_NGUOIDUNGNHOMNGUOIDUNGBindingSource;
        private QLPKTableAdapters.QL_NGUOIDUNGNHOMNGUOIDUNGTableAdapter qL_NGUOIDUNGNHOMNGUOIDUNGTableAdapter;
    }
}