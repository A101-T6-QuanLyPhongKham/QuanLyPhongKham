using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class PhongKham
    {
        QLPKDataContext qlpk = new QLPKDataContext();
       
        public List<PHONG_KHAM> get_list_clinic()
        {
            return qlpk.PHONG_KHAMs.Where(a => a.HOATDONG == true).Select(a => a).ToList();


        }
        public PHONG_KHAM get_Clinic_By_Id(int id)
        {
            return qlpk.PHONG_KHAMs.Where(a => a.PHONGKHAM_ID == id).Select(a => a).FirstOrDefault();
        }
        

    }
}
