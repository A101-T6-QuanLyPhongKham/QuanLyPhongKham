using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace CustomControl
{
    public class CT_Label : Label
    {
        public CT_Label()
        {
            this.Font = new Font("Times New Roman", 12, FontStyle.Bold);

        }
    }
}
