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
    public partial class loginForm : MetroFramework.Forms.MetroForm
    {
        int Number_Login_Fail = 0;
        TaiKhoan tk = new TaiKhoan();
        Employee emp = new Employee();
        public loginForm()
        {
            InitializeComponent();
            
        }
        private void ProcessLogin(string tdn ,string mk)
        {
            
            //Wrong username or password
            if (tk.KiemTraDangNhap(tdn, mk) == TaiKhoan.LoginResult.Invalid)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                Number_Login_Fail += 1;
                if (Number_Login_Fail % 3==0)
                {
                    
                    if(tk.block_Account(txtUsername.Text.Trim()))
                        MessageBox.Show("Bạn đã nhập sai thông tin 3 lần. Tài khoản đã bị khóa.");
                    return;
                }
                    return;
             }
            
            //Account has been disabled
            else if (tk.KiemTraDangNhap(tdn, mk) == TaiKhoan.LoginResult.Disabled)
            {
                MessageBox.Show("Tài khoản đã bị khóa");
                return;
            }
            //NHAN_VIEN nhanvien = emp.get_Info_Employee_By_id(Convert.ToInt32(tk.get_NV_id_By_UserName(txtUsername.Text.ToString())));
            mainForm frm = new mainForm(txtUsername.Text.ToString());
            //frm.Size = new Size(1731, 871);
            frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.None; 

            this.Hide();
            frm.Show();
        }
        private void loginForm_Load(object sender, EventArgs e)
        {
            
            txtUsername.Focus();
 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            txtUsername.Text = txtUsername.Text.Trim();
            txtPassword.Text = txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(txtUsername.Text.ToString()))
            {
                MessageBox.Show("Tên đăng nhập không được bỏ trống");
                txtUsername.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text.ToString()))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                txtPassword.Focus();
                return;
            }
            ProcessLogin(txtUsername.Text.ToString(), txtPassword.Text.ToString());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
                Application.Exit();
        }
        
    }
}
