namespace GUI
{
    partial class phanQuyenForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.qL_NHOMNGUOIDUNGDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qL_NHOMNGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLPK = new GUI.QLPK();
            this.qL_GetPhanQuyenDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coquyen = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.qL_GetPhanQuyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.qL_NHOMNGUOIDUNGTableAdapter = new GUI.QLPKTableAdapters.QL_NHOMNGUOIDUNGTableAdapter();
            this.tableAdapterManager = new GUI.QLPKTableAdapters.TableAdapterManager();
            this.qL_GetPhanQuyenTableAdapter = new GUI.QLPKTableAdapters.QL_GetPhanQuyenTableAdapter();
            this.qL_PHANQUYENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_PHANQUYENTableAdapter = new GUI.QLPKTableAdapters.QL_PHANQUYENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOMNGUOIDUNGDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOMNGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GetPhanQuyenDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GetPhanQuyenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_PHANQUYENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách nhóm người dùng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(505, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách quyền chức năng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.qL_NHOMNGUOIDUNGDataGridView.Location = new System.Drawing.Point(42, 126);
            this.qL_NHOMNGUOIDUNGDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.qL_NHOMNGUOIDUNGDataGridView.Name = "qL_NHOMNGUOIDUNGDataGridView";
            this.qL_NHOMNGUOIDUNGDataGridView.Size = new System.Drawing.Size(400, 271);
            this.qL_NHOMNGUOIDUNGDataGridView.TabIndex = 3;
            this.qL_NHOMNGUOIDUNGDataGridView.SelectionChanged += new System.EventHandler(this.qL_NHOMNGUOIDUNGDataGridView_SelectionChanged);
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
            // qL_NHOMNGUOIDUNGBindingSource
            // 
            this.qL_NHOMNGUOIDUNGBindingSource.DataMember = "QL_NHOMNGUOIDUNG";
            this.qL_NHOMNGUOIDUNGBindingSource.DataSource = this.qLPK;
            // 
            // qLPK
            // 
            this.qLPK.DataSetName = "QLPK";
            this.qLPK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qL_GetPhanQuyenDataGridView
            // 
            this.qL_GetPhanQuyenDataGridView.AutoGenerateColumns = false;
            this.qL_GetPhanQuyenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.qL_GetPhanQuyenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.coquyen});
            this.qL_GetPhanQuyenDataGridView.DataSource = this.qL_GetPhanQuyenBindingSource;
            this.qL_GetPhanQuyenDataGridView.Location = new System.Drawing.Point(501, 126);
            this.qL_GetPhanQuyenDataGridView.Name = "qL_GetPhanQuyenDataGridView";
            this.qL_GetPhanQuyenDataGridView.RowTemplate.Height = 24;
            this.qL_GetPhanQuyenDataGridView.Size = new System.Drawing.Size(734, 271);
            this.qL_GetPhanQuyenDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MAMANHINH";
            this.dataGridViewTextBoxColumn4.HeaderText = "MAMANHINH";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TENMANHINH";
            this.dataGridViewTextBoxColumn5.HeaderText = "TENMANHINH";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 300;
            // 
            // coquyen
            // 
            this.coquyen.DataPropertyName = "coquyen";
            this.coquyen.HeaderText = "COQUYEN";
            this.coquyen.Name = "coquyen";
            // 
            // qL_GetPhanQuyenBindingSource
            // 
            this.qL_GetPhanQuyenBindingSource.DataMember = "QL_GetPhanQuyen";
            this.qL_GetPhanQuyenBindingSource.DataSource = this.qLPK;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSave.Location = new System.Drawing.Point(53, 25);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 38);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.tableAdapterManager.QL_NGUOIDUNGNHOMNGUOIDUNG_ConditionTableAdapter = null;
            this.tableAdapterManager.QL_NGUOIDUNGNHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.QL_NGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.QL_NHOMNGUOIDUNGTableAdapter = this.qL_NHOMNGUOIDUNGTableAdapter;
            this.tableAdapterManager.QL_PHANQUYENTableAdapter = null;
            this.tableAdapterManager.THUOCTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GUI.QLPKTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // qL_GetPhanQuyenTableAdapter
            // 
            this.qL_GetPhanQuyenTableAdapter.ClearBeforeFill = true;
            // 
            // qL_PHANQUYENBindingSource
            // 
            this.qL_PHANQUYENBindingSource.DataMember = "QL_PHANQUYEN";
            this.qL_PHANQUYENBindingSource.DataSource = this.qLPK;
            // 
            // qL_PHANQUYENTableAdapter
            // 
            this.qL_PHANQUYENTableAdapter.ClearBeforeFill = true;
            // 
            // phanQuyenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 654);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.qL_GetPhanQuyenDataGridView);
            this.Controls.Add(this.qL_NHOMNGUOIDUNGDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "phanQuyenForm";
            this.Text = "phanQuyenForm";
            this.Load += new System.EventHandler(this.phanQuyenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOMNGUOIDUNGDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NHOMNGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLPK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GetPhanQuyenDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GetPhanQuyenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_PHANQUYENBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private QLPK qLPK;
        private System.Windows.Forms.BindingSource qL_NHOMNGUOIDUNGBindingSource;
        private QLPKTableAdapters.QL_NHOMNGUOIDUNGTableAdapter qL_NHOMNGUOIDUNGTableAdapter;
        private QLPKTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView qL_NHOMNGUOIDUNGDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource qL_GetPhanQuyenBindingSource;
        private QLPKTableAdapters.QL_GetPhanQuyenTableAdapter qL_GetPhanQuyenTableAdapter;
        private System.Windows.Forms.DataGridView qL_GetPhanQuyenDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn coquyen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource qL_PHANQUYENBindingSource;
        private QLPKTableAdapters.QL_PHANQUYENTableAdapter qL_PHANQUYENTableAdapter;
    }
}