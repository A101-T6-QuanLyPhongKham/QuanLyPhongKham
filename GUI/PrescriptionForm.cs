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
using System.Globalization;
namespace GUI
{
    public partial class PrescriptionForm : MetroFramework.Forms.MetroForm
    {
        NHAN_VIEN employee = new NHAN_VIEN();
        PHONG_KHAM room = new PHONG_KHAM();
        BENH_NHAN patient_current = new BENH_NHAN();
        Prescription pre = new Prescription();
        DetailPrescription detail = new DetailPrescription();
        Drug thuoc = new Drug();
        CategoryDrug cate = new CategoryDrug();
        string ChanDoanBenh = "";
        public PrescriptionForm(NHAN_VIEN nv, PHONG_KHAM phong, BENH_NHAN bn, string chandoan)
        {
            InitializeComponent();
            employee = nv;
            room = phong;
            patient_current = bn;
            ChanDoanBenh = chandoan;
        }

        private void SelectDrugForm_Load(object sender, EventArgs e)
        {
            
            DataTable table = new DataTable();
            table.Columns.Add("TenThuoc");

            table.Columns.Add("DonViTinh");
            table.Columns.Add("ChiDinh");
            List<THUOC> lst = thuoc.get_Drug_By_Category(1);
            foreach (THUOC item in lst)
            {
                DataRow row = table.NewRow();
                row["TenThuoc"] = item.THUOC_TENTHUOC;
                row["DonViTinh"] = item.THUOC_DVT;
                row["ChiDinh"] = item.THUOC_CHIDINH;
                table.Rows.Add(row);
            }
            dgvListWithCategory.DataSource = table;
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {


            string _danhmuc = cbbCategory.SelectedValue.ToString();
            try
            {
                DataTable table = new DataTable();
                table.Columns.Add("TenThuoc");
               
                table.Columns.Add("DonViTinh");
                table.Columns.Add("ChiDinh");
                List<THUOC> lst = thuoc.get_Drug_By_Category(Convert.ToInt32(_danhmuc));
                foreach (THUOC item in lst)
                {
                    DataRow row = table.NewRow();
                    row["TenThuoc"] = item.THUOC_TENTHUOC;
                    row["DonViTinh"] = item.THUOC_DVT;
                    row["ChiDinh"] = item.THUOC_CHIDINH;
                    table.Rows.Add(row);
                }
                dgvListWithCategory.DataSource = table;
                
            }
            catch
            {
               
            }
            
            
        }

        private void SelectDrugForm_Shown(object sender, EventArgs e)
        {
            cbbCategory.DataSource = cate.get_List_Category();
            cbbCategory.DisplayMember = "danhmuc_ten";
            cbbCategory.ValueMember = "danhmuc_id";
        }

        

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Constants.charIsInvalid.Contains(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || e.KeyChar == ' ')
                e.Handled = true;
        }

        private void txtMorning_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Constants.charIsInvalid.Contains(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || e.KeyChar == ' ')
                e.Handled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (dgvListWithCategory.Rows.Count == 1)
                return;
            if(!check_Drug_is_Exist())
            {
                MessageBox.Show("Thuốc vừa chọn đã có");
                return;
            }
            DataGridViewRow currentRow = dgvListWithCategory.CurrentRow;


            DataGridViewRow newRow = (DataGridViewRow)currentRow.Clone();

            // Lặp qua từng ô trong dòng hiện tại và gán giá trị vào dòng mới
            for (int i = 0; i < currentRow.Cells.Count -1; i++)
            {
                newRow.Cells[i].Value = currentRow.Cells[i].Value;
            }

