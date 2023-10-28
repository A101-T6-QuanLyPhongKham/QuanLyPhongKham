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
    public partial class InfoPatientForm : MetroFramework.Forms.MetroForm
    {
       
        Patient pt = new Patient();
        public InfoPatientForm()
        {
            InitializeComponent();
        }

        private void InfoPatientForm_Load(object sender, EventArgs e)
        {
            txtCode.Text = pt.Generate_Code_Patient();
            cbbGender.Text = "Nam";
            dtDayOfBirth.Text = "01/01/1990";
           
        }

       

       
        private void display_Info_Patient(List<BENH_NHAN> lst, string Code)
        {
            foreach (BENH_NHAN bn in lst)
            {
                if (Code == bn.BN_ID)
                {
                    txtAddress.Text = bn.BN_DIACHI.ToString();
                    txtPhone.Text = bn.BN_SDT.ToString();
                    cbbGender.Text = bn.BN_GIOITINH;
                    dtDayOfBirth.Text = bn.BN_NGAYSINH.ToString();
                }
            }
        }

        private void cbbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Constants.charInvalid_Address.Contains(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự được nhập vào TextBox
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Constants.charIsInvalid.Contains(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || e.KeyChar == ' ')
                e.Handled = true;
        }
        private bool Check_Data()
        {

            string ten = txtName.Text.ToString();
            string diachi = txtAddress.Text.ToString();
            string dienthoai = txtPhone.Text.ToString();
            if (ten == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập họ tên");
                txtName.Focus();
                return false;
            }
            for (int i = 0; i < ten.Length; i++)
            {
                if (char.IsDigit(ten[i]) || char.IsPunctuation(ten[i]) || Constants.charIsInvalid.Contains(ten[i]))
                {
                    MessageBox.Show("Họ tên chỉ được phép nhập chữ");
                    txtName.Focus();
                    return false;
                }
            }
            for (int i = 0; i < diachi.Length; i++)
            {
                if (char.IsPunctuation(diachi[i]) || Constants.charInvalid_Address.Contains(diachi[i]))
                {
                    MessageBox.Show("Địa chỉ nhập vào không hợp lệ");
                    txtAddress.Focus();
                    return false;
                }
            }
            
            if(dienthoai != "")
            {
                if (dienthoai[0] != '0')
                {
                    MessageBox.Show("Số điện thoại phải bắt đầu bằng số 0");
                    txtPhone.Focus();
                    return false;
                }
                for (int i = 0; i < dienthoai.Length; i++)
                {
                    if (dienthoai[i] == ' ')
                    {
                        MessageBox.Show("Số điện thoại không hợp lệ");
                        txtPhone.Focus();
                        return false;
                    }
                    if (Constants.charIsInvalid.Contains(dienthoai[i]) || char.IsLetter(dienthoai[i]) || char.IsPunctuation(dienthoai[i]))
                    {
                        MessageBox.Show("Số điện thoại chỉ được phép chứa số");
                        txtPhone.Focus();
                        return false;
                    }
                    if (dienthoai.Length != 10)
                    {
                        MessageBox.Show("Số điện thoại chỉ được chứa 10 số");
                        txtPhone.Focus();
                        return false;
                    }
                }
                
            }
            
            
            return true;
        }
        private void Process_String()
        {
            txtPhone.Text = txtPhone.Text.Trim();
            txtName.Text = txtName.Text.Trim();
            txtAddress.Text =  txtAddress.Text.Trim();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            Process_String();

            if (!Check_Data())
                return;
            BENH_NHAN bn = new BENH_NHAN();
            string birth = Convert_Date_Month_Type(dtDayOfBirth.Text.ToString());

            bn.BN_ID = txtCode.Text;
            bn.BN_TEN = txtName.Text;
            bn.BN_NGAYSINH = Convert.ToDateTime(birth);
            bn.BN_SDT = txtPhone.Text;
            bn.BN_GIOITINH = cbbGender.Text;
            bn.BN_DIACHI = txtAddress.Text;
            if (pt.Add_New_Patient(bn))
            {
                MessageBox.Show("Thêm thành công");
                load_DataGridView();
            }

            else
                MessageBox.Show("Thêm thất bại");

            

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || Constants.charIsInvalid.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void InfoPatientForm_Shown(object sender, EventArgs e)
        {
            txtName.Focus();
            pnInfoPatient.AutoScroll = false;
        }
        private void load_DataGridView()
        {
            string Code = txtCode.Text.ToString();
            string Name = txtName.Text.ToString();
            string Birth = Convert_Date_Month_Type(dtDayOfBirth.Text.ToString());
            string Gender = cbbGender.Text.ToString();
            string Address = txtAddress.Text.ToString();
            string Phone = txtPhone.Text.ToString();
            dgvlistPatient.Rows.Add(Code, Name, Birth, Gender, Address, Phone);
        }
        private string Convert_Date_Month_Type(string input)
        {
            
            DateTime parsedDate = DateTime.Parse(input);

            return parsedDate.ToString("yyyy-MM-dd");
            
        }

        
    }
}
