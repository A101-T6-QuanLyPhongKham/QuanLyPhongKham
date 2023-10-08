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
    public partial class phanQuyenForm : Form
    {
        public phanQuyenForm()
        {
            InitializeComponent();
        }

        private void qL_NHOMNGUOIDUNGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NHOMNGUOIDUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLPK);

        }

        private void phanQuyenForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLPK.QL_PHANQUYEN' table. You can move, or remove it, as needed.
            this.qL_PHANQUYENTableAdapter.Fill(this.qLPK.QL_PHANQUYEN);
            // TODO: This line of code loads data into the 'qLPK.QL_NHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.qL_NHOMNGUOIDUNGTableAdapter.Fill(this.qLPK.QL_NHOMNGUOIDUNG);

        }

        private void qL_NHOMNGUOIDUNGBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
        public void LoadDataCondition()
        {
            qL_GetPhanQuyenTableAdapter.Fill(qLPK.QL_GetPhanQuyen, qL_NHOMNGUOIDUNGDataGridView.CurrentRow.Cells[0].Value.ToString());
        }
        

        private void qL_NHOMNGUOIDUNGDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            LoadDataCondition();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string _nhomnguoidung = qL_NHOMNGUOIDUNGDataGridView.CurrentRow.Cells[0].Value.ToString();
            foreach (DataGridViewRow item in qL_GetPhanQuyenDataGridView.Rows)
            {
                if (item.Cells[0].Value == null)
                {
                    
                    MessageBox.Show("Lưu thay đổi thành công");
                    return;
                }
                   
                if (qL_GetPhanQuyenTableAdapter.KiemTraKhoaChinhPhanQuyen(_nhomnguoidung, item.Cells[0].Value.ToString()) == null)
                {
                    try
                    {
                        qL_PHANQUYENTableAdapter.Insert(_nhomnguoidung, item.Cells[0].Value.ToString(), (bool)(item.Cells[2].Value));
                        
                    }
                    catch
                    {
                        qL_PHANQUYENTableAdapter.Insert(_nhomnguoidung, item.Cells[0].Value.ToString(), false);
                      
                    }
                }
                else
                {
                    qL_PHANQUYENTableAdapter.UpdateQuery((item.Cells[2] == null) ? false : (bool)(item.Cells[2].Value), _nhomnguoidung, item.Cells[0].Value.ToString());
                    
                }
            }
           
        }

        
    }
}
