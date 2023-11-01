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
using System.Diagnostics;
namespace GUI
{
    public partial class BookClinic : MetroFramework.Forms.MetroForm
    {
        //Schedule sch = new Schedule();
        Patient pt = new Patient();
        PhongKham PK = new PhongKham();
        Schedule sch = new Schedule();
        string Today = DateTime.Today.ToString("yyyy-MM-dd");
        
        public BookClinic(string maBN, string TenPhongAndMaPhong)
        {

            InitializeComponent();
           
            BENH_NHAN bn = pt.get_Info_Patient_By_Code(Convert.ToInt32(maBN));
            string ngaySinh = pt.Trim_String_Date(bn.BN_NGAYSINH.ToString());
            txtAddressB.Text = bn.BN_DIACHI;
            txtNameB.Text = bn.BN_TEN;
            txtPhoneNumberB.Text = bn.BN_SDT;
            txtDayOfBirthB.Text = ngaySinh;
            txtGenderB.Text = bn.BN_GIOITINH;
            string maPhong = get_Code_Clinic(TenPhongAndMaPhong);
            PHONG_KHAM Phong = PK.get_Clinic_By_Id(Convert.ToInt32(maPhong));
            display_Info_Clinic(Phong);

            
            cbbListDoctor.DataSource = sch.get_List_Doctor_In_Clinic(Convert.ToInt32(maPhong), Today);
            cbbListDoctor.DisplayMember = "NV_Ten";
            
        }
        private string get_Code_Clinic(string input)
        {
            return input.Substring(0,1);
        }
        private void BookClinic_Load(object sender, EventArgs e)
        {
            pnInfo.AutoScroll = false;
        }
        private void display_Info_Clinic(PHONG_KHAM p)
        {
            txtNumberPeople.Text = p.SOLUONGBENHNHAN.ToString();
            txtSpecialty.Text = p.PHONGKHAM_CHUYENKHOA.ToString();
            txtNumber.Text = p.PHONGKHAM_ID.ToString();
            if (p.HOATDONG == true)
                txtState.Text = "Hoạt động";
            else
                txtState.Text = "Tạm ngưng";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận thông tin", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {

            }
        }
        
    }
}
