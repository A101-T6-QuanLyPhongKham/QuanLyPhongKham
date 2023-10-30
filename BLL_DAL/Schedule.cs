using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class Schedule
    {
        QLPKDataContext qlpk = new QLPKDataContext();
        public List<PHONG_KHAM> get_list_clinic()
        {
            List<PHONG_KHAM> pk =  qlpk.PHONG_KHAMs.Where(a => a.HOATDONG == true).ToList();
            List<PHONG_KHAM> field = pk.Select(a => new { a.PHONGKHAM_ID, a.PHONGKHAM_CHUYENKHOA });
            return field;

        }
        

    }
}
