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
            rdbAllList.Font = new Font("Times New Roman", 12);
            rdbCheck.Font = new Font("Times New Roman", 12);
            rdbChecked.Font = new Font("Times New Roman", 12);
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
            foreach (var item in listBN)
            {
                int rowIndex = dgvListPatient.Rows.Add();
                dgvListPatient.Rows[rowIndex].Cells["MaBenhNhan"].Value = item.MABENHNHAN;
                dgvListPatient.Rows[rowIndex].Tag = item.BN_ID;
                dgvListPatient.Rows[rowIndex].Cells["HoTen"].Value = item.BN_TEN;
                dgvListPatient.Rows[rowIndex].Cells["NgaySinh"].Value = item.BN_NGAYSINH;
                dgvListPatient.Rows[rowIndex].Cells["GioiTinh"].Value = item.BN_GIOITINH;
                dgvListPatient.Rows[rowIndex].Cells["ChieuCao"].Value = item.BN_CHIEUCAO;
                dgvListPatient.Rows[rowIndex].Cells["CanNang"].Value = item.BN_CANNANG;
                dgvListPatient.Rows[rowIndex].Cells["HuyetAp"].Value = item.BN_HUYETAP;
                dgvListPatient.Rows[rowIndex].Cells["NhipTim"].Value = item.BN_NHIPTIM;
                dgvListPatient.Rows[rowIndex].Cells["NhietDo"].Value = item.BN_NHIETDO;
                
            }
        }
      

       

       

        private void cT_Button2_Click(object sender, EventArgs e)
        {
            load_Data();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgvListPatient.CurrentRow.Cells[0] == null)
            {
                MessageBox.Show("Chưa có bệnh nhân");
                return;
            }
            int id_current = (int)dgvListPatient.CurrentRow.Tag;
            BENH_NHAN patient = pt.get_Info_Patient_By_Code(id_current);
            KhamBenh frm = new KhamBenh(employee, phong, patient);
            frm.WindowState = FormWindowState.Maximized;
            frm.FormBorderStyle = FormBorderStyle.None; 
            this.Hide();
            frm.Show();
        }

        

        
    }
}
