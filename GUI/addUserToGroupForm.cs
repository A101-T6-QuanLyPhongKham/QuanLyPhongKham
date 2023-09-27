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
            loadUserList();
        }

        private void qL_NGUOIDUNGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NGUOIDUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataBase);

        }

        private void addUserToGroupForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataBase.QL_NHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.qL_NHOMNGUOIDUNGTableAdapter.Fill(this.dataBase.QL_NHOMNGUOIDUNG);
            // TODO: This line of code loads data into the 'dataBase.QL_NGUOIDUNGNHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.qL_NGUOIDUNGNHOMNGUOIDUNGTableAdapter.Fill(this.dataBase.QL_NGUOIDUNGNHOMNGUOIDUNG);
            // TODO: This line of code loads data into the 'dataBase.QL_NGUOIDUNG' table. You can move, or remove it, as needed.
            this.qL_NGUOIDUNGTableAdapter.Fill(this.dataBase.QL_NGUOIDUNG);

        }

        private void cbbGroupName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loadUserList()
        {
            
        }
    }
}
