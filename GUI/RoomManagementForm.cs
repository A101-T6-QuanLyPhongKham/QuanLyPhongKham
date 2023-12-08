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
    public partial class RoomManagementForm : UserControl
    {
        Clinic room = new Clinic();
        public RoomManagementForm()
        {
            InitializeComponent();
            dgvRoomList.RowHeadersVisible = false;
            load_datagridview();
        }
        private void load_datagridview()
        {
            dgvRoomList.DataSource = room.get_list();
            dgvRoomList.Columns[0].Width = 200;
            dgvRoomList.Columns[1].Width = 400;
            dgvRoomList.Columns[2].Width = 200;
            dgvRoomList.Columns[3].Width = 100;
            dgvRoomList.Columns[4].Width = 100;
            dgvRoomList.ColumnHeadersDefaultCellStyle.BackColor = Color.PowderBlue;
            dgvRoomList.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtSpecialty.Text.ToString() == null)
            {
                MessageBox.Show("Chưa nhập chuyên khoa");
                txtSpecialty.Focus();
                return;
            }
            if (room.insert_data(txtSpecialty.Text.ToString(), cbState.Checked))
            {
                MessageBox.Show("Thêm thành công");
                load_datagridview();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận xóa phòng", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {

            }
        }

        private void dgvRoomList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRoomList.Rows.Count > 1)
            {
                
                    txtSpecialty.Text = dgvRoomList.CurrentRow.Cells[2].Value.ToString();
                    cbState.Checked = Convert.ToBoolean(dgvRoomList.CurrentRow.Cells[3].Value);
                

            }
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (room.update_data((int)dgvRoomList.CurrentRow.Cells[0].Value, txtSpecialty.Text.ToString(), cbState.Checked))
            {
                MessageBox.Show("Cập nhật thành công");
                load_datagridview();
            }
        }

        
    }
}
