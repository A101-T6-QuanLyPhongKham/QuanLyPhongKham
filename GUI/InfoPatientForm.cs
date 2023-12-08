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
    public partial class InfoPatientForm : UserControl
    {
       
        Patient pt = new Patient();
        PhongKham pk = new PhongKham();
        public InfoPatientForm()
        {
            InitializeComponent();
            metroTabPage1.AutoScroll = false;
            metroTabPage2.AutoScroll = false;
            dgvInfo.DataSource = pt.get_all();
        }

        private void InfoPatientForm_Load(object sender, EventArgs e)
        {
            
            //txtCode.Text = pt.Generate_Code_Patient().ToString();
            cbbGender.Text = "Nam";
            dtDayOfBirth.Text = "01/01/1990";
            cbb_Clinic.DataSource = get_Id_And_Name_Clinic();
            
        }

       private List<string> get_Id_And_Name_Clinic()
       {
           List<PHONG_KHAM> lst = pk.get_list_clinic();
           List<string> list = new List<string>();
           foreach (PHONG_KHAM a in lst)
           {
               
               string chuoi = a.PHONGKHAM_ID + " - " + a.PHONGKHAM_CHUYENKHOA;
               list.Add(chuoi);
           }
           return list;
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
            if (txtPhone.Text.Length >= 10 && e.KeyChar != (char)Keys.Back)
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
                if ( Constants.charInvalid_Address.Contains(diachi[i]))
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

            bn.BN_ID = Convert.ToInt32(txtCode.Text);
            bn.BN_TEN = txtName.Text;
            bn.BN_NGAYSINH = Convert.ToDateTime(birth);
            bn.BN_SDT = txtPhone.Text;
            bn.BN_GIOITINH = cbbGender.Text;
            bn.BN_DIACHI = txtAddress.Text;
            if (pt.Add_New_Patient(bn))
            {
                MessageBox.Show("Thêm thành công");
                load_DataGridView();
                Clear_TextBox();
                //txtCode.Text = pt.Generate_Code_Patient().ToString();
            }

            else
                MessageBox.Show("Thêm thất bại");

            

        }
        private void Clear_TextBox()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtName.Focus();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (dgvlistPatient.Rows.Count == 1)
            {
                MessageBox.Show("Chưa có bệnh nhân để xóa");
                return;
            }
            DialogResult result = MessageBox.Show("Xác nhận xóa", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if(result == DialogResult.Yes)
            {
                if (pt.Delete_Patient(dgvlistPatient.CurrentRow.Cells[0].Value.ToString()))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvlistPatient.Rows.Remove(dgvlistPatient.CurrentRow);
                    //txtCode.Text = pt.Generate_Code_Patient().ToString();
                }
                    
                else
                    MessageBox.Show("Không thể xóa");
                


            }
        }

        

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = metroTabControl1.SelectedIndex; // Lấy chỉ số của tab đang được chọn

            string tab = metroTabControl1.TabPages[selectedIndex].Text;

            if (tab == "Thêm mới bệnh nhân")
            {
                txtName.Focus();
                return;
            }

           
            if (tab == "Xếp phòng khám bệnh")
            {
                txtFindName.Focus();
                return;
            }
            
        }

        private void btnFindName_Click(object sender, EventArgs e)
        {
            string name = txtFindName.Text.ToString();
            if(name == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập họ tên bệnh nhân");
                return;
            }
            DataTable tb = pt.Find_Info_Patient_By_Name(name);
           
            if (tb == null)
            {
                MessageBox.Show("Không tìm thấy bệnh nhân");
                txtFindName.Focus();
                return;
            }
            
            dgvInfo.DataSource = tb;
            Set_Width_Column();
        }
        private void Set_Width_Column()
        {
            dgvInfo.Columns[0].Width = 100;
            dgvInfo.Columns[1].Width = 200;
            dgvInfo.Columns[2].Width = 80;
            dgvInfo.Columns[3].Width = 70;
            dgvInfo.Columns[4].Width = 80;
            dgvInfo.Columns[5].Width = 280;
        }

        private void dgvInfo_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (dgvInfo.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân");
                return;
            }
            string maBN = dgvInfo.CurrentRow.Cells[0].Value.ToString();
            BookClinic frm = new BookClinic(maBN, cbb_Clinic.SelectedValue.ToString());
            frm.FormClosed += frm_FormClosed;

            this.Hide();
            frm.Show();

        }

        void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            dgvInfo.DataSource = pt.get_all();
        }

        

        

       
        
    }
}
