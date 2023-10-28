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
            cbbPatientCode.Text = pt.Generate_Code_Patient();
            cbbGender.Text = "Nam";
           
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
           
            
            if (char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || Constants.charIsInvalid.Contains(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự được nhập vào TextBox
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.ToString() == string.Empty)
                panelClinic.Enabled = false;
            else
                panelClinic.Enabled = true;
        }

        private void InfoPatientForm_Shown(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtName.Text.ToString() == string.Empty)
                return;
            string tenBN = txtName.Text.ToString();
            
        }

        
    }
}
