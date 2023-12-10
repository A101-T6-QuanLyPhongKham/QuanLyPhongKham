using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace CustomControl
{
    public class CT_TextBox: TextBox
    {
        public CT_TextBox()
        {
            this.Font = new Font("Times New Roman", 12);
            this.Leave += CT_TextBox_Leave;

        }

        void CT_TextBox_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            txt.Text.Trim();
        }
    }
}
