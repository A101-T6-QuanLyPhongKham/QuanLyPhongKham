using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using BLL_DAL;
namespace CustomControl
{
    public class CT_TextBoxOnlyNumber : TextBox
    {
        public CT_TextBoxOnlyNumber()
        {
            this.Font = new Font("Times New Roman", 12);
            this.KeyPress += CT_TextBoxOnlyNumber_KeyPress;
        }

        void CT_TextBoxOnlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || Constants.charIsInvalid.Contains(e.KeyChar))
                e.Handled = true;
        }
    }
}
