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
    public partial class screenListForm : Form
    {
        public screenListForm()
        {
            InitializeComponent();
        }

        private void dM_MANHINHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dM_MANHINHBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataBase);

        }

        private void screenListForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataBase.DM_MANHINH' table. You can move, or remove it, as needed.
            this.dM_MANHINHTableAdapter.Fill(this.dataBase.DM_MANHINH);

        }
    }
}
