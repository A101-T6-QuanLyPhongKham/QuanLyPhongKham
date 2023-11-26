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
    public partial class KhamBenh : MetroFramework.Forms.MetroForm
    {
        public KhamBenh(BENH_NHAN bn)
        {
            InitializeComponent();
            load_info(bn);
        }
        private void load_info(BENH_NHAN bn)
        {
            txtName.Text = bn.BN_TEN;
            txtGender.Text = bn.BN_GIOITINH;
            label.Text = bn.BN_SDT;
            txtBirth.Text = bn.BN_NGAYSINH.ToString();
        }

        private void txtTemperature_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Constants.charIsInvalid.Contains(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || e.KeyChar == ' ')
                e.Handled = true;
        }

        private void btnDrug_Click(object sender, EventArgs e)
        {

        }

       
    }
}
