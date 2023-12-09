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
    public partial class mainForm : MetroFramework.Forms.MetroForm
    {
        bool state_menu_bar = true;
        Button btn = new Button();
        Button btn2 = new Button();
        Button btn3 = new Button();
        PhanQuyen _pq = new PhanQuyen();
        GroupUser gr = new GroupUser();
        Employee staff = new Employee();
        TaiKhoan tk = new TaiKhoan();
        int top_position = 0;
        List<Button> lst = new List<Button>();
        List<int> dsphanquyen = new List<int>();
        string username = string.Empty;
        private void create_button()
        {
            btn.Text = "Phòng chờ khám bệnh";
            btn.Name = "btn_1";
            btn.Size = new Size(242, 62);
            btn.BackColor = Color.DeepSkyBlue;
            btn.ForeColor = Color.White;
            btn.Font = new Font("", 12, FontStyle.Bold);
            btn.Left = 0;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Tag = "1";
            btn.Click += btn_Click;
            btn.MouseEnter += btn_MouseEnter;
            btn.MouseLeave += btn_MouseLeave;
      
            lst.Add(btn);


            btn2.Text = "Quản lý nhân viên";
            btn2.Size = new Size(242, 62);
            btn2.BackColor = Color.DodgerBlue;
            btn2.ForeColor = Color.White;
            btn2.Font = new Font("", 12, FontStyle.Bold);
            btn2.Left = 0;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn2.Tag = "2";
            btn2.MouseEnter += btn_MouseEnter;
            btn2.MouseLeave += btn_MouseLeave;
            
            lst.Add(btn2);


            btn3.Text = "Quản lý thuốc";
            btn3.Size = new Size(242, 62);
            btn3.BackColor = Color.DodgerBlue;
            btn3.ForeColor = Color.White;
            btn3.Font = new Font("", 12, FontStyle.Bold);
            btn3.Left = 0;
            btn3.TextAlign = ContentAlignment.MiddleCenter;
          
            btn3.Tag = "3";
            btn3.MouseEnter += btn_MouseEnter;
            btn3.MouseLeave += btn_MouseLeave;
            btn3.Click += btn3_Click;
            lst.Add(btn3);




            Button btn4 = new Button();
            btn4.Text = "Quản lý danh sách phòng";
            btn4.Size = new Size(242, 62);
            btn4.BackColor = Color.DodgerBlue;
            btn4.ForeColor = Color.White;
            btn4.Font = new Font("", 12, FontStyle.Bold);
            btn4.Left = 0;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn4.Tag = "4";
            btn4.Click += btn4_Click;
            btn4.MouseEnter += btn_MouseEnter;
            btn4.MouseLeave += btn_MouseLeave;

            lst.Add(btn4);



            Button btn5 = new Button();
            btn5.Text = "Tiếp đón bệnh nhân";
            btn5.Size = new Size(242, 62);
            btn5.BackColor = Color.DodgerBlue;
            btn5.ForeColor = Color.White;
            btn5.Font = new Font("", 12, FontStyle.Bold);
            btn5.Left = 0;
            btn5.TextAlign = ContentAlignment.MiddleCenter;
            btn5.Tag = "5";
            btn5.Click += btn5_Click;
            btn5.MouseEnter += btn_MouseEnter;
            btn5.MouseLeave += btn_MouseLeave;

            lst.Add(btn5);




            Button btn6 = new Button();
            btn6.Text = "Quản lý nhóm người dùng";
            btn6.Size = new Size(242, 62);
            btn6.BackColor = Color.DodgerBlue;
            btn6.ForeColor = Color.White;
            btn6.Font = new Font("", 12, FontStyle.Bold);
            btn6.Left = 0;
            btn6.TextAlign = ContentAlignment.MiddleCenter;
            btn6.Tag = "6";
            btn6.Click += btn6_Click;
            btn6.MouseEnter += btn_MouseEnter;
            btn6.MouseLeave += btn_MouseLeave;

            lst.Add(btn6);
        }

        void btn3_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            hide_menu_bar();
            mainPanel.Controls.Add(new QuanLyThuoc());
           
        }

        void btn6_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            hide_menu_bar();
            mainPanel.Controls.Add(new groupUserManagement());
        }

        void btn5_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            hide_menu_bar();
            mainPanel.Controls.Add(new InfoPatientForm());
        }

        void btn4_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            hide_menu_bar();
            mainPanel.Controls.Add(new RoomManagementForm());
        }

        void btn_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            hide_menu_bar();
            string id = tk.get_NV_id_By_UserName(username);
            NHAN_VIEN nv = staff.get_Info_Employee_By_id(Convert.ToInt32(id));
            mainPanel.Controls.Add(new ListRoomForm(nv));
        }
        public mainForm(string username)
        {
            InitializeComponent();
            this.username = username;
            create_button();
            List<QL_NGUOIDUNGNHOMNGUOIDUNG> lst = gr.get_group_by_username(username);
            if(lst.Count == 0)
            {
                MessageBox.Show("Người dùng chưa được phân quyền");
                return;
            }


            


            foreach (QL_NGUOIDUNGNHOMNGUOIDUNG item in lst)
            {
                List<QL_PHANQUYEN> _ls = _pq.get_list(item.MANHOMNGUOIDUNG);
                if (_ls.Count == 0)
                {
                    
                    continue;
                }
                foreach(QL_PHANQUYEN index in _ls)
                {
                    dsphanquyen.Add(index.MAMANHINH);
                }
            }
            if (dsphanquyen.Count == 0)
                MessageBox.Show("Người dùng chưa được phân quyền");
            RemoveDuplicates(dsphanquyen);
            init_button();
            
        }
        private void RemoveDuplicates(List<int> inputList)
        {
            // Sử dụng HashSet để lưu các phần tử đã xuất hiện
            HashSet<int> uniqueElements = new HashSet<int>();

            // List mới để lưu kết quả loại bỏ phần tử trùng
            List<int> result = new List<int>();

            foreach (int element in inputList)
            {
                // Nếu phần tử chưa xuất hiện trong HashSet, thêm vào List kết quả và HashSet
                if (!uniqueElements.Contains(element))
                {
                    result.Add(element);
                    uniqueElements.Add(element);
                }
            }

            dsphanquyen = result;
        }
        private void init_button()
        {
            for (int i = 0; i < dsphanquyen.Count; i++)
            {
                 for (int j = 0; j < lst.Count; j++)
                 {
                     
                     if (dsphanquyen[i] == Convert.ToInt32(lst[j].Tag))
                     {
                         lst[j].Top = top_position;
                         menu.Controls.Add(lst[j]);
                         top_position += 62;
                     }
                 }
            }
            
            
        }

        void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.DeepSkyBlue; // Thay đổi màu nền khi hover vào
        }

        void btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.DodgerBlue; // Thay đổi màu nền khi hover vào
        }
       
        

        private void mainForm_Load(object sender, EventArgs e)
        {
            string id = tk.get_NV_id_By_UserName(username);
            NHAN_VIEN nv = staff.get_Info_Employee_By_id(Convert.ToInt32(id));
            lbGreeting.Text = "Xin chào " + nv.NV_TEN;
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm frm = new loginForm();
            frm.Show();
        }
        private void hide_menu_bar()
        {
            state_menu_bar = false;
            mainPanel.Size = new Size(1910, 959);
            mainPanel.Location = new Point(0, mainPanel.Location.Y);
            menu.Visible = false;
        }
        

        private void labelMenu_Click(object sender, EventArgs e)
        {
            
        }

        private void change_State_menu_Bar()
        {
            if (state_menu_bar == true)
            {
                hide_menu_bar();
            }
            else
            {
                state_menu_bar = true;
                mainPanel.Size = new Size(1710, 959);
                mainPanel.Location = new Point(252, mainPanel.Location.Y);
                menu.Visible = true;
            }
        }

        private void labelMenu_MouseHover(object sender, EventArgs e)
        {
            labelMenu.ForeColor = Color.Blue;
            change_State_menu_Bar();
        }

        private void labelMenu_MouseLeave(object sender, EventArgs e)
        {
            labelMenu.ForeColor = Color.Black;
        }

        private void menu_MouseHover(object sender, EventArgs e)
        {
            change_State_menu_Bar();
        }

        

        

       

        
    }
}
