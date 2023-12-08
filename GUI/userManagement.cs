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
    public partial class userManagement : MetroFramework.Forms.MetroForm
    {
        TaiKhoan tk = new TaiKhoan();
        Employee emp = new Employee();
        public userManagement()
        {
            InitializeComponent();
        }

        private void userManagement_Load(object sender, EventArgs e)
        {
            load_data();
            
        }
        private void load_data()
        {
            dgvListUser.DataSource = tk.get_list_account();
            dgvListUser.Columns[4].Visible = false;
            cbbStaff.DataSource = emp.get_list_Staff();
            cbbStaff.DisplayMember = "nv_ten";
            cbbStaff.ValueMember = "nv_id";
        }
        
        private bool check_data()
        {
            if (txtUsername.Text.ToString() == "")
            {
                MessageBox.Show("Điền vào tên đăng nhập");
                txtUsername.Focus();
                return false;
            }
            if (txtPassword.Text.ToString() == "")
            {
                MessageBox.Show("Điền vào mật khẩu");
                txtPassword.Focus();
                return false;
            }
            if (cbbStaff.SelectedValue == null)
            {
                MessageBox.Show("Chưa có nhân viên để thêm tài khoản");
                return false;
            }
            return true;
        }

        

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtUsername.Text = txtUsername.Text.Trim();
            txtPassword.Text = txtPassword.Text.Trim();
            if (check_data())
            {
                string _username = txtUsername.Text.ToString();
                string _password = txtPassword.Text.ToString();
                bool _state = cbActive.Checked;
                int nv_id = (int)cbbStaff.SelectedValue;
                if (!tk.check_Staff_have_account((int)cbbStaff.SelectedValue))
                {
                    MessageBox.Show("Nhân viên " + cbbStaff.Text + " đã có tài khoản");
                    return;
                }
                if (!tk.check_account_is_Exits(txtUsername.Text.ToString()))
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại");
                    return;
                }
                if (tk.insert_data(_username, _password, _state, nv_id))
                {
                    MessageBox.Show("Thêm thành công");
                    load_data();
                }

                else
                    MessageBox.Show("Không thể thêm");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvListUser.CurrentRow == null)
            {
                MessageBox.Show("Chưa chọn tài khoản để xóa");
                return;
            }
            DialogResult result = MessageBox.Show("Xác nhận xóa tài khoản", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                tk.remove_data(dgvListUser.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Xóa tài khoản thành công");
                load_data();
            }
            else
            {
                MessageBox.Show("Không thể xóa");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtUsername.Text = txtUsername.Text.Trim();
            txtPassword.Text = txtPassword.Text.Trim();
            if (check_data())
            {
                if(tk.check_account_is_Exits(txtUsername.Text.ToString()))
                {
                    MessageBox.Show("Không tìm thấy tên đăng nhập");
                    return;
                }
                if ((int)cbbStaff.SelectedValue != (int)dgvListUser.CurrentRow.Cells[3].Value)
                {
                    if (!tk.check_Staff_have_account((int)cbbStaff.SelectedValue))
                    {
                        MessageBox.Show("Nhân viên " + cbbStaff.Text + " đã có tài khoản");
                        return;
                    }
                }
                
                if(tk.update_data(txtUsername.Text.ToString(), txtPassword.Text.ToString(), (bool)cbActive.Checked, (int)cbbStaff.SelectedValue))
                {
                    MessageBox.Show("Cập nhật thành công");
                    load_data();
                }
                else
                    MessageBox.Show("Không thể cập nhật");
            }
        }
        private void load_info()
        {
            txtUsername.Text = dgvListUser.CurrentRow.Cells[0].Value.ToString();
            txtPassword.Text = dgvListUser.CurrentRow.Cells[1].Value.ToString();
            if ((bool)dgvListUser.CurrentRow.Cells[2].Value == true)
                cbActive.Checked = true;
            else
                cbActive.Checked = false;
            txtName.Text = emp.get_Info_Employee_By_id((int)dgvListUser.CurrentRow.Cells[3].Value).NV_TEN;

        }
        private void dgvListUser_SelectionChanged(object sender, EventArgs e)
        {
            load_info();
        }

        

        
    }
}
