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
    public partial class userForm : Form
    {
        public userForm()
        {
            InitializeComponent();
        }

        private void qL_NGUOIDUNGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qL_NGUOIDUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataBase);

        }

        private void userForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataBase.QL_NGUOIDUNG' table. You can move, or remove it, as needed.
            this.qL_NGUOIDUNGTableAdapter.Fill(this.dataBase.QL_NGUOIDUNG);

        }
    }
}
