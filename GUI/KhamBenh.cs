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
        Patient pt = new Patient();

        NHAN_VIEN employee = new NHAN_VIEN();
        PHONG_KHAM room = new PHONG_KHAM();
        BENH_NHAN patient_current = new BENH_NHAN();
        public KhamBenh(NHAN_VIEN nv, PHONG_KHAM phong, BENH_NHAN bn)
        {
            InitializeComponent();
            load_info(bn);
            employee = nv;
            room = phong;
            patient_current = bn;
        }
        private void load_info(BENH_NHAN bn)
        {
            txtName.Text = bn.BN_TEN;
            txtGender.Text = bn.BN_GIOITINH;
            txtPhone.Text = bn.BN_SDT;
            txtBirth.Text = bn.BN_NGAYSINH.ToString();
            txtHeart.Text = bn.BN_NHIPTIM.ToString();
            txtHeight.Text = bn.BN_CHIEUCAO.ToString();
            txtWeight.Text = bn.BN_CANNANG.ToString();
            txtBloodPressure.Text = bn.BN_HUYETAP.ToString();
            txtTemperature.Text = bn.BN_NHIETDO.ToString();
        }

        private void txtTemperature_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Constants.charIsInvalid.Contains(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || e.KeyChar == ' ')
                e.Handled = true;
        }

        private void btnDrug_Click(object sender, EventArgs e)
        {
            save_data();
            PrescriptionForm frm = new PrescriptionForm(employee, room, patient_current,txtDescription.Text.ToString());
            this.Hide();
            frm.Show();
        }
        private void save_data()
        {
            int chieucao, cannang, nhietdo, huyetap, nhiptim;
            if (txtHeight.Text == "")
                chieucao = 0;
            else
                chieucao = Convert.ToInt32(txtHeight.Text);

            if (txtWeight.Text == "")
                cannang = 0;
            else
                cannang = Convert.ToInt32(txtWeight.Text);

            if (txtTemperature.Text == "")
                nhietdo = 0;
            else
                nhietdo = Convert.ToInt32(txtTemperature.Text);

            if (txtBloodPressure.Text == "")
                huyetap = 0;
            else
                huyetap = Convert.ToInt32(txtBloodPressure.Text);

            if (txtHeart.Text == "")
                nhiptim = 0;
            else
                nhiptim = Convert.ToInt32(txtHeart.Text);

            pt.update_info_Health(patient_current.BN_ID, chieucao, cannang, huyetap, nhiptim, nhietdo);


        }

       
    }
}
