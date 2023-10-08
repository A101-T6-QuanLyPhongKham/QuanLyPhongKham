using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class addUserToGroupForm : Form
    {
        public addUserToGroupForm()
        {
            InitializeComponent();
        }

        private void qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLPK);

        }

       

        private void addUserToGroupForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLPK.QL_NGUOIDUNGNHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.qL_NGUOIDUNGNHOMNGUOIDUNGTableAdapter.Fill(this.qLPK.QL_NGUOIDUNGNHOMNGUOIDUNG);
            // TODO: This line of code loads data into the 'qLPK.QL_NGUOIDUNGNHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.qL_NGUOIDUNGNHOMNGUOIDUNGTableAdapter.Fill(this.qLPK.QL_NGUOIDUNGNHOMNGUOIDUNG);
            // TODO: This line of code loads data into the 'qLPK.QL_NGUOIDUNG' table. You can move, or remove it, as needed.
            this.qL_NGUOIDUNGTableAdapter.Fill(this.qLPK.QL_NGUOIDUNG);
            // TODO: This line of code loads data into the 'qLPK.QL_NHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.qL_NHOMNGUOIDUNGTableAdapter.Fill(this.qLPK.QL_NHOMNGUOIDUNG);

        }

        private void qL_NHOMNGUOIDUNGComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbGroup.SelectedValue == null)
            {
                return;
            }
            string tennhom = cbbGroup.SelectedValue.ToString();
            
            try
            {
                this.qL_NGUOIDUNGNHOMNGUOIDUNG_ConditionTableAdapter.Fill(this.qLPK.QL_NGUOIDUNGNHOMNGUOIDUNG_Condition, tennhom);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tendn = qL_NGUOIDUNGDataGridView.CurrentRow.Cells[0].Value.ToString();
            string tennhom = cbbGroup.SelectedValue.ToString();
            try
            {
                qL_NGUOIDUNGNHOMNGUOIDUNGTableAdapter.Insert(tendn, tennhom, "");
                MessageBox.Show("Thêm người dùng vào nhóm thành công");
                qL_NGUOIDUNGNHOMNGUOIDUNGTableAdapter.GetData();
            }
            catch
            {
                MessageBox.Show("Người dùng đã thuộc nhóm" + cbbGroup.SelectedValue.ToString());
            }
            
        }
    }
}
