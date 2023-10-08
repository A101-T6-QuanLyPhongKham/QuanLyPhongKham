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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
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
            int kq =QL_NguoiDung.Check_Config();
            if (kq == 0)
            {
                ProcessLogin();
            }
            if(kq == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");
                ProcessConfig();
            }
            if (kq == 2)
            {
               
                MessageBox.Show("Chuỗi cấu hình không phù hợp");
                ProcessConfig();
            }
        }
        private void ProcessLogin()
        {
            QL_NguoiDung.LoginRusult result;
            result = QL_NguoiDung.Check_User(txtUsername.Text,txtPassword.Text);
            //Wrong username or password
            if (result == QL_NguoiDung.LoginRusult.Invalid)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
             
                return;
            }
            //Account has been disable
            else if (result == QL_NguoiDung.LoginRusult.Disabled)
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
        private void ProcessConfig()
        {
            configForm config = new configForm();
            this.Visible = false;
            config.Show();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        

       
    }
}
