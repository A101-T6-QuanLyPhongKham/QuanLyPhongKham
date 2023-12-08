using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;
namespace GUI
{
    public partial class addUserToGroupForm : UserControl
    {
        GroupUser gr = new GroupUser();
        TaiKhoan tk = new TaiKhoan();
        public addUserToGroupForm()
        {
            InitializeComponent();
        }

        private void addUserToGroupForm_Load(object sender, EventArgs e)
        {
            cbbgroup.DataSource = gr.get_list_group_user();
            cbbgroup.ValueMember = "manhom";
            cbbgroup.DisplayMember = "tennhom";
        }

        private void cbbgroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbbgroup.SelectedValue == null)
            //    return;
            //tk.get_list_account_in_group((int)cbbgroup.SelectedValue);
        }
    }
}
