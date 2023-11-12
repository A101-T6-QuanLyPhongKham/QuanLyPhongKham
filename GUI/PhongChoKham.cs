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
    public partial class PhongChoKham : MetroFramework.Forms.MetroForm
    {
        PHIEUKHAMBENH phieukham = new PHIEUKHAMBENH();
        PhongKham pk = new PhongKham();
        Patient pt = new Patient();
        NHAN_VIEN employee = new NHAN_VIEN();
        PHONG_KHAM phong = new PHONG_KHAM();
        public PhongChoKham(PHONG_KHAM p, NHAN_VIEN nhanvien)
        {
            InitializeComponent();
            employee = nhanvien;
            phong = p;
            labelName.Text = "Phòng khám " + phong.PHONGKHAM_ID.ToString();
        }

        private void PhongChoKham_Load(object sender, EventArgs e)
        {
            labeldate.Text = DateTime.Now.ToString();
            rdbCheck.Checked = true;
            load_Data();
        }
        private void load_Data()
        {
            List<PHIEU_KHAM> lst = phieukham.get_List_PhieuKham(phong.PHONGKHAM_ID, DateTime.Now.ToString("yyyy-MM-dd"), employee.NV_ID);

            List<BENH_NHAN> listBN = new List<BENH_NHAN>();
            foreach (PHIEU_KHAM item in lst)
            {

                BENH_NHAN bn = pt.get_Info_Patient_By_Code((int)item.PHIEUKHAM_BN);
                listBN.Add(bn);

            }
            dgvListPatient.DataSource = listBN;
        }
        private void btnBill_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load_Data();
        }
    }
}
