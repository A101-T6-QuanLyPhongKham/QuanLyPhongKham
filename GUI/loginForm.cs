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
        public loginForm()
        {
            InitializeComponent();
           
        }

        TaiKhoan tk = new TaiKhoan();
        Employee emp = new Employee();
        private void ProcessLogin(string tdn ,string mk)
        {
            
            //Wrong username or password
            if (tk.KiemTraDangNhap(tdn, mk) == TaiKhoan.LoginResult.Invalid)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                Number_Login_Fail += 1;
                if (Number_Login_Fail % 3==0)
                {
                    
                    if(tk.block_Account(txtUserName.Text.Trim()))
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
            NHAN_VIEN nhanvien = emp.get_Info_Employee_By_id(Convert.ToInt32(tk.get_NV_id_By_UserName(txtUserName.Text.ToString())));
            ListRoomForm frm = new ListRoomForm(nhanvien);
            this.Hide();
            frm.Show();
        }
       

        private void loginForm_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.ToString()))
            {
                MessageBox.Show("Tên đăng nhập không được bỏ trống");
                txtUserName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text.ToString()))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                txtPassword.Focus();
                return;
            }
            ProcessLogin(txtUserName.Text.ToString(), txtPassword.Text.ToString());
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        

       
    }
}
