using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BLL_DAL
{
    public class PhongKham
    {
        QLPK_DataContext qlpk = new QLPK_DataContext();
       
        public List<PHONG_KHAM> get_list_clinic()
        {
            return qlpk.PHONG_KHAMs.Where(a => a.HOATDONG == true).Select(a => a).ToList();


        }
        
        public PHONG_KHAM get_Clinic_By_Id(int id)
        {
            return qlpk.PHONG_KHAMs.Where(a => a.PHONGKHAM_ID == id).Select(a => a).FirstOrDefault();
        }

        public int get_Order_Now_Patient_Now(int id)
        {
            PHONG_KHAM pk = get_Clinic_By_Id(id);
            int? Number_Now = pk.SOTHUTU;
            int new_Number = 0;
            if (Number_Now == null || Number_Now == 0)
            {
                new_Number = 1;
                pk.SOTHUTU = new_Number;
                qlpk.SubmitChanges();
                return new_Number;
            }
            else
            {
                new_Number = (int)Number_Now + 1;
                pk.SOTHUTU = new_Number;
                qlpk.SubmitChanges();
                return new_Number;
            }
        }

        public void increase_Number_Patient_Now(int id)
        {
            PHONG_KHAM pk = get_Clinic_By_Id(id);
            int? Number_Now = pk.SOLUONGBENHNHAN;
            int new_Number = 0;
            if (Number_Now == null)
            {
                new_Number = 1;
                pk.SOLUONGBENHNHAN = new_Number;
                qlpk.SubmitChanges();
             
            }
            else
            {
                new_Number = (int)Number_Now + 1;
                pk.SOLUONGBENHNHAN = new_Number;
                qlpk.SubmitChanges();
            }
        }
    }
}
