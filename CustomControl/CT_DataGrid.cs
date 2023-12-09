using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace CustomControl
{
    public class CT_DataGrid : DataGridView
    {
        public CT_DataGrid()
        {
            this.DefaultCellStyle.Font = new Font("Times New Roman", 10);
            this.RowHeadersVisible = false;
            this.BackgroundColor = Color.PowderBlue;
            //Center alignment for header
            this.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
