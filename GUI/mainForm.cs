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
    public partial class mainForm : MetroFramework.Forms.MetroForm
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void nguoiDungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userForm f = new userForm();
            this.Hide();
            
            f.Show();
        }

        private void thêmNgườiDùngVàoNhómToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addUserToGroupForm f = new addUserToGroupForm();
            this.Hide();

            f.Show();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            List<string> nhomND = QL_NguoiDung.MaNhomNguoiDung;
            foreach (string item in nhomND)
            {
                DataTable dsQuyen = QL_NguoiDung.getMaManHinh(item);
                foreach(DataRow mh in dsQuyen.Rows)
                {
                    FindMenuPhanQuyen(this.menuStrip1.Items, mh[1].ToString(),Convert.ToBoolean(mh[2].ToString()));
                }
            }
        }
        void FindMenuPhanQuyen(ToolStripItemCollection mnuItems, string pScreenName, bool pEnable)
        {
            
            foreach (ToolStripItem menu in mnuItems)
            {
                if (menu.ToString() == "Hệ thống")
                    continue;
               
                if (menu is ToolStripMenuItem && ((ToolStripMenuItem)(menu)).DropDownItems.Count > 0)
                {
                    menu.Enabled = CheckAllMenuChildVisible(((ToolStripMenuItem)(menu)).DropDownItems);
                    menu.Visible = menu.Enabled;
                    //FindMenuPhanQuyen(((ToolStripMenuItem)(menu)).DropDownItems, pScreenName, pEnable);
                    
                }
                if (string.Equals(pScreenName, menu.Tag))
                {
                   
                    menu.Enabled = pEnable;
                    menu.Visible = pEnable;
                }
            }
        }
        bool CheckAllMenuChildVisible(ToolStripItemCollection mnuItems)
        {
            foreach (ToolStripItem menuItem in mnuItems)
            {
                if (menuItem is ToolStripMenuItem && menuItem.Enabled)
                    return true;
                else if (menuItem is ToolStripSeparator)
                    continue;
            }
            return false;
        }

        private void danhMụcMànHìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phânQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            phanQuyenForm f = new phanQuyenForm();
            this.Hide();

            f.Show();
        }

        private void tiếpĐónBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoPatientForm f = new InfoPatientForm();
            f.Show();
        }
    }
}
