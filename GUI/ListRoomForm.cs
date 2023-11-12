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
    public partial class ListRoomForm : MetroFramework.Forms.MetroForm
    {
        
        PhongKham pk = new PhongKham();
        NHAN_VIEN employee = new NHAN_VIEN();
        public ListRoomForm(NHAN_VIEN nv)
        {
            InitializeComponent();
            create_List_Button_Clinic(pnlistRoom);
            employee = nv;
            labelName.Text = "Xin chào " + nv.NV_TEN;
        }
        public void create_List_Button_Clinic(Control ctr)
        {
            List<PHONG_KHAM> lst = pk.get_list_clinic();
            int left = 10, top = 30, position = 1;
            foreach (PHONG_KHAM item in lst)
            {
                Button btn = new Button();
                btn.Size = new Size(100, 50);
                btn.Left = left;
                btn.Top = top;
                btn.Text = item.PHONGKHAM_ID.ToString();
                btn.Click += btn_Click;
                ctr.Controls.Add(btn);
                left += 110;
                if (position % 4 == 0)
                {
                    top += 60;
                    left = 10;
                }
                position += 1;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            DialogResult result = MessageBox.Show("Xác nhận vào phòng", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                PHONG_KHAM clinic_Selected = pk.get_Clinic_By_Id(Convert.ToInt32(btn.Text));
                PhongChoKham frm = new PhongChoKham(clinic_Selected, employee);
                this.Hide();
                frm.Show();
            }

        }
        
    }
}
