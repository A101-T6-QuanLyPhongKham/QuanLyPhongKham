using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class Provider
    {
        QLPKDataContext qlpk = new QLPKDataContext();
        public List<NHA_CUNG_CAP> get_All()
        {
            return qlpk.NHA_CUNG_CAPs.Select(a => a).ToList();
        }
    }
}
