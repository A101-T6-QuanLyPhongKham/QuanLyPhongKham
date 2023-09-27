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
    public partial class userGroupForm : Form
    {
        public userGroupForm()
        {
            InitializeComponent();
        }

        private void qL_NHOMNGUOIDUNGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NHOMNGUOIDUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataBase);

        }

        private void userGroupForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataBase.QL_NHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.qL_NHOMNGUOIDUNGTableAdapter.Fill(this.dataBase.QL_NHOMNGUOIDUNG);

        }
    }
}
