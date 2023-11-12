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
    public partial class RoomNow : MetroFramework.Forms.MetroForm
    {
        PHIEUKHAMBENH phieukhambenh = new PHIEUKHAMBENH();
        Patient pt = new Patient();
        PhongKham pk = new PhongKham();
        Employee emp = new Employee();
        int idPhieuKham = 0;
        public RoomNow(PHIEU_KHAM phieu)
        {
            InitializeComponent();

            idPhieuKham = phieu.PHIEUKHAM_ID;
            BENH_NHAN bn = pt.get_Info_Patient_By_Code((int)phieu.PHIEUKHAM_BN);
            PHONG_KHAM phong = pk.get_Clinic_By_Id((int)phieu.PHIEUKHAM_PK);
            NHAN_VIEN nhanv = emp.get_Info_Employee_By_id((int)phieu.PHIEUKHAM_BS);
            txtBirth.Text = bn.BN_NGAYSINH.ToString("dd/MM/yyyy");
            txtDoctor.Text = nhanv.NV_TEN;
            txtName.Text = bn.BN_TEN;
            txtRoom.Text = phong.PHONGKHAM_ID.ToString();
            
            

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận xóa", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                if(phieukhambenh.delete_phieukham_By_id(idPhieuKham))
                {
                    MessageBox.Show("Xóa thành công");
                    this.Close();
                    InfoPatientForm frm = new InfoPatientForm();
                    frm.Show();

                }
                else {
                    MessageBox.Show("Không thể xóa");
                }
            }
        }
    }
}