            // Thêm dòng mới vào dgvPrescription
            dgvPrescription.Rows.Add(newRow);

        }
        private bool check_Drug_is_Exist()
        {

            
            int id_Selected = thuoc.get_Id_By_Name(dgvListWithCategory.CurrentRow.Cells[0].Value.ToString());
            if (dgvPrescription.Rows.Count == 1)
                return true;
            for (int i = 0; i < dgvPrescription.Rows.Count -1; i++)
            {
                
                int id_Drug = thuoc.get_Id_By_Name(dgvPrescription.Rows[i].Cells[0].Value.ToString());
                if (id_Selected == id_Drug)
                    return false;
            }
            return true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvPrescription.SelectedRows.Count > 0)
            {
                if(dgvPrescription.CurrentRow.Cells[0].Value != null)
                    dgvPrescription.Rows.RemoveAt(dgvPrescription.SelectedRows[0].Index);
            }
                
        }

        private void dgvPrescription_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (Constants.charIsInvalid.Contains(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || e.KeyChar == ' ')
                e.Handled = true;
        }

        private void dgvPrescription_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = (TextBox)e.Control;
            if (dgvPrescription.CurrentRow.Cells[0].Value == null)
                txt.KeyPress += txt_KeyPress_1;
            else
            {
                txt.KeyPress += txt_KeyPress;
                txt.TextChanged += txt_TextChanged;
            }
            
                
           
            
        }

        void txt_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Kiểm tra xem TextBox có chứa ký tự đầu tiên là số 0 hoặc chuỗi số 0 không
            if (!string.IsNullOrEmpty(textBox.Text) && (textBox.Text.StartsWith("0") || textBox.Text.Equals("0")))
            {
                
                textBox.Text = textBox.Text.Substring(1);
               
                textBox.SelectionStart = textBox.Text.Length;
            }
        }
        
        void txt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (dgvPrescription.CurrentRow.Cells[0].Value != null)
                txt_KeyPress(sender, e);
            else
                e.Handled = true;
        }
        void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (Constants.charIsInvalid.Contains(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || e.KeyChar == ' ')
                e.Handled = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvPrescription.Rows.Count == 1)
            {
                MessageBox.Show("Chưa chọn thuốc");
                return;
            }
            for (int i = 0; i < dgvPrescription.Rows.Count - 1; i++)
            {

                if (dgvPrescription.Rows[i].Cells[2].Value == null)
                {
                    MessageBox.Show("Nhập số lượng cho thuốc " + dgvPrescription.Rows[i].Cells[0].Value.ToString());

                    dgvPrescription.Rows[i].Selected = true;
                    return;
                    
                }
                if (dgvPrescription.Rows[i].Cells[3].Value == null && dgvPrescription.Rows[i].Cells[4].Value == null && dgvPrescription.Rows[i].Cells[5].Value == null)
                {
                    MessageBox.Show("Nhập liều dùng cho thuốc " + dgvPrescription.Rows[i].Cells[0].Value.ToString());

                    dgvPrescription.Rows[i].Selected = true;
                    return;
                }
                int soluong = Convert.ToInt32(dgvPrescription.Rows[i].Cells[2].Value.ToString());
                int? sang = Convert.ToInt32(dgvPrescription.Rows[i].Cells[3].Value);
                int? trua = Convert.ToInt32(dgvPrescription.Rows[i].Cells[4].Value);
                int? toi = Convert.ToInt32(dgvPrescription.Rows[i].Cells[5].Value);
                
                
                string dvt = dgvPrescription.Rows[i].Cells[1].Value.ToString();
                if (dvt == "Viên" || dvt == "Gói")
                {
                    int tong = 0;
                    if (sang != null)
                        tong += (int)sang;
                    if (trua != null)
                        tong += (int)trua;
                    if (toi != null)
                        tong += (int)toi;
                    if (soluong < tong)
                    {
                        MessageBox.Show("Tổng số lượng thuốc phải lớn hơn tổng liều dùng 1 ngày");
                        dgvPrescription.Rows[i].Selected = true;
                        return;
                    }
                }
                
                
            }
            if (!check_date())
            {
                MessageBox.Show("Ngày tái khám phải lớn hơn ngày hiện tại");
                return;
            }
            DialogResult result = MessageBox.Show("Xác nhận in đơn thuốc", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                save_data();
                PrintPresciptionForm frm = new PrintPresciptionForm();
                frm.Show();
                this.Hide();

            }
        }
        private bool check_date()
        {
            string inputDateString = dateReturnpicker.Value.ToString("dddd, MMMM dd, yyyy");
            string formattedDateString = Constants.ConvertDateFormat(inputDateString, "yyyy/MM/dd");
            //if (formattedDateString > DateTime.Now.ToString("yyyy/MM/dd"))
            //    return false;
            string dateString1 = formattedDateString;
            string dateString2 = DateTime.Now.ToString("yyyy/MM/dd");
            DateTime date1 = DateTime.ParseExact(dateString1, "yyyy/MM/dd", CultureInfo.InvariantCulture);
            DateTime date2 = DateTime.ParseExact(dateString2, "yyyy/MM/dd", CultureInfo.InvariantCulture);
            if (date1 <= date2)
                return false;
            return true;
        }
        private void save_data()
        {
            string currentDate = DateTime.Now.ToString("yyyy/MM/dd");
            pre.insert_data(currentDate, employee.NV_ID, patient_current.BN_ID, room.PHONGKHAM_ID, 0);
            //string _tenthuoc = string.Empty;
            int id_thuoc = 0;
            int _sl = 0, sang = 0, trua = 0, toi = 0;
            double tongtien = 0;
            for (int i = 0; i < dgvPrescription.Rows.Count - 1; i++)
            {
                id_thuoc = thuoc.get_Drug_By_Name(dgvPrescription.Rows[i].Cells[0].Value.ToString()).THUOC_ID;

                _sl = Convert.ToInt32(dgvPrescription.Rows[i].Cells[2].Value);
                tongtien += _sl *Convert.ToDouble(thuoc.get_Price_By_Id(id_thuoc));
                if (dgvPrescription.Rows[i].Cells[3].Value == null)
                    sang = 0;
                else
                    sang = Convert.ToInt32(dgvPrescription.Rows[i].Cells[3].Value);

                if (dgvPrescription.Rows[i].Cells[4].Value == null)
                    trua = 0;
                else
                    trua = Convert.ToInt32(dgvPrescription.Rows[i].Cells[4].Value);

                if (dgvPrescription.Rows[i].Cells[5].Value == null)
                    toi = 0;
                else
                    toi = Convert.ToInt32(dgvPrescription.Rows[i].Cells[5].Value);
                //insert detail Prescription
                string inputDateString = dateReturnpicker.Value.ToString("dddd, MMMM dd, yyyy");
            string formattedDateString = Constants.ConvertDateFormat(inputDateString, "yyyy/MM/dd");
            detail.insert_data(pre.get_current_Prescription(), id_thuoc, sang, trua, toi, txtReminder.Text.ToString(), ChanDoanBenh, formattedDateString, _sl);


            }
            pre.update_Price(pre.get_current_Prescription(), tongtien);
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            string data = txtInput.Text.ToString();
            if (data == string.Empty)
                return;



            DataTable tb = thuoc.Find_List_Drug_By_Name(data);

            if (tb == null)
            {
                MessageBox.Show("Không tìm thấy tên thuốc");
                
                txtInput.Focus();
                return;
            }

            dgvListWithCategory.DataSource = tb;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvPrescription.Rows.Clear();
        }

    }
}
