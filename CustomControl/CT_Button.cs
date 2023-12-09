using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace CustomControl
{
    public class CT_Button : Button
    {
        public CT_Button()
        {
            this.Size = new Size(135, 50);
            this.ForeColor = Color.White;
            this.Font = new Font("Times New Roman", 12);
            this.BackColor = Color.DodgerBlue;
        }
    }
}
