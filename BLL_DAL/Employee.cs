using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class Employee
    {
        QLPKDataContext qlpk = new QLPKDataContext();
        public NHAN_VIEN get_Info_Employee_By_id(int id)
        {
            return qlpk.NHAN_VIENs.Where(a => a.NV_ID == id).Select(a => a).FirstOrDefault();
        }
        
    }
}
