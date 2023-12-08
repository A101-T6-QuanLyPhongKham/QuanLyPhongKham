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
    public partial class groupUserManagement : UserControl
    {
        GroupUser gr = new GroupUser();
        public groupUserManagement()
        {
            InitializeComponent();
            load_data();
            
        }
        private bool check_data()
        {
           
            if (txtName.Text.ToString() == "")
            {
                MessageBox.Show("Nhập vào tên nhóm");
                txtName.Focus();
                return false;
            }
            return true;
        }
        
        private void load_data()
        {
            dgvList.DataSource = gr.get_list_group_user();
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!gr.check_Name_Exist(txtName.Text.ToString()))
            {
                MessageBox.Show("Tên nhóm đã tồn tại");
                return;
            }
        }
        private void fill_data()
        {
            txtName.Text = dgvList.CurrentRow.Cells[1].Value.ToString();
            txtDes.Text = dgvList.CurrentRow.Cells[2].Value.ToString();
        }
        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
            fill_data();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            txtName.Text = txtName.Text.Trim();
            if (check_data())
            {
                int _ma = gr.Generate_Code();
                string _ten = txtName.Text.ToString();
                string _ghichu = txtDes.Text.ToString();
                if (!gr.check_Name_Exist(_ten))
                {
                    MessageBox.Show("Tên nhóm đã tồn tại");
                    return;
                }
                if (gr.insert_data(_ma, _ten, _ghichu))
                {
                    MessageBox.Show("Thêm thành công");

                    load_data();

                }
                else
                    MessageBox.Show("Không thể thêm");
            }
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận xóa nhóm này", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                if (gr.remove_data(Convert.ToInt32(dgvList.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("Xóa thành công");
                    load_data();
                }
                else
                    MessageBox.Show("Không thể xóa");
            }
        }
    }
}
