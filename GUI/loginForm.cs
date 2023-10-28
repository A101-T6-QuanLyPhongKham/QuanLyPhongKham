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
        
        public loginForm()
        {
            InitializeComponent();
           
        }

        TaiKhoan tk = new TaiKhoan();
        private void ProcessLogin(string tdn ,string mk)
        {
            
            //Wrong username or password
            if (tk.KiemTraDangNhap(tdn, mk) == TaiKhoan.LoginResult.Invalid)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
             
                return;
            }
            //Account has been disabled
            else if (tk.KiemTraDangNhap(tdn, mk) == TaiKhoan.LoginResult.Disabled)
            {
                MessageBox.Show("Tài khoản đã bị khóa");
                return;
            }
            if (Program.main == null || Program.main.IsDisposed)
            {
                Program.main = new mainForm();
            }
            this.Visible = false;
            Program.main.Show();
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

       

        

       
    }
}
