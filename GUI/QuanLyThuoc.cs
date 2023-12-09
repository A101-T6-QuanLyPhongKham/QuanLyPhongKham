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
    public partial class QuanLyThuoc : UserControl
    {
        CategoryDrug ct = new CategoryDrug();
        Provider pr = new Provider();
        Drug drg = new Drug();

        public QuanLyThuoc()
        {
            InitializeComponent();
            

            htmlPanel1.AutoScroll = false;
            set_property_datagrid();
        }
        public void set_property_datagrid()
        {
            
            List<THUOC> danhSachThuoc = drg.get_All();

            
            foreach (var thuoc in danhSachThuoc)
            {
                int rowIndex = dgvList.Rows.Add();
                dgvList.Rows[rowIndex].Cells["Mathuoc"].Value = thuoc.MATHUOC;
                dgvList.Rows[rowIndex].Cells["Tenthuoc"].Value = thuoc.THUOC_TENTHUOC;
                dgvList.Rows[rowIndex].Cells["Danhmuc"].Value = ct.get_Name_By_Id((int)thuoc.DANHMUC_ID);
                dgvList.Rows[rowIndex].Cells["Donvitinh"].Value = thuoc.THUOC_DVT;
                dgvList.Rows[rowIndex].Cells["Soluong"].Value = thuoc.THUOC_SOLUONG;
                
                dgvList.Rows[rowIndex].Cells["Dongia"].Value = thuoc.THUOC_DONGIA;
                dgvList.Rows[rowIndex].Cells["Hansudung"].Value = thuoc.THUOC_HANSUDUNG;
                dgvList.Rows[rowIndex].Cells["Nhacungcap"].Value = pr.get_Name_By_Id((int)thuoc.THUOC_NHACUNGCAP);
                dgvList.Rows[rowIndex].Cells["Chidinh"].Value = thuoc.THUOC_CHIDINH;
            }
            dgvList.DefaultCellStyle.Font = new Font("Arial", 10);
            dgvList.RowHeadersVisible = false;

            //Center alignment for header
            dgvList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //Right alignment for numbers
            dgvList.Columns["Soluong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvList.Columns["Dongia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvList.Columns["Hansudung"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            // Left alignment for text
            dgvList.Columns["Mathuoc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvList.Columns["Tenthuoc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvList.Columns["Danhmuc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvList.Columns["Donvitinh"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvList.Columns["Nhacungcap"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvList.Columns["Chidinh"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvList.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);


            //Set width for Cells
            dgvList.Columns[0].Width = 130;
            dgvList.Columns[1].Width = 200;
            dgvList.Columns[2].Width = 150;
            dgvList.Columns[3].Width = 70;
            dgvList.Columns[4].Width = 100;
            dgvList.Columns[5].Width = 100;
            dgvList.Columns[6].Width = 100;
            dgvList.Columns[7].Width = 280;
            dgvList.Columns[8].Width = 363;
            


        }
        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(dgvList.CurrentRow.Cells[0].Value.ToString());
        }

        private void htmlPanel1_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyThuoc_Load(object sender, EventArgs e)
        {
            cbbType.DataSource = ct.get_List_Category();
            cbbType.ValueMember = "danhmuc_id";
            cbbType.DisplayMember = "danhmuc_ten";
            cbbProvider.DataSource = pr.get_All();
            cbbProvider.DisplayMember = "ncc_ten";
            cbbProvider.ValueMember = "ncc_id";
            cbbDVT.Text = "Viên";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Phải nhập tên thuốc");
                txtName.Focus();
                return;
            }
            string mathuoc = txtCode.Text.ToString();
            string tenthuoc = txtName.Text.ToString();
            int dm = Convert.ToInt32(cbbType.SelectedValue);
            
            string dv = cbbDVT.Text.ToString();
            string dongia = txtPrice.Text.ToString();
            int hsd = 0;
            if(cbbDate.Text.ToString() != "")
               hsd = Convert.ToInt32(cbbDate.Text);
           
            int ncc = Convert.ToInt32(cbbProvider.SelectedValue);
            string chidinh = txtDescription.Text.ToString();
            if (drg.insert_data(mathuoc, tenthuoc, dm, dv, dongia, hsd, ncc, chidinh))
            {
                MessageBox.Show("Thêm thành công");
                dgvList.Rows.Clear();
                set_property_datagrid();
                
            }
            else
                MessageBox.Show("Không thể thêm");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(drg.remove_data((int)dgvList.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Xóa thành công");
                set_property_datagrid();
            }
            else
                MessageBox.Show("Không thể thêm");

        }

        private void dgvList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvList.Columns["Dongia"].Index && e.Value != null)
            {
                decimal dongia = (decimal)e.Value; 
                e.Value = dongia.ToString("#,#"); 
            }
            if (e.ColumnIndex == dgvList.Columns["Soluong"].Index && e.Value != null)
            {
                decimal dongia = (int)e.Value;
                
                e.Value = dongia.ToString("#,###");
            }
        }

        private void cbbDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || Constants.charIsInvalid.Contains(e.KeyChar) || char.IsPunctuation(e.KeyChar)) 
                e.Handled = true;
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || Constants.charIsInvalid.Contains(e.KeyChar) || char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }
    }
}
