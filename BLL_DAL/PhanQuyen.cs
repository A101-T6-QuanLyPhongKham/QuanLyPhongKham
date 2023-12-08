using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class PhanQuyen
    {
        QLPKDataContext qlpk = new QLPKDataContext();
        public List<QL_PHANQUYEN> get_list(int manhom)
        {
            return qlpk.QL_PHANQUYENs.Where(a => a.MANHOMNGUOIDUNG == manhom && a.COQUYEN == true).Select(a => a).ToList();
        }
    }
}
